using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExportHelper;
using System.IO;

namespace ExportFromCaptiva
{
    public partial class MainForm : Form, IMainObserver
    {
        // this can be buggy
        private int mov;
        private int movX;
        private int movY;
        private int mm = 0;
        private LogOnForm logOn;

        public MainForm()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            progressLabel.Visible = false;
            DissconectStatus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        /// <summary>
        /// from IMainObserver interface
        /// </summary>
        public void UpdateElements()
        {

        }

        public void DissconectStatus()
        {
            startButton.Enabled = false;
            disconnectToolStripMenuItem.Enabled = false;
        }

        public void ConnectStatus()
        {
            startButton.Enabled = true;
            disconnectToolStripMenuItem.Enabled = true;
        }

        #region Top panel
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void closePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(169, 169, 169));
            z.DrawLine(pen, 3, 3, 15, 15);
            z.DrawLine(pen, 3, 15, 15, 3);
            z.DrawLine(pen, 4, 3, 16, 15);
            z.DrawLine(pen, 4, 15, 16, 3);
        }

        private void minimizePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Color myColor = Color.FromArgb(169, 169, 169);
            SolidBrush myBrush = new SolidBrush(myColor);
            Pen pen = new Pen(Color.FromArgb(169, 169, 169));

            z.DrawRectangle(pen, 3, 12, 12, 4);
            z.FillRectangle(myBrush, 3, 12, 12, 4);
        }

        private void closePanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void minimizePanel_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion Top panel

        #region Buttons
        private void openFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV (*.csv)| *.csv";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                openFileTextBox.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                saveFileTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logOn = new LogOnForm();
            logOn.RegisterObs(this);
            logOn.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Validate Form
        public void ValidateForm()
        {
            startButton.Enabled = true;

            if(String.IsNullOrEmpty(InputResultInstanceTextBox.Text) && String.IsNullOrEmpty(outputResultInstanceTextBox.Text)
                || (String.IsNullOrEmpty(openFileTextBox.Text) || String.IsNullOrEmpty(saveFileTextBox.Text)))
            {
                startButton.Enabled = false;
            }

        }

        private void InputResultInstanceTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void outputResultInstanceTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void openFileTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void saveFileTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }
        #endregion
    }

}
