﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Faculty_review
{
    public partial class Search : Form
    {


        string connectionString = string.Format(
                "server={0};uid={1};pwd={2};database={3}",
                "localhost",
                "root",
                "1813059642",
                "frapp"
                );

        public Search()
        {
            InitializeComponent();

            /*Login lg = new Login();*/
            label1.Text = Login.name;
            if (Login.typ == "1")
            {
                label2.Text = "Administrator";
            }
            else if (Login.typ == "2")
            {
                label2.Text = "Faculty";
            }
            else            {
                label2.Text = "Student";
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvaluateFaculty evaluateFaculty = new EvaluateFaculty();
            evaluateFaculty.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rating rating = new Rating();
            rating.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Profile pp = new Profile();
            pp.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(connectionString))
            {


                conn.Open();

                using (var cmd = new MySqlCommand("SELECT initial, name, dep, pro_link FROM faculty WHERE initial='" + this.textBox1.Text + "'", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        var initial = reader.GetString(0);
                        var name = reader.GetString(1);
                        var link = reader.GetString(3);
                        label8.Text = initial;
                        label9.Text = name;
                        linkLabel1.Text = link;

                    }
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
