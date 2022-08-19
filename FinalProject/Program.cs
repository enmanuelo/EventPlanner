using FinalProject;
using Newtonsoft.Json.Linq;

/* Ask for api key */
Console.WriteLine("Enter key: "); 
var key = Console.ReadLine();

/* Create Event object */
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
var endTime = eventO.EndTime();

/* Ask client what type of event */
var genre = eventO.EventGenre();

/* Print search results */
JObject jsonResponse = eventO.JsonResponse(city, startDate, startTime, endDate, endTime, key);
eventO.PrintSearchResults(jsonResponse, genre);
