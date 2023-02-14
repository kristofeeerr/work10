using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workGrandMouther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityPeople;
            int fixedWaitingTime = 10;
            int minutesInHour = 60;
            
            Console.Write($" Введите количество человек:");
            quantityPeople = Convert.ToInt32( Console.ReadLine());

            int totalMinutes = quantityPeople * fixedWaitingTime;
            int hoursBeforeAdmission = totalMinutes / minutesInHour;
            int minutesBeforeAdmission = totalMinutes % minutesInHour; 

            Console.WriteLine($"Вы отстоите в очереди {hoursBeforeAdmission} часа и {minutesBeforeAdmission} минут");
        }
    }
}
