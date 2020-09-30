using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKSCompilerProject.Logica.LLexico
{
    public class reservadas
    {
        public String[] Reservadas { get; set; }
        public String[] Errores { get; set; }
        public String[] Comparadores { get; set; }
        

        public reservadas()
        {
            this.Reservadas = new string[]{
                "baseClase", "como","base","booleano","romper","byte","caso","capturar","caracter", "comprobado","clase","constante","continuar","decimal", "defecto", "delegar","hacer", "Gdeciamal","contrario","enumerar","evento","explicito","externo","falso","finalmente","fijo",
        "flotante","por","porcada","irA","si","siNo","implicito","en","entero","interfaz","interno","es","bloquear","GEntero","AreaCodigo","nuevo","nulo","objeto","operador",
        "salida","sobreescribir","parametros","privado","protegido","publico","leerSolo","referencia","regresar","numIntegral","sellar","chico","capacidadDe","estatico",
        "cadena","estructura","casos","esto","lanzar","verdadero","intentar","tipoDe","sinRevisar","usar","vacio","mientras","mostrar","principal"};

            this.Errores = new string[]
            {
                "?","!","|","#","$","%","&","´","~","¨","`","^","¡","¬","@"
            };

            this.Comparadores = new string[]
            {
                "y","diferente","igual", "mayor","menor", "menorIgual","mayorIgual","o"
            };
        }
        
    }
}
