﻿using System.ComponentModel;

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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabHomePage = new System.Windows.Forms.TabPage();
            this.pbFlower = new System.Windows.Forms.PictureBox();
            this.clbChores = new System.Windows.Forms.CheckedListBox();
            this.lblYourName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewPlant = new System.Windows.Forms.Button();
            this.lblTodayTasks = new System.Windows.Forms.Label();
            this.tabLibrary = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabMenu.SuspendLayout();
            this.tabHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pbFlower)).BeginInit();
            this.tabLibrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabHomePage);
            this.tabMenu.Controls.Add(this.tabLibrary);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(800, 666);
            this.tabMenu.TabIndex = 15;
            // 
            // tabHomePage
            // 
            this.tabHomePage.Controls.Add(this.pbFlower);
            this.tabHomePage.Controls.Add(this.clbChores);
            this.tabHomePage.Controls.Add(this.lblYourName);
            this.tabHomePage.Controls.Add(this.btnSave);
            this.tabHomePage.Controls.Add(this.btnNewPlant);
            this.tabHomePage.Controls.Add(this.lblTodayTasks);
            this.tabHomePage.Location = new System.Drawing.Point(4, 25);
            this.tabHomePage.Name = "tabHomePage";
            this.tabHomePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabHomePage.Size = new System.Drawing.Size(792, 637);
            this.tabHomePage.TabIndex = 0;
            this.tabHomePage.Text = "Home Page";
            this.tabHomePage.UseVisualStyleBackColor = true;
            // 
            // pbFlower
            // 
            this.pbFlower.Location = new System.Drawing.Point(401, 125);
            this.pbFlower.Margin = new System.Windows.Forms.Padding(4);
            this.pbFlower.Name = "pbFlower";
            this.pbFlower.Size = new System.Drawing.Size(392, 272);
            this.pbFlower.TabIndex = 17;
            this.pbFlower.TabStop = false;
            // 
            // clbChores
            // 
            this.clbChores.FormattingEnabled = true;
            this.clbChores.Location = new System.Drawing.Point(9, 125);
            this.clbChores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbChores.Name = "clbChores";
            this.clbChores.Size = new System.Drawing.Size(385, 463);
            this.clbChores.TabIndex = 14;
            this.clbChores.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbChores_ItemCheck);
            // 
            // lblYourName
            // 
            this.lblYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.lblYourName.Location = new System.Drawing.Point(0, 11);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(793, 49);
            this.lblYourName.TabIndex = 15;
            this.lblYourName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 598);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 27);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save completed tasks";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewPlant
            // 
            this.btnNewPlant.Location = new System.Drawing.Point(261, 598);
            this.btnNewPlant.Name = "btnNewPlant";
            this.btnNewPlant.Size = new System.Drawing.Size(133, 27);
            this.btnNewPlant.TabIndex = 19;
            this.btnNewPlant.Text = "Add new plant";
            this.btnNewPlant.UseVisualStyleBackColor = true;
            this.btnNewPlant.Click += new System.EventHandler(this.btnNewPlant_Click_1);
            // 
            // lblTodayTasks
            // 
            this.lblTodayTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.lblTodayTasks.Location = new System.Drawing.Point(0, 60);
            this.lblTodayTasks.Name = "lblTodayTasks";
            this.lblTodayTasks.Size = new System.Drawing.Size(793, 50);
            this.lblTodayTasks.TabIndex = 16;
            this.lblTodayTasks.Text = "Tasks for today";
            this.lblTodayTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabLibrary
            // 
            this.tabLibrary.Controls.Add(this.listBox1);
            this.tabLibrary.Location = new System.Drawing.Point(4, 25);
            this.tabLibrary.Name = "tabLibrary";
            this.tabLibrary.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibrary.Size = new System.Drawing.Size(792, 637);
            this.tabLibrary.TabIndex = 1;
            this.tabLibrary.Text = "Library";
            this.tabLibrary.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(398, 340);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.tabMenu);
            this.Location = new System.Drawing.Point(19, 19);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabMenu.ResumeLayout(false);
            this.tabHomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pbFlower)).EndInit();
            this.tabLibrary.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnNewPlant;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckedListBox clbChores;
        private System.Windows.Forms.Label lblTodayTasks;
        private System.Windows.Forms.Label lblYourName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pbFlower;
        private System.Windows.Forms.TabPage tabHomePage;
        private System.Windows.Forms.TabPage tabLibrary;
        private System.Windows.Forms.TabControl tabMenu;

        #endregion
    }
}