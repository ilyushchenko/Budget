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
            m_art.GetAtrToDataGW(AddArtToGrid);
            lIncome.Text = m_art.GetIncome(true).ToString();
            lExpence.Text = m_art.GetIncome(false).ToString();
        }

        private void AddArtToGrid(Article article)
        {
            dataGridView.Rows.Add(article.Date, article.Category, article.NameArt, article.PriceArt, article.AmountArt, article.CommentAtr);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            if (rBDay.Checked)
            {
                m_art.GetAtrToDataGW(AddArtToGrid, dateTimePickerForm.Value, dateTimePickerForm.Value);
            }
            if (raBWeek.Checked)
            {
                m_art.GetAtrToDataGW(AddArtToGrid, dateTimePickerForm.Value, dateTimePickerForm.Value.AddDays(7));
            }
            if (rBMonth.Checked)
            {
                m_art.GetAtrToDataGW(AddArtToGrid, dateTimePickerForm.Value, dateTimePickerForm.Value.AddMonths(1));
            }
            if (rbPeriod.Checked)
            {
                m_art.GetAtrToDataGW(AddArtToGrid, dateTimePickerForm.Value, dateTimePickerTo.Value);
            }
            if (rBAll.Checked)
            {
                m_art.GetAtrToDataGW(AddArtToGrid);
            }
        }
    }
}
