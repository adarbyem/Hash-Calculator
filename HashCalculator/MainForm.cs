using System;
using System.Windows.Forms;

namespace HashCalculator
{
    public partial class MainForm : Form
    {
        //Global Variables
        OpenFileDialog openFile = new OpenFileDialog();

        //Main Form Call
        public MainForm()
        {
            InitializeComponent();
            //Setup Dropdown Menu
            string[] menuItems = new string[2];
            menuItems[0] = "View Hash of Current File";
            menuItems[1] = "Compare Hash to Another Hash";
            comboBoxMenu.Items.Add(menuItems[0]);
            comboBoxMenu.Items.Add(menuItems[1]);
            comboBoxMenu.SelectedIndex = 0;
            //Setup Default UI State
            setUI(0);//State 0: Generate Mode, State 1: Compare Mode
            
        }
   
        public void setUI(int state)
        {
            //Sets up visible statuses based on button clicks
            switch (state)
            {
                case 0:
                    labelHashCompare.Visible = false;
                    labelHash.Visible = true;
                    labelHashGenerated.ReadOnly = true;
                    break;
                case 1:
                    labelHashCompare.Visible = true;
                    labelHash.Visible = false;
                    labelHashGenerated.ReadOnly = false;
                    break;
            }
        }

        //Browse Button
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            //Browse for File
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = openFile.FileName;
            }
            
        }
        //MD5 Button
        private void buttonMD5_Click(object sender, EventArgs e)
        {
            //Compute MD5
            beginFile(1, textBoxFile.Text, comboBoxMenu.SelectedIndex);
        }

        private void buttonSHA256_Click(object sender, EventArgs e)
        {
            //Compute SHA256
            beginFile(2, textBoxFile.Text, comboBoxMenu.SelectedIndex);
        }

        private void buttonSHA512_Click(object sender, EventArgs e)
        {
            //Compute SHA512
            beginFile(3, textBoxFile.Text, comboBoxMenu.SelectedIndex);
        }

        //Function to validate the file and pass it to the hash class
        public void beginFile(int type, string file, int uistyle)
        {
            //Local variables
            VerifyFile verify = new VerifyFile();

            //Verify the file is valid
            if (verify.verify(textBoxFile.Text))
            {
                //If it's valid, perform crypto
                Crypto crypto = new Crypto();
                if(uistyle == 0)labelHashGenerated.Text = crypto.doHash(type, file);
                else
                {
                    if(labelHashGenerated.Text == crypto.doHash(type, file))
                    {
                        MessageBox.Show(this, "The hashes match!", "Match Confirmed");
                    }
                    else
                    {
                        MessageBox.Show(this, "The hashes DO NOT match!", "Beware!");
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "The file name is invalid or that file could not be found.", "File Error");
            }
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            setUI(comboBoxMenu.SelectedIndex);
        }
    }
}
