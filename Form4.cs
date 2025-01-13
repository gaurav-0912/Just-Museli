using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form4 : Form
    {
        Table1 table1 = new Table1();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using(PracticeEntities pe = new PracticeEntities())
            {
                dataGridView1.DataSource = pe.Table2.ToList<Table2>();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PracticeEntities pe = new PracticeEntities())
            {
                
            }

        }
    }
}
