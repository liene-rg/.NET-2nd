using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Collections
{
    //public class CustomerInfoCollection : IEnumerable
    //{


    //    public List<CustomerInfo> customerlist = new List<CustomerInfo>();
    //    public int Add(CustomerInfo customer)
    //    {
    //        if (customer == null)
    //            throw new ArgumentNullException();

    //        else customerlist.Add(customer);
    //        return customerlist.Count;
    //    }
    //    public void Insert(int index, CustomerInfo customer)
    //    {
    //        if (customer == null)
    //            throw new ArgumentNullException();
    //        if (index < 0)
    //            throw new ArgumentOutOfRangeException();

    //        customerlist.Insert(index, customer);

    //    }

    //    public void Remove(CustomerInfo customer)
    //    {
    //        if (customer == null)
    //            throw new ArgumentNullException(nameof(customer));

    //        customerlist.Remove(customer);
    //    }


    //    public bool Contains(CustomerInfo customer)
    //    {
    //        if (customer == null)
    //            throw new ArgumentNullException();

    //        if (customerlist.Contains(customer))
    //            return true;
    //        else return false;
    //    }

    //    public int IndexOf(CustomerInfo customer)
    //    {
    //        if (customer == null)
    //            throw new ArgumentNullException();
    //        else
    //            return customerlist.IndexOf(customer);
    //    }

    //    public CustomerInfo this[int index]
    //    {
    //        get
    //        {
    //            if (index < 0 || index >= customerlist.Count)
    //                throw new IndexOutOfRangeException("Index out of range");

    //            return (CustomerInfo)customerlist[index];
    //        }

    //        set
    //        {
    //            if (index < 0 || index >= customerlist.Count)
    //                throw new IndexOutOfRangeException("Index out of range");

    //            customerlist[index] = value;
    //        }
    //    }

    //    public IEnumerator<CustomerInfo> GetEnumerator()
    //    {
    //        foreach (var nameStr in customerlist)
    //            yield return (CustomerInfo)nameStr;
    //        yield break;
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }


    //}


    public class CustomerInfoCollection
    {
        private List<CustomerInfo> customerInfos = new List<CustomerInfo>();
        public int Add(CustomerInfo customerInfo)
        {
            if (customerInfo == null)
                throw new ArgumentNullException();

            if (this.customerInfos.Contains(customerInfo))
                return -1;

            this.customerInfos.Add(customerInfo);
            return this.customerInfos.Count - 1;
        }
        public void Insert(int position, CustomerInfo customerInfo)
        {
            if (customerInfo == null)
                throw new ArgumentNullException();

            if (position < 0)
                throw new ArgumentOutOfRangeException();
            if (this.customerInfos.Contains(customerInfo))
                return;//do nothing

            this.customerInfos.Insert(position, customerInfo);
        }

        public void Remove(CustomerInfo customerInfo)
        {
            if (customerInfo == null)
                throw new ArgumentNullException();

            this.customerInfos.Remove(customerInfo);
        }
        public bool Contains(CustomerInfo customerInfo)
        {
            if (customerInfo == null)
                throw new ArgumentNullException();

            return this.customerInfos.Contains(customerInfo);
        }

        public int IndexOf(CustomerInfo customerInfo)
        {
            if (customerInfo == null)
                throw new ArgumentNullException();
            return this.customerInfos.IndexOf(customerInfo);
        }

        public CustomerInfo this[int index]
        {
            get { return this.customerInfos[index]; }
            set { this.Insert(index, value); }
        }
        public override string ToString()
        {
            System.Text.StringBuilder strBuild = new System.Text.StringBuilder();
            foreach (var element in this.customerInfos)
                strBuild.Append(element + System.Environment.NewLine);
            return strBuild.ToString();
        }

    }

}



