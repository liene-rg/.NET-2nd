using System;

namespace CSharp.Activity.Collections
{
    //public class CustomerInfo
    //{

    //    public int Id { get; set; }

    //    public string Name { get; set; }

    //    public string Address { get; set; }

    //    public string Email { get; set; }


    //    public CustomerInfo(int Id, string Name, string Address, string Email)
    //    {
    //        this.Id = Id;
    //        this.Name = Name;
    //        this.Address = Address;
    //        this.Email = Email;
    //    }


    //    public override string ToString()
    //    {
    //        return "Customer: " + this.Id + " " + this.Name + " " + this.Address + " " + this.Email;
    //    }

    //}

    public class CustomerInfo
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public CustomerInfo(int id, string name, string address, string email)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.Email = email;
        }

        public override string ToString()
        {
            return "ID = " + this.ID + ";Name = " + this.Name + "; Address = " + this.Address + "; EMail = " + this.Email;
        }

    }

}