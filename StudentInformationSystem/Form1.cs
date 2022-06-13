using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace StudentInformationSystem
{
    public partial class Form1 : Form
    {
        public SQLiteConnection theConnection;
        public Form1()
        {
            InitializeComponent();
        }
        public void connect()
        {
            theConnection = new SQLiteConnection("Data Source = C:\\Users\\EmreD\\Documents\\Database\\MyDatabase.db");
            theConnection.Open();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            connect();
            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = "INSERT INTO student_info (term, coursecode, coursename, ectscredits, lettergrade) VALUES (@Term, @CourseCode, @CourseName, @ectscredits, @lettergrade)";
            command.Connection = theConnection;
            command.Parameters.AddWithValue("@Term", comboBox1.Text);
            command.Parameters.AddWithValue("@CourseCode", textBox2.Text);
            command.Parameters.AddWithValue("@CourseName", textBox1.Text);
            command.Parameters.AddWithValue("@ectscredits", textBox4.Text);
            command.Parameters.AddWithValue("@lettergrade", textBox5.Text);
            command.ExecuteNonQuery();
            button_load_Click(sender, e);
            theConnection.Close();

        }

        private void button_load_Click(object sender, EventArgs e)
        {
            connect();
            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = "select ID, term, coursecode, coursename, ectscredits, lettergrade from student_info order by 1 ";
            command.Connection = theConnection;
            SQLiteDataAdapter theAdapter = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            theAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            theConnection.Close();
        }


        private void button_deletebyname_Click(object sender, EventArgs e)
        {
            connect();
            string deleteName = textBox1.Text;
            SQLiteCommand sqlCmd = new SQLiteCommand();
            sqlCmd.CommandText = "Delete from student_info where CourseName='" + deleteName + "'";
            sqlCmd.Connection = theConnection;
            sqlCmd.ExecuteNonQuery();
            button_load_Click(sender, e);


        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
