
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
            this.flushGrpBox = new System.Windows.Forms.GroupBox();
            this.miscGrpBox = new System.Windows.Forms.GroupBox();
            this.partsLaborGrpBox = new System.Windows.Forms.GroupBox();
            this.sumGrpBox = new System.Windows.Forms.GroupBox();
            this.oilChgeChkBox = new System.Windows.Forms.CheckBox();
            this.lubeChkBox = new System.Windows.Forms.CheckBox();
            this.radFlushChkBox = new System.Windows.Forms.CheckBox();
            this.tranFlushChkBox = new System.Windows.Forms.CheckBox();
            this.inspectChkBox = new System.Windows.Forms.CheckBox();
            this.mufflerChkBox = new System.Windows.Forms.CheckBox();
            this.tireRotChkBox = new System.Windows.Forms.CheckBox();
            this.partsLabel = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.servSumLaborLabel = new System.Windows.Forms.Label();
            this.partsSumLabel = new System.Windows.Forms.Label();
            this.taxSumLabel = new System.Windows.Forms.Label();
            this.totFeesSumLlabel = new System.Windows.Forms.Label();
            this.totServAndLaborLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.oilAndLubeGrpBox.SuspendLayout();
            this.flushGrpBox.SuspendLayout();
            this.miscGrpBox.SuspendLayout();
            this.partsLaborGrpBox.SuspendLayout();
            this.sumGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilAndLubeGrpBox
            // 
            this.oilAndLubeGrpBox.Controls.Add(this.lubeChkBox);
            this.oilAndLubeGrpBox.Controls.Add(this.oilChgeChkBox);
            this.oilAndLubeGrpBox.Location = new System.Drawing.Point(39, 18);
            this.oilAndLubeGrpBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oilAndLubeGrpBox.Name = "oilAndLubeGrpBox";
            this.oilAndLubeGrpBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oilAndLubeGrpBox.Size = new System.Drawing.Size(222, 113);
            this.oilAndLubeGrpBox.TabIndex = 0;
            this.oilAndLubeGrpBox.TabStop = false;
            this.oilAndLubeGrpBox.Text = "Oil and Lube";
            // 
            // flushGrpBox
            // 
            this.flushGrpBox.Controls.Add(this.tranFlushChkBox);
            this.flushGrpBox.Controls.Add(this.radFlushChkBox);
            this.flushGrpBox.Location = new System.Drawing.Point(289, 18);
            this.flushGrpBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flushGrpBox.Name = "flushGrpBox";
            this.flushGrpBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flushGrpBox.Size = new System.Drawing.Size(222, 113);
            this.flushGrpBox.TabIndex = 1;
            this.flushGrpBox.TabStop = false;
            this.flushGrpBox.Text = "Flushes";
            // 
            // miscGrpBox
            // 
            this.miscGrpBox.Controls.Add(this.tireRotChkBox);
            this.miscGrpBox.Controls.Add(this.mufflerChkBox);
            this.miscGrpBox.Controls.Add(this.inspectChkBox);
            this.miscGrpBox.Location = new System.Drawing.Point(39, 149);
            this.miscGrpBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.miscGrpBox.Name = "miscGrpBox";
            this.miscGrpBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.miscGrpBox.Size = new System.Drawing.Size(222, 155);
            this.miscGrpBox.TabIndex = 2;
            this.miscGrpBox.TabStop = false;
            this.miscGrpBox.Text = "Misc";
            // 
            // partsLaborGrpBox
            // 
            this.partsLaborGrpBox.Controls.Add(this.laborTextBox);
            this.partsLaborGrpBox.Controls.Add(this.partsTextBox);
            this.partsLaborGrpBox.Controls.Add(this.laborLabel);
            this.partsLaborGrpBox.Controls.Add(this.partsLabel);
            this.partsLaborGrpBox.Location = new System.Drawing.Point(289, 149);
            this.partsLaborGrpBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partsLaborGrpBox.Name = "partsLaborGrpBox";
            this.partsLaborGrpBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partsLaborGrpBox.Size = new System.Drawing.Size(222, 155);
            this.partsLaborGrpBox.TabIndex = 3;
            this.partsLaborGrpBox.TabStop = false;
            this.partsLaborGrpBox.Text = "Parts and Labor";
            // 
            // sumGrpBox
            // 
            this.sumGrpBox.Controls.Add(this.label3);
            this.sumGrpBox.Controls.Add(this.label2);
            this.sumGrpBox.Controls.Add(this.label1);
            this.sumGrpBox.Controls.Add(this.totServAndLaborLbl);
            this.sumGrpBox.Controls.Add(this.totFeesSumLlabel);
            this.sumGrpBox.Controls.Add(this.taxSumLabel);
            this.sumGrpBox.Controls.Add(this.partsSumLabel);
            this.sumGrpBox.Controls.Add(this.servSumLaborLabel);
            this.sumGrpBox.Location = new System.Drawing.Point(39, 326);
            this.sumGrpBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sumGrpBox.Name = "sumGrpBox";
            this.sumGrpBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sumGrpBox.Size = new System.Drawing.Size(472, 211);
            this.sumGrpBox.TabIndex = 3;
            this.sumGrpBox.TabStop = false;
            this.sumGrpBox.Text = "Summary";
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
            // servSumLaborLabel
            // 
            this.servSumLaborLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.servSumLaborLabel.AutoSize = true;
            this.servSumLaborLabel.Location = new System.Drawing.Point(75, 36);
            this.servSumLaborLabel.Name = "servSumLaborLabel";
            this.servSumLaborLabel.Size = new System.Drawing.Size(114, 16);
            this.servSumLaborLabel.TabIndex = 2;
            this.servSumLaborLabel.Text = "Service and Labor";
            // 
            // partsSumLabel
            // 
            this.partsSumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partsSumLabel.AutoSize = true;
            this.partsSumLabel.Location = new System.Drawing.Point(150, 76);
            this.partsSumLabel.Name = "partsSumLabel";
            this.partsSumLabel.Size = new System.Drawing.Size(39, 16);
            this.partsSumLabel.TabIndex = 3;
            this.partsSumLabel.Text = "Parts";
            // 
            // taxSumLabel
            // 
            this.taxSumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taxSumLabel.AutoSize = true;
            this.taxSumLabel.Location = new System.Drawing.Point(99, 116);
            this.taxSumLabel.Name = "taxSumLabel";
            this.taxSumLabel.Size = new System.Drawing.Size(90, 16);
            this.taxSumLabel.TabIndex = 4;
            this.taxSumLabel.Text = "Tax (on parts)";
            // 
            // totFeesSumLlabel
            // 
            this.totFeesSumLlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totFeesSumLlabel.AutoSize = true;
            this.totFeesSumLlabel.Location = new System.Drawing.Point(121, 157);
            this.totFeesSumLlabel.Name = "totFeesSumLlabel";
            this.totFeesSumLlabel.Size = new System.Drawing.Size(68, 16);
            this.totFeesSumLlabel.TabIndex = 5;
            this.totFeesSumLlabel.Text = "Total Fees";
            // 
            // totServAndLaborLbl
            // 
            this.totServAndLaborLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totServAndLaborLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totServAndLaborLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totServAndLaborLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totServAndLaborLbl.Location = new System.Drawing.Point(217, 31);
            this.totServAndLaborLbl.Name = "totServAndLaborLbl";
            this.totServAndLaborLbl.Size = new System.Drawing.Size(139, 26);
            this.totServAndLaborLbl.TabIndex = 6;
            this.totServAndLaborLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(217, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(217, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 8;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(217, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 9;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(58, 558);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(126, 35);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "C&alculate";
            this.calcButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(213, 558);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(126, 35);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(365, 558);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(108, 48);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(84, 22);
            this.partsTextBox.TabIndex = 7;
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(108, 87);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(84, 22);
            this.laborTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(553, 605);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.sumGrpBox);
            this.Controls.Add(this.partsLaborGrpBox);
            this.Controls.Add(this.miscGrpBox);
            this.Controls.Add(this.flushGrpBox);
            this.Controls.Add(this.oilAndLubeGrpBox);
            this.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totServAndLaborLbl;
        private System.Windows.Forms.Label totFeesSumLlabel;
        private System.Windows.Forms.Label taxSumLabel;
        private System.Windows.Forms.Label partsSumLabel;
        private System.Windows.Forms.Label servSumLaborLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

