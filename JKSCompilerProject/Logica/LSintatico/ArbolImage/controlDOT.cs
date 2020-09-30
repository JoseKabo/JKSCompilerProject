using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKSCompilerProject.Logica.LSintatico.ArbolImage
{
    class controlDOT
    {
        /*
         * diagraph G{
         * nodo0[label="etiqueta"];
         * nodo1[label="hijo1"];
         * nodo2[label="hijo2"];
         * nodo0 -> nodo1;
         * nodo0 -> nodo2;
         */

        public static int contador;
        public static String grafo;

        public static String getDOT(ParseTreeNode raiz)
        {
            grafo = "diagraph G{";
            grafo += "nodo0[label=\"" + escapar(raiz.ToString()) + "\"];\n";
            contador = 1;
            recorrerAST("nodo0", raiz);
            grafo += "}";
            return grafo;
        }

        public static void recorrerAST(String padre, ParseTreeNode hijos)
        {
            foreach (ParseTreeNode hijo in hijos.ChildNodes)
            {
                String nombreHijo = "nodo" + contador.ToString();
                grafo += nombreHijo + "[label=\"" + escapar(hijo.ToString()) + "\"];\n";
                grafo += padre + "->" + nombreHijo + ";\n";
                contador++;
                recorrerAST(nombreHijo, hijo);
            }
        }

        public  static String escapar (String cadena)
        {
            cadena = cadena.Replace("\\","\\\\");
            cadena = cadena.Replace("\"","\\\"");
            return cadena;
        }
    }
}
