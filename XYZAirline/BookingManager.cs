using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace XYZAirline
{
    class BookingManager
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\XYZArline.mdf;Integrated Security=True");

        public bool addBooking(string date, int cid, int fid)
        {
            try
            {
                conn.Open();
                //add new booking
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"INSERT into Booking(bookingDate, bookingPassenger, bookingFlight) values ('{date}',{cid},{fid})";
                cmd.ExecuteNonQuery();
                conn.Close();

                //increase num passenger for flight
                conn.Open();
                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = $"update Flight SET numPassenger += 1 where flightNumber = {fid}";
                cmd1.ExecuteNonQuery();
                conn.Close();

                //increase num booking for customer
                conn.Open();
                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = $"update Customer SET numBookings += 1 where customerId = {cid}";
                cmd2.ExecuteNonQuery();
                conn.Close();

                //check if booking has been added
                if (bookingExist(cid, fid)) return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool findBooking(int bid)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from Booking where bookingNumber = {bid}";
                cmd.ExecuteNonQuery();

                DataTable dTable = new DataTable();
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                dAdapter.Fill(dTable);

                conn.Close();
                if (dTable.Rows.Count == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool bookingExist(int cid, int fid)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from Booking where bookingPassenger = {cid} and bookingFlight = {fid}";
                cmd.ExecuteNonQuery();

                DataTable dTable = new DataTable();
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                dAdapter.Fill(dTable);

                conn.Close();
                if (dTable.Rows.Count == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Booking getBooking(int bid)
        {
            if (findBooking(bid))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"select * from Booking where bookingNumber = {bid}";
                    cmd.ExecuteNonQuery();

                    DataTable dTable = new DataTable();
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    dAdapter.Fill(dTable);

                    conn.Close();

                    string date = dTable.Rows[0]["lastName"].ToString();
                    int cid = Convert.ToInt32(dTable.Rows[0]["bookingPassenger"].ToString());
                    int fid = Convert.ToInt32(dTable.Rows[0]["bookingFlight"].ToString());

                    Booking b = new Booking(bid, date, fid, cid);
                    return b;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            return null;
        }

        public DataSet getBookingList()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select bookingNumber, bookingDate, CONCAT(firstName, ' ', lastName) as passengerName, bookingFlight from Booking b join customer c ON b.bookingPassenger = c.customerId";
                cmd.ExecuteNonQuery();

                DataSet ds = new DataSet();
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                dAdapter.Fill(ds, "Booking");
                conn.Close();
                return ds;
            }
            catch (Exception e)
            {
                throw e;
                //return null;
            }
        }

        public DataSet getFlightPassengerList(int fid)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"select customerId, firstName, lastName, phone " +
                    $"from Customer c JOIN Booking b " +
                    $"ON c.customerId = b.bookingPassenger " +
                    $"WHERE b.bookingFlight = {fid}";
                
                cmd.ExecuteNonQuery();

                DataSet ds = new DataSet();
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                dAdapter.Fill(ds, "Customer");
                conn.Close();
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
