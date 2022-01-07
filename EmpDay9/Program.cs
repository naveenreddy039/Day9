using System;

namespace EmpDay9
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingForLoop loop = new UsingForLoop();
            loop.empWage();
            EmployeeWage employee = new EmployeeWage();
            employee.calculateWages();

            //UC1
            int isFullTime = 1;
            Random rand = new Random();
            int empCheck = rand.Next(1, 2);
            if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            //UC2
            int empRatePerHour = 20;

            int empHrs = 0;
            int empWage = 0;
            if (empCheck == isFullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Empoly Days Wage" + empWage);

            //UC3
            int isPartTime = 1;
            int partTimeWagePerHr = 8;

            int partTime = 0;
            int partTimeEmpWage = 0;
            if (empCheck == isPartTime)
            {
                partTime = 4;
            }
            else
            {
                partTime = 0;
            }
            partTimeEmpWage = partTime * partTimeWagePerHr;
            Console.WriteLine("parttime emp wage:" + partTimeEmpWage);
            Console.ReadKey();
        }
    }
}
