using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordCreator
{
    public partial class FormMain : MetroForm
    {
        TextBox[] txtPasswords = new TextBox[12];
        String[] keys = new String[12];
        String[] accounts = { "Gmail", "Steam", "Paypal", "Unity", "Facebook", "Netflix", "Amazon", "HumbleBunlde", "Gandhi", "Twitter", "Instagram", "Others" };

        public FormMain()
        {
            InitializeComponent();

            for (int i = 0; i < 12; i++)
            {
                this.txtPasswords[i] = TextPassword(i + 1);
            }

            this.StyleManager = metroStyleManager1;
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTheme.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
                case 2:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Default;
                    break;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;

            for (int i = 0; i < 12; i++)
            {
                PanelPasswords.Controls.Add(this.txtPasswords[i]);
            }
        }

        TextBox TextPassword(int i)
        {
            TextBox txt = new TextBox();
            txt.Name = String.Concat("Pass", Convert.ToString(i));
            txt.Width = 400;
            txt.Height = 20;
            txt.Font = new Font("Consolas", 11, FontStyle.Regular);
            return txt;
        }

        private String[] GetNewPassword()
        {
            Random random = new Random();
            String[] keys = {"","","","","","","","","","","",""};
            String[] alphabetLower = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            String[] alphabetMayus = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    int num = random.Next(10);
                    switch (num / 4)
                    {
                        case 0:
                            keys[i] += alphabetLower[random.Next(26)];
                            break;
                        case 1:
                            keys[i] += alphabetMayus[random.Next(26)];
                            break;
                        case 2:
                            keys[i] += num;
                            break;
                        default:
                            break;
                    }
                }
            }
            return keys;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.keys = GetNewPassword();
            for (int i = 0; i < 12; i++)
            {
                txtPasswords[i].Text = this.keys[i];
            }
        }

        private void btnExportTXT_Click(object sender, EventArgs e)
        {

            string filePath="";
            FileStream stream;
            String[] lines = new String[12];
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "Archivos de texto|*.txt";
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                filePath = @"" + saveFile.FileName;
                stream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
                stream.Close();
            }
            if(filePath != null || filePath != "")
            {
                stream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(stream);
                for (int i = 0; i < 12; i++)
                {
                    if(this.accounts[i] == "Facebook" || this.accounts[i] == "HumbleBunlde" || this.accounts[i] == "Instagram")
                    {
                        lines[i] = String.Concat(this.accounts[i], '\t', this.keys[i]);
                    }
                    else
                    {
                        lines[i] = String.Concat(this.accounts[i], '\t', '\t', this.keys[i]);
                    }
                    sw.WriteLine(lines[i]);
                }
                sw.Close();
                stream.Close();
            }
        }
    }
}
