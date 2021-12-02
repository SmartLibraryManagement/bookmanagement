using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookmanagement
{
    public partial class MainForm : Form
    {

        public void visblefalse() // 안보이게 가리는 함수
        {
            MemberBtn.Visible = false; BookRequestBtn.Visible = false;ManagementBtn.Visible = false;
            BookRetunBtn.Visible = false; BookManagBtn.Visible = false;BookSerchBtn.Visible = false;
            BookSearchPan.Visible = false;BookRetunPan.Visible = false;BookManagPan.Visible = false;

        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void BookSerchBtn_Click(object sender, EventArgs e)
        {
            BookSearchPan.Visible = true;BookRetunPan.Visible = false; BookManagPan.Visible = false;
        }

        private void BookRetunBtn_Click(object sender, EventArgs e)
        {
            BookSearchPan.Visible = false; BookRetunPan.Visible = true; BookManagPan.Visible = false;
        }

        private void BookManagBtn_Click(object sender, EventArgs e)
        {
            BookSearchPan.Visible = false; BookRetunPan.Visible = false; BookManagPan.Visible = true;
        }

        private void BookBtn_Click(object sender, EventArgs e) // 책 버튼
        {
            visblefalse();
            BookRetunBtn.Visible = true; BookManagBtn.Visible = true; BookSerchBtn.Visible = true;
        }

        private void adminBtn_Click(object sender, EventArgs e) // 회원 버튼
        {
            visblefalse();
            MemberBtn.Visible = true; BookRequestBtn.Visible = true; ManagementBtn.Visible = true;
            
        }

        private void MemberBtn_Click(object sender, EventArgs e)
        {
            MemberPan.Visible = true; BookRequestPan.Visible = false;
        }

        private void BookRequestBtn_Click(object sender, EventArgs e)
        {
            MemberPan.Visible = false; BookRequestPan.Visible = true;
        }

        private void ManagementBtn_Click(object sender, EventArgs e)
        {
            ManageForm ManForm = new ManageForm();
            ManForm.Show();
        }

        private void IDfind_Click(object sender, EventArgs e)
        {
            IDfindForm IDForm = new IDfindForm();
            IDForm.Show();
        }

        private void Join_Click(object sender, EventArgs e)
        {
            JoinForm JForm = new JoinForm();
            JForm.Show();
        }
    }
}
