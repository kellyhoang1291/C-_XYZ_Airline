using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZAirline
{
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int numBookings;

        public Customer(int cId, string fname, string lname, string ph)
        {
            numBookings = 0;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }

        public Customer(int cId, string fname, string lname, string ph, int numBook)
        {
            numBookings = numBook;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }

        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }

        public string getFullName() { return firstName + " " + lastName; }
        public string getPhone() { return phone; }
        public int getNumBookings() { return numBookings; }

        public bool addBooking()
        {
            numBookings++;
            return true;
        }


        public string toString()
        {
            string s = "Customer " + customerId;
            s = s + "\nName: " + firstName + " " + lastName;
            s = s + "\nPhone: " + phone;
            s = s + "\n Bookings: " + numBookings;

            return s;
        }
    }
}
