using FinalProject;
using Newtonsoft.Json.Linq;

var client = new HttpClient();
Console.WriteLine("Enter key: "); 
var key = Console.ReadLine();

var eventO = new Event();

/* Ask client for travel destination */
var city = eventO.AcquireCity();

/* Ask client for date of arrival */
var startDate = eventO.ArrivalDate();

/* Ask client for time of arrival */
var startTime = eventO.StartTime();

/* Ask client for date of departure */
var endDate = eventO.DepartureDate();

/* Ask client for time of departure */
var endTime = eventO.EndTime;

/* Ask client what type of event */
var genre = eventO.EventGenre();

var startDateTime = $"{startDate}T{startTime}Z";
var endDateTime = $"{endDate}T{endTime}Z";

var eventURL = $"https://app.ticketmaster.com/discovery/v2/events.json?city={city}&startDateTime{startDateTime}&endDateTime={endDateTime}&apikey={key}";
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
