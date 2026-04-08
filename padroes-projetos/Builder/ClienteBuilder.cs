using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //Posso adicionar uma interface no builder para definir como os métodos de atribuição dos parametros devem ser implementados
    public class ClienteBuilder
    {
        private string _name;

        private int _age;

        private string _cpf;

        private double _altura;

        private double _peso;

        public ClienteBuilder ComNome(string nome)
        {
            _name = nome;

            return this;
        }

        public ClienteBuilder ComIdade(int age)
        {
            _age = age;

            return this;
        }

        public ClienteBuilder ComCpf(string cpf)
        {
            _cpf = cpf;

            return this;
        }

        public ClienteBuilder ComAltura(double altura)
        {
            _altura = altura;

            return this;
        }

        public ClienteBuilder ComPeso(double peso)
        {
            _peso = peso;

            return this;
        }

        public Cliente Build()
        {
            return new Cliente(_name,_age,_cpf,_altura,_peso);
        }
    }
}
