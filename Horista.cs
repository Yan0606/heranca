using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca{

    class Horista : Funcionario
{
    protected int qtdeHorasSemana;

    public Horista(int codigo, string nome, double salario, int qtdeHorasSemana)
        : base(codigo, nome, salario)
    {
        this.qtdeHorasSemana = qtdeHorasSemana;
    }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine("Horas por Semana: " + qtdeHorasSemana+ "hrs");
    }
}
}