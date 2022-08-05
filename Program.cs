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

            //UC2 Added 

            int wagePerHour = 20;
            int fullDayHour = 8;

            //UC3 Added 
            Random workinghr = new Random();
            int workingHr = attendance.Next(0, 2);
            int partTime = 4;

            if (value == 0)
            {
                if (workingHr == 0)
                {
                    Console.WriteLine("Employee is Present");
                    Console.WriteLine("Employee todays wage is:" + fullDayHour * wagePerHour);
                }
                else
                {
                    Console.WriteLine("Employee is Present for Halfday");
                    Console.WriteLine("Employee todays wage is:" + partTime * wagePerHour);
                }
               
                           
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Employee todays wage is: 0");
            }

        }
    }
}