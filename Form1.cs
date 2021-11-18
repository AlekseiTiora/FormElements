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
            tn.Nodes.Add(new TreeNode("Nupp"));
            tn.Nodes.Add(new TreeNode("Silt-label"));
            tn.Nodes.Add(new TreeNode("Märkeruut-CheckBox"));
            tn.Nodes.Add(new TreeNode("Radionupp-Radiobutton"));
            tn.Nodes.Add(new TreeNode("Tekstkast-TextBox"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("Kaart-TabControl"));
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

            //double_Click -> carusel (3-4 images)


            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void Pb_DoubleClick(object sender, EventArgs e)
        {
            List<string> list = new List<string>;
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            
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
            if(e.Node.Text=="Nupp")
            {
                this.Controls.Add(btn);

            }
            else if(e.Node.Text == "Silt-label")
            {
                this.Controls.Add(lbl);
            }
            else if(e.Node.Text == "Märkeruut-CheckBox")
            {
                this.Controls.Add(pb);
            }
        }
    }
}
