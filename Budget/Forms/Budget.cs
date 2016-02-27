using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget
{
    public partial class Budget : Form
    {
        public Budget(Articles articles, Categories categories)
        {
            InitializeComponent();
            m_art = articles;
            m_categories = categories;
            AddToCtgList();
        }

        Categories m_categories;
        Articles m_art;

        public void AddToCtgList()
        {
            foreach(string Category in m_categories.GetCategoryToFrm())
            {
                lstbx_Categories.Items.Add(Category); 
            }
        }

        /*public void AddToArtList()
        {
            foreach (var article in m_art.GetAtrToDataGW())
            {
                dataGridView.Rows.Add(article);
            }
        }*/

        private void lstbx_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           if (lstbx_Categories.SelectedItems.ToString() != "")
            {
                btn_AddNewArt.Enabled = true;
                picBoxAdd.Enabled = true;
                picBoxEdit.Enabled = true;
                picBoxDel.Enabled = true;
            }
        }

        private void btn_AddNewArt_Click(object sender, EventArgs e)
        {
            NewArticle newA = new NewArticle();
            newA.ShowDialog();
            if (DialogResult.OK == newA.DialogResult)
            {
                Article art1 = newA.Art;
                art1.Category = lstbx_Categories.SelectedItem.ToString();
                m_art.ListArticles.Add(art1);
                AddArtToGrid(art1);
            }
        }

        private void picBoxAdd_Click(object sender, EventArgs e)
        {
            pnl_AddEditCtg.Visible = true;
            lbl_help.Text = "Введите имя новой категории";
            btnAddNewCtg.Text = "Добавить";            
        }

        private void picBoxEdit_Click(object sender, EventArgs e)
        {
            pnl_AddEditCtg.Visible = true;
            lbl_help.Text = "Переименуйте категорию";
            btnAddNewCtg.Text = "Переименовать";
        }

        private void picBoxDel_Click(object sender, EventArgs e)
        {
            int index = lstbx_Categories.SelectedIndex;
            lstbx_Categories.Items.Remove(lstbx_Categories.SelectedItem);
            m_categories.RemoveCategory(index);
        }

        private void btnAddNewCtg_Click(object sender, EventArgs e)
        {
            if (lbl_help.Text == "Введите имя новой категории")
            {
                lstbx_Categories.Items.Add(tb_NameCtg.Text);
                m_categories.AddCategory(tb_NameCtg.Text);
            }
            else
            {                
                lstbx_Categories.Items[lstbx_Categories.SelectedIndex] = tb_NameCtg.Text;
                m_categories.RemoveCategory(lstbx_Categories.SelectedIndex);
                m_categories.EditCategory(lstbx_Categories.SelectedIndex, tb_NameCtg.Text);
            }
            pnl_AddEditCtg.Visible = false;
            tb_NameCtg.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_categories.SaveCtg();
            m_art.SaveArticles("articles.txt");
        }

        private void btn_CancelAddNewCtg_Click(object sender, EventArgs e)
        {
            tb_NameCtg.Clear();
            pnl_AddEditCtg.Visible = false;
        }

        private void Budget_Load(object sender, EventArgs e)
        {
            m_art.LoadArticles("articles.txt");
            LoadGW();
        }

        private void LoadGW()
        {
            m_art.GetAtrToDataGW(AddArtToGrid);
            decimal expence = m_art.GetIncome(false);
            decimal income = m_art.GetIncome(true);
            decimal saldo = income - expence;
            lIncome.Text = income.ToString();
            lExpence.Text = expence.ToString();
            lSaldo.Text = saldo.ToString();
        }

        private void AddArtToGrid(Article article)
        {
            dataGridView.Rows.Add(article.Date, article.Category, article.NameArt, article.PriceArt, article.AmountArt, article.CommentAtr, (article.IsIncome) ? "Доход" : "Расход");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            if (rBAll.Checked)
            {
                LoadGW();
            }
            else
            {
                DateTime dateFrom, dateTo;
                if (rBDay.Checked)
                {
                    dateFrom = dateTimePickerForm.Value;
                    dateTo = dateTimePickerForm.Value;
                }
                else if (raBWeek.Checked)
                {
                    dateFrom = dateTimePickerForm.Value;
                    dateTo = dateTimePickerForm.Value.AddDays(7);
                }
                else if (rBMonth.Checked)
                {
                    dateFrom = dateTimePickerForm.Value;
                    dateTo = dateTimePickerForm.Value.AddMonths(1);
                }
                else /*(rbPeriod.Checked)*/
                {
                    dateFrom = dateTimePickerForm.Value;
                    dateTo = dateTimePickerTo.Value;
                }
                m_art.GetAtrToDataGW(AddArtToGrid, dateFrom, dateTo);
                decimal expence = m_art.GetIncome(false, dateFrom, dateTo);
                decimal income = m_art.GetIncome(true, dateFrom, dateTo);
                decimal saldo = income - expence;
                lIncome.Text = income.ToString();
                lExpence.Text = expence.ToString();
                lSaldo.Text = saldo.ToString();
            }
        }

        private void btn_RemoweArt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.CurrentRow;
            DateTime date = Convert.ToDateTime(row.Cells[0].Value).Date;
            string category = row.Cells[1].Value.ToString();
            string name = row.Cells[2].Value.ToString();
            decimal price = Convert.ToDecimal(row.Cells[3].Value);
            int count = Convert.ToInt32(row.Cells[4].Value);
            string comment = row.Cells[5].Value.ToString();
            bool isIncome = (row.Cells[6].Value.ToString() == "Доход") ? true : false;
            Article article = new Article(date, name, price, count, comment, isIncome);
            article.Category = category;
            m_art.RemoveArticle(article);
            dataGridView.Rows.RemoveAt(row.Index);
        }
    }
}
