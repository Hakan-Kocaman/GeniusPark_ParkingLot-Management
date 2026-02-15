using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Core
{
    public class Bill
    {
       public int id { get; set; }
       public string licensePlate { get; set; }
       public DateTime enterDate { get; set; }
       public DateTime exitDate { get; set; }
       public decimal price { get; set; }
       public int Company_id  { get; set; }

       public static List<Bill> Bills { get; set; }

    }
}
