using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noda_Time_Sample_Console
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Serversncode.com Noda Time demo starting");

      // Get All timezones

      Console.WriteLine("Get all Timezones");

      var timeZones = TimeZoneInfo.GetSystemTimeZones();

      foreach (var oTimeZone in timeZones)
      {
        Console.WriteLine("TimeZone: " + oTimeZone.DisplayName + " Id: " + oTimeZone.Id);
      }


      Console.WriteLine("------------------------");
      Console.WriteLine("Convert Date time to UTC");

      // Set our fictional users time zone
      string easternZoneId = "Eastern Standard Time";

      // The date they want to schedule the delivery.
      var userScheduledTime = new DateTime(2018, 12, 03, 10, 46, 00);

      // Load the NodaTimeZone information for the users timezone
      TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById(easternZoneId);


      // Convert the Date Time to UTC
      var utcTime = TimeZoneInfo.ConvertTimeToUtc(userScheduledTime, easternZone);

      Console.WriteLine("The date and time are " + utcTime + " UTC " + userScheduledTime + " " + easternZone.DisplayName);




      Console.WriteLine("Complete");
      Console.ReadKey();
    }
  }
}
