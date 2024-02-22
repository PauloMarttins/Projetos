using System;


namespace EnumeracoesCalculoFuncionario.Entities
{
    internal class HourContract
    {

       //DateTime, ValuePerHour, Hours são PROPRIEDADES.
        public DateTime Date { get; set; }  

        public double ValuePerHour { get; set; }   

        public int Hours {  get; set; }

        //Construtor Padrão.
        public HourContract()
        {

        }

        //Construtor recebendo os parametros Data, Valor por hora, e Horas.
        public HourContract (DateTime date, double valuePerHour, int hours)
        {
            //Todas as Propriedades declaradas no inicio dessa class estão recebendo os valores das variaveis declarads como parametro no inicio desse contrutor.
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //A Função/Método do tipo double TotalValue recebe:
        public double TotalValue()
        {
            //Este comando retorna para TotalValue o valor das horas vezes o tempo trabalhado.
            //Esse valor será invocado na class Worker através do comando "contract.TotalValue"
            return Hours * ValuePerHour;
        }


       
    }
}
