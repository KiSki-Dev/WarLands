namespace WarLand
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            labelCoord = new Label();
            panelBoard = new PictureBox();
            panel1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)panelBoard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panel1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(85, 339);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Game";
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(21, 122);
            button1.Name = "button1";
            button1.Size = new Size(132, 52);
            button1.TabIndex = 2;
            button1.Text = "Reload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // labelCoord
            // 
            labelCoord.AutoSize = true;
            labelCoord.BackColor = Color.Transparent;
            labelCoord.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCoord.ForeColor = Color.White;
            labelCoord.Location = new Point(21, 177);
            labelCoord.Name = "labelCoord";
            labelCoord.Size = new Size(84, 25);
            labelCoord.TabIndex = 3;
            labelCoord.Text = "label2";
            // 
            // panelBoard
            // 
            panelBoard.Anchor = AnchorStyles.Right;
            panelBoard.BackColor = Color.DarkGray;
            panelBoard.BorderStyle = BorderStyle.FixedSingle;
            panelBoard.Location = new Point(65, 238);
            panelBoard.Name = "panelBoard";
            panelBoard.Size = new Size(10, 10);
            panelBoard.TabIndex = 0;
            panelBoard.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(600, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 654);
            panel1.TabIndex = 5;
            panel1.TabStop = false;
            panel1.SizeChanged += panel1_SizeChanged;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 49);
            ClientSize = new Size(1266, 678);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(labelCoord);
            Controls.Add(panelBoard);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Game";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Game";
            ((System.ComponentModel.ISupportInitialize)panelBoard).EndInit();
            ((System.ComponentModel.ISupportInitialize)panel1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label labelCoord;
        private PictureBox panelBoard;
        private PictureBox panel1;
    }
}