using ParkingLot.Core;

namespace ParkingLot.API.Services
{
    public class BillService
    {

        public BillService() { }


        public List<Bill> GetBills()
        {
            return Bill.Bills;
        }

        public void PostBill(Bill bill)
        {
           
        }

        public void PutBill(Bill bill)
        {
        }

    }
}
