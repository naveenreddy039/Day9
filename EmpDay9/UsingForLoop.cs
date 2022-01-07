using System;
using System.Collections.Generic;
using System.Text;

namespace EmpDay9
{

    public class UsingForLoop
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int maxHoursInMonth = 20;
        public const int maxWorkingDaysInMonth = 20;
        public const int empRatePerDay = 20;
        public const int empRatePerHr = 20;

        //UC4
        public void empWage()
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(1, 2);
            switch (empCheck)
            {
                case isPartTime:
                    empHrs = 8;
                    break;
                case isFullTime:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * empRatePerHr;
            Console.WriteLine(empWage);

            //UC5
            int totalWorkingHrs = 0;
            int workingHrs;
            switch (empCheck)
            {
                case isPartTime:
                    workingHrs = 8;
                    break;
                case isFullTime:
                    workingHrs = 4;
                    break;
                default:
                    workingHrs = 0;
                    break;
            }
            totalWorkingHrs = workingHrs * maxHoursInMonth;
            int totalSalary = totalWorkingHrs * empRatePerDay;
            Console.WriteLine(totalSalary);
        }
        
    }
}
