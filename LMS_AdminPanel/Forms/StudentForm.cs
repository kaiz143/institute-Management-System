using LMS_AdminPanel.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS_AdminPanel.Forms
{
    public partial class StudentForm : Form
    {

        public StudentForm()
        {
            InitializeComponent();
        }

        private void LoadStudents()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetStudents", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FullName", textBox1.Text);
                cmd.Parameters.AddWithValue("@FatherName", textBox2.Text);
                cmd.Parameters.AddWithValue("@Contact", textBox3.Text);
                cmd.Parameters.AddWithValue("@FatherContact", textBox4.Text);
                cmd.Parameters.AddWithValue("@Course", textBox5.Text);
                cmd.Parameters.AddWithValue("@TotalFees", Convert.ToDecimal(textBox6.Text));
                cmd.Parameters.AddWithValue("@FeesPaid", Convert.ToDecimal(textBox7.Text));
                cmd.Parameters.AddWithValue("@JoinDate", dateTimePicker1.Value);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Student Added Successfully!");
            LoadStudents(); // Refresh DataGridView
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int studentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StudentID"].Value);

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UpdateStudent", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.Parameters.AddWithValue("@FullName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@FatherName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Contact", textBox3.Text);
                    cmd.Parameters.AddWithValue("@FatherContact", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Course", textBox5.Text);
                    cmd.Parameters.AddWithValue("@TotalFees", Convert.ToDecimal(textBox6.Text));
                    cmd.Parameters.AddWithValue("@FeesPaid", Convert.ToDecimal(textBox7.Text));
                    cmd.Parameters.AddWithValue("@JoinDate", dateTimePicker1.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student Updated Successfully!");
                LoadStudents();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int studentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StudentID"].Value);

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DeleteStudent", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StudentID", studentId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student Deleted Successfully!");
                LoadStudents();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SearchStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FullName", textBox8.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ensure user clicked a valid row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Yahan tumhare textboxes fill ho jayenge
                textBox1.Text = row.Cells["FullName"].Value.ToString();
                textBox2.Text = row.Cells["FatherName"].Value.ToString();
                textBox3.Text = row.Cells["Contact"].Value.ToString();
                textBox4.Text = row.Cells["FatherContact"].Value.ToString();
                textBox5.Text = row.Cells["Course"].Value.ToString();
                textBox6.Text = row.Cells["TotalFees"].Value.ToString();
                textBox7.Text = row.Cells["FeesPaid"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["JoinDate"].Value);
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
