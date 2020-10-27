using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoComposicao.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.Date = date;
            this.ValuePerHour = valuePerHour;
            this.Hours = hours;
        }

        public double totalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
