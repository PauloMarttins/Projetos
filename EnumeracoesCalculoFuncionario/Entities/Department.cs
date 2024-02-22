using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeracoesCalculoFuncionario.Entities
{
    internal class Department
    {
        //Declara-se a Propriedade Nome do tipo string com o metodo Get; Set;
        public string Nome { get; set; }

        public Department ()
        {

        }

        public Department(string nome)
        {
            //O atributo Name vai receber a variavel nome dada como parametro no construtor.
            Nome = nome;
        }

    }
}
