using Irony.Parsing;
using Irony.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WINGRAPHVIZLib;
using JKSCompilerProject.Logica.LSintatico.ArbolImage;
using System.Windows.Forms;

namespace JKSCompilerProject.Logica.LSintatico
{
    class sintactico : Grammar
    {
        
        public static bool analizar (String codigo)
        {
            var gramatica = new gramatica();
            var parser = new Parser(gramatica);
            var arbol = parser.Parse(codigo);
            String resultadoError = "";

            if (arbol.Root == null) 
            {
                for (int i = 0; i <arbol.ParserMessages.Count; i++)
                {
                    resultadoError += arbol.ParserMessages[i].Message + "\n en linea: " + arbol.ParserMessages[i].Location.Line;
                }
                MessageBox.Show(resultadoError, "Error en el código",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            ParseTreeNode raiz = arbol.Root;
            return true;
        }

        

        public static void generarImagen(ParseTreeNode raiz)
        {
            String grafoDOT = controlDOT.getDOT(raiz);
            WINGRAPHVIZLib.DOT dot = new WINGRAPHVIZLib.DOT();
            WINGRAPHVIZLib.BinaryImage img = dot.ToPNG(grafoDOT);
            img.Save("grafo.png");
        }
    }
}
