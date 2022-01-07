using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDay9
{
    public class Tcs : AddMultipleCompanies
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        int empRatePerHr = 120;
        public void CalculateEmpWage(String name, int maxHrsInMonth, int maxDaysInMonth, int maxRatePerDay)
        {
            Console.WriteLine("welcome to Wipro");
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;


            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays <= maxDaysInMonth)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(1, 2);
                switch (empCheck)
                {
                    case isPartTime:
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = empHrs + totalEmpHrs;
                Console.WriteLine(totalWorkingDays);
                Console.WriteLine(empHrs);
            }
            int totalEmpWage = totalWorkingDays * maxRatePerDay;
            Console.WriteLine(totalEmpWage);
            //return totalEmpWage;
        }
    }
}
