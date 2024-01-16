namespace WarLand
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelHeader = new Label();
            buttonHelp = new Button();
            buttonSettings = new Button();
            buttonInv = new Button();
            buttonPlay = new Button();
            buttonExit = new Button();
            bgButtons = new Panel();
            panelMain = new Panel();
            bgButtons.SuspendLayout();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.FlatStyle = FlatStyle.Flat;
            labelHeader.Font = new Font("Myanmar Text", 95.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(0, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(1281, 187);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "WarLands";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            labelHeader.UseMnemonic = false;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Left;
            buttonHelp.AutoSize = true;
            buttonHelp.BackColor = Color.FromArgb(62, 180, 137);
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(11, 330);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(324, 87);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.Left;
            buttonSettings.AutoSize = true;
            buttonSettings.BackColor = Color.FromArgb(62, 180, 137);
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Location = new Point(11, 231);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(324, 87);
            buttonSettings.TabIndex = 7;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonInv
            // 
            buttonInv.Anchor = AnchorStyles.Left;
            buttonInv.AutoSize = true;
            buttonInv.BackColor = Color.FromArgb(62, 180, 137);
            buttonInv.FlatStyle = FlatStyle.Flat;
            buttonInv.Location = new Point(11, 133);
            buttonInv.Name = "buttonInv";
            buttonInv.Size = new Size(324, 87);
            buttonInv.TabIndex = 8;
            buttonInv.Text = "Inventory";
            buttonInv.UseVisualStyleBackColor = false;
            buttonInv.Click += buttonInv_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.Anchor = AnchorStyles.Left;
            buttonPlay.AutoSize = true;
            buttonPlay.BackColor = Color.FromArgb(62, 180, 137);
            buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonPlay.Location = new Point(11, 18);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(324, 87);
            buttonPlay.TabIndex = 9;
            buttonPlay.Text = "Play";
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Left;
            buttonExit.AutoSize = true;
            buttonExit.BackColor = Color.FromArgb(62, 180, 137);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Location = new Point(11, 431);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(324, 87);
            buttonExit.TabIndex = 10;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // bgButtons
            // 
            bgButtons.Anchor = AnchorStyles.Left;
            bgButtons.AutoSize = true;
            bgButtons.BackColor = Color.FromArgb(24, 28, 39);
            bgButtons.Controls.Add(buttonPlay);
            bgButtons.Controls.Add(buttonHelp);
            bgButtons.Controls.Add(buttonInv);
            bgButtons.Controls.Add(buttonExit);
            bgButtons.Controls.Add(buttonSettings);
            bgButtons.Location = new Point(0, 170);
            bgButtons.Name = "bgButtons";
            bgButtons.Size = new Size(346, 528);
            bgButtons.TabIndex = 11;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(16, 16);
            panelMain.TabIndex = 12;
            panelMain.Visible = false;
            // 
            // MainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.FromArgb(44, 44, 49);
            ClientSize = new Size(1264, 681);
            Controls.Add(panelMain);
            Controls.Add(labelHeader);
            Controls.Add(bgButtons);
            Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            HelpButton = true;
            Name = "MainMenu";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarLands";
            WindowState = FormWindowState.Maximized;
            bgButtons.ResumeLayout(false);
            bgButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader;
        private Button buttonHelp;
        private Button buttonSettings;
        private Button buttonInv;
        private Button buttonPlay;
        private Button buttonExit;
        private Panel bgButtons;
        private Panel panelMain;
    }
}
