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
            int totalMonthlyWorkingHour = 100;
            int totalMonthlyWorkingDay = 20;
            int empWorkingHour=0;
            int empWorkingDay=0;

            //UC3 Added 
            int workingHr = attendanceCall.Next(0, 2);
            int partTime = 4;

            //UC5
            int wagePerDay = wagePerHour * fullDayHour;
            int totalMonthlyWage = wagePerDay * workingDays;

            while (empWorkingDay<=totalMonthlyWorkingDay && empWorkingHour <=totalMonthlyWorkingHour)
            {

                        switch (workingHr)
                        {


                            case 0:// if present for half day this case will execute
                                empWorkingHour += 4;
                                empWorkingDay++;
                                break;


                            case 1:// if present for full day this case will execute
                                empWorkingHour += 8;
                                empWorkingDay++;
                                break;
                      
                }

                
            }
            Console.WriteLine("Total Montly wage is :{0}", empWorkingHour * wagePerHour);
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