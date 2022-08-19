using System;
using Newtonsoft.Json.Linq;
namespace FinalProject
{
	public class Event
	{
		public Event()
		{
		}
        public string ArrivalDate()
        {
            var startDate = "";

            var valid = false;

            do
            {
                Console.WriteLine("When will you be visiting? (Enter using YYYY-MM-DD format)");
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
        public string DepartureDate()
        {
            var endDate = "";

            var valid = false;

            do
            {
                Console.WriteLine("When will you be leaving? (Enter using YYYY-MM-DD format)");
                endDate = Console.ReadLine();

                if (int.Parse(endDate.Substring(0, 4)) < 2022)
                {
                    Console.WriteLine("Invalid year! Must pick a future date");
                    valid = true;
                }
                else if (int.Parse(endDate.Substring(5, 2)) < 1 || int.Parse(endDate.Substring(5, 2)) > 12)
                {
                    Console.WriteLine("Invalid month! Must pick an existing month between 01-12");
                    valid = true;
                }
                else if ((int.Parse(endDate.Substring(5, 2)) == 2) && (int.Parse(endDate.Substring(8, 2)) < 1 || int.Parse(endDate.Substring(8, 2)) > 28))
                {
                    Console.WriteLine("Invalid day! Must choose between 01-28 for the month of February");
                    valid = true;
                }
                else if ((int.Parse(endDate.Substring(5, 2)) == 4 || int.Parse(endDate.Substring(5, 2)) == 6 || int.Parse(endDate.Substring(5, 2)) == 9 || int.Parse(endDate.Substring(5, 2)) == 11) && (int.Parse(endDate.Substring(8, 2)) < 1 || int.Parse(endDate.Substring(8, 2)) > 30))
                {
                    Console.WriteLine("Invalid day! Must choose day between 01-30 for this month");
                    valid = true;

                }
                else if ((int.Parse(endDate.Substring(5, 2)) == 1 || int.Parse(endDate.Substring(5, 2)) == 3 || int.Parse(endDate.Substring(5, 2)) == 5 || int.Parse(endDate.Substring(5, 2)) == 7 || int.Parse(endDate.Substring(5, 2)) == 8 || int.Parse(endDate.Substring(5, 2)) == 10 || int.Parse(endDate.Substring(5, 2)) == 12) && (int.Parse(endDate.Substring(8, 2)) < 1 || int.Parse(endDate.Substring(8, 2)) > 31))
                {
                    Console.WriteLine("Invalid day! Must choose day between 01-31 for this month");
                    valid = true;
                }
                else if (endDate[4] != '-' || endDate[7] != '-')
                {
                    Console.WriteLine("Invalid input! Must use '-' to separate year, month and date. Please check format!");
                    valid = true;
                }
                else
                {
                    valid = false;
                }
            } while (valid == true);


            return endDate;
        }
        public string AcquireCity()
        {
            Console.WriteLine("What city will you be visiting?");
            var city = Console.ReadLine();
            return city;
        }
        public string StartTime()
        {
            var time = "";
            string hour;            
            var valid = false;

            do
            {
                Console.WriteLine("What is the soonest time you will be available for the event? (Use HH:MM_M format, where 'HH' is the hour, 'MM' is the minutes, and '_M' is either AM or PM.");
                time = Console.ReadLine();

                if (int.Parse(time.Substring(0, 2)) < 1 || int.Parse(time.Substring(0, 2)) > 12)
                {
                    Console.WriteLine("Invalid hour! Please choose an hour between 01 and 12.");
                    valid = true;
                }
                else if (int.Parse(time.Substring(3, 2)) < 0 || int.Parse(time.Substring(3, 2)) > 59)
                {
                    Console.WriteLine("Invalid minute! Please choose a minute between 00 and 59.");
                    valid = true;
                }
                else if (time[2] != ':')
                {
                    Console.WriteLine("Invalid input! Please use ':' to separate hours and minutes.");
                    valid = true;
                }
                else if (time.Length <= 5)
                {
                    Console.WriteLine("Invalid input! Must indicate whether AM or PM");
                    valid = true;
                }
                else if (!(time.Substring(5).ToLower().Equals("am") || time.Substring(5).ToLower().Equals("pm")))
                {
                    Console.WriteLine($"Invalid input! Enter either 'AM' or 'PM' after time. You entered {time.Substring(5)}");
                    valid = true;
                }
                else
                {
                    valid = false;
                }
            } while (valid == true);
            
            if (time.Substring(5, 2).ToUpper() == "PM")
            {
                hour = (int.Parse(time.Substring(0, 2)) + 12).ToString();
            }
            else
            {
                hour = time.Substring(0, 2);
            }

            var minutes = time.Substring(3, 2);
            time = $"{hour}:{minutes}";

            return time;
        }
        public string EndTime()
        {
            var time = "";
            string hour;
            var valid = false;

            do
            {
                Console.WriteLine("What is the latest time you can attend event? (Use HH:MM_M format, where 'HH' is the hour, 'MM' is the minutes, and '_M' is either AM or PM.");
                time = Console.ReadLine();

                if (int.Parse(time.Substring(0, 2)) < 1 || int.Parse(time.Substring(0, 2)) > 12)
                {
                    Console.WriteLine("Invalid hour! Please choose an hour between 01 and 12.");
                    valid = true;
                }
                else if (int.Parse(time.Substring(3, 2)) < 0 || int.Parse(time.Substring(3, 2)) > 59)
                {
                    Console.WriteLine("Invalid minute! Please choose a minute between 00 and 59.");
                    valid = true;
                }
                else if (time[2] != ':')
                {
                    Console.WriteLine("Invalid input! Please use ':' to separate hours and minutes.");
                    valid = true;
                }
                else if (time.Length <= 5)
                {
                    Console.WriteLine("Invalid input! Must indicate whether AM or PM");
                    valid = true;
                }
                else if (!(time.Substring(5).ToLower().Equals("am") || time.Substring(5).ToLower().Equals("pm")))
                {
                    Console.WriteLine($"Invalid input! Enter either 'AM' or 'PM' after time. You entered {time.Substring(5)}");
                    valid = true;
                }
                else
                {
                    valid = false;
                }
            } while (valid == true);

            if (time.Substring(5, 2).ToUpper() == "PM")
            {
                hour = (int.Parse(time.Substring(0, 2)) + 12).ToString();
            }
            else
            {
                hour = time.Substring(0, 2);
            }

            var minutes = time.Substring(3, 2);
            time = $"{hour}:{minutes}";

            return time;
        }
        public string EventGenre()
        {
            Console.WriteLine("What type of event are you interested in attending? Sports, Music, or Miscellaneous");
            var eventType = Console.ReadLine().ToLower();
            if (eventType == "sports")
            {
                Console.WriteLine("Which sport? ");
            }
            else if (eventType == "music")
            {
                Console.WriteLine("Which musical genre? ");
            }
            else
            {
                Console.WriteLine("Which genre? ");
            }
            var genre = Console.ReadLine().ToLower();
            return genre;
        }
        public JObject JsonResponse(string city, string startDate, string startTime, string endDate, string endTime, string apiKey)
        {
            var client = new HttpClient();
            var startDateTime = $"{startDate}T{startTime}:00Z";
            var endDateTime = $"{endDate}T{endTime}:00Z";

            var eventURL = $"https://app.ticketmaster.com/discovery/v2/events.json?city={city}&startDateTime{startDateTime}&endDateTime={endDateTime}&apikey={apiKey}";
            var response = client.GetStringAsync(eventURL).Result;

            return JObject.Parse(response);
        }
        public void PrintSearchResults(JObject jsonResponse, string genre)
        {
            for (int i = 0; i < jsonResponse["_embedded"]["events"].Count(); i++)
            {
                var genreName = jsonResponse["_embedded"]["events"][i]["classifications"][0]["genre"]["name"].ToString().ToLower();
                var startDate = jsonResponse["_embedded"]["events"][i]["dates"]["start"]["localDate"];
                var eventName = jsonResponse["_embedded"]["events"][i]["name"];
                var eventTime = jsonResponse["_embedded"]["events"][i]["dates"]["start"]["localTime"];

                if (genre == genreName)
                {
                    Console.WriteLine($"On {startDate}, there will be a {eventName} at {eventTime}");
                }
            }

        }
    }
}
