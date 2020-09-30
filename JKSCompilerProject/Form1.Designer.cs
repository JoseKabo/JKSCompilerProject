namespace JKSCompilerProject
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hdr_options = new System.Windows.Forms.Panel();
            this.btn_nuevo = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Label();
            this.btn_abrir = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.btn_maximize = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_acerca = new System.Windows.Forms.Label();
            this.btn_errores = new System.Windows.Forms.Label();
            this.btn_compilacion = new System.Windows.Forms.Label();
            this.btn_sintactico = new System.Windows.Forms.Label();
            this.btn_semantico = new System.Windows.Forms.Label();
            this.btn_lexico = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rtxt_codigo = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            this.hdr_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.header.Controls.Add(this.textBox1);
            this.header.Controls.Add(this.hdr_options);
            this.header.Controls.Add(this.btn_minimize);
            this.header.Controls.Add(this.btn_maximize);
            this.header.Controls.Add(this.btn_close);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1126, 31);
            this.header.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Sen", 9.75F);
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(247, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(640, 16);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Nombre de archivo.jks";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hdr_options
            // 
            this.hdr_options.Controls.Add(this.btn_nuevo);
            this.hdr_options.Controls.Add(this.btn_cerrar);
            this.hdr_options.Controls.Add(this.btn_guardar);
            this.hdr_options.Controls.Add(this.btn_abrir);
            this.hdr_options.Dock = System.Windows.Forms.DockStyle.Right;
            this.hdr_options.Location = new System.Drawing.Point(893, 0);
            this.hdr_options.Name = "hdr_options";
            this.hdr_options.Size = new System.Drawing.Size(233, 31);
            this.hdr_options.TabIndex = 3;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AutoSize = true;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_nuevo.Font = new System.Drawing.Font("Sen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.Silver;
            this.btn_nuevo.Location = new System.Drawing.Point(178, 6);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(48, 19);
            this.btn_nuevo.TabIndex = 8;
            this.btn_nuevo.Text = "Nuevo";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.AutoSize = true;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_cerrar.Font = new System.Drawing.Font("Sen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(127, 6);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(48, 19);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.Text = "Cerrar";
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSize = true;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_guardar.Font = new System.Drawing.Font("Sen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.Silver;
            this.btn_guardar.Location = new System.Drawing.Point(63, 6);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(59, 19);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            // 
            // btn_abrir
            // 
            this.btn_abrir.AutoSize = true;
            this.btn_abrir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_abrir.Font = new System.Drawing.Font("Sen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir.ForeColor = System.Drawing.Color.Silver;
            this.btn_abrir.Location = new System.Drawing.Point(18, 6);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(40, 19);
            this.btn_abrir.TabIndex = 5;
            this.btn_abrir.Text = "Abrir";
            // 
            // btn_minimize
            // 
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(49, 8);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(13, 13);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.TabStop = false;
            // 
            // btn_maximize
            // 
            this.btn_maximize.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximize.Image")));
            this.btn_maximize.Location = new System.Drawing.Point(29, 8);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(13, 13);
            this.btn_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximize.TabIndex = 1;
            this.btn_maximize.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(10, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(13, 13);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 0;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wild Compiler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 588);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 23);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 557);
            this.panel3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Sen", 9.75F);
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(33, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "suma.jks";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(9, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panelDetalles);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(147, 441);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(979, 147);
            this.panel5.TabIndex = 4;
            // 
            // panelDetalles
            // 
            this.panelDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panelDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalles.Location = new System.Drawing.Point(0, 27);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(979, 120);
            this.panelDetalles.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel7.Controls.Add(this.btn_acerca);
            this.panel7.Controls.Add(this.btn_errores);
            this.panel7.Controls.Add(this.btn_compilacion);
            this.panel7.Controls.Add(this.btn_sintactico);
            this.panel7.Controls.Add(this.btn_semantico);
            this.panel7.Controls.Add(this.btn_lexico);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(979, 27);
            this.panel7.TabIndex = 0;
            // 
            // btn_acerca
            // 
            this.btn_acerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_acerca.AutoSize = true;
            this.btn_acerca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_acerca.Font = new System.Drawing.Font("Sen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acerca.ForeColor = System.Drawing.Color.Silver;
            this.btn_acerca.Location = new System.Drawing.Point(888, 4);
            this.btn_acerca.Name = "btn_acerca";
            this.btn_acerca.Size = new System.Drawing.Size(69, 19);
            this.btn_acerca.TabIndex = 11;
            this.btn_acerca.Text = "Acerca de";
            // 
            // btn_errores
            // 
            this.btn_errores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_errores.AutoSize = true;
            this.btn_errores.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_errores.Font = new System.Drawing.Font("Sen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_errores.ForeColor = System.Drawing.Color.Silver;
            this.btn_errores.Location = new System.Drawing.Point(441, 4);
            this.btn_errores.Name = "btn_errores";
            this.btn_errores.Size = new System.Drawing.Size(52, 19);
            this.btn_errores.TabIndex = 10;
            this.btn_errores.Text = "Errores";
            // 
            // btn_compilacion
            // 
            this.btn_compilacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_compilacion.AutoSize = true;
            this.btn_compilacion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_compilacion.Font = new System.Drawing.Font("Sen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compilacion.ForeColor = System.Drawing.Color.Silver;
            this.btn_compilacion.Location = new System.Drawing.Point(316, 4);
            this.btn_compilacion.Name = "btn_compilacion";
            this.btn_compilacion.Size = new System.Drawing.Size(86, 19);
            this.btn_compilacion.TabIndex = 9;
            this.btn_compilacion.Text = "Compilación";
            // 
            // btn_sintactico
            // 
            this.btn_sintactico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_sintactico.AutoSize = true;
            this.btn_sintactico.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_sintactico.Font = new System.Drawing.Font("Sen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sintactico.ForeColor = System.Drawing.Color.Silver;
            this.btn_sintactico.Location = new System.Drawing.Point(205, 4);
            this.btn_sintactico.Name = "btn_sintactico";
            this.btn_sintactico.Size = new System.Drawing.Size(71, 19);
            this.btn_sintactico.TabIndex = 8;
            this.btn_sintactico.Text = "Sintáctico";
            this.btn_sintactico.Click += new System.EventHandler(this.btn_sintactico_Click);
            this.btn_sintactico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_sintactico_MouseClick);
            this.btn_sintactico.MouseEnter += new System.EventHandler(this.btn_sintactico_MouseEnter);
            this.btn_sintactico.MouseLeave += new System.EventHandler(this.btn_sintactico_MouseLeave);
            // 
            // btn_semantico
            // 
            this.btn_semantico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_semantico.AutoSize = true;
            this.btn_semantico.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_semantico.Font = new System.Drawing.Font("Sen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_semantico.ForeColor = System.Drawing.Color.Silver;
            this.btn_semantico.Location = new System.Drawing.Point(96, 4);
            this.btn_semantico.Name = "btn_semantico";
            this.btn_semantico.Size = new System.Drawing.Size(74, 19);
            this.btn_semantico.TabIndex = 7;
            this.btn_semantico.Text = "Semántico";
            // 
            // btn_lexico
            // 
            this.btn_lexico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_lexico.AutoSize = true;
            this.btn_lexico.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_lexico.Font = new System.Drawing.Font("Sen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lexico.ForeColor = System.Drawing.Color.Silver;
            this.btn_lexico.Location = new System.Drawing.Point(17, 4);
            this.btn_lexico.Name = "btn_lexico";
            this.btn_lexico.Size = new System.Drawing.Size(49, 19);
            this.btn_lexico.TabIndex = 6;
            this.btn_lexico.Text = "Léxico";
            this.btn_lexico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_lexico_MouseClick);
            this.btn_lexico.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.btn_lexico.MouseLeave += new System.EventHandler(this.btn_lexico_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(147, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 410);
            this.panel4.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 410);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel6.Controls.Add(this.rtxt_codigo);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(185, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(941, 410);
            this.panel6.TabIndex = 6;
            // 
            // rtxt_codigo
            // 
            this.rtxt_codigo.AcceptsTab = true;
            this.rtxt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.rtxt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_codigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_codigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_codigo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.rtxt_codigo.Location = new System.Drawing.Point(11, 0);
            this.rtxt_codigo.Name = "rtxt_codigo";
            this.rtxt_codigo.Size = new System.Drawing.Size(930, 410);
            this.rtxt_codigo.TabIndex = 0;
            this.rtxt_codigo.TabStop = false;
            this.rtxt_codigo.Text = "";
            this.rtxt_codigo.TextChanged += new System.EventHandler(this.rtxt_codigo_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 410);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 611);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "to Wild";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.hdr_options.ResumeLayout(false);
            this.hdr_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.PictureBox btn_maximize;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel hdr_options;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label btn_nuevo;
        private System.Windows.Forms.Label btn_cerrar;
        private System.Windows.Forms.Label btn_guardar;
        private System.Windows.Forms.Label btn_abrir;
        private System.Windows.Forms.Label btn_acerca;
        private System.Windows.Forms.Label btn_errores;
        private System.Windows.Forms.Label btn_compilacion;
        private System.Windows.Forms.Label btn_sintactico;
        private System.Windows.Forms.Label btn_semantico;
        private System.Windows.Forms.Label btn_lexico;
        private System.Windows.Forms.RichTextBox rtxt_codigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

