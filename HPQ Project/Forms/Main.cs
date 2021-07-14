using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HPQ_Project
{
    public partial class Main : Form
    {
        // Make the top draggable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Main()
        {
            Databasing._Load();
            InitializeComponent();
        }

        // Buttons
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        // Display an login/register fail message.
        private void displayError(bool isReg, string errText) 
        {
            if (isReg)
            {
                regError.Visible = true;
                regError.Text = errText;
            }
            else
            {
                logError.Visible = true;
                logError.Text = errText;
            }
        }

        // Login
        private void loginButton_Click(object sender, EventArgs e)
        {
            logError.Visible = false;
            
            // Gather variables from the box
            string username = loginUnameBox.Text;
            string password = loginPwordBox.Text;

            // Attempt the Login
            int result = Verification.logHandle(username, password);

            // Handle the result
            switch (result)
            {
                case 0:
                    // Login valid
                    SuccessForm sForm = new SuccessForm();
                    sForm.ShowDialog();
                    break;
                case 1:
                    displayError(false, "Either username or password is empty.");
                    break;
                case 2:
                    displayError(false, "Username does not exist.");
                    break;
                case 3:
                    displayError(false, "Incorrect username/password.");
                    break;
            }
        }

        // Register
        private void regButton_Click(object sender, EventArgs e)
        {
            regError.Visible = false;
            regError.ForeColor = Color.FromArgb(192, 0, 0);

            // Gather variables from the box
            string username = regUnameBox.Text;
            string password = regPwordBox.Text;
            string email = regEmailBox.Text;
            // Attempt the register.
            int result = Verification.regHandle(username, password, email); 

            // Handle the result.
            switch (result)
            {
                case 0:
                    regError.ForeColor = Color.FromArgb(0, 192, 0);
                    displayError(true, "Registry success! Please login to gain access.");
                    break;
                case 1:
                    displayError(true, "Either username, password, or email is empty");
                    break;
                case 2:
                    displayError(true, "Email is invalid.");
                    break;
                case 3:
                    displayError(true, "Username already taken.");
                    break;
            }

        }

        private void logPanelB_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
            registerPanel.Visible = false;
            this.AcceptButton = loginButton;
        }

        private void regPanelB_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            registerPanel.Visible = true;
            this.AcceptButton = regButton;
        }
        
    }
}

/*
 * Register codes:
 * 0 = Success
 * 1 = Username/pass/email empty
 * 2 = Invalid email format
 * 3 = Username already taken
 * 
 * Login codes
 * 0 = Success
 * 1 = Username/pass empty
 * 2 = User does not exist
 * 3 = Invalid username/password
 * 
*/