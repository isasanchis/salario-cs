namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salário ATUAL do colaborador:");

            double employeeSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Salário atual do colaborador: R$ " + employeeSalary);

            double readjust = employeeSalary * 1.1;

            Console.WriteLine("Novo salário, com reajuste: R$ " + readjust);

        }
    }
}