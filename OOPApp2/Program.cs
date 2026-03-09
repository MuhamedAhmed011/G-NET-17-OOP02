using System.ComponentModel;

namespace OOPApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part01

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


        }
    }
}
