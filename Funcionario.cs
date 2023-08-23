using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Heranca {
    public class Funcionario
    {
        protected int codigo;
        protected string nome;
        protected double salario;

        public Funcionario(int codigo, string nome, double salario)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
        }

         public virtual void Mostrar()
    {
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Salário: R$ " +salario);
    }

    }
}