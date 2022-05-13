using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        /**
         * 별도의 이벤트 처리 함수
         */
        void childForm_Closed(object sendor, FormClosedEventArgs e)
        {
            //Show();
            System.Windows.Forms.Application.Exit();
        }

        private void singleplaybutton_Click(object sender, EventArgs e)
        {
            Hide();
            SinglePlayForm singlePlayForm = new SinglePlayForm();
            //singleplayfoirm이 닫히면 eventhandler에서 childForm_Closed 작업추가. childForm_Closed는 menu 판을 show
            singlePlayForm.FormClosed += new FormClosedEventHandler(childForm_Closed);
            singlePlayForm.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
