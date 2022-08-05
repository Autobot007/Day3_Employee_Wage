namespace Day3_Employee_Wage
{
    public class EmployeeWage
    {

        public static void Main(string[] args)
        {
            //Welcome to Employee Wage computation problem


            // UC1 Added
            Random attendance = new Random();
            int value = attendance.Next(0, 2);

            if (value == 0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");
            }

        }
    }
}