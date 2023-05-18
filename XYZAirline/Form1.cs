using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace XYZAirline
{
    public partial class Form1 : Form
    {
        static AirlineCoordinator aCoord;
        public static int flightNumber;
        public static int customerId;
        public static int bookingCus;
        public static int bookingFlight;
        public Form1()
        {
            aCoord = new AirlineCoordinator();
            InitializeComponent();
            getFlightList();
            getCustomerList();
            getBookingList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabBookings;

        }

        //Clear fields
        private void clearFlightField()
        {
            txtFlightNumber.Text = txtOrigin.Text = txtDestination.Text = "";
            numMaxSeats.Value = 0;
        }
        private void clearCustomerField()
        {
            txtCusFirstName.Text = txtCusLastName.Text = txtCusPhone.Text = "";
        }

        private void clearBookingField()
        {
            txtCusID.Text = txtFID.Text = "";
        }

        // Retrieve flight, customer and booking list
        private void getFlightList()
        {
            dGridFlights.DataSource = aCoord.flightList();
            dGridFlights.DataMember = "Flight";
            dGridBookingFlight.DataSource = aCoord.flightList();
            dGridBookingFlight.DataMember = "Flight";
        }
        private void getCustomerList()
        {
            dGridCustomers.DataSource = aCoord.customerList();
            dGridCustomers.DataMember = "Customer";
            dGridBookingCus.DataSource = aCoord.customerList();
            dGridBookingCus.DataMember = "Customer";
        }
        private void getBookingList()
        {
            dGridBookings.DataSource = aCoord.bookingList();
            dGridBookings.DataMember = "Booking";
        }

        //handle tab selection change
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                getFlightList();
                lblErrFlight.Text = lblDelete.Text = "";
            } 
            else if (tabControl1.SelectedIndex == 1)
            {
                getCustomerList();
                lblCustomer.Text = lblDeleteCus.Text = "";
            } 
            else if (tabControl1.SelectedIndex == 2)
            {
                getFlightList();
                getCustomerList();
                getBookingList();
            }
        }

        // ************************* Flight functions *************************
        private void btnCreateFlight_Click(object sender, EventArgs e)
        {
            int fid;
            if (txtFlightNumber.Text == "" || txtOrigin.Text == "" || txtDestination.Text == "" || numMaxSeats.Value == 0)
            {
                lblErrFlight.Text = "Please enter all the fields";
            } else if (Int32.TryParse(txtFlightNumber.Text, out fid))
            {
                //if flight exist
                if (aCoord.flightExist(fid))
                {
                    lblErrFlight.Text = $"Flight Number {fid} already exists";
                } else
                {
                    //add new flight
                    int maxSeats = Convert.ToInt32(numMaxSeats.Value);
                    aCoord.addFlight(fid, txtOrigin.Text, txtDestination.Text, maxSeats);
                    lblErrFlight.Text = $"Flight Number {fid} has been successfully added";
                    clearFlightField();
                    getFlightList();
                }  
            } else
            {
                lblErrFlight.Text = "Please enter a number for Flight Number";
            }
        }

        private void dGridFlights_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridFlights.CurrentCell != null && dGridFlights.CurrentCell.Value != null && e.RowIndex != -1)
            {
                String temp = dGridFlights.Rows[e.RowIndex].Cells["flightNumber"].Value.ToString();
                if (temp == "")
                {
                    flightNumber = -1;
                }
                else
                {
                    flightNumber = Convert.ToInt32(temp);
                    dGridFlightPassenger.DataSource = aCoord.flightPassengerList(flightNumber);
                    dGridFlightPassenger.DataMember = "Customer";
                    lblFlightPassengerTitle.Text = "Passengers on Flight #" + flightNumber;
                }
            }            
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (flightNumber == -1)
            {
                lblDelete.Text = "Please select a flight from the list for deletion";
            } else
            {
                DialogResult d = MessageBox.Show($"Do you want to delete flight #{flightNumber}", "Delete Flight", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    if (aCoord.deleteFlight(flightNumber))
                    {
                        lblDelete.Text = $"Flight Number {flightNumber} has been successfully delete.";
                        getFlightList();
                    }
                    else
                    {
                        lblDelete.Text = $"Cannot delete Flight Number {flightNumber}";
                    }
                }
                
            }
            
        }

        // ************************* Customer functions *************************
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            if (txtCusFirstName.Text == "" || txtCusLastName.Text == "" || txtCusPhone.Text == "") {
                lblCustomer.Text = "Please enter all the fields";
            } 
            else 
            {
                if (aCoord.customerExist(txtCusFirstName.Text, txtCusLastName.Text, txtCusPhone.Text))
                {
                    lblCustomer.Text = "The customer is already existed";
                }
                else
                {
                    if (aCoord.addCustomer(txtCusFirstName.Text, txtCusLastName.Text, txtCusPhone.Text))
                    {
                        lblCustomer.Text = "The customer has been successfully added";
                        clearCustomerField();
                        getCustomerList();
                    }
                    else
                    {
                        lblCustomer.Text = "Cannot add customer";
                    }
                }
            }
            
        }

        private void dGridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridCustomers.CurrentCell != null && dGridCustomers.CurrentCell.Value != null &&  e.RowIndex != -1)
            {
                String temp = dGridCustomers.Rows[e.RowIndex].Cells["customerId"].Value.ToString();
                if (temp == "")
                {
                    customerId = -1;
                }
                else
                {
                    customerId = Convert.ToInt32(temp);
                }
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (customerId == -1)
            {
                lblDeleteCus.Text = "Please select a customer from the list for deletion";
            }
            else
            {
                DialogResult d = MessageBox.Show($"Do you want to delete customer #{customerId}", "Delete Customer", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    if (aCoord.deleteCustomer(customerId))
                    {
                        lblDeleteCus.Text = $"Customer #{customerId} has been successfully delete.";
                        getCustomerList();
                    }
                    else
                    {
                        lblDeleteCus.Text = $"Cannot delete Customer #{customerId}";
                    }
                }
                
            }
        }

        // ************************* Booking functions *************************
        private void dGridBookingFlight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridBookingFlight.CurrentCell != null && dGridBookingFlight.CurrentCell.Value != null && e.RowIndex != -1)
            {
                String temp = dGridBookingFlight.Rows[e.RowIndex].Cells["flightNumber"].Value.ToString();
                if (temp == "")
                {
                    bookingFlight = -1;
                }
                else
                {
                    bookingFlight = Convert.ToInt32(temp);
                    txtFID.Text = bookingFlight.ToString();
                }
            }
        }

        private void dGridBookingCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridBookingCus.CurrentCell != null && dGridBookingCus.CurrentCell.Value != null && e.RowIndex != -1)
            {
                String temp = dGridBookingCus.Rows[e.RowIndex].Cells["customerId"].Value.ToString();
                if (temp == "")
                {
                    bookingCus = -1;
                }
                else
                {
                    bookingCus = Convert.ToInt32(temp);
                    txtCusID.Text = bookingCus.ToString();
                }
            }
        }
        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            int fid, cid;

            if (txtCusID.Text == "" || txtFID.Text == "")
            {
                lblErrBooking.Text = "Please enter all the fields";
            }
            else if (Int32.TryParse(txtCusID.Text, out cid) && Int32.TryParse(txtFID.Text, out fid))
            {
                //lblErrBooking.Text = cid.ToString();
                if (aCoord.bookingExist(cid, fid))
                {
                    lblErrBooking.Text = "The booking is already existed";
                }
                else
                {
                    if (aCoord.flightHasSeats(fid))
                    {
                        if (aCoord.addBooking(cid, fid))
                        {
                            lblErrBooking.Text = "The booking has been successfully added";
                            clearBookingField();
                            getCustomerList();
                            getFlightList();
                            getBookingList();
                        }
                        else
                        {
                            lblErrBooking.Text = "Cannot add booking";
                        }

                    } else
                    {
                        lblErrBooking.Text = "This flight is full. Please select another flight.";
                    }
                    
                    
                    
                }
            } else
            {
                lblErrBooking.Text = "Please enter a number for Customer ID and Flight Number";
            }

        }


        private void tabFlights_Click(object sender, EventArgs e)
        {

        }
        private void tabCustomers_Click(object sender, EventArgs e)
        {

        }
        private void tabBookings_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void dGridFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void gBoxCustomer_Enter(object sender, EventArgs e)
        { }

        private void dGridBookingFlight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
