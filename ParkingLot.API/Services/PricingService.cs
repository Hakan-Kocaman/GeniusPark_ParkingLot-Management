using ParkingLot.Core;

namespace ParkingLot.API.Services
{
    public class PricingService
    {
    


        public List<Pricing> GetPricings()
        {
            return Pricing.Prices;
        }
        public decimal CalculatePrice(DateTime entryDate)
        {
            decimal price = 0;
            var hours = ((DateTime.Now - entryDate).TotalHours);

            if (hours > 24)
            {
                foreach (var pricing in Pricing.Prices)
                {
                    if (pricing.startHour <= 24 && 24 <= pricing.endHour && pricing.dayType == DateTime.Now.DayOfWeek.ToString() && pricing.Company_id == Company.id)
                    {
                        while (hours > 24)
                        {
                            price += pricing.priceOfInterval;
                            hours -= 24;
                        }
                    }
                }
            }


            foreach (var pricing in Pricing.Prices)
            {
                if (pricing.startHour <= hours && hours < pricing.endHour && pricing.dayType == DateTime.Now.DayOfWeek.ToString() && pricing.Company_id == Company.id)
                {
                    price += pricing.priceOfInterval;

                }
            }


            return price;
        }
    }
}
