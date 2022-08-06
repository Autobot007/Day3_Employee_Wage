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

            //UC3 Added 
            Random workinghr = new Random();
            int workingHr = attendanceCall.Next(0, 2);
            int partTime = 4;
            int workhour =0 ;


            //UC4 Added

            switch (attendance)
            {
                case 0:// if present this case will execute
                    switch (workingHr)
                    {
                        case 0:// if present for half day this case will execute
                            workhour = 4;
                            Console.WriteLine("Employee is Present for half day");
                            break;
                        case 1:// if present for full day this case will execute
                            workhour = 8;
                            Console.WriteLine("Employee is Present for full day");
                            break;
                    }
                    break;

                case 1://if employee is absent this case will  execute.
                    workhour = 0; 
                    Console.WriteLine("Employee is absent");
                    break;

            }
            Console.WriteLine("Employee's todays wage is:" + workhour * wagePerHour);
            

           /* if (value == 0)
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
           */
        }
    }
}