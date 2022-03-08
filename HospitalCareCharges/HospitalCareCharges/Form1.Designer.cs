
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chargesGrpBox = new System.Windows.Forms.GroupBox();
            this.dayCountGrpBox.SuspendLayout();
            this.chargesGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(26, 31);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(106, 16);
            this.daysLabel.TabIndex = 1;
            this.daysLabel.Text = "Number of Days";
            this.daysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totStayCostLabel
            // 
            this.totStayCostLabel.AutoSize = true;
            this.totStayCostLabel.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totStayCostLabel.Location = new System.Drawing.Point(26, 60);
            this.totStayCostLabel.Name = "totStayCostLabel";
            this.totStayCostLabel.Size = new System.Drawing.Size(188, 16);
            this.totStayCostLabel.TabIndex = 2;
            this.totStayCostLabel.Text = "Total Cost of Room and Board";
            this.totStayCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayCountGrpBox
            // 
            this.dayCountGrpBox.Controls.Add(this.totStayCostLabel);
            this.dayCountGrpBox.Controls.Add(this.daysLabel);
            this.dayCountGrpBox.Location = new System.Drawing.Point(12, 315);
            this.dayCountGrpBox.Name = "dayCountGrpBox";
            this.dayCountGrpBox.Size = new System.Drawing.Size(321, 93);
            this.dayCountGrpBox.TabIndex = 3;
            this.dayCountGrpBox.TabStop = false;
            this.dayCountGrpBox.Text = "Length of Stay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lab Fees\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Physical Rehabilitation ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surgical Procedures";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Cost of Medical Serices Provided";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Medication ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chargesGrpBox
            // 
            this.chargesGrpBox.Controls.Add(this.label5);
            this.chargesGrpBox.Controls.Add(this.label4);
            this.chargesGrpBox.Controls.Add(this.label3);
            this.chargesGrpBox.Controls.Add(this.label2);
            this.chargesGrpBox.Controls.Add(this.label1);
            this.chargesGrpBox.Location = new System.Drawing.Point(12, 16);
            this.chargesGrpBox.Name = "chargesGrpBox";
            this.chargesGrpBox.Size = new System.Drawing.Size(320, 219);
            this.chargesGrpBox.TabIndex = 8;
            this.chargesGrpBox.TabStop = false;
            this.chargesGrpBox.Text = "Services Provided Cost Sheet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(350, 479);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label totStayCostLabel;
        private System.Windows.Forms.GroupBox dayCountGrpBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox chargesGrpBox;
    }
}

