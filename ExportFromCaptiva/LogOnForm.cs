using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExportHelper;

namespace ExportFromCaptiva
{
    public partial class LogOnForm : Form, ISubject
    {
        private int mov;
        private int movX;
        private int movY;
        private List<IMainObserver> observers = new List<IMainObserver>();

        public LogOnForm()
        {
            InitializeComponent();
        }

        private void LogOnForm_Load(object sender, EventArgs e)
        {
            SetAlertTextOff();
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


        private void closePanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion Top panel

        #region Buttons

        private void loginButton_Click(object sender, EventArgs e)
        {
            ValidateContent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        #region Buttons functions
        public bool ValidateContent()
        {
            bool valid = true;
            SetAlertTextOff();
            if(String.IsNullOrEmpty(this.userTextBox.Text))
            {
                valid = false;
                userAlertLabel.Visible = true;
            }

            if(String.IsNullOrEmpty(passwordTextBox.Text))
            {
                valid = false;
                passwordAlertLabel.Visible = true;
            }

            if(String.IsNullOrEmpty(serversTextBox.Text))
            {
                valid = false;
                iaServerAlertLabel.Visible = true;
            }

            return valid;
        }

        /// <summary>
        /// Diasable all Alert Text label
        /// from this Form
        /// </summary>
        public void SetAlertTextOff()
        {
            userAlertLabel.Visible = false;
            passwordAlertLabel.Visible = false;
            iaServerAlertLabel.Visible = false;
        }
        #endregion

        /// <summary>
        /// from ISubject
        /// </summary>
        /// <param name="ob"></param>
        public void RegisterObs(IMainObserver ob)
        {
            observers.Add(ob);
        }

        public void UnregisterObs(IMainObserver ob)
        {
            observers.Remove(ob);
        }

        public void NotifyObs()
        {
            foreach(IMainObserver ob in observers)
            {
                ob.UpdateElements();
            }
        }
    }
}
