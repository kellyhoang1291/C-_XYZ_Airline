using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZAirline
{
    class Booking
    {
        private int bookingNumber;
        private string bookingDate;
        private int bookingFlight;
        private int bookingPassenger;

        public Booking(int bid, string date, int fid, int cid)
        {
            this.bookingNumber = bid;
            this.bookingDate = date;
            this.bookingFlight = fid;
            this.bookingPassenger = cid;

        }

        public int getBookingNumber() { return bookingNumber; }
        public string getBookingDate() { return bookingDate; }
        public int getBookingFlight() { return bookingFlight; }
        public int getBookingPassenger() { return bookingPassenger; }

        public string toString()
        {
            string s = "Booking Number: " + bookingNumber;
            s = s + "\nDate: " + bookingDate;
            s = s + "\nFlight Number: " + bookingFlight;
            s = s + "\nPassenger ID: " + bookingPassenger;

            return s;
        }
    }
}
