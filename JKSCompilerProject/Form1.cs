using JKSCompilerProject.CForms.CLexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using JKSCompilerProject.Logica.LLexico;
using System.Drawing;
using Microsoft.Win32;
using JKSCompilerProject.Logica.LSintatico;

namespace JKSCompilerProject
{
    public partial class Form1 : Form
    {
        List<JKSCompilerProject.Logica.LLexico.Token> tokens = new List<JKSCompilerProject.Logica.LLexico.Token>();
        JKSCompilerProject.Logica.LLexico.reservadas rvs = new JKSCompilerProject.Logica.LLexico.reservadas();
        String[] reservadas;
        String[] comparadores;
        String[] errores;
        
        List<String> token_names = new List<String>();
        Regex rex;
        StringBuilder pattern = null;
        int[] group_numbers;
        lexicoTable lexicoTable = new lexicoTable();

        public Form1()
        {
            InitializeComponent();
            reservadas = rvs.Reservadas;
            errores = rvs.Errores;
            comparadores = rvs.Comparadores;
            tokens.Add(new Token(@"\d*\.?\d+", "NUMERO", false));
            tokens.Add(new Token("\".*?\"", "CADENA", false));
            tokens.Add(new Token(@"\s+", "ESPACIO", true));
            tokens.Add(new Token(@"//[^\r\n]*", "COMENTARIO", false));
            tokens.Add(new Token(@"[\(\)\{\}\[\];,]", "DELIMITADOR", false));
            tokens.Add(new Token(@"[\.=\+\-/*%]", "OPERADOR", false));
            tokens.Add(new Token(@"\b[_a-zA-Z][\w]*\b", "IDENTIFICADOR", false));
            tokens.Add(new Token(@"['\`\^\~\¨\&\$\#\!\¡\°\|\¬;,]", "DESCONOCIDO", false));



            foreach (Token token in tokens)
            {
                if (pattern == null)
                    pattern = new StringBuilder(string.Format("(?<{0}>{1})", token.getToken_name(), token.getPatron()));
                if (!token.getIgnore())
                {
                    pattern.Append(string.Format("|(?<{0}>{1})", token.getToken_name(), token.getPatron()));
                    token_names.Add(token.getToken_name());
                }

            }
            
            rex = new Regex(pattern.ToString(), RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.ExplicitCapture);

            
            group_numbers = new int[token_names.Count];
            
            string[] gn = rex.GetGroupNames();

            
            for (int i = 0, idx = 0; i < gn.Length; i++)
            {
                if (token_names.Contains(gn[i]))
                {
                    group_numbers[idx++] = rex.GroupNumberFromName(gn[i]);
                }
            }
        }

        public IEnumerable<datosTokens> GetTokens(string text)
        {
            
            Match match = rex.Match(text);

            if (!match.Success) yield break;
            int line = 1, start = 0, index = 0;

            while (match.Success)
            {
            
                if (match.Index > index)
                {
                    string token = text.Substring(index, match.Index - index);
                    yield return new datosTokens("ERROR", token, index, line);
                    line += contarLineas(token, index, ref start);
                }

            
                for (int i = 0; i < group_numbers.Length; i++)
                {
                    if (match.Groups[group_numbers[i]].Success)
                    {

                        string name = rex.GroupNameFromNumber(group_numbers[i]);
            
                        yield return new datosTokens(name, match.Value, match.Index, line);

                        break;
                    }
                }
                line += contarLineas(match.Value, match.Index, ref start);
                index = match.Index + match.Length;
                match = match.NextMatch();
            }

            if (text.Length > index)
            {
                yield return new datosTokens("ERROR", text.Substring(index), index, line);
            }
        }

        private int contarLineas(string token, int index, ref int line_start)
        {
            int line = 0;
            for (int i = 0; i < token.Length; i++)
                if (token[i] == '\n')
                {
                    line++;
                    line_start = index + i + 1;
                }
            return line;
        }

