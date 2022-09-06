using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trytry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MingSuEntities MS = new MingSuEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            var q = from i in MS.Room
                    select new { i.RoomID,i.RoomName,i.RoomPrice,i.RoomIntrodution,i.MemberID,i.RoomstatusID,i.Address};
            dataGridView1.DataSource = q.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO ms1 = new System.IO.MemoryMappedFiles();
        }
    }
}
