using System;
namespace FinalProject
{
	public class Event
	{
		public Event()
		{
		}
        public string AcquireDate(string someDate)
        {            
            var startDate = someDate;

            var valid = false;

            do
            {
                if (int.Parse(startDate.Substring(0, 4)) < 2022)
                {
                    Console.WriteLine("Invalid year! Must pick a future date");
                    valid = true;
                }
                else if (int.Parse(startDate.Substring(5, 2)) < 1 || int.Parse(startDate.Substring(5, 2)) > 12)
                {
                    Console.WriteLine("Invalid month! Must pick an existing month between 01-12");
                    valid = true;
                }
                else if (int.Parse(startDate.Substring(5, 2)) == 2)
                {
                    if (int.Parse(startDate.Substring(8, 2)) < 1 || int.Parse(startDate.Substring(8, 2)) > 28)
                    {
                        Console.WriteLine("Invalid day! Must choose between 01-28 for the month of February");
                        valid = true;
                    }
                }
                else if (int.Parse(startDate.Substring(5, 2)) == 4 || int.Parse(startDate.Substring(5, 2)) == 6 || int.Parse(startDate.Substring(5, 2)) == 9 || int.Parse(startDate.Substring(5, 2)) == 11)
                {
                    if (int.Parse(startDate.Substring(8, 2)) < 1 || int.Parse(startDate.Substring(8, 2)) > 30)
                    {
                        Console.WriteLine("Invalid day! Must choose day between 01-30 for this month");
                        valid = true;
                    }
                }
                else if (int.Parse(startDate.Substring(5, 2)) == 1 || int.Parse(startDate.Substring(5, 2)) == 3 || int.Parse(startDate.Substring(5, 2)) == 5 || int.Parse(startDate.Substring(5, 2)) == 7 || int.Parse(startDate.Substring(5, 2)) == 8 || int.Parse(startDate.Substring(5, 2)) == 10 || int.Parse(startDate.Substring(5, 2)) == 12)
                {
                    if (int.Parse(startDate.Substring(8, 2)) < 1 || int.Parse(startDate.Substring(8, 2)) > 31)
                    {
                        Console.WriteLine("Invalid day! Must choose day between 01-31 for this month");
                        valid = true;
                    }
                }
                else if (startDate[4] != '-' || startDate[7] != '-')
                {
                    Console.WriteLine("Invalid input! Must use '-' to separate year, month and date. Please check format!");
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid date using YYYY-MM-DD format, where 'YYYY' is a 4-digit year, 'MM' is a 2-digit month, and 'DD' is a 2-digit day");
                    valid = true;
                }
            } while (valid == true);


            return startDate;
        }
        public string AcquireDate()
        {
            var startDate = "";

            var valid = false;

            do
            {
                Console.WriteLine("When will you be visiting? (Enter using YYYY-MM-DD format");
                startDate = Console.ReadLine();

                if (int.Parse(startDate.Substring(0, 4)) < 2022)
                {
                    Console.WriteLine("Invalid year! Must pick a future date");
                    valid = true;
                }
                else if (int.Parse(startDate.Substring(5, 2)) < 1 || int.Parse(startDate.Substring(5, 2)) > 12)
                {
                    Console.WriteLine("Invalid month! Must pick an existing month between 01-12");
                    valid = true;
                }
                else if ((int.Parse(startDate.Substring(5, 2)) == 2) && (int.Parse(startDate.Substring(8, 2)) < 1 || int.Parse(startDate.Substring(8, 2)) > 28))
                {
                    Console.WriteLine("Invalid day! Must choose between 01-28 for the month of February");
                    valid = true;
                }
                else if ((int.Parse(startDate.Substring(5, 2)) == 4 || int.Parse(startDate.Substring(5, 2)) == 6 || int.Parse(startDate.Substring(5, 2)) == 9 || int.Parse(startDate.Substring(5, 2)) == 11) && (int.Parse(startDate.Substring(8, 2)) < 1 || int.Parse(startDate.Substring(8, 2)) > 30))
                {
                    Console.WriteLine("Invalid day! Must choose day between 01-30 for this month");
                    valid = true;

                }
                else if ((int.Parse(startDate.Substring(5, 2)) == 1 || int.Parse(startDate.Substring(5, 2)) == 3 || int.Parse(startDate.Substring(5, 2)) == 5 || int.Parse(startDate.Substring(5, 2)) == 7 || int.Parse(startDate.Substring(5, 2)) == 8 || int.Parse(startDate.Substring(5, 2)) == 10 || int.Parse(startDate.Substring(5, 2)) == 12) && (int.Parse(startDate.Substring(8, 2)) < 1 || int.Parse(startDate.Substring(8, 2)) > 31))
                {
                    Console.WriteLine("Invalid day! Must choose day between 01-31 for this month");
                    valid = true;
                }
                else if (startDate[4] != '-' || startDate[7] != '-')
                {
                    Console.WriteLine("Invalid input! Must use '-' to separate year, month and date. Please check format!");
                    valid = true;
                }
                else
                {
                    valid = false;
                }
            } while (valid == true);
            

            return startDate;
        }

        public string AcquireCity()
        {
            Console.WriteLine("What city will you be visiting?");
            return Console.ReadLine();
        }
        public string AcquireTime()
        {
            Console.WriteLine("What is the soonest time you will be available for the event? (Use military time. Example: 3:30 pm would be entered as 15:30");
            var startTime = Console.ReadLine();
            return startTime;
        }
    }
}

