//Main()
using Heranca;
class Program
{
    static void Main()
    {
        
        Funcionario funcionario1 = new Funcionario(1, "Yan", 3000.0);
        Mensalista mensalista = new Mensalista(2, "Maria", 2500.0, 160);
        Horista horista = new Horista(3, "Messi", 1500.0, 30);

        Console.WriteLine("Dados do Funcionário:");
        funcionario1.Mostrar();
        Console.WriteLine("\nDados do Mensalista:");
        mensalista.Mostrar();
        Console.WriteLine("\nDados do Horista:");
        horista.Mostrar();
    }
}






