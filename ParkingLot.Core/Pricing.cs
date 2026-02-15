using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Core
{
    public class Pricing
    {
       public int id { get; set; }
       public int startHour { get; set; }

       public int endHour { get; set; }
       public string dayType { get; set; }
       public decimal priceOfInterval { get; set; }
       public int Company_id { get; set; }

       public static List<Pricing> Prices { get; set; }
        
    }
}
