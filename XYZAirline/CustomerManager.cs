using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace XYZAirline
{
    class CustomerManager
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\XYZArline.mdf;Integrated Security=True");

        public bool addCustomer(string fname, string lname, string ph)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"INSERT into Customer(firstName, lastName, phone) values ('{fname}','{lname}','{ph}')";
                cmd.ExecuteNonQuery();
                conn.Close();

                //check if customer has been added
                if (customerExists(fname, lname, ph)) return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        
        public bool findCustomer(int cid)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from Customer where customerId = {cid}";
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


        public bool customerExists(string fname, string lname, string ph)
        {
            try 
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from Customer where firstName = '{fname}' and lastName = '{lname}' and phone = '{ph}'";
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

        public Customer getCustomer(int cid)
        {
            if (findCustomer(cid))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"select * from Customer where customerId = {cid}";
                    cmd.ExecuteNonQuery();

                    DataTable dTable = new DataTable();
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    dAdapter.Fill(dTable);

                    conn.Close();

                    string fn = dTable.Rows[0]["firstName"].ToString();
                    string ln = dTable.Rows[0]["lastName"].ToString();
                    string ph = dTable.Rows[0]["phone"].ToString();
                    int numBookings = Convert.ToInt32(dTable.Rows[0]["numBookings"].ToString());

                    Customer c = new Customer(cid, fn, ln, ph, numBookings);
                    return c;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            return null;
        }

        public bool deleteCustomer(int cid)
        {
            if (findCustomer(cid))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"delete from Customer where customerId = {cid} and numBookings = 0";
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    // check if customer has been successfully deleted
                    if (findCustomer(cid))
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

        public DataSet getCustomerList()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Customer";
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
