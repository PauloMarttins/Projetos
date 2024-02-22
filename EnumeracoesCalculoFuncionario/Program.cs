using System;
using EnumeracoesCalculoFuncionario.Entities.Enums;
using EnumeracoesCalculoFuncionario.Entities;
using System.Globalization;

namespace EnumeracoesCalculoFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
       

            //9
            //através do comando (Console.Write) o console apresenta o texto digitado entre aspas e solicita que o usuario informe a resposta na frente do texto por nao haver a quebra de linha (Line).
            Console.Write("Enter departament's name: ");

            //9
            //deptName é uma variavel do tipo string que recebe as informações fornecidas  no comando à cima. 
            string deptName = Console.ReadLine();

            //8
            //Comando para o console escrever na tela mais uma informação para o usuário, há quebra de linha (Line).
            Console.WriteLine("Enter Worker data: ");

            //8
            //Comando para o console escrever na tela mais um texto, sem quebra de linha.
            Console.Write("Name: ");

            //8
            //a variavel do tipo string recebe através do comando (Console.ReadLine), a informação enviada pelo usuario no comando a cima.
            string name = Console.ReadLine();



            //8
            //Nesse comando, o Console escreve um texto que informa para o usuario 3 opções, as quais foram declaradas na classe WorkerLevel no formato Enum.
            //Cada umma dessas categorias recebe uma posição a qual servirá como referecial de nivel e proporção para os salarios.
            Console.Write("Level (Junior/Pleno/Senior): ");


            //9
            //WorkerLevel é a nomeação dada à Classe Enum. 
            //level é uma variavel local que recebe a informação recebida do comando a cima. Obs: é necessario que faça a conversao do texto no formato string para o formato Enum.
            //portanto, é necessario utilizar o codigo (WorkerLevel)Enum.Parse(typeof(WorkerLevel) antes do (Console.ReadLine).
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine().ToUpper());

            //8
            //Através desse comando o console escreve um texto solicitando o valor do salario fixo do funcionario em questao.
            Console.Write("Base salary: ");

            //9
            //A informação correspondente ao salario será alocada na variavel (baseSalary) do tipo double.  
            //Utiliza-se o comando double.Parse para fazer a conversao da informação recebida para o formato double.
            //O comando CultureInfo.InvariantCulture é utilizado para que essa mensagem alocada na variavel no formato double (numeral) preserve o ponto e suas casas decimais.
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //7
            //Instanciação da variavel dept(objeto) do tipo (Department).
            //ela recebe o nome do departamento informado no primeiro Console.WriteLine a qual foi armazenada em (deptName) utilizando o modelo CamelCase.
            Department dept = new Department(deptName);


            //7
            //Nessa instanciação é informada entre parentese as 4 atributos recebidas nos comandos a cima. todas elas serao alocadas na variavel worker do tipo Worker
            //Onde serao tomadas como valor pelas variaveis Locais declaradas nesse Objeto.
            Worker worker = new Worker(name, level, baseSalary, dept);


            //Comando para o console escrever para o usuário um texto solicitando a quantidade de contratos efetivados pelo funcionario especificado.
            Console.Write("How many contracts to this worker? ");


            //8
            //A inforamação será um numero inteiro, portanto, deverá utilizar-se  a expressão (int.Parse) para realizar a conversao do texto para o tipo int. 
            int n = int.Parse(Console.ReadLine());



            //Para a variavel i do tipo inteiro deve-se atribuir a posição 1, enquanto o valor de i for menor ou igual ao valor de n. i++ ordena que acrescente mais uma posição à variavel i do tipo inteiro após cada rodada. 
            for (int i = 1; i <= n; i++)
            {
                //Dentro desse loop
                //O console irá escrever um texto solicitando que o usuario digite cada inforamção referente ao contrato.
                //Colocando o Cifrao "$" antes das aspas e o {i} após a #. utiliza-se uma ferramenta do sistema para automatizar um comando que trocará a variavel i pela posição atual da rodada do loop for.
                Console.WriteLine($"Enter #{i}º contract data: ");

                //Comando solicitando a data do contrato.
                //(DD/MM/YYYY) é uma ferramenta que recebe os dados de dia, mês e ano. separadamente similar ao split.
                Console.Write("Date (DD/MM/YYYY): ");

                //9
                //DateTime é uma estrutura struct que comporta a variavel date. DateTime.Parse é um comando que deve anteceder (Console.ReadLine) para que o sistema realize a conversao do texto recebido alocando-o logo em seguida na variavel.
                DateTime date = DateTime.Parse(Console.ReadLine());

                //O console escreve para o usuario um texto solicitando os dados referentes ao valor da hora de trabalho.
                Console.Write("Value per Hour: ");


                //8
                //Declara-se a variavel (valuePerHour) do tipo double que logo em seguida recebe através do comando à sua frente, as informações fornecidas no comando à cima.
                //Nesse mesmo comando já é realizado a conversao do texto para o tipo double e utilizando o CultureInfo.IvariantCulture para preservar a localização do ponto e as casas decimais.
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


                //O console escreve um texto solicitando as informações pertinentes a duração do trabalho em horas.
                Console.Write("Duration (Hour): ");



                //Declara-se a variavel (hours) do tipo inteiro que logo em seguida recebe através do codigo à sua frente as informações enviadas pelo usuário por intermedio do comando a cima.
                int hours = int.Parse(Console.ReadLine());

                //8
                //Nesse momento ocorre instanciação do objeto HourContract.               
                HourContract contract = new HourContract(date, valuePerHour, hours);


                //Neste comando utiliza-se a Função/método ( .Add(); ) com o parametro de entrada dentro dos parenteses
                //O qual adcionará a informação que se refere ao contrato ao trabalhador.
                worker.AddContract(contract);

            }

            Console.WriteLine();
            
            //5
            //O console escreverá um texto solicitando informações referente ao mês e o ano para que se possa calcular a renda.
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            //Declara-se a variavel monthAndYear do tipo string que alocará Mês e Ano.
            string monthAndYear = Console.ReadLine();

            //Declara-se a variavel month do tipo inteiro que através das posições informadas entre parenteses (0, 2) recolhe as informações que serao entendidas como MÊS.
            int month = int.Parse(monthAndYear.Substring(0, 2));
            //Declara-se a variavel year do tipo inteiro que através da informação informada entre parentese (3) recolhe as informações que serao entendidas como ANO.
            int year = int.Parse(monthAndYear.Substring(3));

            //O console escreverá o nome do trabalhador na tela.
            Console.WriteLine("Name: " + worker.Name);

            //O console escreverá o departamento informado referente a função do trabalhador na empresa.
            Console.WriteLine("Department: " + worker.Department.Nome);
            Console.WriteLine("Level: " + worker.Level);

           
            //O console escreverá o rendimento monetario baseado nos parametros informados.
            //ou seja Mês e ano, concatenado com uma função/método. utiliza-se o ToString com o CultureInfo.CurrentCulture para fazer a conversão das informações em texto e os numeros se apresentaram em formato de moeda.
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("C2", CultureInfo.CurrentCulture));
           
            


            Console.ReadKey();
        }
    }
}





