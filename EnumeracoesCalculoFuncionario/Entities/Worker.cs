using System.Collections.Generic;
using EnumeracoesCalculoFuncionario.Entities.Enums;

namespace EnumeracoesCalculoFuncionario.Entities
{
    internal class Worker
    {
        //Aqui são criadas algumas propriedades da classe Trabalhador.
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        //Além dos 3 atributos basicos, aqui tambem será criado uma composição de objetos.
        //Uma associação entre Worker e Department.
        //O tipo dessa propriedade é (Department) e o nome também é Department.
        //É uma associação entre duas classes diferentes.
        public Department Department { get; set; }  

        //Como o sistema irá lidar com varios contratos,
        //Cria-se um ArrayList para comportar todas essas informações.
        //O tipo dessa Lista é o que está entre <> ou seja HourContract
        //O nome da propriedade é Contracts (no plural)
        //E para garantir que a lista nao seja Nula, ja é realizada a instanciação.
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //Construtor Vazio
        public Worker()
        { 
        }

        //O Construtor com os Argumentos não pode conter o ArrayList Contracts.(Associação para muitos)
        //Obs:Não é usual colocar uma lista instanciada no construtor de um objeto.
        //A lista inicia-se vazia, e os objetos serão adcionados conforme a necessidade através do console.
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }


        //Métodos.
        //Esse metodo irá acessar o ArrayList Contracts e irá adcionar cada contrato que chegará através do parametro de entrada informado.
        //Ou seja, o contrato será adcionado através dessa operação.
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        //Essa operação é responsavel por remover os contratos se necessario.
        //Esses metodos são muito utilizados em associação de objetos.
        public void RemoveContract(HourContract contract)
        {  
            Contracts.Remove(contract);
        }

        //Essa ultima operação (Income), Através dos paramentos de entrada, capta a informação referente ao Mês solicitado e o Ano.        
        public double Income(int year, int month)
        {
            //Declara-se a variavel sum do tipo double que recebe as informações da propriedade BaseSalary.
            //BaseSalary contem o valor do salario Fixo do funcionario.
            double sum = BaseSalary;

            //Para cada HourContrat contract no ArrayLista Contracts faça:
            foreach (HourContract contract in Contracts)
            {
                //Se contract.Date.Year for igual a year -- E -- contract.Date.Month for igual a month, faça:
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    //A variavel sum recebe sum + contract.TotalValue
                    sum += contract.TotalValue();
                }
            }
            //Este comando retorna o valor contido em sum para "Income".
            //O valor será invocado na class program através do comando "worker.Income"
            return sum;
        }
    }
}





