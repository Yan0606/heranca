using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca{
    public class Mensalista : Funcionario
    {

       protected  int qtdeHorasTrabalhadas;
        
        public Mensalista(int codigo, string nome, double salario, int qtdeHorasTrabalhadas)
        : base(codigo, nome, salario)
   {
        this.qtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
    }

         public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine("Horas Trabalhadas:" + qtdeHorasTrabalhadas +"hrs");
    }
    }
}