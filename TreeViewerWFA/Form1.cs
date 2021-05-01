using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewerWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LeafPic.Image = Properties.Resources.leaf1;
            LeafPic.Refresh();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            LeafPic.Image = Properties.Resources.leaf2;
            LeafPic.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Size_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void emperorIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeafPic.Image = Properties.Resources.leaf2;
            LeafPic.Refresh();
        }

        private void fireGlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeafPic.Image = Properties.Resources.leaf2;
            LeafPic.Refresh();
        }

        private void glowingEmbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeafPic.Image = Properties.Resources.leaf5;
            LeafPic.Refresh();
        }

        private void osakazukiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeafPic.Image = Properties.Resources.leaf2;
            LeafPic.Refresh();
        }

        private void sangoKakuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeafPic.Image = Properties.Resources.leaf6;
            LeafPic.Refresh();
        }

        private void seiryuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeafPic.Image = Properties.Resources.leaf5;
            LeafPic.Refresh();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void years1_2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void HabitPic_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           if(trackBar1.Value == 0)
            {
                TreePic.Image = Properties.Resources.osakazuki_Spring;
                TreePic.Refresh();
            }
            else if (trackBar1.Value == 1)
            {
                TreePic.Image = Properties.Resources.osakazuki_Summer;
                TreePic.Refresh();
            }
            else if (trackBar1.Value == 2)
            {
                TreePic.Image = Properties.Resources.osakazuki_fall;
                TreePic.Refresh();
            }
        }

        private void LeafPic_Click(object sender, EventArgs e)
        {

        }

        private void TreePic_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}
