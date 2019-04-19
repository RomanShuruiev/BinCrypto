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


namespace BinCrypto
{

    delegate void Serialize(string Result);
    delegate string Deserialize();

    public partial class Form1 : Form
    {
        Serialization Serial;
        Crypto crypt;
        Convertion convert;
         DirectoryInfo Project = new DirectoryInfo(@"C:\Results");
        
          

        private string name;
        public string OriginalText;
        public string OriginalGamma;

        public Form1()
        {
            InitializeComponent();
            Project.Create();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Serial.Serialize();
            tbOriginalDat.Text = Serial.ConvertText();
            tbGammaDat.Text = Serial.ConvertGamma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialogText.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialogText.FileName;
                tbOriginal.Clear();
                tbOriginal.Text = File.ReadAllText(name);
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbCrypt.Text = crypt.DES();
            convert.ConvertResult(tbCrypt.Text);
            tbResultDat.Text = convert.ConvertResultDat();

            if (saveFileDialogText.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialogText.FileName;
                File.WriteAllText(name, tbCrypt.Text);
             
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (openFileDialogGamma.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialogGamma.FileName;
                tbGamma.Clear();
                tbGamma.Text = File.ReadAllText(name);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbOriginalDat.Text = Serial.ConvertText();

            if (saveFileDialogDatText.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialogDatText.FileName;
                File.WriteAllText(name, tbOriginalDat.Text);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbGammaDat.Text = Serial.ConvertGamma();

            if (saveFileDialogDatGamma.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialogDatGamma.FileName;
                File.WriteAllText(name, tbGammaDat.Text);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OriginalText = tbOriginal.Text;
            OriginalGamma = tbGamma.Text;
        }
    }
}
