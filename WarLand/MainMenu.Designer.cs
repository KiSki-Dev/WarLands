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
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.Dock = DockStyle.Top;
            labelHeader.FlatStyle = FlatStyle.Flat;
            labelHeader.Font = new Font("Myanmar Text", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(0, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(1204, 129);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "WarLands";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            labelHeader.UseMnemonic = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(44, 44, 49);
            ClientSize = new Size(1204, 583);
            Controls.Add(labelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Name = "MainMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarLands";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Label labelHeader;
    }
}
