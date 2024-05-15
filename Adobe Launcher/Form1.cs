using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Adobe_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cheminfichier0 = @"C:\Program Files\Adobe\Adobe Premiere Pro 2022\Adobe Premiere Pro.exe";
            Process.Start(cheminfichier0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cheminfichier1 = @"C:\Program Files\Adobe\Adobe After Effects 2022\Support Files\AfterFX.exe";
            Process.Start(cheminfichier1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cheminfichier2 = @"C:\Program Files\Adobe\Adobe Audition 2022\Adobe Audition.exe";
            Process.Start(cheminfichier2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cheminfichier3 = @"C:\Program Files\Adobe\Adobe Bridge 2022\Bridge.exe";
            Process.Start(cheminfichier3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cheminfichier4 = @"C:\Program Files\Adobe\Adobe Character Animator 2022\Support Files\Character Animator.exe";
            Process.Start(cheminfichier4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cheminfichier5 = @"C:\Program Files\Adobe\Adobe Dimension\Dimension.exe";
            Process.Start(cheminfichier5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string cheminfichier6 = @"C:\Program Files\Adobe\Adobe Dreamweaver 2021\Dreamweaver.exe";
            Process.Start(cheminfichier6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string cheminfichier7 = @"C:\Program Files\Adobe\Adobe Illustrator 2022\Support Files\Contents\Windows\Illustrator.exe";
            Process.Start(cheminfichier7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string cheminfichier8 = @"C:\Program Files\Adobe\Adobe InCopy 2022\InCopy.exe";
            Process.Start(cheminfichier8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string cheminfichier9 = @"C:\Program Files\Adobe\Adobe InDesign 2022\InDesign.exe";
            Process.Start(cheminfichier9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string cheminfichier10 = @"C:\Program Files\Adobe\Adobe Lightroom Classic\Lightroom.exe";
            Process.Start(cheminfichier10);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string cheminfichier11 = @"C:\Program Files\Adobe\Adobe Media Encoder 2022\Adobe Media Encoder.exe";
            Process.Start(cheminfichier11);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string cheminfichier12 = @"C:\Program Files\Adobe\Adobe Photoshop 2023\Photoshop.exe";
            Process.Start(cheminfichier12);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string cheminfichier13 = @"C:\Program Files (x86)\Adobe\Acrobat DC\Acrobat\Acrobat.exe";
            Process.Start(cheminfichier13);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string cheminfichier14 = @"C:\Program Files(x86)\Adobe\Acrobat DC\Acrobat\acrodist.exe";
            Process.Start(cheminfichier14);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
