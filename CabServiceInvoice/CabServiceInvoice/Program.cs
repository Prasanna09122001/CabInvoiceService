using System;
namespace CabServiceInvoice
{
    class program
    {
        static void Main()
        {
            InvoiceService invoiceSerice = new InvoiceService();
            string userid = "Prasanna";
            Ride[] ride =
            {
                new Ride(){Distance=10,time=5},
                new Ride(){Distance=10,time=15},
            };
            RideRepository rideRepository = new RideRepository();
            rideRepository.AddRides(userid, ride);
            Console.WriteLine(invoiceSerice.CalculateFare(rideRepository.GetRides(userid)));
        }
    }
}
