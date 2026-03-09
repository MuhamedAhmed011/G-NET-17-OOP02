using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp2
{
    public class Ticket
    {
        private string movieName;
        private TicketType type;
        private SeatLocation seat;
        private double price;

        private static int ticketCounter = 0;
        public int TicketId { get; private set; }
        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    movieName = value;
            }
        }
        public TicketType Type
        {
            get { return type; }
            set { type = value; }
        }
        public SeatLocation Seat
        {
            get { return seat; }
            set { seat = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }
        public double PriceAfterTax
        {
            get { return price * 1.14; }
        }
        public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;

            ticketCounter++;
            TicketId = ticketCounter;
        }
        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }
        public void DisplayTicket()
        {
            Console.WriteLine("Ticket ID: " + TicketId);
            Console.WriteLine("Movie Name: " + MovieName);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Seat: " + Seat);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Price After Tax: " + PriceAfterTax);
        }
    }
}
