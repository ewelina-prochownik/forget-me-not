using System.ComponentModel;

namespace ForgetMeNot
{
    partial class AddPlantForm
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
            this.txbFlowerName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.txbFilePath = new System.Windows.Forms.TextBox();
            this.lblFlowerName = new System.Windows.Forms.Label();
            this.lblFlowerNickname = new System.Windows.Forms.Label();
            this.lblWaterFrequency = new System.Windows.Forms.Label();
            this.lblFertilizingFrequency = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblDialogTitle = new System.Windows.Forms.Label();
            this.btnSaveFlower = new System.Windows.Forms.Button();
            this.numlblWatering = new System.Windows.Forms.NumericUpDown();
            this.numlblFeritilizing = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.numlblWatering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numlblFeritilizing)).BeginInit();
            this.SuspendLayout();
            // 
            // txbFlowerName
            // 
            this.txbFlowerName.Location = new System.Drawing.Point(9, 114);
            this.txbFlowerName.Name = "txbFlowerName";
            this.txbFlowerName.Size = new System.Drawing.Size(320, 22);
            this.txbFlowerName.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(471, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(320, 22);
            this.textBox2.TabIndex = 1;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(9, 290);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(320, 80);
            this.txbDescription.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(471, 315);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(320, 55);
            this.btnLoadImage.TabIndex = 5;
            this.btnLoadImage.Text = "Load image from disk\r\n";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbFilePath
            // 
            this.txbFilePath.Location = new System.Drawing.Point(471, 287);
            this.txbFilePath.Name = "txbFilePath";
            this.txbFilePath.ReadOnly = true;
            this.txbFilePath.Size = new System.Drawing.Size(320, 22);
            this.txbFilePath.TabIndex = 6;
            // 
            // lblFlowerName
            // 
            this.lblFlowerName.Location = new System.Drawing.Point(9, 84);
            this.lblFlowerName.Name = "lblFlowerName";
            this.lblFlowerName.Size = new System.Drawing.Size(320, 27);
            this.lblFlowerName.TabIndex = 7;
            this.lblFlowerName.Text = "Flower name";
            // 
            // lblFlowerNickname
            // 
            this.lblFlowerNickname.Location = new System.Drawing.Point(471, 84);
            this.lblFlowerNickname.Name = "lblFlowerNickname";
            this.lblFlowerNickname.Size = new System.Drawing.Size(320, 27);
            this.lblFlowerNickname.TabIndex = 8;
            this.lblFlowerNickname.Text = "Flower nickname";
            // 
            // lblWaterFrequency
            // 
            this.lblWaterFrequency.Location = new System.Drawing.Point(9, 172);
            this.lblWaterFrequency.Name = "lblWaterFrequency";
            this.lblWaterFrequency.Size = new System.Drawing.Size(320, 27);
            this.lblWaterFrequency.TabIndex = 9;
            this.lblWaterFrequency.Text = "Watering frequency (in days)";
            // 
            // lblFertilizingFrequency
            // 
            this.lblFertilizingFrequency.Location = new System.Drawing.Point(471, 172);
            this.lblFertilizingFrequency.Name = "lblFertilizingFrequency";
            this.lblFertilizingFrequency.Size = new System.Drawing.Size(320, 27);
            this.lblFertilizingFrequency.TabIndex = 10;
            this.lblFertilizingFrequency.Text = "Fertilizing frequency (in days)";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(9, 257);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(317, 27);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // lblImage
            // 
            this.lblImage.Location = new System.Drawing.Point(471, 257);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(320, 27);
            this.lblImage.TabIndex = 12;
            this.lblImage.Text = "Image";
            // 
            // lblDialogTitle
            // 
            this.lblDialogTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.lblDialogTitle.Location = new System.Drawing.Point(9, 18);
            this.lblDialogTitle.Name = "lblDialogTitle";
            this.lblDialogTitle.Size = new System.Drawing.Size(782, 40);
            this.lblDialogTitle.TabIndex = 13;
            this.lblDialogTitle.Text = "Add new flower";
            this.lblDialogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveFlower
            // 
            this.btnSaveFlower.Location = new System.Drawing.Point(309, 402);
            this.btnSaveFlower.Name = "btnSaveFlower";
            this.btnSaveFlower.Size = new System.Drawing.Size(180, 40);
            this.btnSaveFlower.TabIndex = 15;
            this.btnSaveFlower.Text = "Save";
            this.btnSaveFlower.UseVisualStyleBackColor = true;
            // 
            // numlblWatering
            // 
            this.numlblWatering.Location = new System.Drawing.Point(9, 203);
            this.numlblWatering.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numlblWatering.Name = "numlblWatering";
            this.numlblWatering.Size = new System.Drawing.Size(320, 22);
            this.numlblWatering.TabIndex = 16;
            this.numlblWatering.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // numlblFeritilizing
            // 
            this.numlblFeritilizing.Location = new System.Drawing.Point(471, 202);
            this.numlblFeritilizing.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numlblFeritilizing.Name = "numlblFeritilizing";
            this.numlblFeritilizing.Size = new System.Drawing.Size(320, 22);
            this.numlblFeritilizing.TabIndex = 17;
            this.numlblFeritilizing.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // AddPlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.numlblFeritilizing);
            this.Controls.Add(this.numlblWatering);
            this.Controls.Add(this.btnSaveFlower);
            this.Controls.Add(this.lblDialogTitle);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblFertilizingFrequency);
            this.Controls.Add(this.lblWaterFrequency);
            this.Controls.Add(this.lblFlowerNickname);
            this.Controls.Add(this.lblFlowerName);
            this.Controls.Add(this.txbFilePath);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txbFlowerName);
            this.MaximizeBox = false;
            this.Name = "AddPlantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPlantForm";
            ((System.ComponentModel.ISupportInitialize) (this.numlblWatering)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numlblFeritilizing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSaveFlower;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDialogTitle;
        private System.Windows.Forms.Label lblFertilizingFrequency;
        private System.Windows.Forms.Label lblFlowerName;
        private System.Windows.Forms.Label lblFlowerNickname;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblWaterFrequency;
        private System.Windows.Forms.NumericUpDown numlblFeritilizing;
        private System.Windows.Forms.NumericUpDown numlblWatering;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.TextBox txbFilePath;
        private System.Windows.Forms.TextBox txbFlowerName;

        #endregion
    }
}