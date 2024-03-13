using HW.Resources;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using uploader;

namespace HW
{
    public partial class Mainform : Form
    {
       
        public Mainform()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            hideSubMenu();
        }
        //for move the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void hideSubMenu()
        {
            panel2.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        bool isFormOpen = false;

        private void Dfinder_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HDscan_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Hard_disk_scan());
        }

        private void Path_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Specificpath());
           
        }

        private void UPfile_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Uploadfile());
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {
            if (!isFormOpen) // if the form is not open
            {
                openChildFormInPanel(new Secondform());
                isFormOpen = true; // set the state variable to true
            }
            else // if the form is already open
            {
                Form form = Application.OpenForms["Secondform"]; // get the reference to the open form
                if (form != null) // check if the form exists
                {
                    form.Close(); // close the form
                }
                isFormOpen = false; // set the state variable to false
            }
        }

        private void Reporting_Click_1(object sender, EventArgs e)
        {
            if (!isFormOpen) // if the form is not open
            {
                openChildFormInPanel(new drag());
                isFormOpen = true; // set the state variable to true
            }
            else // if the form is already open
            {
                Form form = Application.OpenForms["Drag"]; // get the reference to the open form
                if (form != null) // check if the form exists
                {
                    form.Close(); // close the form
                }
                isFormOpen = false; // set the state variable to false
            }
        }

        private void panelTitel_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
