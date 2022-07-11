using System;

namespace Program;


class EmployeeWageSwitch
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int Emp_Rate_Per_Hr = 20;

    static void Main(string[] args)
    {
        
        int EmpHrs = 0;
        int EmpWage = 0;
        Random random = new Random();

        int empCheck = random.Next(0, 3);
        switch (empCheck)
        {
            case IS_PART_TIME:
                EmpHrs = 4;
                break;
            case IS_FULL_TIME:
                EmpHrs = 8;
                break;
            default:
                EmpHrs = 0;
                break;
        }
        EmpWage = EmpHrs * Emp_Rate_Per_Hr;
        Console.WriteLine("Emp Wage" + EmpWage);
    }
}