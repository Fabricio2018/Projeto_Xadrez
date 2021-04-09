using System;
using System.Globalization;
namespace Exer_COT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro Funcionario: ");
            Console.Write("Nome: ");
            f1._Funcionario = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo Funcionario: ");
            Console.Write("Nome: ");
            f2._Funcionario = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Salário médio: " + Media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
