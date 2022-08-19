using FinalProject;
using Newtonsoft.Json.Linq;

var client = new HttpClient();
Console.WriteLine("Enter key: "); 
var key = Console.ReadLine();

var eventO = new Event();

/* Ask client for the city where they will be traveling to */
var city = eventO.AcquireCity;

/* Ask client for the date they will be traveling */
var startDate = eventO.AcquireDate();

/* Ask client for the time they will be available for event */
Console.WriteLine("What is the soonest time you will be available for the event? (Use military time. Example: 3:30 pm would be entered as 15:30");
var startTime = Console.ReadLine();
var startDateTime = $"{startDate}T{startTime}:00Z";

/* Ask client what type of event */
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

var eventURL = $"https://app.ticketmaster.com/discovery/v2/events.json?city={city}&startDateTime{startDateTime}&apikey={key}";
var response = client.GetStringAsync(eventURL).Result;

JObject jsonResponse = JObject.Parse(response);
var name = jsonResponse["_embedded"]["events"][0]["name"];
var time = jsonResponse["_embedded"]["events"][0]["dates"]["start"]["localTime"];
//var eventType = jsonResponse["_embedded"]["events"][i]["classifications"][0]["segment"]["name"];
//var eventGenre = jsonResponse["_embedded"]["events"][i]["classifications"][0]["genre"]["name"];


for (int i = 0; i < jsonResponse["_embedded"]["events"].Count(); i++)
{
    if (genre == jsonResponse["_embedded"]["events"][i]["classifications"][0]["genre"]["name"].ToString().ToLower())
    {
        Console.WriteLine($"On {jsonResponse["_embedded"]["events"][i]["dates"]["start"]["localDate"]}, there will be a {jsonResponse["_embedded"]["events"][i]["name"]} at {jsonResponse["_embedded"]["events"][i]["dates"]["start"]["localTime"]}");
    }
}
