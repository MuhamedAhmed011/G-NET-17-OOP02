using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Reflection;

namespace OOPApp2
{
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


        }
    }
}
