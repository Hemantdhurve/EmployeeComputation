using System;

namespace Program;


class EmployeeWageSwitch
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int Emp_Rate_Per_Hr = 20;
    public const int Number_Of_Working_Days = 20;
    public const int Max_Hr_In_Month = 100;

    static void Main(string[] args)
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= Max_Hr_In_Month && totalWorkingDays < Number_Of_Working_Days)

        {
            totalWorkingDays++;
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
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);


        }
        int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hr;
        Console.WriteLine("Total Emp Wage : " + totalEmpWage);
    }
}