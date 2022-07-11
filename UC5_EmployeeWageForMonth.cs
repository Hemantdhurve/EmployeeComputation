using System;

namespace Program;


class EmployeeWageSwitch
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int Emp_Rate_Per_Hr = 20;
    public const int Number_Of_Working_Days = 2;

    static void Main(string[] args)
    {
        int empHrs = 0, empWage = 0, totalEmpWage=0;

        for (int day = 1; day < Number_Of_Working_Days; day++)
        {
            Random random = new Random();

            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * Emp_Rate_Per_Hr;
            totalEmpWage += empWage;
        Console.WriteLine("Emp Wage" + empWage);
        }
        Console.WriteLine("Total Emp Wage : " + totalEmpWage);
    }
}