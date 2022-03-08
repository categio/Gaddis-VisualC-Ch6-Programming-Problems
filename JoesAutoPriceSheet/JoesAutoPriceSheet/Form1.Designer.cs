
namespace JoesAutoPriceSheet
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
            this.oilAndLubeGrpBox = new System.Windows.Forms.GroupBox();
            this.lubeChkBox = new System.Windows.Forms.CheckBox();
            this.oilChgeChkBox = new System.Windows.Forms.CheckBox();
            this.flushGrpBox = new System.Windows.Forms.GroupBox();
            this.tranFlushChkBox = new System.Windows.Forms.CheckBox();
            this.radFlushChkBox = new System.Windows.Forms.CheckBox();
            this.miscGrpBox = new System.Windows.Forms.GroupBox();
            this.tireRotChkBox = new System.Windows.Forms.CheckBox();
            this.mufflerChkBox = new System.Windows.Forms.CheckBox();
            this.inspectChkBox = new System.Windows.Forms.CheckBox();
            this.partsLaborGrpBox = new System.Windows.Forms.GroupBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.sumGrpBox = new System.Windows.Forms.GroupBox();
            this.totFeesOutputLabel = new System.Windows.Forms.Label();
            this.totTaxOutputLabel = new System.Windows.Forms.Label();
            this.totPartsOutputLabel = new System.Windows.Forms.Label();
            this.totServAndLabOutputLabel = new System.Windows.Forms.Label();
            this.totFeesSumLlabel = new System.Windows.Forms.Label();
            this.taxSumLabel = new System.Windows.Forms.Label();
            this.partsSumLabel = new System.Windows.Forms.Label();
            this.servSumLaborLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.joesLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oilAndLubeGrpBox.SuspendLayout();
            this.flushGrpBox.SuspendLayout();
            this.miscGrpBox.SuspendLayout();
            this.partsLaborGrpBox.SuspendLayout();
            this.sumGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joesLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // oilAndLubeGrpBox
            // 
            this.oilAndLubeGrpBox.Controls.Add(this.lubeChkBox);
            this.oilAndLubeGrpBox.Controls.Add(this.oilChgeChkBox);
            this.oilAndLubeGrpBox.Location = new System.Drawing.Point(39, 18);
            this.oilAndLubeGrpBox.Margin = new System.Windows.Forms.Padding(4);
            this.oilAndLubeGrpBox.Name = "oilAndLubeGrpBox";
            this.oilAndLubeGrpBox.Padding = new System.Windows.Forms.Padding(4);
            this.oilAndLubeGrpBox.Size = new System.Drawing.Size(222, 113);
            this.oilAndLubeGrpBox.TabIndex = 0;
            this.oilAndLubeGrpBox.TabStop = false;
            this.oilAndLubeGrpBox.Text = "Oil and Lube";
            // 
            // lubeChkBox
            // 
            this.lubeChkBox.AutoSize = true;
            this.lubeChkBox.Location = new System.Drawing.Point(19, 66);
            this.lubeChkBox.Name = "lubeChkBox";
            this.lubeChkBox.Size = new System.Drawing.Size(136, 20);
            this.lubeChkBox.TabIndex = 1;
            this.lubeChkBox.Text = "Lube Job ($18.00)";
            this.lubeChkBox.UseVisualStyleBackColor = true;
            // 
            // oilChgeChkBox
            // 
            this.oilChgeChkBox.AutoSize = true;
            this.oilChgeChkBox.Location = new System.Drawing.Point(19, 29);
            this.oilChgeChkBox.Name = "oilChgeChkBox";
            this.oilChgeChkBox.Size = new System.Drawing.Size(147, 20);
            this.oilChgeChkBox.TabIndex = 0;
            this.oilChgeChkBox.Text = "Oil Change ($26.00)";
            this.oilChgeChkBox.UseVisualStyleBackColor = true;
            // 
            // flushGrpBox
            // 
            this.flushGrpBox.Controls.Add(this.tranFlushChkBox);
            this.flushGrpBox.Controls.Add(this.radFlushChkBox);
            this.flushGrpBox.Location = new System.Drawing.Point(289, 18);
            this.flushGrpBox.Margin = new System.Windows.Forms.Padding(4);
            this.flushGrpBox.Name = "flushGrpBox";
            this.flushGrpBox.Padding = new System.Windows.Forms.Padding(4);
            this.flushGrpBox.Size = new System.Drawing.Size(222, 113);
            this.flushGrpBox.TabIndex = 1;
            this.flushGrpBox.TabStop = false;
            this.flushGrpBox.Text = "Flushes";
            // 
            // tranFlushChkBox
            // 
            this.tranFlushChkBox.AutoSize = true;
            this.tranFlushChkBox.Location = new System.Drawing.Point(7, 66);
            this.tranFlushChkBox.Name = "tranFlushChkBox";
            this.tranFlushChkBox.Size = new System.Drawing.Size(195, 20);
            this.tranFlushChkBox.TabIndex = 3;
            this.tranFlushChkBox.Text = "Transmission Flush ($80.00)";
            this.tranFlushChkBox.UseVisualStyleBackColor = true;
            // 
            // radFlushChkBox
            // 
            this.radFlushChkBox.AutoSize = true;
            this.radFlushChkBox.Location = new System.Drawing.Point(7, 29);
            this.radFlushChkBox.Name = "radFlushChkBox";
            this.radFlushChkBox.Size = new System.Drawing.Size(167, 20);
            this.radFlushChkBox.TabIndex = 2;
            this.radFlushChkBox.Text = "Radiator Flush ($30.00)";
            this.radFlushChkBox.UseVisualStyleBackColor = true;
            // 
            // miscGrpBox
            // 
            this.miscGrpBox.Controls.Add(this.tireRotChkBox);
            this.miscGrpBox.Controls.Add(this.mufflerChkBox);
            this.miscGrpBox.Controls.Add(this.inspectChkBox);
            this.miscGrpBox.Location = new System.Drawing.Point(39, 149);
            this.miscGrpBox.Margin = new System.Windows.Forms.Padding(4);
            this.miscGrpBox.Name = "miscGrpBox";
            this.miscGrpBox.Padding = new System.Windows.Forms.Padding(4);
            this.miscGrpBox.Size = new System.Drawing.Size(222, 155);
            this.miscGrpBox.TabIndex = 2;
            this.miscGrpBox.TabStop = false;
            this.miscGrpBox.Text = "Misc";
            // 
            // tireRotChkBox
            // 
            this.tireRotChkBox.AutoSize = true;
            this.tireRotChkBox.Location = new System.Drawing.Point(19, 106);
            this.tireRotChkBox.Name = "tireRotChkBox";
            this.tireRotChkBox.Size = new System.Drawing.Size(158, 20);
            this.tireRotChkBox.TabIndex = 4;
            this.tireRotChkBox.Text = "Tire Rotation ($20.00)";
            this.tireRotChkBox.UseVisualStyleBackColor = true;
            // 
            // mufflerChkBox
            // 
            this.mufflerChkBox.AutoSize = true;
            this.mufflerChkBox.Location = new System.Drawing.Point(19, 67);
            this.mufflerChkBox.Name = "mufflerChkBox";
            this.mufflerChkBox.Size = new System.Drawing.Size(181, 20);
            this.mufflerChkBox.TabIndex = 3;
            this.mufflerChkBox.Text = "Replace Muffler ($100.00)";
            this.mufflerChkBox.UseVisualStyleBackColor = true;
            // 
            // inspectChkBox
            // 
            this.inspectChkBox.AutoSize = true;
            this.inspectChkBox.Location = new System.Drawing.Point(19, 30);
            this.inspectChkBox.Name = "inspectChkBox";
            this.inspectChkBox.Size = new System.Drawing.Size(144, 20);
            this.inspectChkBox.TabIndex = 2;
            this.inspectChkBox.Text = "Inspection ($15.00)";
            this.inspectChkBox.UseVisualStyleBackColor = true;
            // 
            // partsLaborGrpBox
            // 
            this.partsLaborGrpBox.Controls.Add(this.laborTextBox);
            this.partsLaborGrpBox.Controls.Add(this.partsTextBox);
            this.partsLaborGrpBox.Controls.Add(this.laborLabel);
            this.partsLaborGrpBox.Controls.Add(this.partsLabel);
            this.partsLaborGrpBox.Location = new System.Drawing.Point(289, 149);
            this.partsLaborGrpBox.Margin = new System.Windows.Forms.Padding(4);
            this.partsLaborGrpBox.Name = "partsLaborGrpBox";
            this.partsLaborGrpBox.Padding = new System.Windows.Forms.Padding(4);
            this.partsLaborGrpBox.Size = new System.Drawing.Size(222, 155);
            this.partsLaborGrpBox.TabIndex = 3;
            this.partsLaborGrpBox.TabStop = false;
            this.partsLaborGrpBox.Text = "Parts and Labor";
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(108, 87);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(84, 22);
            this.laborTextBox.TabIndex = 8;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(108, 48);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(84, 22);
            this.partsTextBox.TabIndex = 7;
            // 
            // laborLabel
            // 
            this.laborLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(40, 90);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(62, 16);
            this.laborLabel.TabIndex = 1;
            this.laborLabel.Text = "Labor ($)";
            // 
            // partsLabel
            // 
            this.partsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(63, 48);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(39, 16);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "Parts";
            // 
            // sumGrpBox
            // 
            this.sumGrpBox.Controls.Add(this.label1);
            this.sumGrpBox.Controls.Add(this.joesLogoPictureBox);
            this.sumGrpBox.Controls.Add(this.totFeesOutputLabel);
            this.sumGrpBox.Controls.Add(this.totTaxOutputLabel);
            this.sumGrpBox.Controls.Add(this.totPartsOutputLabel);
            this.sumGrpBox.Controls.Add(this.totServAndLabOutputLabel);
            this.sumGrpBox.Controls.Add(this.totFeesSumLlabel);
            this.sumGrpBox.Controls.Add(this.taxSumLabel);
            this.sumGrpBox.Controls.Add(this.partsSumLabel);
            this.sumGrpBox.Controls.Add(this.servSumLaborLabel);
            this.sumGrpBox.Location = new System.Drawing.Point(39, 320);
            this.sumGrpBox.Margin = new System.Windows.Forms.Padding(4);
            this.sumGrpBox.Name = "sumGrpBox";
            this.sumGrpBox.Padding = new System.Windows.Forms.Padding(4);
            this.sumGrpBox.Size = new System.Drawing.Size(472, 230);
            this.sumGrpBox.TabIndex = 3;
            this.sumGrpBox.TabStop = false;
            this.sumGrpBox.Text = "Summary";
            // 
            // totFeesOutputLabel
            // 
            this.totFeesOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totFeesOutputLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totFeesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totFeesOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totFeesOutputLabel.Location = new System.Drawing.Point(309, 152);
            this.totFeesOutputLabel.Name = "totFeesOutputLabel";
            this.totFeesOutputLabel.Size = new System.Drawing.Size(139, 26);
            this.totFeesOutputLabel.TabIndex = 9;
            this.totFeesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totTaxOutputLabel
            // 
            this.totTaxOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totTaxOutputLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totTaxOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totTaxOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totTaxOutputLabel.Location = new System.Drawing.Point(309, 111);
            this.totTaxOutputLabel.Name = "totTaxOutputLabel";
            this.totTaxOutputLabel.Size = new System.Drawing.Size(139, 26);
            this.totTaxOutputLabel.TabIndex = 8;
            this.totTaxOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totPartsOutputLabel
            // 
            this.totPartsOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totPartsOutputLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totPartsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totPartsOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totPartsOutputLabel.Location = new System.Drawing.Point(309, 71);
            this.totPartsOutputLabel.Name = "totPartsOutputLabel";
            this.totPartsOutputLabel.Size = new System.Drawing.Size(139, 26);
            this.totPartsOutputLabel.TabIndex = 7;
            this.totPartsOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totServAndLabOutputLabel
            // 
            this.totServAndLabOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totServAndLabOutputLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totServAndLabOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totServAndLabOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totServAndLabOutputLabel.Location = new System.Drawing.Point(309, 31);
            this.totServAndLabOutputLabel.Name = "totServAndLabOutputLabel";
            this.totServAndLabOutputLabel.Size = new System.Drawing.Size(139, 26);
            this.totServAndLabOutputLabel.TabIndex = 6;
            this.totServAndLabOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totFeesSumLlabel
            // 
            this.totFeesSumLlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totFeesSumLlabel.AutoSize = true;
            this.totFeesSumLlabel.Location = new System.Drawing.Point(213, 157);
            this.totFeesSumLlabel.Name = "totFeesSumLlabel";
            this.totFeesSumLlabel.Size = new System.Drawing.Size(68, 16);
            this.totFeesSumLlabel.TabIndex = 5;
            this.totFeesSumLlabel.Text = "Total Fees";
            // 
            // taxSumLabel
            // 
            this.taxSumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taxSumLabel.AutoSize = true;
            this.taxSumLabel.Location = new System.Drawing.Point(191, 116);
            this.taxSumLabel.Name = "taxSumLabel";
            this.taxSumLabel.Size = new System.Drawing.Size(90, 16);
            this.taxSumLabel.TabIndex = 4;
            this.taxSumLabel.Text = "Tax (on parts)";
            // 
            // partsSumLabel
            // 
            this.partsSumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partsSumLabel.AutoSize = true;
            this.partsSumLabel.Location = new System.Drawing.Point(178, 76);
            this.partsSumLabel.Name = "partsSumLabel";
            this.partsSumLabel.Size = new System.Drawing.Size(103, 16);
            this.partsSumLabel.TabIndex = 3;
            this.partsSumLabel.Text = "Parts and Labor";
            // 
            // servSumLaborLabel
            // 
            this.servSumLaborLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.servSumLaborLabel.AutoSize = true;
            this.servSumLaborLabel.Location = new System.Drawing.Point(225, 36);
            this.servSumLaborLabel.Name = "servSumLaborLabel";
            this.servSumLaborLabel.Size = new System.Drawing.Size(56, 16);
            this.servSumLaborLabel.TabIndex = 2;
            this.servSumLaborLabel.Text = "Services";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(58, 569);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(126, 35);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "C&alculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(213, 569);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(126, 35);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(365, 569);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // joesLogoPictureBox
            // 
            this.joesLogoPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.joesLogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.joesLogoPictureBox.Image = global::JoesAutoPriceSheet.Properties.Resources.Car_Repair_Logo;
            this.joesLogoPictureBox.Location = new System.Drawing.Point(9, 30);
            this.joesLogoPictureBox.Name = "joesLogoPictureBox";
            this.joesLogoPictureBox.Size = new System.Drawing.Size(163, 179);
            this.joesLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.joesLogoPictureBox.TabIndex = 10;
            this.joesLogoPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(210, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thanks for choosing Joe\'s!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(553, 622);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.sumGrpBox);
            this.Controls.Add(this.partsLaborGrpBox);
            this.Controls.Add(this.miscGrpBox);
            this.Controls.Add(this.flushGrpBox);
            this.Controls.Add(this.oilAndLubeGrpBox);
            this.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Joe\'s Automotive Estimate Calculator ";
            this.oilAndLubeGrpBox.ResumeLayout(false);
            this.oilAndLubeGrpBox.PerformLayout();
            this.flushGrpBox.ResumeLayout(false);
            this.flushGrpBox.PerformLayout();
            this.miscGrpBox.ResumeLayout(false);
            this.miscGrpBox.PerformLayout();
            this.partsLaborGrpBox.ResumeLayout(false);
            this.partsLaborGrpBox.PerformLayout();
            this.sumGrpBox.ResumeLayout(false);
            this.sumGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joesLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilAndLubeGrpBox;
        private System.Windows.Forms.CheckBox lubeChkBox;
        private System.Windows.Forms.CheckBox oilChgeChkBox;
        private System.Windows.Forms.GroupBox flushGrpBox;
        private System.Windows.Forms.CheckBox tranFlushChkBox;
        private System.Windows.Forms.CheckBox radFlushChkBox;
        private System.Windows.Forms.GroupBox miscGrpBox;
        private System.Windows.Forms.CheckBox tireRotChkBox;
        private System.Windows.Forms.CheckBox mufflerChkBox;
        private System.Windows.Forms.CheckBox inspectChkBox;
        private System.Windows.Forms.GroupBox partsLaborGrpBox;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.GroupBox sumGrpBox;
        private System.Windows.Forms.Label totFeesOutputLabel;
        private System.Windows.Forms.Label totTaxOutputLabel;
        private System.Windows.Forms.Label totPartsOutputLabel;
        private System.Windows.Forms.Label totServAndLabOutputLabel;
        private System.Windows.Forms.Label totFeesSumLlabel;
        private System.Windows.Forms.Label taxSumLabel;
        private System.Windows.Forms.Label partsSumLabel;
        private System.Windows.Forms.Label servSumLaborLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox joesLogoPictureBox;
        private System.Windows.Forms.Label label1;
    }
}

