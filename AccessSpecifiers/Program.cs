using System;

namespace AccessSpecifiers
{
    //example 1
    /*  public class Customer
      {
          #region Private Fields
          private int _id;
          private string _firstName;
          private string _lastName;
          #endregion
          #region Properties
          public int Id
          {
              get { return _id; }
              set { _id = value; }
          }
          public string FirstName
          {
              get { return _firstName; }
              set { _firstName = value; }
          }
          public string LastName
          {
              get { return _lastName; }
              set { _lastName = value; }
          }
          #endregion
          #region Methods
          public string GetFullName()
          {
              return this._firstName + " " + this._lastName;
          }
          #endregion
      }*/

    //example 2 Private and Public Access Specifiers

    /*  public class Customer
      {
          private int _id;
          public int Id
          {
              get
              {
                  return _id;
              }
              set
              {
                  _id = value;
              }
          }
      }
      public class MainClass
      {
          private static void Main()
          {
              Customer CustomerInstance = new Customer();
              CustomerInstance.Id = 101;
              // Compiler Error: 'Customer._id' is inaccessible due to its protection level
              //CustomerInstance._id = 101;
          }
      }*/
    //example 3 Protected Access Specifier
    public class Customer
    {
        protected int ID = 101;
        public void PrintID()
        {
            //Protected member ID is accessible with in Customer class
            Console.WriteLine(this.ID);
        }
    }
    public class CorporateCustomer : Customer
    {
        public void PrintCustomerID()
        {
            CorporateCustomer corporateCustomerInstance = new CorporateCustomer();
            // Can access the base class protected instance member using the derived class object
            Console.WriteLine(corporateCustomerInstance.ID);
            // Can access the base class protected instance member using this or base keyword
            Console.WriteLine(this.ID);
            Console.WriteLine(base.ID);
        }
    }
    public class RetailCustomer
    {
        public void PrintCustomerID()
        {
            RetailCustomer retailCustomerInstance = new RetailCustomer();
            //RetailCustomer class is not deriving from Customer class, hence it is an error
            //to access Customer class protected ID member, using the retailCustomerInstance
            //Console.WriteLine(retailCustomerInstance.ID); //Error
            //Both these below lines also produce the same Error
            //Console.WriteLine(this.ID); // Error
            //Console.WriteLine(base.ID); // Error
        }
    }


}
