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
    public partial class Entering : Form
    {
        public Entering()
        {
            InitializeComponent();
        }

        User us = new User();

        private void btn_CreateNewUser_Click(object sender, EventArgs e)
        {
            lbl_UserName.Text = "Введите имя нового пользователя";
            //UserName = tb_UserName.Text;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if ((tb_UserName.Text == us.UserName) && (tb_Password.Text == us.Password))
            {
                /*Entering.ActiveForm.Hide();
                Budget frm = new Budget();
                frm.ShowDialog();
                Close();*/
            }
            else { MessageBox.Show("Неверный пароль", "Ошибка"); }
        }

        private void Entering_Load(object sender, EventArgs e)
        {
            tb_UserName.Focus();
            tb_Password.UseSystemPasswordChar = true;
            btn_CreateNewUser.Enabled = false;
        }
    }
}
