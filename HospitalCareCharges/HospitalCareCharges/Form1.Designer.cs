
namespace HospitalCareCharges
{
    partial class Form1
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
            this.daysLabel = new System.Windows.Forms.Label();
            this.totStayCostLabel = new System.Windows.Forms.Label();
            this.dayCountGrpBox = new System.Windows.Forms.GroupBox();
            this.labCostLabel = new System.Windows.Forms.Label();
            this.rehabCostLabel = new System.Windows.Forms.Label();
            this.surgicalCostLabel = new System.Windows.Forms.Label();
            this.totCostSvcsLabel = new System.Windows.Forms.Label();
            this.medsCostLabel = new System.Windows.Forms.Label();
            this.chargesGrpBox = new System.Windows.Forms.GroupBox();
            this.totComboCostLabel = new System.Windows.Forms.Label();
            this.medSvcsOutputLabel = new System.Windows.Forms.Label();
            this.rmBoardOutputLabel = new System.Windows.Forms.Label();
            this.grandTotalOutputLabel = new System.Windows.Forms.Label();
            this.medsTextBox = new System.Windows.Forms.TextBox();
            this.surgeryTextBox = new System.Windows.Forms.TextBox();
            this.labsTextBox = new System.Windows.Forms.TextBox();
            this.rehabTextBox = new System.Windows.Forms.TextBox();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dayCountGrpBox.SuspendLayout();
            this.chargesGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(49, 29);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(106, 16);
            this.daysLabel.TabIndex = 1;
            this.daysLabel.Text = "Number of Days";
            this.daysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totStayCostLabel
            // 
            this.totStayCostLabel.AutoSize = true;
            this.totStayCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totStayCostLabel.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totStayCostLabel.Location = new System.Drawing.Point(69, 61);
            this.totStayCostLabel.Name = "totStayCostLabel";
            this.totStayCostLabel.Size = new System.Drawing.Size(190, 18);
            this.totStayCostLabel.TabIndex = 2;
            this.totStayCostLabel.Text = "Total Cost of Room and Board";
            this.totStayCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayCountGrpBox
            // 
            this.dayCountGrpBox.Controls.Add(this.daysTextBox);
            this.dayCountGrpBox.Controls.Add(this.rmBoardOutputLabel);
            this.dayCountGrpBox.Controls.Add(this.totStayCostLabel);
            this.dayCountGrpBox.Controls.Add(this.daysLabel);
            this.dayCountGrpBox.Location = new System.Drawing.Point(12, 216);
            this.dayCountGrpBox.Name = "dayCountGrpBox";
            this.dayCountGrpBox.Size = new System.Drawing.Size(365, 96);
            this.dayCountGrpBox.TabIndex = 3;
            this.dayCountGrpBox.TabStop = false;
            this.dayCountGrpBox.Text = "Length of Stay";
            // 
            // labCostLabel
            // 
            this.labCostLabel.AutoSize = true;
            this.labCostLabel.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCostLabel.Location = new System.Drawing.Point(95, 84);
            this.labCostLabel.Name = "labCostLabel";
            this.labCostLabel.Size = new System.Drawing.Size(60, 16);
            this.labCostLabel.TabIndex = 3;
            this.labCostLabel.Text = "Lab Fees\r\n";
            this.labCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rehabCostLabel
            // 
            this.rehabCostLabel.AutoSize = true;
            this.rehabCostLabel.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rehabCostLabel.Location = new System.Drawing.Point(13, 111);
            this.rehabCostLabel.Name = "rehabCostLabel";
            this.rehabCostLabel.Size = new System.Drawing.Size(142, 16);
            this.rehabCostLabel.TabIndex = 4;
            this.rehabCostLabel.Text = "Physical Rehabilitation";
            this.rehabCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surgicalCostLabel
            // 
            this.surgicalCostLabel.AutoSize = true;
            this.surgicalCostLabel.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surgicalCostLabel.Location = new System.Drawing.Point(29, 57);
            this.surgicalCostLabel.Name = "surgicalCostLabel";
            this.surgicalCostLabel.Size = new System.Drawing.Size(126, 16);
            this.surgicalCostLabel.TabIndex = 5;
            this.surgicalCostLabel.Text = "Surgical Procedures";
            this.surgicalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totCostSvcsLabel
            // 
            this.totCostSvcsLabel.AutoSize = true;
            this.totCostSvcsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totCostSvcsLabel.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totCostSvcsLabel.Location = new System.Drawing.Point(24, 149);
            this.totCostSvcsLabel.Name = "totCostSvcsLabel";
            this.totCostSvcsLabel.Size = new System.Drawing.Size(235, 18);
            this.totCostSvcsLabel.TabIndex = 6;
            this.totCostSvcsLabel.Text = "Total Cost of Medical Serices Provided";
            this.totCostSvcsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medsCostLabel
            // 
            this.medsCostLabel.AutoSize = true;
            this.medsCostLabel.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medsCostLabel.Location = new System.Drawing.Point(77, 30);
            this.medsCostLabel.Name = "medsCostLabel";
            this.medsCostLabel.Size = new System.Drawing.Size(78, 16);
            this.medsCostLabel.TabIndex = 7;
            this.medsCostLabel.Text = "Medication ";
            this.medsCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chargesGrpBox
            // 
            this.chargesGrpBox.Controls.Add(this.logoPictureBox);
            this.chargesGrpBox.Controls.Add(this.rehabTextBox);
            this.chargesGrpBox.Controls.Add(this.labsTextBox);
            this.chargesGrpBox.Controls.Add(this.surgeryTextBox);
            this.chargesGrpBox.Controls.Add(this.medsTextBox);
            this.chargesGrpBox.Controls.Add(this.medSvcsOutputLabel);
            this.chargesGrpBox.Controls.Add(this.medsCostLabel);
            this.chargesGrpBox.Controls.Add(this.totCostSvcsLabel);
            this.chargesGrpBox.Controls.Add(this.surgicalCostLabel);
            this.chargesGrpBox.Controls.Add(this.rehabCostLabel);
            this.chargesGrpBox.Controls.Add(this.labCostLabel);
            this.chargesGrpBox.Location = new System.Drawing.Point(12, 16);
            this.chargesGrpBox.Name = "chargesGrpBox";
            this.chargesGrpBox.Size = new System.Drawing.Size(365, 183);
            this.chargesGrpBox.TabIndex = 0;
            this.chargesGrpBox.TabStop = false;
            this.chargesGrpBox.Text = "Services Provided Cost Sheet";
            // 
            // totComboCostLabel
            // 
            this.totComboCostLabel.AutoSize = true;
            this.totComboCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totComboCostLabel.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totComboCostLabel.Location = new System.Drawing.Point(36, 333);
            this.totComboCostLabel.Name = "totComboCostLabel";
            this.totComboCostLabel.Size = new System.Drawing.Size(235, 18);
            this.totComboCostLabel.TabIndex = 3;
            this.totComboCostLabel.Text = "Total Extended Hospital Stay Charges";
            this.totComboCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medSvcsOutputLabel
            // 
            this.medSvcsOutputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.medSvcsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medSvcsOutputLabel.Location = new System.Drawing.Point(267, 142);
            this.medSvcsOutputLabel.Name = "medSvcsOutputLabel";
            this.medSvcsOutputLabel.Size = new System.Drawing.Size(91, 30);
            this.medSvcsOutputLabel.TabIndex = 8;
            this.medSvcsOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rmBoardOutputLabel
            // 
            this.rmBoardOutputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.rmBoardOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rmBoardOutputLabel.Location = new System.Drawing.Point(267, 54);
            this.rmBoardOutputLabel.Name = "rmBoardOutputLabel";
            this.rmBoardOutputLabel.Size = new System.Drawing.Size(91, 30);
            this.rmBoardOutputLabel.TabIndex = 9;
            this.rmBoardOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grandTotalOutputLabel
            // 
            this.grandTotalOutputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.grandTotalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grandTotalOutputLabel.Location = new System.Drawing.Point(279, 328);
            this.grandTotalOutputLabel.Name = "grandTotalOutputLabel";
            this.grandTotalOutputLabel.Size = new System.Drawing.Size(91, 30);
            this.grandTotalOutputLabel.TabIndex = 9;
            this.grandTotalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medsTextBox
            // 
            this.medsTextBox.Location = new System.Drawing.Point(168, 27);
            this.medsTextBox.Name = "medsTextBox";
            this.medsTextBox.Size = new System.Drawing.Size(71, 22);
            this.medsTextBox.TabIndex = 1;
            // 
            // surgeryTextBox
            // 
            this.surgeryTextBox.Location = new System.Drawing.Point(168, 54);
            this.surgeryTextBox.Name = "surgeryTextBox";
            this.surgeryTextBox.Size = new System.Drawing.Size(71, 22);
            this.surgeryTextBox.TabIndex = 2;
            // 
            // labsTextBox
            // 
            this.labsTextBox.Location = new System.Drawing.Point(168, 81);
            this.labsTextBox.Name = "labsTextBox";
            this.labsTextBox.Size = new System.Drawing.Size(71, 22);
            this.labsTextBox.TabIndex = 3;
            // 
            // rehabTextBox
            // 
            this.rehabTextBox.Location = new System.Drawing.Point(168, 108);
            this.rehabTextBox.Name = "rehabTextBox";
            this.rehabTextBox.Size = new System.Drawing.Size(71, 22);
            this.rehabTextBox.TabIndex = 4;
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(168, 26);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(71, 22);
            this.daysTextBox.TabIndex = 0;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(15, 382);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(104, 39);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "C&alculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(141, 382);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 39);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(269, 382);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 39);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoPictureBox.Image = global::HospitalCareCharges.Properties.Resources.hospital_logo;
            this.logoPictureBox.Location = new System.Drawing.Point(256, 22);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(101, 104);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 13;
            this.logoPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(389, 443);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.grandTotalOutputLabel);
            this.Controls.Add(this.totComboCostLabel);
            this.Controls.Add(this.chargesGrpBox);
            this.Controls.Add(this.dayCountGrpBox);
            this.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Extended Hospital Stay Cost Sheet";
            this.dayCountGrpBox.ResumeLayout(false);
            this.dayCountGrpBox.PerformLayout();
            this.chargesGrpBox.ResumeLayout(false);
            this.chargesGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label totStayCostLabel;
        private System.Windows.Forms.GroupBox dayCountGrpBox;
        private System.Windows.Forms.Label labCostLabel;
        private System.Windows.Forms.Label rehabCostLabel;
        private System.Windows.Forms.Label surgicalCostLabel;
        private System.Windows.Forms.Label totCostSvcsLabel;
        private System.Windows.Forms.Label medsCostLabel;
        private System.Windows.Forms.GroupBox chargesGrpBox;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.Label rmBoardOutputLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox rehabTextBox;
        private System.Windows.Forms.TextBox labsTextBox;
        private System.Windows.Forms.TextBox surgeryTextBox;
        private System.Windows.Forms.TextBox medsTextBox;
        private System.Windows.Forms.Label medSvcsOutputLabel;
        private System.Windows.Forms.Label totComboCostLabel;
        private System.Windows.Forms.Label grandTotalOutputLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

