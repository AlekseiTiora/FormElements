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
        RadioButton rb3;
        RadioButton rb4;
        public Form1()
        {
            this.Height = 400;//высота
            this.Width = 800;//ширина
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
            pb.Location = new Point(500, 50);
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
            rb3 = new RadioButton();
            rb4 = new RadioButton();
            rb1.Location = new Point(600, 50);
            rb2.Location = new Point(600, 70);
            rb3.Location = new Point(600, 90);
            rb4.Location = new Point(600, 110);
            rb1.Text = "C#";
            rb2.Text = "HTML";
            rb3.Text = "JS";
            rb4.Text = "PHP";
            rb1.Click += Rb1_Click;
            rb2.Click += Rb2_Click;
            rb3.Click += Rb3_Click;
            rb4.Click += Rb4_Click;





            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void Rb4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hea valik!", ":)");
        }

        private void Rb3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hea valik!", ":)");
        }

        private void Rb2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hea valik!", ":)");
        }

        private void Rb1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hea valik!", ":)");
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
            if(e.Node.Text=="Button")
            {
                this.Controls.Add(btn);

            }
            else if(e.Node.Text == "Silt-label")
            {
                this.Controls.Add(lbl);
            }
            else if(e.Node.Text == "PictureBox")
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
                this.Controls.Add(rb1);
                this.Controls.Add(rb2);
                this.Controls.Add(rb3);
                this.Controls.Add(rb4);
            }
            else if (e.Node.Text == "MessageBox");
            {
                MessageBox.Show("MessageBox", "Kõige lihtsam aken");
                var answer = MessageBox.Show("Tahad InputBoxi näha?", "Aken koos nupudeha", MessageBoxButtons.YesNo);
                if(answer == DialogResult.Yes)
                {
                    string text = Interaction.InputBox("Sisesta siia mingi tekst", "InputBox", "Mingi tekst");
                    if(MessageBox.Show("Kas tahad tekst saada Tekskastisse?","Teksti salvestamine", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lbl.Text = text;
                        Controls.Add(lbl);
                    }
                    else
                    {
                        lbl.Text = "sa solvad mind!";
                        Controls.Add(lbl);
                    }
                }
                else
                {
                    MessageBox.Show("sa solvad mind!");
                }
            }

        }
    }
}
