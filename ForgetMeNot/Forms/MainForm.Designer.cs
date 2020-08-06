using System.ComponentModel;

namespace ForgetMeNot
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblYourName = new System.Windows.Forms.Label();
            this.lblTodayTasks = new System.Windows.Forms.Label();
            this.flowerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.flowerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(600, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {"fgrgrg", "efef", "ef", "efefefef", "ef", "efefefwew", "", "wgwgwrgrwg", "rwgrwg"});
            this.checkedListBox1.Location = new System.Drawing.Point(10, 124);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(329, 199);
            this.checkedListBox1.TabIndex = 2;
            // 
            // lblYourName
            // 
            this.lblYourName.Location = new System.Drawing.Point(2, 20);
            this.lblYourName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(598, 40);
            this.lblYourName.TabIndex = 3;
            // 
            // lblTodayTasks
            // 
            this.lblTodayTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.lblTodayTasks.Location = new System.Drawing.Point(10, 84);
            this.lblTodayTasks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodayTasks.Name = "lblTodayTasks";
            this.lblTodayTasks.Size = new System.Drawing.Size(210, 28);
            this.lblTodayTasks.TabIndex = 4;
            this.lblTodayTasks.Text = "Tasks for today";
            // 
            // flowerPictureBox
            // 
            this.flowerPictureBox.Location = new System.Drawing.Point(370, 123);
            this.flowerPictureBox.Name = "flowerPictureBox";
            this.flowerPictureBox.Size = new System.Drawing.Size(217, 199);
            this.flowerPictureBox.TabIndex = 5;
            this.flowerPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.flowerPictureBox);
            this.Controls.Add(this.lblTodayTasks);
            this.Controls.Add(this.lblYourName);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize) (this.flowerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox flowerPictureBox;
        private System.Windows.Forms.Label lblTodayTasks;
        private System.Windows.Forms.Label lblYourName;
        private System.Windows.Forms.MenuStrip menu;

        #endregion
    }
}