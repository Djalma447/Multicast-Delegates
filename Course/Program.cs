using System;
using Course.Services;

namespace Course
{
    class Program
    {

        delegate void BinaryNumericOperation(double n1, double n2); // Multicast Delegate - Um Delegate que pode servir de referência para mais de um Método, porém, seu uso faz sentido para Métodos 'void'

        static void Main(string[] args)
        {
            double a = 12;
            double b = 10;

            BinaryNumericOperation op = CalculationService.ShowSum; // Declarando um objeto do tipo Delegate e usando-o como referência para um Método Static
            op += CalculationService.ShowMax; // Acrescentando outro Método Static para o Delegate declarado
            op(a, b); // Os Métodos são feitos na ordem que foram acrescentados
        }
    }
}
