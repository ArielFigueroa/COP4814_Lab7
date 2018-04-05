using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_Library
{
    public class Flight
    {

        public int flightNum { get; set; }

        public DateTime date { get; set; }

        public String origAirport { get; set; }

        public String destAirport { get; set; }

        public int seats { get; set; }

        public double price { get; set; }

        public Flight()
        { }

        public Flight(int flightNum, DateTime date, String origAirport, String destAirport, int seats, double price)
        {
            this.flightNum = flightNum;
            this.date = date;
            this.origAirport = origAirport;
            this.destAirport = destAirport;
            this.seats = seats;
            this.price = price;
        }
        
        public override String ToString()
        {
            return flightNum + ",   " + date.Date.ToString("MM/dd/yyyy") + " at " + date.ToString("HH:mm tt") + ",   " + origAirport + " to " + destAirport + ",   Cost: " + price.ToString("C1") + ",\t" + " Seats: " + seats;
        }

    }
}
