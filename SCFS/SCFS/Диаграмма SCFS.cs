using System;
using System.Windows.Forms;

namespace SCFS
{
    public partial class Form1 : Form
    {
        Collection m_collection = new Collection();
        public Form1()
        {
            m_collection.Load("1.txt");
            InitializeComponent();
            m_collection.WaitRunTime(FillRow);
        }

        private void FillRow(string name, int wait, int run)
        {
            dataGridView1.Rows.Add(name, wait, run);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            m_collection.Draw(e.Graphics);
        }

    }
}
