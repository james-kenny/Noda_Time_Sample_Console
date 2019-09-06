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

      var timeZones = TimeZoneInfo.GetSystemTimeZones();

      foreach (var oTimeZone in timeZones)
      {
        Console.WriteLine("TimeZone: " + oTimeZone.DisplayName + " Id: " + oTimeZone.Id);
      }

      string easternZoneId = "Eastern Standard Time";


      Console.WriteLine("Complete");
    }
  }
}
