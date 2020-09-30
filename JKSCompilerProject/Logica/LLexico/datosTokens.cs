using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKSCompilerProject.Logica.LLexico
{
    public class datosTokens
    {
        public datosTokens(string name, string lexema, int index, int linea)
        {
            Name = name;
            Lexema = lexema;
            Index = index;
            Linea = linea;
        }

        public string Name { get; set; }
        public string Lexema { get; private set; }

        public int Index { get; private set; }
        public int Linea { get; private set; }
        public int Lenght { get { return Lexema.Length; } }
    }
}
