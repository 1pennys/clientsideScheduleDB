using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table
{
    public partial class MainMenu : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public MainMenu()
        {
            InitializeComponent();
            MaximizeBox = false;
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey700, Primary.Grey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public string login = "admin";
        public string password = "qwerty123";

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == login && textBox2.Text == password)
            {
                
                EditDictionaries f1 = new EditDictionaries();
                f1.Show();
                Visible = false;
            }
            else { MessageBox.Show("Логин либо пароль неверны"); }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            LookAtSchedule f2 = new LookAtSchedule();
            f2.Show();
            Visible = false;
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Вы действительно хотите выйти?",
                               "EditDictionaries",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    Environment.Exit(0);
                else
                    e.Cancel = true; // to don't close form is user change his mind
            }
        }


        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyValue == 13)
                {
                    //if (textBox1.Text == login && textBox2.Text == password)
                    {

                        EditDictionaries f1 = new EditDictionaries();
                        f1.Show();
                        Visible = false;
                    }
                    //else { MessageBox.Show("Логин либо пароль неверны"); }
                }

                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }
    }
}
