using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace XYZAirline
{
    class AirlineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManager bkManager;


        public AirlineCoordinator()
        {
            flManager = new FlightManager();
            bkManager = new BookingManager();
            custManager = new CustomerManager();

        }
        public bool flightExist(int flightNo)
        {
            return flManager.flightExists(flightNo);
        }

        public bool addFlight(int flightNo, string origin, string destination, int maxSeats)
        {
            return flManager.addFlight(flightNo, origin, destination, maxSeats);
        }

        public DataSet flightList()
        {
            return flManager.getFlightList();
        }
        
        public bool deleteFlight(int fid)
        {
            return flManager.deleteFlight(fid);
        }

        public bool customerExist(string fname, string lname, string ph)
        {
            return custManager.customerExists(fname, lname, ph);
        }

        public bool addCustomer(string fname, string lname, string phone)
        {
            return custManager.addCustomer(fname, lname, phone);
        }

        public DataSet customerList()
        {
            return custManager.getCustomerList();
        }
        
        public bool deleteCustomer(int cId)
        {
            return custManager.deleteCustomer(cId);
        }

        public bool bookingExist(int cid, int fid)
        {
            return bkManager.bookingExist(cid,fid);
        }

        public bool flightHasSeats(int fid)
        {
            return flManager.flightHasSeats(fid);
        }

        public bool addBooking(int cId, int fId)
        {
            if (!bkManager.bookingExist(cId, fId))
            {
                string date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
                return bkManager.addBooking(date, cId, fId);
            }

            return false;

        } 

        public DataSet bookingList()
        {
            return bkManager.getBookingList();
        }

        public DataSet flightPassengerList(int fid)
        {
            return bkManager.getFlightPassengerList(fid);
        }

    }
}
