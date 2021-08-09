
namespace Library_System
{
    partial class Appbody
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appbody));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubPanel = new System.Windows.Forms.Panel();
            this.EXITBUTTON = new System.Windows.Forms.Button();
            this.SETTINGSBUTTOON = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BorrowersButton = new System.Windows.Forms.Button();
            this.BooksButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SubPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.SubPanel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BorrowersButton);
            this.panel1.Controls.Add(this.BooksButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 733);
            this.panel1.TabIndex = 0;
            // 
            // SubPanel
            // 
            this.SubPanel.Controls.Add(this.EXITBUTTON);
            this.SubPanel.Controls.Add(this.SETTINGSBUTTOON);
            this.SubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanel.Location = new System.Drawing.Point(0, 441);
            this.SubPanel.Name = "SubPanel";
            this.SubPanel.Size = new System.Drawing.Size(250, 213);
            this.SubPanel.TabIndex = 3;
            // 
            // EXITBUTTON
            // 
            this.EXITBUTTON.BackColor = System.Drawing.Color.Crimson;
            this.EXITBUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXITBUTTON.Dock = System.Windows.Forms.DockStyle.Top;
            this.EXITBUTTON.FlatAppearance.BorderSize = 0;
            this.EXITBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXITBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.EXITBUTTON.ForeColor = System.Drawing.SystemColors.Control;
            this.EXITBUTTON.Location = new System.Drawing.Point(0, 62);
            this.EXITBUTTON.Name = "EXITBUTTON";
            this.EXITBUTTON.Size = new System.Drawing.Size(250, 62);
            this.EXITBUTTON.TabIndex = 2;
            this.EXITBUTTON.Text = "EXIT";
            this.EXITBUTTON.UseVisualStyleBackColor = false;
            this.EXITBUTTON.Click += new System.EventHandler(this.EXITBUTTON_Click);
            // 
            // SETTINGSBUTTOON
            // 
            this.SETTINGSBUTTOON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SETTINGSBUTTOON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SETTINGSBUTTOON.Dock = System.Windows.Forms.DockStyle.Top;
            this.SETTINGSBUTTOON.FlatAppearance.BorderSize = 0;
            this.SETTINGSBUTTOON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SETTINGSBUTTOON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.SETTINGSBUTTOON.ForeColor = System.Drawing.SystemColors.Control;
            this.SETTINGSBUTTOON.Location = new System.Drawing.Point(0, 0);
            this.SETTINGSBUTTOON.Name = "SETTINGSBUTTOON";
            this.SETTINGSBUTTOON.Size = new System.Drawing.Size(250, 62);
            this.SETTINGSBUTTOON.TabIndex = 1;
            this.SETTINGSBUTTOON.Text = "ABOUT";
            this.SETTINGSBUTTOON.UseVisualStyleBackColor = false;
            this.SETTINGSBUTTOON.Click += new System.EventHandler(this.SETTINGSBUTTOON_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "OTHER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BorrowersButton
            // 
            this.BorrowersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrowersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorrowersButton.FlatAppearance.BorderSize = 0;
            this.BorrowersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BorrowersButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BorrowersButton.Location = new System.Drawing.Point(0, 317);
            this.BorrowersButton.Name = "BorrowersButton";
            this.BorrowersButton.Size = new System.Drawing.Size(250, 62);
            this.BorrowersButton.TabIndex = 1;
            this.BorrowersButton.Text = "TRANSACTIONS";
            this.BorrowersButton.UseVisualStyleBackColor = true;
            this.BorrowersButton.Click += new System.EventHandler(this.BorrowersButton_Click);
            // 
            // BooksButton
            // 
            this.BooksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BooksButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BooksButton.FlatAppearance.BorderSize = 0;
            this.BooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BooksButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BooksButton.Location = new System.Drawing.Point(0, 255);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(250, 62);
            this.BooksButton.TabIndex = 1;
            this.BooksButton.Text = "BOOKS";
            this.BooksButton.UseVisualStyleBackColor = true;
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 255);
            this.panel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(248, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(828, 733);
            this.ContentPanel.TabIndex = 1;
            // 
            // Appbody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 733);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1076, 719);
            this.Name = "Appbody";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appbody";
            this.Load += new System.EventHandler(this.Appbody_Load);
            this.panel1.ResumeLayout(false);
            this.SubPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SubPanel;
        private System.Windows.Forms.Button EXITBUTTON;
        private System.Windows.Forms.Button SETTINGSBUTTOON;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BorrowersButton;
        private System.Windows.Forms.Button BooksButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel ContentPanel;
    }
}