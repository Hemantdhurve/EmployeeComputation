using System;

namespace program;

class EmployeeDailyWage
{
    static void Main(string[] args)
    {
        int IS_FULL_TIME = 1;
        int Emp_Rate_Per_Hr = 20;

        int empHrs = 0;
        int empWage = 0;
        Random random = new Random();

        int empCheck = random.Next(0, 2);
        if (empCheck == IS_FULL_TIME)
        {
            empHrs = 8;
        }
        else
        {
            empHrs = 0;
        }
        empWage = empHrs * Emp_Rate_Per_Hr;
        Console.WriteLine("Emp Wage :" + empWage);
    }
}