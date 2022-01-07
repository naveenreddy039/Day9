using System;
using System.Collections.Generic;
using System.Text;

namespace EmpDay9
{
    //UC6&7
    public class EmployeeWage
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int maxHrsInMonth = 100;
        public const int maxDaysInMonth = 20;

        public void calculateWages()
        {
            int empHrs = 0;
            int totalWorkingDays = 0;

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
            int totalWorkingHrs = empHrs + maxHrsInMonth;
            totalWorkingDays = totalWorkingHrs * maxDaysInMonth;
            Console.WriteLine(totalWorkingDays);
        }
    }
}
