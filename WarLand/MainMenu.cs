using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarLand
{
    public partial class MainMenu : Form
    {
        public static MainMenu instance;
        public MainMenu()
        {
            InitializeComponent();
            //InitializeLayout();

            instance = this;
        }

        public void loadform(object Form) // The Logic how to open a Form with the Menu on the right and Top
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            System.Windows.Forms.Form f = Form as System.Windows.Forms.Form;
            f.TopLevel = false;
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Visible = true;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void InitializeLayout()
        {
            this.WindowState = FormWindowState.Maximized;
            int Width = this.Width - this.Width;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            buttonExit.Size = new Size(screenWidth / 4, screenHeight / 15);
            buttonHelp.Size = new Size(screenWidth / 4, screenHeight / 15);
            buttonSettings.Size = new Size(screenWidth / 4, screenHeight / 15);
            buttonInv.Size = new Size(screenWidth / 4, screenHeight / 15);
            buttonPlay.Size = new Size(screenWidth / 4, screenHeight / 15);

            int buttonWidth = buttonExit.Width;
            int buttonHeight = buttonExit.Height;
            int buttonSpacing = 20;
            buttonExit.Location = new Point(Width, screenHeight / 2 + (buttonSpacing * 4));
            buttonHelp.Location = new Point(Width, buttonExit.Location.Y - buttonHeight - buttonSpacing);
            buttonSettings.Location = new Point(Width, buttonHelp.Location.Y - buttonHeight - buttonSpacing);
            buttonInv.Location = new Point(Width, buttonSettings.Location.Y - buttonHeight - buttonSpacing);
            buttonPlay.Location = new Point(Width, buttonInv.Location.Y - buttonHeight - (buttonSpacing * 2));

            int labelWidth = labelHeader.Width;
            labelHeader.Dock = DockStyle.None;
            labelHeader.Size = new Size(labelWidth, labelHeader.Height);
            labelHeader.Location = new Point(this.Width / 4, buttonPlay.Location.Y / 2);

            bgButtons.Size = new Size(buttonExit.Width + 20, buttonHeight * 5 + buttonSpacing * 5 + 40);
            bgButtons.Location = new Point(0, buttonPlay.Location.Y + buttonHeight + (buttonSpacing * 2));

        }

        private void buttonExit_Click(object sender, EventArgs e) { Application.Exit(); }
        private void buttonPlay_Click(object sender, EventArgs e) { loadform(new Game()); }
        private void buttonInv_Click(object sender, EventArgs e) { loadform(new Inventory()); }
        private void buttonSettings_Click(object sender, EventArgs e) { loadform(new Settings()); }
        private void buttonHelp_Click(object sender, EventArgs e) { loadform(new Help()); }
    }
}