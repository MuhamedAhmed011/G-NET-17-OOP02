using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Reflection;

namespace OOPApp2
{
    //public enum TicketType
    //{
    //    Standard,
    //    VIP,
    //    IMAX
    //}
    //public struct SeatLocation
    //{
    //    public char Row { get; set; }
    //    public int Number { get; set; }

    //    public SeatLocation(char row, int number)
    //    {
    //        Row = row;
    //        Number = number;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Row}{Number}";
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            #region Question01
            //a) Problems with the Design (Encapsulation)

            //The variables Owner and Balance are declared as public,
            //so any other class can access and modify them directly.

            //There is no validation in the Withdraw method,
            //so it can reduce the balance even if the account does not have enough money.

            //b) How to Fix the Class

            //Change the fields Owner and Balance from public to private.

            //Use getter and setter methods to control access to these fields.

            //c) Why Public Fields Are Bad in OOP

            //They break encapsulation because data can be changed directly from outside the class.

            //They make it hard to control or validate data.

            //They can lead to errors  data in the program. 
            #endregion

            #region Question02
            //Difference Between Field and Property in C#
            //Field: A variable that directly stores data inside a class.
            //Property: A member that provides controlled access to a field using get and set.

            //Can a Property Contain Logic?
            //Yes, a property can include logic inside the get or set methods

            //Example
            //class Rectangle
            //{
            //    public double Width;
            //    public double Height;

            //    public double Area
            //    {
            //        get { return Width * Height; }
            //    }
            //} 
            #endregion

            #region Question03
            //a) 
            //It is called an Indexer in C#.
            //It allows objects of the class to be accessed like an array using an index.
            //In this example, it allows accessing student names like this:
            //register[0] = "Ali";

            //b)
            //Using index 10 will cause an IndexOutOfRangeException.
            //To make it safer:Add a check to ensure the index is within the valid range.
            //if (index >= 0 && index < names.Length) => names[index] = value;

            //c)
            //Yes, a class can have multiple indexers.
            //They can use different parameter types or numbers of parameters.
            //Example: A class may allow access by index or by name in a student system. 
            #endregion

            #region Question04
            //a)
            //The static keyword means the variable belongs to the class itself.
            //TotalOrders is shared by all Order objects
            //so every time a new order is created the same variable increases.
            //The Item field is not static, so each object has its own Item value.

            //b)
            //No, a static method cannot access Item directly.
            //This is because Item belongs to a specific object (instance), while a static method belongs to the class. 
            #endregion
            #endregion

            #region Part02
            //Cinema cinema = new Cinema();

            //Console.WriteLine("======== Ticket Booking ========");
            //Console.WriteLine();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter data for Ticket {i + 1}:");

            //    Console.Write("Movie Name: ");
            //    string movieName = Console.ReadLine();

            //    Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
            //    TicketType type = (TicketType)int.Parse(Console.ReadLine());

            //    Console.Write("Seat Row (A-Z): ");
            //    char row = char.Parse(Console.ReadLine().ToUpper());

            //    Console.Write("Seat Number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    Console.Write("Price: ");
            //    double price = double.Parse(Console.ReadLine());

            //    Ticket ticket = new Ticket(movieName, type, new SeatLocation(row, number), price);
            //    cinema.AddTicket(ticket);

            //    Console.WriteLine();
            //}

            //Console.WriteLine("-------- All Tickets --------");
            //Console.WriteLine();

            //for (int i = 0; i < 3; i++)
            //{
            //    Ticket t = cinema[i];

            //    if (t != null)
            //    {
            //        Console.WriteLine(
            //            $"Ticket #{t.TicketId} | {t.MovieName} | {t.Type} | Seat: {t.Seat} | Price: {t.Price} EGP | After Tax: {t.PriceAfterTax} EGP"
            //        );
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("-------- Search by Movie --------");
            //Console.WriteLine();

            //Console.Write("Enter movie name to search: ");
            //string searchName = Console.ReadLine();

            //Ticket foundTicket = cinema[searchName];

            //if (foundTicket != null)
            //{
            //    Console.WriteLine(
            //        $"Found: Ticket #{foundTicket.TicketId} | {foundTicket.MovieName} | {foundTicket.Type} | Seat: {foundTicket.Seat} | Price: {foundTicket.Price} EGP"
            //    );
            //}
            //else
            //{
            //    Console.WriteLine("Movie not found.");
            //}

            //Console.WriteLine();
            //Console.WriteLine("-------- Statistics --------");
            //Console.WriteLine();

            //Console.WriteLine("Total Tickets Sold: " + Ticket.GetTotalTicketsSold());
            //Console.WriteLine();

            //string bookingRef1 = BookingHelper.GenerateBookingReference();
            //string bookingRef2 = BookingHelper.GenerateBookingReference();

            //Console.WriteLine("Booking Reference 1: " + bookingRef1);
            //Console.WriteLine("Booking Reference 2: " + bookingRef2);
            //Console.WriteLine();

            //double discountedTotal = BookingHelper.CalcGroupDiscount(5, 80);
            //Console.WriteLine("Group Discount (5 tickets x 80 EGP): " + discountedTotal + " EGP");

            #endregion        

        }
    }
}
