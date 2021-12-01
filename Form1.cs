using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox pb;
        CheckBox cb;
        CheckBox cb1;
        CheckBox cb2;
        CheckBox cb3;
        RadioButton rb1;
        RadioButton rb2;
        TabControl tC;
        ListBox lb;
        DataGrid dg;
        MainMenu menu;
        public Form1()
        {
            this.Height = 700;//высота
            this.Width = 900;//ширина
            this.Text = "Vorm elementidega";//загловок формы
            this.BackColor = Color.CadetBlue;//цвет фона формы
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Button"));
            tn.Nodes.Add(new TreeNode("Silt-label"));
            tn.Nodes.Add(new TreeNode("CheckBox"));
            tn.Nodes.Add(new TreeNode("Radiobutton"));
            tn.Nodes.Add(new TreeNode("TextBox"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("TabControl"));
            tn.Nodes.Add(new TreeNode("MessageBox"));
            tn.Nodes.Add(new TreeNode("ListBox"));
            tn.Nodes.Add(new TreeNode("DataGridView"));
            tn.Nodes.Add(new TreeNode("MainMenu"));
            btn = new Button();

            //nupp
            btn.BackColor = Color.White;
            btn.Text = "Vajuta siia";
            btn.Location = new Point(Top = 130,50);
            btn.Height = 30;
            btn.Width = 100;
            btn.Click += Btn_Click;

            //pealkiri
            lbl = new Label();
            lbl.Text = "Amogus";
            lbl.Size = new Size(200, 30);
            lbl.Location = new Point(160, 0);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;

            //pictureBox
            pb = new PictureBox();
            pb.Size = new Size(100, 100);
            pb.Location = new Point(450, 50);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.ImageLocation=("../../img/utka.gif");
            pb.DoubleClick += Pb_DoubleClick;

            //checkBox-фон
            cb = new CheckBox();
            cb.Size = new Size(50, 30);
            cb.Location = new Point(140, 100);
            cb.Text = "test";
            cb.Click += Cb_Click;

            //checkBox2-размер

            cb1 = new CheckBox();
            cb1.Size = new Size(70, 40);
            cb1.Location = new Point(140, 120);
            cb1.Text = "размер";
            cb1.Click += Cb1_Click;

            //checkBox3- шрифт
            cb2 = new CheckBox();
            cb2.Size = new Size(60, 50);
            cb2.Location = new Point(140, 142);
            cb2.Text = "bro";
            cb2.Click += Cb2_Click;

            //RadioButton

            rb1 = new RadioButton();
            rb2 = new RadioButton();
            rb1.Location = new Point(600, 50);
            rb2.Location = new Point(600, 70);
            rb1.Text = "C#";
            rb2.Text = "HTML";
            rb1.Click += Rb1_Click;







            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }


        private void Rb2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hea valik!", ":)");
        }

        private void Rb1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hea valik!", ":)");
        }



        int fn = 0;
        private void Cb2_Click(object sender, EventArgs e)
        {
            fn++;
            if(fn==1)
            {
                this.Font = new Font("Arial", 20, FontStyle.Bold);
            }
            else
            {
                this.Font = new Font("Arial", 8, FontStyle.Bold);
                fn = 0;
            }
        }

        int rz = 0; 
        private void Cb1_Click(object sender, EventArgs e)
        {
            rz++;
            if(rz==1)
            {
                this.Size = new Size(1000, 1000);
            }
            else
            {
                this.Size = new Size(800, 400);
                rz = 0;
            }
        }

        int fk = 0;
        private void Cb_Click(object sender, EventArgs e)
        {
            fk++;
            if(fk==1)
            {
                this.BackColor = Color.Brown;
            }
            else
            {
                this.BackColor = Color.CadetBlue;
                fk = 0;
            }
        }

        private void Pb_DoubleClick(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("4elovek.gif");
            list.Add("amogus.gif");
            list.Add("1u.gif");
            list.Add("utka.gif");

            Random rnd = new Random();

            int num = rnd.Next(4);

            pb.ImageLocation = ($"../../img/{list[num]}");
        }


        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = Color.CadetBlue;

        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(244,141,123);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //this.Close();
            Process.Start("https://tiora20.thkit.ee/");
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Button")
            {
                this.Controls.Add(btn);

            }
            else if (e.Node.Text == "Silt-label")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "PictureBox")
            {
                this.Controls.Add(pb);
            }

            else if (e.Node.Text == "CheckBox")
            {
                this.Controls.Add(cb);
                this.Controls.Add(cb1);
                this.Controls.Add(cb2);
            }
            else if (e.Node.Text == "Radiobutton")
            {
                rb1 = new RadioButton();
                rb1.Text = "Must teema";
                rb1.Location = new Point(300, 150);
                rb2 = new RadioButton();
                rb2.Text = "Valge teema";
                rb2.Location = new Point(300, 200);
                this.Controls.Add(rb1);
                this.Controls.Add(rb2);
                rb1.CheckedChanged += new EventHandler(rb_Checked);
                rb2.CheckedChanged += new EventHandler(rb_Checked);

            }
            else if (e.Node.Text == "MessageBox")
            {
                MessageBox.Show("MessageBox", "Kõige lihtsam aken");
                var answer = MessageBox.Show("Tahad InputBoxi näha?", "Aken koos nupudega", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    string text = Interaction.InputBox("Sisesta siia mingi tekst", "InputBox", "Mingi tekst");
                    if (MessageBox.Show("Kas tahad tekst saada Tekskastisse?", "Teksti salvestamine", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lbl.Text = text;
                        Controls.Add(lbl);
                    }

                }
                else
                {
                    MessageBox.Show("sa solvad mind!");
                }

            }
            else if (e.Node.Text == "TabControl")
            {
                tC = new TabControl();
                tC.Location = new Point(550, 100);
                tC.Size = new Size(300, 300);

                TabPage tabP1 = new TabPage("Esimene");
                WebBrowser wb = new WebBrowser();
                wb.Url = new Uri("https://www.tthk.ee/");
                tabP1.Controls.Add(wb);


                TabPage tabP2 = new TabPage("Teine");
                WebBrowser wb2 = new WebBrowser();
                wb2.Url = new Uri("https://github.com/AlekseiTiora");
                tabP2.Controls.Add(wb2);

                TabPage tabP3 = new TabPage("Kolmas");
                WebBrowser wb3 = new WebBrowser();
                wb3.Url = new Uri("https://i.imgur.com/LllbFyY.gif");
                tabP3.Controls.Add(wb3);

                tC.Controls.Add(tabP1);
                tC.Controls.Add(tabP2);
                tC.Controls.Add(tabP3);
                this.Controls.Add(tC);
                tC.DoubleClick += TC_DoubleClick;
                tabP3.DoubleClick += tabP3_DoubleClick;

            }
            else if (e.Node.Text == "ListBox")
            {
                lb = new ListBox();
                lb.Items.Add("Rohaline");
                lb.Items.Add("Punane");
                lb.Items.Add("Sinine");
                lb.Items.Add("Hall");
                lb.Items.Add("Kollane");
                lb.Location = new Point(150, 400);
                lb.SelectedIndexChanged += new EventHandler
                    (ls_SelectedIndexChanged);
                this.Controls.Add(lb);


            }
            else if (e.Node.Text == "DataGridView")
            {
                DataSet dg = new DataSet("XML fail. Menüü");
                dg.ReadXml(@"..\..\img\test.xml");
                DataGridView ds = new DataGridView();
                ds.Width = 450;
                ds.Height = 150;
                ds.Location = new Point(150, 250);
                ds.AutoGenerateColumns = true;
                ds.DataSource = dg;
                ds.DataMember = "food";

                this.Controls.Add(ds);
            }
            else if (e.Node.Text == "MainMenu")
            {
                MainMenu menu = new MainMenu();
                MenuItem menuFile = new MenuItem("File");
                menuFile.MenuItems.Add("Exit", new EventHandler(menuFile_Exit_Select));
                menuFile.MenuItems.Add("Browser", new EventHandler(menuFile_Browser_Select));
                menuFile.MenuItems.Add("Hide", new EventHandler(menuFile_Hide_Select));
                menu.MenuItems.Add(menuFile);
                this.Menu = menu;
            }
        }

        private void menuFile_Hide_Select(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void menuFile_Browser_Select(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/");

        }

        private void menuFile_Exit_Select(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ls_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(lb.SelectedIndex)
            {
                case 0:
                lb.BackColor = Color.Green;
                break;
                case 1:
                    lb.BackColor = Color.Red;
                    break;
                case 2:
                    lb.BackColor = Color.Blue;
                    break;
                case 3:
                    lb.BackColor = Color.Gray;
                    break;
                default:
                    lb.BackColor = Color.Yellow;
                    break;
            }   
        }

        private void TC_DoubleClick(object sender, EventArgs e)
        {
            this.tC.TabPages.Remove(tC.SelectedTab);
        }

        private void tabP3_DoubleClick(object sender, EventArgs e)
        {
            string title = "tabP" + (tC.TabCount + 1).ToString();
            TabPage tb = new TabPage(title);
            tC.TabPages.Add(tb);
        }


        private void rb_Checked(object sender, EventArgs e)
        {

            if (rb1.Checked)
            {
                this.BackColor = Color.Black;
                rb2.ForeColor = Color.White;
                rb1.ForeColor = Color.White;
            }
            else if(rb2.Checked)
            {
                this.BackColor = Color.White;
                rb2.ForeColor = Color.Black;
                rb1.ForeColor = Color.Black;
            }
        }
    
    }
}
