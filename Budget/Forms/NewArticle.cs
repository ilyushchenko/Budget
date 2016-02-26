using System;
using System.Windows.Forms;

namespace Budget
{
    public partial class NewArticle : Form
    {
        public NewArticle()
        {
            InitializeComponent();
        }

        Article m_art;

        public Article Art
        {
            get { return m_art; }
        }

        private void btn_CreateNewArt_Click(object sender, EventArgs e)
        {
            if (true)
            {
                DateTime data = dateTimePicker1.Value;
                string nameArt = tb_NameArt.Text;
                decimal priceArt = decimal.Parse(tb_PriceArt.Text);
                int amountArt = int.Parse(tb_AmountArt.Text);
                string CommentAtr = tb_CommentAtr.Text;
                bool isincome = (rbtnIncome.Checked) ? true : false;
                m_art = new Article(data, nameArt, priceArt, amountArt, CommentAtr, isincome);
                Close();
            }
            else
            {
                MessageBox.Show("Заполните правильно поля");
            }
        }

        private void btn_CancelAddArt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewArticle_Load(object sender, EventArgs e)
        {

        }
    }
}
