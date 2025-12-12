using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace HorizonBookingSystem
{
    public partial class AdminUsersView : Form
    {
        private Users AdminLoggedIn;
        private BookingDBEntities db = new BookingDBEntities();

        public AdminUsersView(Users admin)
        {
            InitializeComponent();
            AdminLoggedIn = admin;
        }

        private void AdminUsersView_Load(object sender, EventArgs e)
        {
            LoadUsers();
            PopulateRoleFilter();
        }

        private void LoadUsers()
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("User ID", typeof(int));
                dataTable.Columns.Add("Username", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));
                dataTable.Columns.Add("Role", typeof(string));

                var users = db.Users.ToList();

                foreach (var user in users)
                {
                    dataTable.Rows.Add(user.userID, user.username, user.email, user.Roles.roleName);
                }

                dgvUsers.DataSource = dataTable;

                // Format the DataGridView
                if (dgvUsers.Columns.Count > 0)
                {
                    // Set column widths
                    dgvUsers.Columns["User ID"].Width = 80;
                    dgvUsers.Columns["Username"].Width = 150;
                    dgvUsers.Columns["Email"].Width = 200;
                    dgvUsers.Columns["Role"].Width = 100;

                    // Format headers
                    dgvUsers.EnableHeadersVisualStyles = false;
                    dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
                    dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    dgvUsers.ColumnHeadersHeight = 40;

                    // Format rows
                    dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                    dgvUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
                    dgvUsers.DefaultCellStyle.SelectionForeColor = Color.White;
                    dgvUsers.RowTemplate.Height = 35;
                }

                lblTotalUsers.Text = $"Total Users: {users.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateRoleFilter()
        {
            var roles = db.Roles.ToList();

            cmBoxRoleFilter.Items.Clear();
            cmBoxRoleFilter.Items.Add("All Users");
            
            foreach (var role in roles)
            {
                cmBoxRoleFilter.Items.Add(role.roleName);
            }
            
            cmBoxRoleFilter.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmBoxRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("User ID", typeof(int));
                dataTable.Columns.Add("Username", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));
                dataTable.Columns.Add("Role", typeof(string));

                string searchText = txtSearchUsername.Text.Trim().ToLower();
                string roleFilter = cmBoxRoleFilter.SelectedItem?.ToString();

                var users = db.Users.ToList();

                // Apply role filter
                if (!string.IsNullOrEmpty(roleFilter) && roleFilter != "All Users")
                {
                    users = users.Where(u => u.Roles.roleName == roleFilter).ToList();
                }

                // Apply search filter
                if (!string.IsNullOrEmpty(searchText))
                {
                    users = users.Where(u => u.username.ToLower().Contains(searchText) || 
                                            u.email.ToLower().Contains(searchText)).ToList();
                }

                foreach (var user in users)
                {
                    dataTable.Rows.Add(user.userID, user.username, user.email, user.Roles.roleName);
                }

                dgvUsers.DataSource = dataTable;
                lblTotalUsers.Text = $"Total Users: {users.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchUsername.Clear();
            cmBoxRoleFilter.SelectedIndex = 0;
            LoadUsers();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ViewUserDetails();
            }
        }

        private void ViewUserDetails()
        {
            if (dgvUsers.CurrentRow != null)
            {
                var userId = dgvUsers.CurrentRow.Cells["User ID"].Value.ToString();
                var username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();
                var email = dgvUsers.CurrentRow.Cells["Email"].Value.ToString();
                var role = dgvUsers.CurrentRow.Cells["Role"].Value.ToString();

                string details = $"User ID: {userId}\n" +
                               $"Username: {username}\n" +
                               $"Email: {email}\n" +
                               $"Role: {role}";

                MessageBox.Show(details, "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchUsername_TextChanged(object sender, EventArgs e)
        {

        }

        // CREATE - Add new user
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new UserFormDialog();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Check if username already exists
                    var existingUser = db.Users.FirstOrDefault(u => u.username == addForm.Username);
                    if (existingUser != null)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var newUser = new Users
                    {
                        username = addForm.Username,
                        password = addForm.Password,
                        email = addForm.Email,
                        roleID = addForm.RoleID
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // UPDATE - Edit existing user
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["User ID"].Value);
            var user = db.Users.FirstOrDefault(u => u.userID == userId);

            if (user == null)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var editForm = new UserFormDialog(user);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Check if new username already exists (excluding current user)
                    var existingUser = db.Users.FirstOrDefault(u => u.username == editForm.Username && u.userID != userId);
                    if (existingUser != null)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    user.username = editForm.Username;
                    user.password = editForm.Password;
                    user.email = editForm.Email;
                    user.roleID = editForm.RoleID;

                    db.SaveChanges();

                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // DELETE - Remove user
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["User ID"].Value);

            // Prevent deleting currently logged in admin
            if (userId == AdminLoggedIn.userID)
            {
                MessageBox.Show("You cannot delete your own account while logged in!", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = db.Users.FirstOrDefault(u => u.userID == userId);

            if (user == null)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete this user?\n\nUser ID: {user.userID}\nUsername: {user.username}\nEmail: {user.email}\n\nThis will also delete all related bookings!",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Delete related bookings first
                    var bookingSeats = db.BookingSeats.Where(bs => bs.Bookings.UserID == userId).ToList();
                    foreach (var bs in bookingSeats)
                    {
                        db.BookingSeats.Remove(bs);
                    }

                    var bookings = db.Bookings.Where(b => b.UserID == userId).ToList();
                    foreach (var booking in bookings)
                    {
                        // Release seats
                        var seats = db.Seats.Where(s => s.BookingID == booking.BookingID).ToList();
                        foreach (var seat in seats)
                        {
                            seat.IsBooked = false;
                            seat.BookingID = null;
                        }
                        db.Bookings.Remove(booking);
                    }

                    db.Users.Remove(user);
                    db.SaveChanges();

                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
