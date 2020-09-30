using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;

namespace JKSCompilerProject.Logica.LSintatico
{
    class gramatica : Grammar
    {
        public gramatica() : base(caseSensitive: false)
        {
            #region ExReg
            var stringRegex = new RegexBasedTerminal("stringregex", "\"[^\"]*\"");
            var espacios = new RegexBasedTerminal("espacios", @"\s+");
            var desconocidos = new RegexBasedTerminal("desconocidos", @"['\`\^\~\¨\&\$\#\!\¡\°\|\¬;,]");
            var comment = new RegexBasedTerminal("comentarios", "\\/\\*[\\s\\S]*?\\*\\/");
            var id = new RegexBasedTerminal("identificadores", "([a-zA-Z]|_*[a-zA-Z]){1}[a-zA-Z0-9_]*");
            var numero = new RegexBasedTerminal("numeros", "\\d+[f|d]?(\\.\\d+[f|d]?)?");

            #endregion

            #region Terminales
            //operadores
            var mas = ToTerm("+");
            var aumenta = ToTerm("++");
            var menos = ToTerm("-");
            var div = ToTerm("/");
            var multi = ToTerm("*");
            var modulo = ToTerm("%");

            //simbolos permitidos
            var punto = ToTerm(".");
            var coma = ToTerm(",");
            var dospuntos = ToTerm(":");
            var puntocoma = ToTerm(";");
            var parentesisAbre = ToTerm("(");
            var parentesisCierra = ToTerm(")");
            var llaveAbre = ToTerm("{");
            var llaveCierra = ToTerm("}");
            var corcheteAbre = ToTerm("[");
            var corcheteCierra = ToTerm("]");
            var igual = ToTerm("=");

            var picoAbre = ToTerm("<?");
            var picoCierra = ToTerm("?>");


            //comparadores
            var y = ToTerm("y");
            var diferente = ToTerm("diferente");
            var igualCmpt = ToTerm("igual");
            var mayor = ToTerm("mayor");
            var menor = ToTerm("menor");
            var menorIgual = ToTerm("menorIgual");
            var mayorIgual = ToTerm("mayorIgual");
            var o = ToTerm("o");

            //tipo de datos
            var entero = ToTerm("entero");
            var flotante = ToTerm("flotante");
            var doub = ToTerm("Gdecimal");
            var boleano = ToTerm("boleano");
            var cadena = ToTerm("cadena");
            var arreglo = ToTerm("arreglo");

            //reservadas
            var usar = ToTerm("usar");
            var mostrar = ToTerm("mostrar");
            var codigoPrincipal = ToTerm("principal");
            var metodo = ToTerm("metodo");
            var vacio = ToTerm("vacio");
            var regresar = ToTerm("regresar");
            var nulo = ToTerm("nulo");
            var verdadero = ToTerm("verdadero");
            var falso = ToTerm("falso");

            //controladores
            var si = ToTerm("si");
            //var entonces = ToTerm("entonces");
            var sino = ToTerm("siNo");
            var cuando = ToTerm("cuando");
            var mientras = ToTerm("mientras");
            var hacer = ToTerm("hacer");
            var hacerMientras = ToTerm("hacerMientras");
            var casos = ToTerm("casos");
            var caso = ToTerm("caso");
            var por = ToTerm("por");
                var porde = ToTerm("de");
                var porhasta = ToTerm("hasta");
                var poren = ToTerm("en");
                

            #endregion

            #region No Terminales
            var nodo_inicio = new NonTerminal("<nodo-inicio>");
            var nodo_main = new NonTerminal("<nodo-main>");
                var nodo_main_contenido = new NonTerminal("<main-contenido>");

            var nodo_lineasCod = new NonTerminal("<nodo-lineasCod>");

            var nodo_declaraVariableCnValor = new NonTerminal("<nodo-varCnValor>");
            var nodo_declaraMetodo = new NonTerminal("<nodo-metodoBody>");
                var nodo_metodoParams = new NonTerminal("<nodo-metodoParams>");
                var nodo_metodoContenido = new NonTerminal("<nodo-metodoBody>");
            var nodo_imprimirBody = new NonTerminal("<nodo-imprimir>");
            var nodo_si = new NonTerminal("<nodo-si>");
                var nodo_comparacionesBody = new NonTerminal("<nodo-comparaciones>");
            var nodo_porBody = new NonTerminal("<nodo-por>");
                var nodo_porParams = new NonTerminal("<nodo-porParams>");
                    var nodo_porParam1 = new NonTerminal("<nodo-porParam1>");

            var nodo_expreAritBody = new NonTerminal("<nodo-exprArit>");
                var nodo_operaArit = new NonTerminal("<nodo-operaArit>");
                var nodo_operaAritConjunto = new NonTerminal("<nodo-operaAritConjunto>");
            var nodo_comparadores = new NonTerminal("<nodo-comparadores>");
            var nodo_paramsBody = new NonTerminal("<nodo-paramsBody>");
            var nodo_tiposdeValor = new NonTerminal("<nodo-tiposValor>");
            var nodo_tiposDatos = new NonTerminal("<nodo-tipoDatos>");
            var nodo_tipoMetodos = new NonTerminal("<nodo-tipoMetodo>");

            #endregion

            //gramatica de las cosas
            #region Gramatica

            nodo_inicio.Rule = picoAbre + nodo_main + picoCierra;
                
            
            nodo_main.Rule = codigoPrincipal + nodo_main_contenido;
                

            nodo_main_contenido.Rule = llaveAbre + nodo_lineasCod +llaveCierra;
                

            nodo_lineasCod.Rule =
                nodo_declaraVariableCnValor |
                nodo_declaraMetodo |
                nodo_imprimirBody |
                nodo_si |
                nodo_porBody

                ;
                


            #endregion

            #region lineas
            nodo_declaraVariableCnValor.Rule =
                nodo_tiposDatos + id + puntocoma |
                nodo_tiposDatos + id + puntocoma + nodo_lineasCod |
                nodo_tiposDatos + id + igual + nodo_operaAritConjunto + puntocoma |
                nodo_tiposDatos + id + igual + nodo_operaAritConjunto + puntocoma + nodo_lineasCod
                ;
                nodo_declaraVariableCnValor.ErrorRule = SyntaxError + "}";

            nodo_declaraMetodo.Rule =
                metodo + nodo_tipoMetodos + id + nodo_metodoParams + dospuntos + dospuntos |
                metodo + nodo_tipoMetodos + id + nodo_metodoParams + dospuntos + dospuntos + nodo_lineasCod|
                metodo + nodo_tipoMetodos + id + nodo_metodoParams + dospuntos + nodo_metodoContenido + dospuntos |
                metodo + nodo_tipoMetodos + id + nodo_metodoParams + dospuntos + nodo_metodoContenido + dospuntos + nodo_lineasCod

                ;
            nodo_declaraMetodo.ErrorRule = SyntaxError + "}";

            nodo_imprimirBody.Rule =
                mostrar + parentesisAbre + nodo_tiposdeValor +parentesisCierra + puntocoma |
                mostrar + parentesisAbre + nodo_tiposdeValor + parentesisCierra + puntocoma + nodo_lineasCod
                ;
            nodo_imprimirBody.ErrorRule = SyntaxError + "}";

            nodo_si.Rule =
                si + parentesisAbre + nodo_comparacionesBody + parentesisCierra + dospuntos + nodo_metodoContenido + dospuntos |
                si + parentesisAbre + nodo_comparacionesBody + parentesisCierra + dospuntos + nodo_metodoContenido + dospuntos + nodo_lineasCod |
                si + parentesisAbre + nodo_comparacionesBody + parentesisCierra + dospuntos + nodo_metodoContenido + dospuntos + sino + dospuntos + nodo_metodoContenido + dospuntos |
                si + parentesisAbre + nodo_comparacionesBody + parentesisCierra + dospuntos + nodo_metodoContenido + dospuntos + sino + dospuntos + nodo_metodoContenido + dospuntos + nodo_lineasCod
                ;
            nodo_si.ErrorRule = SyntaxError + "}";

            nodo_porBody.Rule =
                por + parentesisAbre + nodo_porParams + parentesisCierra + puntocoma |
                por + parentesisAbre + nodo_porParams + parentesisCierra + puntocoma + nodo_lineasCod
                ;
            nodo_porBody.ErrorRule = SyntaxError + "}";
            #endregion

            #region contenido Lineas
            nodo_metodoContenido.Rule =
                nodo_declaraVariableCnValor |  
                nodo_imprimirBody |
                nodo_si |
                nodo_porBody
                ;
            nodo_metodoContenido.ErrorRule = SyntaxError + "}";

            nodo_metodoParams.Rule =
                parentesisAbre + parentesisCierra |
                parentesisAbre + nodo_paramsBody + parentesisCierra 
                ;
            nodo_metodoParams.ErrorRule = SyntaxError + "}";

            nodo_paramsBody.Rule =
                nodo_tiposDatos + id |
                nodo_tiposDatos + id + coma + nodo_paramsBody
                ;
            nodo_paramsBody.ErrorRule = SyntaxError + "}";

            nodo_comparacionesBody.Rule =
                nodo_tiposdeValor + nodo_comparadores + nodo_tiposdeValor
                ;
            nodo_comparacionesBody.ErrorRule = SyntaxError + "}";

            nodo_porParams.Rule =
                porde + nodo_porParam1 + porhasta + numero + poren + numero + hacer + dospuntos + dospuntos |
                porde + nodo_porParam1 + porhasta + numero + poren + numero + hacer + dospuntos + nodo_metodoContenido + dospuntos
                ;
            nodo_porParams.ErrorRule = SyntaxError + "}";

            nodo_porParam1.Rule =
                nodo_tiposDatos + id + igual + nodo_tiposdeValor + puntocoma
                ;
            nodo_porParam1.ErrorRule = SyntaxError + "}";

            nodo_expreAritBody.Rule =
                nodo_tiposdeValor |
                nodo_tiposdeValor + nodo_operaArit + nodo_tiposdeValor |
                nodo_tiposdeValor + nodo_operaArit + nodo_tiposdeValor + nodo_operaArit + nodo_expreAritBody

                ;

            nodo_operaAritConjunto.Rule =
                nodo_expreAritBody |
                parentesisAbre + nodo_expreAritBody + parentesisCierra |
                parentesisAbre + nodo_expreAritBody + parentesisCierra + nodo_operaArit + nodo_operaAritConjunto
                ;
            #endregion


            #region tipos datos,valor, comparadores u operadores
            nodo_tipoMetodos.Rule = vacio | nodo_tiposDatos;

            nodo_operaArit.Rule =
                mas |
                menos |
                multi |
                div |
                modulo
                ;

            nodo_comparadores.Rule =
                y |
                o |
                mayor |
                mayorIgual |
                menor |
                menorIgual |
                diferente |
                igualCmpt
                ;

            nodo_tiposDatos.Rule =
                entero |
                cadena |
                doub |
                boleano |
                flotante 
                ;

            nodo_tiposdeValor.Rule =
                stringRegex |
                id |
                numero |
                verdadero |
                falso 
                ;
            #endregion

            #region Preferencias
            Root = nodo_inicio;
            #endregion

        }
    }
}