        private void AnalizeCode()
        {
            lexicoTable = new lexicoTable();
            foreach (var tk in this.GetTokens(rtxt_codigo.Text))
            {
                if (tk.Name == "ERROR")
                {
                    tk.Name = "DESCONOCIDO";
                }
                else
                {
                    if (tk.Name == "IDENTIFICADOR") {
                        if (reservadas.Contains(tk.Lexema))
                        {
                            tk.Name = "RESERVADO";
                        }
                        if (comparadores.Contains(tk.Lexema))
                        {
                            tk.Name = "COMPARADOR";
                        }
                        if (errores.Contains(tk.Lexema))
                        {
                            tk.Name = "DESCONOCIDO";
                        }
                    }
                    lexicoTable.dgvTabla.Rows.Add(tk.Name, tk.Lexema, tk.Linea);
                    coloreaPalabra(tk.Lexema, tk.Name, tk.Index);
                }
            }
            AbrirForm(lexicoTable);
        }

        public void coloreaPalabra(String palabra, String tipo, int index)
        {
            int inicio = index;
            int longitud = palabra.Length;
            rtxt_codigo.Select(inicio, longitud);
            if (tipo.Equals("DESCONOCIDO"))
                rtxt_codigo.SelectionColor = Color.Red;
            if (tipo.Equals("OPERADOR"))
                rtxt_codigo.SelectionColor = Color.Yellow;
            if (tipo.Equals("RESERVADO"))
                rtxt_codigo.SelectionColor = Color.CornflowerBlue;
            if (tipo.Equals("IDENTIFICADOR"))
                rtxt_codigo.SelectionColor = Color.White;
            if (tipo.Equals("COMPARADOR"))
                rtxt_codigo.SelectionColor = Color.Olive;
            if (tipo.Equals("CADENA"))
                rtxt_codigo.SelectionColor = Color.Beige;

            rtxt_codigo.Select(rtxt_codigo.Text.Length,0);
            rtxt_codigo.HideSelection = true;
            rtxt_codigo.ShowSelectionMargin = false;

        }

        public void AbrirForm(object formulario)
        {
            if (this.panelDetalles.Controls.Count > 0)
            {
                this.panelDetalles.Controls.RemoveAt(0);
            }
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelDetalles.Controls.Add(fh);
            this.panelDetalles.Tag = fh;
            fh.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            btn_lexico.Font = new Font(textBox1.Font, FontStyle.Bold);
            btn_lexico.ForeColor = Color.FromArgb(251, 197, 49);
        }

        private void btn_lexico_MouseLeave(object sender, EventArgs e)
        {
            btn_lexico.Font = new Font(textBox1.Font, FontStyle.Regular);
            btn_lexico.ForeColor = Color.Silver;
        }

        private void btn_lexico_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirForm(lexicoTable);
        }

        private void rtxt_codigo_TextChanged(object sender, EventArgs e)
        {
            AnalizeCode();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int caracter = 0;
            int altura = rtxt_codigo.GetPositionFromCharIndex(0).Y;
            if (rtxt_codigo.Lines.Length > 0) {
                for (int i = 0; i < rtxt_codigo.Lines.Length - 1; i++)
                {
                    e.Graphics.DrawString((i + 1).ToString(), rtxt_codigo.Font, Brushes.Orange, pictureBox2.Width - e.Graphics.MeasureString((i+1).ToString(),rtxt_codigo.Font).Width+2, altura);
                    caracter += rtxt_codigo.Lines[i].Length + 1;
                    altura = rtxt_codigo.GetPositionFromCharIndex(caracter).Y;
                }
            }
            else 
            {
                e.Graphics.DrawString("1", rtxt_codigo.Font, Brushes.Orange, pictureBox2.Width - (e.Graphics.MeasureString("1", rtxt_codigo.Font).Width + 10), altura);
            }
        }

        private void btn_sintactico_MouseClick(object sender, MouseEventArgs e)
        {
            bool resultado = sintactico.analizar(rtxt_codigo.Text);
            if (resultado)
            {
                MessageBox.Show("Codigo valido en arbol");
            }
            else
            {
                MessageBox.Show("Codigo NO valido en arbol");
            }
        }

        private void btn_sintactico_MouseEnter(object sender, EventArgs e)
        {
            btn_sintactico.Font = new Font(textBox1.Font, FontStyle.Bold);
            btn_sintactico.ForeColor = Color.FromArgb(251, 197, 49);
        }

        private void btn_sintactico_MouseLeave(object sender, EventArgs e)
        {
            btn_sintactico.Font = new Font(textBox1.Font, FontStyle.Regular);
            btn_sintactico.ForeColor = Color.Silver;
        }

        private void btn_sintactico_Click(object sender, EventArgs e)
        {

        }
    }
}
