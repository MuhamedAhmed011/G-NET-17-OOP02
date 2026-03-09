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


        }
    }
}
