using system;
using system.Collections.Generic;
using system.Linq;
using system.Text;
using system.Threading.Tasks;

namespace AULA
{
    Class program
    {
        static void Main (string [] args)
        {
            //simples calculadora

            double num1, num2; \\variaveis que irão conter os números digitados
            string tmp;
            
            console.writeLine("Digite um número: ");
            tmp = console.ReadLine();
            num1 = int.Parse(tmp);

            console.Writeline("Digite mais um número: ");

            console.Readkine();
            num2 = int.Parse(tmp);

            double resultados;
            
            \\realiza a soma e imprime no console
            resultado = num1 + num2;
            console.Writeline("soma: " + resultado);
            
            \\realiza a subtração e imprime no console
            
            resultado = num1 - num2;
            console.Writeline("subtração: "+ resultado);
            
            resultadpo num1 * num2;
            console.writeLine("multiplicação: "+resultado);
            
            resultado = num1 / num2;
            console.writeLine("divisão: "=resultado);
                    }
    }
    
}