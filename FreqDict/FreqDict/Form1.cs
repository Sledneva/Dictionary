using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FreqDict
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonExe_Click(object sender, EventArgs e)
        {
            ClassDict dct = new ClassDict(); //из класса дикт 
            string FlOpen="";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) FlOpen = openFileDialog1.FileName;
            string flSave ="";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                flSave = saveFileDialog1.FileName;


            dct.ProcAll(FlOpen, flSave); //выбрали для открытия или сохраненя
            MessageBox.Show("result is in file " + flSave);
        }
    }
}
