using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Cliente
    {
        //Tenho uma classe com muitas propriedades a serem configuradas,
        //passando pelo construtor o código ficaria de dificil leitura
        public string Name { get; }

        public int Age { get; }

        public string Cpf { get; }

        public double Altura { get; }

        public double Peso { get; }

        public Cliente(string name, int age, string cpf, double altura, double peso)
        {
            Name = name;
            Age = age;
            Cpf = cpf;
            Altura = altura;
            Peso = peso;
        }
    }
}
