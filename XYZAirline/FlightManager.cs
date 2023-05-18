using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace XYZAirline
{
    class FlightManager
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\XYZArline.mdf;Integrated Security=True");

        public bool addFlight(int fn, string origin, string destination, int maxSeats)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"INSERT into Flight(flightNumber, origin, destination, maxSeats) values ('{fn}','{origin}','{destination}',{maxSeats})";
                cmd.ExecuteNonQuery();
                conn.Close();

                //check if flight has been added
                if (flightExists(fn)) return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool flightExists(int fid)
        {
            try {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from Flight where flightNumber = {fid}";
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

        public bool flightHasSeats(int fid)
        {
            if (flightExists(fid))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"select * from Flight where flightNumber = {fid} and maxSeats - numPassenger > 0";
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
            return false;
            
        }

        public Flight getFlight(int fid)
        {
            if (flightExists(fid))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"select * from Flight where flightNumber = {fid}";
                    cmd.ExecuteNonQuery();

                    DataTable dTable = new DataTable();
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    dAdapter.Fill(dTable);

                    conn.Close();

                    int flightNumber = Convert.ToInt32(dTable.Rows[0]["flightNumber"].ToString());
                    string origin = dTable.Rows[0]["origin"].ToString();
                    string destination = dTable.Rows[0]["origin"].ToString();
                    int maxSeats = Convert.ToInt32(dTable.Rows[0]["maxSeats"].ToString());
                    int numPassengers = Convert.ToInt32(dTable.Rows[0]["numPassenger"].ToString());

                    Flight f = new Flight(flightNumber, origin, destination, maxSeats, numPassengers);
                    return f;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            return null;
        }

        public bool deleteFlight(int fid)
        {
            if (flightExists(fid))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"delete from Flight where flightNumber = {fid} and numPassenger = 0";
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //check if flight has been successfully deleted
                    if (flightExists(fid))
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
            return false;
        }

        public DataSet getFlightList()
        {
            try {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Flight";
                cmd.ExecuteNonQuery();

                DataSet ds = new DataSet();
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                dAdapter.Fill(ds, "Flight");
                conn.Close();
                return ds;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
