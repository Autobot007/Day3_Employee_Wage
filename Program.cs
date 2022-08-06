namespace Day3_Employee_Wage
{
    public class EmployeeWage
    {

        public static void Main(string[] args)
        {
            //Welcome to Employee Wage computation problem


            // UC1 Added
            Random attendanceCall = new Random();
            int attendance = attendanceCall.Next(0, 2);

            //UC2 Added 

            int wagePerHour = 20;
            int fullDayHour = 8;
            int workingDays = 20;
            int monthlyWorkingHour = 100;


            //UC3 Added 
            int workingHr = attendanceCall.Next(0, 2);
            int partTime = 4;

            //UC5
            int wagePerDay = wagePerHour * fullDayHour;
            int totalMonthlyWage = wagePerDay * workingDays;

            Console.WriteLine("Total monthly wage is :{0}", totalMonthlyWage);


          /*  if (attendance == 0)
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
            }*/

        }
    }
}