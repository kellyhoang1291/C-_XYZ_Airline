
namespace XYZAirline
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFlights = new System.Windows.Forms.TabPage();
            this.lblFlightPassengerTitle = new System.Windows.Forms.Label();
            this.dGridFlightPassenger = new System.Windows.Forms.DataGridView();
            this.lblDelete = new System.Windows.Forms.Label();
            this.gBoxFlight = new System.Windows.Forms.GroupBox();
            this.lblErrFlight = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numMaxSeats = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateFlight = new System.Windows.Forms.Button();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.dGridFlights = new System.Windows.Forms.DataGridView();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.lblDeleteCus = new System.Windows.Forms.Label();
            this.gBoxCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCusLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCusFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.dGridCustomers = new System.Windows.Forms.DataGridView();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.dGridBookingCus = new System.Windows.Forms.DataGridView();
            this.dGridBookingFlight = new System.Windows.Forms.DataGridView();
            this.gBoxBooking = new System.Windows.Forms.GroupBox();
            this.lblErrBooking = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFID = new System.Windows.Forms.TextBox();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.dGridBookings = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridFlightPassenger)).BeginInit();
            this.gBoxFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridFlights)).BeginInit();
            this.tabCustomers.SuspendLayout();
            this.gBoxCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridCustomers)).BeginInit();
            this.tabBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridBookingCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridBookingFlight)).BeginInit();
            this.gBoxBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFlights);
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Controls.Add(this.tabBookings);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1103, 445);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabFlights
            // 
            this.tabFlights.Controls.Add(this.lblFlightPassengerTitle);
            this.tabFlights.Controls.Add(this.dGridFlightPassenger);
            this.tabFlights.Controls.Add(this.lblDelete);
            this.tabFlights.Controls.Add(this.gBoxFlight);
            this.tabFlights.Controls.Add(this.btnDeleteFlight);
            this.tabFlights.Controls.Add(this.dGridFlights);
            this.tabFlights.Location = new System.Drawing.Point(4, 29);
            this.tabFlights.Name = "tabFlights";
            this.tabFlights.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlights.Size = new System.Drawing.Size(1095, 412);
            this.tabFlights.TabIndex = 0;
            this.tabFlights.Text = "Flights";
            this.tabFlights.UseVisualStyleBackColor = true;
            this.tabFlights.Click += new System.EventHandler(this.tabFlights_Click);
            // 
            // lblFlightPassengerTitle
            // 
            this.lblFlightPassengerTitle.AutoSize = true;
            this.lblFlightPassengerTitle.Location = new System.Drawing.Point(13, 264);
            this.lblFlightPassengerTitle.Name = "lblFlightPassengerTitle";
            this.lblFlightPassengerTitle.Size = new System.Drawing.Size(381, 20);
            this.lblFlightPassengerTitle.TabIndex = 35;
            this.lblFlightPassengerTitle.Text = "Passengers on Flight (Select a Flight from Flight List)";
            // 
            // dGridFlightPassenger
            // 
            this.dGridFlightPassenger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGridFlightPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridFlightPassenger.Location = new System.Drawing.Point(16, 285);
            this.dGridFlightPassenger.Name = "dGridFlightPassenger";
            this.dGridFlightPassenger.Size = new System.Drawing.Size(618, 109);
            this.dGridFlightPassenger.TabIndex = 34;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.Red;
            this.lblDelete.Location = new System.Drawing.Point(651, 84);
            this.lblDelete.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(0, 16);
            this.lblDelete.TabIndex = 33;
            // 
            // gBoxFlight
            // 
            this.gBoxFlight.Controls.Add(this.lblErrFlight);
            this.gBoxFlight.Controls.Add(this.label12);
            this.gBoxFlight.Controls.Add(this.numMaxSeats);
            this.gBoxFlight.Controls.Add(this.label4);
            this.gBoxFlight.Controls.Add(this.txtDestination);
            this.gBoxFlight.Controls.Add(this.label3);
            this.gBoxFlight.Controls.Add(this.txtOrigin);
            this.gBoxFlight.Controls.Add(this.label2);
            this.gBoxFlight.Controls.Add(this.txtFlightNumber);
            this.gBoxFlight.Controls.Add(this.label1);
            this.gBoxFlight.Controls.Add(this.btnCreateFlight);
            this.gBoxFlight.Location = new System.Drawing.Point(763, 18);
            this.gBoxFlight.Name = "gBoxFlight";
            this.gBoxFlight.Size = new System.Drawing.Size(316, 376);
            this.gBoxFlight.TabIndex = 14;
            this.gBoxFlight.TabStop = false;
            this.gBoxFlight.Text = "Create New Flight";
            // 
            // lblErrFlight
            // 
            this.lblErrFlight.AutoSize = true;
            this.lblErrFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrFlight.ForeColor = System.Drawing.Color.Red;
            this.lblErrFlight.Location = new System.Drawing.Point(30, 259);
            this.lblErrFlight.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblErrFlight.Name = "lblErrFlight";
            this.lblErrFlight.Size = new System.Drawing.Size(0, 16);
            this.lblErrFlight.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 40);
            this.label12.MaximumSize = new System.Drawing.Size(300, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(282, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Please enter flight information below";
            // 
            // numMaxSeats
            // 
            this.numMaxSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxSeats.Location = new System.Drawing.Point(136, 205);
            this.numMaxSeats.Name = "numMaxSeats";
            this.numMaxSeats.Size = new System.Drawing.Size(154, 22);
            this.numMaxSeats.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Max Seats";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(136, 162);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(154, 26);
            this.txtDestination.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Destination";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(136, 120);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(154, 26);
            this.txtOrigin.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Origin";
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(136, 76);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(154, 26);
            this.txtFlightNumber.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Flight Number";
            // 
            // btnCreateFlight
            // 
            this.btnCreateFlight.Location = new System.Drawing.Point(30, 299);
            this.btnCreateFlight.Name = "btnCreateFlight";
            this.btnCreateFlight.Size = new System.Drawing.Size(260, 49);
            this.btnCreateFlight.TabIndex = 13;
            this.btnCreateFlight.Text = "Create Flight";
            this.btnCreateFlight.UseVisualStyleBackColor = true;
            this.btnCreateFlight.Click += new System.EventHandler(this.btnCreateFlight_Click);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.Location = new System.Drawing.Point(649, 18);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(95, 49);
            this.btnDeleteFlight.TabIndex = 12;
            this.btnDeleteFlight.Text = "Delete";
            this.btnDeleteFlight.UseVisualStyleBackColor = true;
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // dGridFlights
            // 
            this.dGridFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGridFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridFlights.Location = new System.Drawing.Point(15, 18);
            this.dGridFlights.Name = "dGridFlights";
            this.dGridFlights.Size = new System.Drawing.Size(619, 237);
            this.dGridFlights.TabIndex = 9;
            this.dGridFlights.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridFlights_CellClick);
            this.dGridFlights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridFlights_CellContentClick);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.lblDeleteCus);
            this.tabCustomers.Controls.Add(this.gBoxCustomer);
            this.tabCustomers.Controls.Add(this.btnDeleteCustomer);
            this.tabCustomers.Controls.Add(this.dGridCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 29);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(1095, 412);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            this.tabCustomers.Click += new System.EventHandler(this.tabCustomers_Click);
            // 
            // lblDeleteCus
            // 
            this.lblDeleteCus.AutoSize = true;
            this.lblDeleteCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCus.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteCus.Location = new System.Drawing.Point(653, 86);
            this.lblDeleteCus.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblDeleteCus.Name = "lblDeleteCus";
            this.lblDeleteCus.Size = new System.Drawing.Size(0, 16);
            this.lblDeleteCus.TabIndex = 34;
            // 
            // gBoxCustomer
            // 
            this.gBoxCustomer.Controls.Add(this.lblCustomer);
            this.gBoxCustomer.Controls.Add(this.label11);
            this.gBoxCustomer.Controls.Add(this.txtCusPhone);
            this.gBoxCustomer.Controls.Add(this.label6);
            this.gBoxCustomer.Controls.Add(this.txtCusLastName);
            this.gBoxCustomer.Controls.Add(this.label7);
            this.gBoxCustomer.Controls.Add(this.txtCusFirstName);
            this.gBoxCustomer.Controls.Add(this.label8);
            this.gBoxCustomer.Controls.Add(this.btnCreateCustomer);
            this.gBoxCustomer.Location = new System.Drawing.Point(765, 18);
            this.gBoxCustomer.Name = "gBoxCustomer";
            this.gBoxCustomer.Size = new System.Drawing.Size(316, 376);
            this.gBoxCustomer.TabIndex = 18;
            this.gBoxCustomer.TabStop = false;
            this.gBoxCustomer.Text = "Create New Customer";
            this.gBoxCustomer.Enter += new System.EventHandler(this.gBoxCustomer_Enter);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Red;
            this.lblCustomer.Location = new System.Drawing.Point(32, 228);
            this.lblCustomer.MaximumSize = new System.Drawing.Size(290, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(0, 16);
            this.lblCustomer.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 34);
            this.label11.MaximumSize = new System.Drawing.Size(300, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 36);
            this.label11.TabIndex = 30;
            this.label11.Text = "Please enter customer information  below";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(136, 181);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(154, 26);
            this.txtCusPhone.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Phone";
            // 
            // txtCusLastName
            // 
            this.txtCusLastName.Location = new System.Drawing.Point(136, 136);
            this.txtCusLastName.Name = "txtCusLastName";
            this.txtCusLastName.Size = new System.Drawing.Size(154, 26);
            this.txtCusLastName.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Last Name";
            // 
            // txtCusFirstName
            // 
            this.txtCusFirstName.Location = new System.Drawing.Point(136, 92);
            this.txtCusFirstName.Name = "txtCusFirstName";
            this.txtCusFirstName.Size = new System.Drawing.Size(154, 26);
            this.txtCusFirstName.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "First Name";
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(30, 299);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(260, 49);
            this.btnCreateCustomer.TabIndex = 13;
            this.btnCreateCustomer.Text = "Create Customer";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(649, 18);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(95, 49);
            this.btnDeleteCustomer.TabIndex = 17;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // dGridCustomers
            // 
            this.dGridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridCustomers.Location = new System.Drawing.Point(12, 18);
            this.dGridCustomers.Name = "dGridCustomers";
            this.dGridCustomers.Size = new System.Drawing.Size(619, 376);
            this.dGridCustomers.TabIndex = 15;
            this.dGridCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridCustomers_CellClick);
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.dGridBookingCus);
            this.tabBookings.Controls.Add(this.dGridBookingFlight);
            this.tabBookings.Controls.Add(this.gBoxBooking);
            this.tabBookings.Controls.Add(this.dGridBookings);
            this.tabBookings.Location = new System.Drawing.Point(4, 29);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Size = new System.Drawing.Size(1095, 412);
            this.tabBookings.TabIndex = 2;
            this.tabBookings.Text = "Bookings";
            this.tabBookings.UseVisualStyleBackColor = true;
            this.tabBookings.Click += new System.EventHandler(this.tabBookings_Click);
            // 
            // dGridBookingCus
            // 
            this.dGridBookingCus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGridBookingCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridBookingCus.Location = new System.Drawing.Point(12, 270);
            this.dGridBookingCus.Name = "dGridBookingCus";
            this.dGridBookingCus.Size = new System.Drawing.Size(726, 109);
            this.dGridBookingCus.TabIndex = 24;
            this.dGridBookingCus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridBookingCus_CellClick);
            // 
            // dGridBookingFlight
            // 
            this.dGridBookingFlight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGridBookingFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridBookingFlight.Location = new System.Drawing.Point(12, 146);
            this.dGridBookingFlight.Name = "dGridBookingFlight";
            this.dGridBookingFlight.Size = new System.Drawing.Size(726, 109);
            this.dGridBookingFlight.TabIndex = 23;
            this.dGridBookingFlight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridBookingFlight_CellClick);
            this.dGridBookingFlight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridBookingFlight_CellContentClick);
            // 
            // gBoxBooking
            // 
            this.gBoxBooking.Controls.Add(this.lblErrBooking);
            this.gBoxBooking.Controls.Add(this.label10);
            this.gBoxBooking.Controls.Add(this.txtFID);
            this.gBoxBooking.Controls.Add(this.txtCusID);
            this.gBoxBooking.Controls.Add(this.label5);
            this.gBoxBooking.Controls.Add(this.label9);
            this.gBoxBooking.Controls.Add(this.btnCreateBooking);
            this.gBoxBooking.Location = new System.Drawing.Point(765, 18);
            this.gBoxBooking.Name = "gBoxBooking";
            this.gBoxBooking.Size = new System.Drawing.Size(316, 361);
            this.gBoxBooking.TabIndex = 22;
            this.gBoxBooking.TabStop = false;
            this.gBoxBooking.Text = "Create New Booking";
            // 
            // lblErrBooking
            // 
            this.lblErrBooking.AutoSize = true;
            this.lblErrBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBooking.ForeColor = System.Drawing.Color.Red;
            this.lblErrBooking.Location = new System.Drawing.Point(28, 221);
            this.lblErrBooking.MaximumSize = new System.Drawing.Size(290, 0);
            this.lblErrBooking.Name = "lblErrBooking";
            this.lblErrBooking.Size = new System.Drawing.Size(0, 16);
            this.lblErrBooking.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 35);
            this.label10.MaximumSize = new System.Drawing.Size(300, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(294, 54);
            this.label10.TabIndex = 29;
            this.label10.Text = "Please select or enter the Customer ID and Flight ID from the Customer and Flight" +
    " list to create a new booking";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtFID
            // 
            this.txtFID.Location = new System.Drawing.Point(140, 117);
            this.txtFID.Name = "txtFID";
            this.txtFID.Size = new System.Drawing.Size(150, 26);
            this.txtFID.TabIndex = 28;
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(140, 161);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(150, 26);
            this.txtCusID.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Flight Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Customer ID";
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(30, 299);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(260, 49);
            this.btnCreateBooking.TabIndex = 13;
            this.btnCreateBooking.Text = "Create Booking";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // dGridBookings
            // 
            this.dGridBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGridBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridBookings.Location = new System.Drawing.Point(12, 18);
            this.dGridBookings.Name = "dGridBookings";
            this.dGridBookings.Size = new System.Drawing.Size(726, 109);
            this.dGridBookings.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "XYZ Airline Booking Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFlights.ResumeLayout(false);
            this.tabFlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridFlightPassenger)).EndInit();
            this.gBoxFlight.ResumeLayout(false);
            this.gBoxFlight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridFlights)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            this.gBoxCustomer.ResumeLayout(false);
            this.gBoxCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridCustomers)).EndInit();
            this.tabBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridBookingCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridBookingFlight)).EndInit();
            this.gBoxBooking.ResumeLayout(false);
            this.gBoxBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFlights;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.Button btnDeleteFlight;
        private System.Windows.Forms.DataGridView dGridFlights;
        private System.Windows.Forms.GroupBox gBoxFlight;
        private System.Windows.Forms.NumericUpDown numMaxSeats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateFlight;
        private System.Windows.Forms.GroupBox gBoxCustomer;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCusLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCusFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.DataGridView dGridCustomers;
        private System.Windows.Forms.DataGridView dGridBookingCus;
        private System.Windows.Forms.DataGridView dGridBookingFlight;
        private System.Windows.Forms.GroupBox gBoxBooking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.DataGridView dGridBookings;
        private System.Windows.Forms.TextBox txtFID;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblErrFlight;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblDeleteCus;
        private System.Windows.Forms.Label lblErrBooking;
        private System.Windows.Forms.Label lblFlightPassengerTitle;
        private System.Windows.Forms.DataGridView dGridFlightPassenger;
    }
}

