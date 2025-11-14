using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RoomReservation_Guillen_IT13
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=DB_RoomReservation_Guillen_IT13;Integrated Security=True;";
        int selectedReservationID = 0;

        public Form1()
        {
            InitializeComponent();
            LoadReservations();
        }

        private void LoadReservations()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM RoomReservation", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReservations.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO RoomReservation (GuestName, RoomNumber, CheckInDate, CheckOutDate) " +
                               "VALUES (@GuestName, @RoomNumber, @CheckInDate, @CheckOutDate)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@GuestName", txtGuestName.Text);
                    cmd.Parameters.AddWithValue("@RoomNumber", txtRoomNumber.Text);
                    cmd.Parameters.AddWithValue("@CheckInDate", dtpCheckIn.Value.Date);
                    cmd.Parameters.AddWithValue("@CheckOutDate", dtpCheckOut.Value.Date);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            LoadReservations();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedReservationID == 0) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE RoomReservation SET GuestName=@GuestName, RoomNumber=@RoomNumber, " +
                               "CheckInDate=@CheckInDate, CheckOutDate=@CheckOutDate WHERE ReservationID=@ReservationID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@GuestName", txtGuestName.Text);
                    cmd.Parameters.AddWithValue("@RoomNumber", txtRoomNumber.Text);
                    cmd.Parameters.AddWithValue("@CheckInDate", dtpCheckIn.Value.Date);
                    cmd.Parameters.AddWithValue("@CheckOutDate", dtpCheckOut.Value.Date);
                    cmd.Parameters.AddWithValue("@ReservationID", selectedReservationID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            LoadReservations();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedReservationID == 0) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM RoomReservation WHERE ReservationID=@ReservationID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", selectedReservationID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            LoadReservations();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtGuestName.Text = "";
            txtRoomNumber.Text = "";
            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today;
            selectedReservationID = 0;
        }

        private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReservations.Rows[e.RowIndex];
                selectedReservationID = Convert.ToInt32(row.Cells["ReservationID"].Value);
                txtGuestName.Text = row.Cells["GuestName"].Value.ToString();
                txtRoomNumber.Text = row.Cells["RoomNumber"].Value.ToString();
                dtpCheckIn.Value = Convert.ToDateTime(row.Cells["CheckInDate"].Value);
                dtpCheckOut.Value = Convert.ToDateTime(row.Cells["CheckOutDate"].Value);
            }
        }
    }
}
