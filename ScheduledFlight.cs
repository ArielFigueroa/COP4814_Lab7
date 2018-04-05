using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_Library
{
    public class ScheduledFlight
    {
        public List<Flight> ListOfFlights = new List<Flight>();
        public string filePath = "..\\..\\flights.xml";

        public List<Flight> CreateFlights()
        {
            int flightNum = 100;
            String origAirport = "", destAirport = "";

            DateTime date = new DateTime(2018, 6, 1);
            

            List<Flight> ListOfFlights = new List<Flight>();
            Flight Route = new Flight();

            for (int i = 0; i < 31; i++)
            {
                Random ran = new Random();
                int seats = 10;
                flightNum = 100;

                    double price = 450.00;
                    TimeSpan time = new TimeSpan(8, 30, 0);
                    date = date.Date + time;

                    if (i > 0)
                    {
                        date = date.AddDays(1);
                    }
                    else { }

                    origAirport = "MIA";
   
                    for (int x = 0; x < 4; x++)
                    {
                        flightNum += 2;
                        destAirport = "SEA";
                        date = date.AddHours(1);
                        price += 250.00;

                        Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                        ListOfFlights.Add(Route);
                    }

                    price = 450.00;
                    time = new TimeSpan(8, 30, 0);
                    date = date.Date + time;

                    for (int x = 0; x < 4; x++)
                    {
                        flightNum += 2;
                        destAirport = "DEN";
                        date = date.AddHours(1);
                        price += 150.00;

                        Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                        ListOfFlights.Add(Route);
                    }

                    price = 450.00;
                    time = new TimeSpan(8, 30, 0);
                    date = date.Date + time;

                    for (int x = 0; x < 4; x++)
                    {
                        flightNum += 2;
                        destAirport = "LAX";
                        date = date.AddHours(1);
                        price += 450.00;

                        Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                        ListOfFlights.Add(Route);
                    }

                    /////////////////////////////////////////////////////////////////////

                    price = 450.00;
                    time = new TimeSpan(8, 30, 0);
                    date = date.Date + time;

                    origAirport = "SEA";

                    for (int x = 0; x < 4; x++)
                    {
                        flightNum += 2;
                        destAirport = "MIA";
                        date = date.AddHours(1);
                        price += 250.00;

                        Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                        ListOfFlights.Add(Route);
                    }

                    price = 450.00;
                    time = new TimeSpan(8, 30, 0);
                    date = date.Date + time;

                    for (int x = 0; x < 4; x++)
                    {
                        flightNum += 2;
                        destAirport = "DEN";
                        date = date.AddHours(1);
                        price += 350.00;

                        Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                        ListOfFlights.Add(Route);
                    }

                    price = 450.00;
                    time = new TimeSpan(8, 30, 0);
                    date = date.Date + time;

                    for (int x = 0; x < 4; x++)
                    {
                        flightNum += 2;
                        destAirport = "LAX";
                        date = date.AddHours(1);
                        price += 425.00;

                        Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                        ListOfFlights.Add(Route);
                    }

                    ///////////////////////////////////////////////////////////////////////////////////////////////

                    price = 450.00;
                    time = new TimeSpan(8, 30, 0);
                    date = date.Date + time;

                    origAirport = "DEN";

                    for (int x = 0; x < 4; x++)
                    {
                        flightNum += 2;
                        destAirport = "SEA";
                        date = date.AddHours(1);
                        price += 350.00;

                        Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                        ListOfFlights.Add(Route);
                    }

                    price = 450.00;
                    time = new TimeSpan(8, 30, 0);
                    date = date.Date + time;

                    for (int x = 0; x < 4; x++)
                    {
                        flightNum += 2;
                        destAirport = "MIA";
                        date = date.AddHours(1);
                        price += 150.00;

                        Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                        ListOfFlights.Add(Route);
                    }

                    price = 450.00;
                    time = new TimeSpan(8, 30, 0);
                    date = date.Date + time;

                    for (int x = 0; x < 4; x++)
                    {
                        flightNum += 2;
                        destAirport = "LAX";
                        date = date.AddHours(1);
                        price += 500.00;

                        Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                        ListOfFlights.Add(Route);
                    }

                    /////////////////////////////////////////////////////////////////////////////////////////////

                    price = 450.00;
                    time = new TimeSpan(8, 30, 0);
                    date = date.Date + time;

                    origAirport = "LAX";

                    for (int x = 0; x < 4; x++)
                    {
                        flightNum += 2;
                        destAirport = "SEA";
                        date = date.AddHours(1);
                        price += 425.00;

                        Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                        ListOfFlights.Add(Route);
                    }

                    price = 450.00;
                    time = new TimeSpan(8, 30, 0);
                    date = date.Date + time;

                    for (int x = 0; x < 4; x++)
                    {
                        flightNum += 2;
                        destAirport = "DEN";
                        date = date.AddHours(1);
                        price += 500.00;

                        Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                        ListOfFlights.Add(Route);
                    }

                    price = 450.00;
                    time = new TimeSpan(8, 30, 0);
                    date = date.Date + time;

                    for (int x = 0; x < 4; x++)
                    {
                        flightNum += 2;
                        destAirport = "MIA";
                        date = date.AddHours(1);
                        price += 450.00;

                        Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                        ListOfFlights.Add(Route);
                    }



            }
    

            return ListOfFlights;
        }

        public List<Flight> RequestFlights()
        {
            int flightNum = 100;
            String origAirport = "", destAirport = "";

            DateTime date = new DateTime(2018, 6, 1);


            List<Flight> ListOfFlights = new List<Flight>();
            Flight Route = new Flight();

            for (int i = 0; i < 20; i++)
            {
                Random ran = new Random();
                int seats = 10;
                flightNum = 100;

                double price = 450.00;
                TimeSpan time = new TimeSpan(8, 30, 0);
                date = date.Date + time;

                if (i > 0)
                {
                    date = date.AddDays(1);
                }
                else { }

                origAirport = "MIA";

                for (int x = 0; x < 4; x++)
                {
                    flightNum += 2;
                    destAirport = "SEA";
                    date = date.AddHours(1);
                    price += 250.00;

                    Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                    ListOfFlights.Add(Route);
                }

                price = 450.00;
                time = new TimeSpan(8, 30, 0);
                date = date.Date + time;

                for (int x = 0; x < 4; x++)
                {
                    flightNum += 2;
                    destAirport = "DEN";
                    date = date.AddHours(1);
                    price += 150.00;

                    Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                    ListOfFlights.Add(Route);
                }

                price = 450.00;
                time = new TimeSpan(8, 30, 0);
                date = date.Date + time;

                for (int x = 0; x < 4; x++)
                {
                    flightNum += 2;
                    destAirport = "LAX";
                    date = date.AddHours(1);
                    price += 450.00;

                    Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                    ListOfFlights.Add(Route);
                }

                /////////////////////////////////////////////////////////////////////

                price = 450.00;
                time = new TimeSpan(8, 30, 0);
                date = date.Date + time;

                origAirport = "SEA";

                for (int x = 0; x < 4; x++)
                {
                    flightNum += 2;
                    destAirport = "MIA";
                    date = date.AddHours(1);
                    price += 250.00;

                    Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                    ListOfFlights.Add(Route);
                }

                price = 450.00;
                time = new TimeSpan(8, 30, 0);
                date = date.Date + time;

                for (int x = 0; x < 4; x++)
                {
                    flightNum += 2;
                    destAirport = "DEN";
                    date = date.AddHours(1);
                    price += 350.00;

                    Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                    ListOfFlights.Add(Route);
                }

                price = 450.00;
                time = new TimeSpan(8, 30, 0);
                date = date.Date + time;

                for (int x = 0; x < 4; x++)
                {
                    flightNum += 2;
                    destAirport = "LAX";
                    date = date.AddHours(1);
                    price += 425.00;

                    Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                    ListOfFlights.Add(Route);
                }

                ///////////////////////////////////////////////////////////////////////////////////////////////

                price = 450.00;
                time = new TimeSpan(8, 30, 0);
                date = date.Date + time;

                origAirport = "DEN";

                for (int x = 0; x < 4; x++)
                {
                    flightNum += 2;
                    destAirport = "SEA";
                    date = date.AddHours(1);
                    price += 350.00;

                    Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                    ListOfFlights.Add(Route);
                }

                price = 450.00;
                time = new TimeSpan(8, 30, 0);
                date = date.Date + time;

                for (int x = 0; x < 4; x++)
                {
                    flightNum += 2;
                    destAirport = "MIA";
                    date = date.AddHours(1);
                    price += 150.00;

                    Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                    ListOfFlights.Add(Route);
                }

                price = 450.00;
                time = new TimeSpan(8, 30, 0);
                date = date.Date + time;

                for (int x = 0; x < 4; x++)
                {
                    flightNum += 2;
                    destAirport = "LAX";
                    date = date.AddHours(1);
                    price += 500.00;

                    Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                    ListOfFlights.Add(Route);
                }

                /////////////////////////////////////////////////////////////////////////////////////////////

                price = 450.00;
                time = new TimeSpan(8, 30, 0);
                date = date.Date + time;

                origAirport = "LAX";

                for (int x = 0; x < 4; x++)
                {
                    flightNum += 2;
                    destAirport = "SEA";
                    date = date.AddHours(1);
                    price += 425.00;

                    Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                    ListOfFlights.Add(Route);
                }

                price = 450.00;
                time = new TimeSpan(8, 30, 0);
                date = date.Date + time;

                for (int x = 0; x < 4; x++)
                {
                    flightNum += 2;
                    destAirport = "DEN";
                    date = date.AddHours(1);
                    price += 500.00;

                    Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                    ListOfFlights.Add(Route);
                }

                price = 450.00;
                time = new TimeSpan(8, 30, 0);
                date = date.Date + time;

                for (int x = 0; x < 4; x++)
                {
                    flightNum += 2;
                    destAirport = "MIA";
                    date = date.AddHours(1);
                    price += 450.00;

                    Route = new Flight(flightNum, date, origAirport, destAirport, seats, price);
                    ListOfFlights.Add(Route);
                }



            }


            return ListOfFlights;
        }

        public Boolean SerializeFlightList(List<Flight> lf)
        {
            StreamWriter sw = new StreamWriter(filePath);
            XmlSerializer serial = new XmlSerializer(lf.GetType());
            serial.Serialize(sw, lf);


            sw.Close();
            return true;
        }

        public Boolean SerializeMatchingFlightList(List<Flight> lf)
        {
            StreamWriter sw = new StreamWriter("..\\..\\matchingflights.xml");
            XmlSerializer serial = new XmlSerializer(lf.GetType());
            serial.Serialize(sw, lf);


            sw.Close();

            XmlSerializer s = new XmlSerializer(typeof(List<Flight>));
            using (XmlWriter w = XmlWriter.Create("..\\..\\matchingflights.xml"))
            {
                w.WriteProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"flighteditor.xslt\"");
                s.Serialize(w, lf);
                sw.Close();
            }

            return true;
        }

        public Boolean DeserializeFlightList()
        {
            StreamReader sr = new StreamReader(filePath);
            XmlSerializer serial = new XmlSerializer(CreateFlights().GetType());

            ListOfFlights = (List<Flight>)serial.Deserialize(sr);

            sr.Close();

            return true;
        }

        public override String ToString()
        {
            string displayList = "";

            for (int i = 0; i < ListOfFlights.Count; i++)
            {
                displayList += ListOfFlights.ElementAt<Flight>(i).ToString();
            }

            return displayList;
        }

    }
}
