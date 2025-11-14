namespace RoomReservation_Guillen_IT13
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblHeader;
        private Panel panelForm;
        private Label lblGuestName, lblRoomNumber, lblCheckIn, lblCheckOut;
        private TextBox txtGuestName, txtRoomNumber;
        private DateTimePicker dtpCheckIn, dtpCheckOut;
        private Button btnAdd, btnUpdate, btnDelete, btnClear;
        private DataGridView dgvReservations;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblHeader = new Label();
            panelForm = new Panel();
            lblGuestName = new Label();
            lblRoomNumber = new Label();
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            txtGuestName = new TextBox();
            txtRoomNumber = new TextBox();
            dtpCheckIn = new DateTimePicker();
            dtpCheckOut = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvReservations = new DataGridView();

            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();

            // ================= HEADER =================
            panelHeader.BackColor = Color.MediumSlateBlue;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 100;
            panelHeader.Controls.Add(lblHeader);

            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Text = "ROOM RESERVATION SYSTEM";
            lblHeader.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;

            // ================= FORM PANEL =================
            panelForm.Dock = DockStyle.Top;
            panelForm.Height = 200;
            panelForm.BackColor = Color.WhiteSmoke;
            panelForm.Padding = new Padding(20);
            panelForm.Controls.AddRange(new Control[]
            {
                lblGuestName, txtGuestName,
                lblRoomNumber, txtRoomNumber,
                lblCheckIn, dtpCheckIn,
                lblCheckOut, dtpCheckOut,
                btnAdd, btnUpdate, btnDelete, btnClear
            });

            // Labels
            lblGuestName.Text = "Guest Name:";
            lblGuestName.Location = new Point(20, 20);
            lblGuestName.AutoSize = true;

            lblRoomNumber.Text = "Room Number:";
            lblRoomNumber.Location = new Point(20, 60);
            lblRoomNumber.AutoSize = true;

            lblCheckIn.Text = "Check-in Date:";
            lblCheckIn.Location = new Point(20, 100);
            lblCheckIn.AutoSize = true;

            lblCheckOut.Text = "Check-out Date:";
            lblCheckOut.Location = new Point(20, 140);
            lblCheckOut.AutoSize = true;

            // TextBoxes
            txtGuestName.Location = new Point(150, 20);
            txtGuestName.Size = new Size(250, 27);
            txtGuestName.Font = new Font("Segoe UI", 10F);

            txtRoomNumber.Location = new Point(150, 60);
            txtRoomNumber.Size = new Size(250, 27);
            txtRoomNumber.Font = new Font("Segoe UI", 10F);

            // DateTimePickers
            dtpCheckIn.Location = new Point(150, 100);
            dtpCheckIn.Format = DateTimePickerFormat.Short;
            dtpCheckIn.Font = new Font("Segoe UI", 10F);

            dtpCheckOut.Location = new Point(150, 140);
            dtpCheckOut.Format = DateTimePickerFormat.Short;
            dtpCheckOut.Font = new Font("Segoe UI", 10F);

            // Buttons
            btnAdd.Text = "Add";
            btnAdd.BackColor = Color.MediumSlateBlue;
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Size = new Size(130, 45);
            btnAdd.Location = new Point(450, 20);
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Click += btnAdd_Click;

            btnUpdate.Text = "Update";
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Size = new Size(130, 45);
            btnUpdate.Location = new Point(450, 75);
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Text = "Delete";
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Size = new Size(130, 45);
            btnDelete.Location = new Point(600, 20);
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Click += btnDelete_Click;

            btnClear.Text = "Clear";
            btnClear.BackColor = Color.Gray;
            btnClear.ForeColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Size = new Size(130, 45);
            btnClear.Location = new Point(600, 75);
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.Cursor = Cursors.Hand;
            btnClear.Click += btnClear_Click;

            // ================= DATA GRID =================
            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.ReadOnly = true;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.MultiSelect = false;
            dgvReservations.CellClick += dgvReservations_CellClick;
            dgvReservations.BackgroundColor = Color.White;
            dgvReservations.EnableHeadersVisualStyles = false;
            dgvReservations.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSlateBlue;
            dgvReservations.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReservations.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvReservations.RowHeadersVisible = false;
            dgvReservations.GridColor = Color.LightGray;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.Font = new Font("Segoe UI", 10F);

            // ================= FORM =================
            BackColor = Color.White;
            ClientSize = new Size(820, 650);
            Controls.Add(dgvReservations);  // Fill remaining space
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Text = "Room Reservation System";

            panelHeader.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
        }
    }
}
