using System;

namespace Program;

class EmployeePartTime
{
    static void Main(string[] args)
    {
        int IS_PART_TIME = 1;
        int IS_FULL_TIME = 2;
        int Emp_Rate_Per_Hr = 20;

        int EmpHrs = 0;
        int EmpWage = 0;
        Random random = new Random();
        int empCheck = random.Next(0, 3);
        if (empCheck == IS_FULL_TIME)
        {
            empCheck = 8;
        }
        else if (empCheck == IS_PART_TIME)
        {
            EmpHrs = 4;
        }
        else
        {
            EmpHrs = 0;
        }
        EmpWage = EmpHrs * Emp_Rate_Per_Hr;
        Console.WriteLine("Emp Wage :" + EmpWage);
    }
}