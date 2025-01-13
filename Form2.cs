using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Practice
{
    public partial class Form2 : Form
    {
        Table1 table1 = new Table1();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text.Length < 5)
            {
                MessageBox.Show("Name must be at least 5 characters long.");
                return;
            }

            if (textBox2.Text.Length < 5)
            {
                MessageBox.Show("Address must be at least 5 characters long.");
                return;
            }
            if (!IsNumeral(textBox3.Text))
            { 
                MessageBox.Show("Please enter numbers");
                return;
            }*/
            /*if (validEmail(textBox6.Text))
            {
                table1.Email = textBox6.Text;

            }
            else
            {
                MessageBox.Show("error.");
            }*/
            
            table1.Name = textBox1.Text;
            table1.Address = textBox2.Text;
            table1.City = textBox3.Text;
            table1.Country = textBox4.Text;
            table1.Phone = textBox5.Text;
            table1.Email = textBox6.Text;

            using (PracticeEntities pe = new PracticeEntities())
            {
                pe.Table1.Add(table1);
                pe.SaveChanges();

            }
            MessageBox.Show("Saved Successfully");
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (PracticeEntities pe = new PracticeEntities())
            {
                var query = from p in pe.Table1 where p.Phone == (textBox3.Text) select p;
                foreach(Table1 p in query)
                {
                    pe.Table1.Remove(p);
                }
                pe.SaveChanges();
                  
            }




        }
        private bool IsNumeral(String value)
        {
            foreach (char e in value)
            {
                if (!Char.IsDigit(e))
                    return false;
            }
            return true;
        }
        /*private bool validEmail(String email)
        {
            


        }*/

            private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
