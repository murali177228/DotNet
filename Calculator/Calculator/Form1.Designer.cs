using System;

namespace Calculator
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.nDot = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(4, 30);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(279, 26);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(18, 66);
            this.n1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(54, 55);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(18, 196);
            this.n7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(54, 55);
            this.n7.TabIndex = 2;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n0
            // 
            this.n0.Location = new System.Drawing.Point(81, 260);
            this.n0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(54, 55);
            this.n0.TabIndex = 3;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(143, 196);
            this.n9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(54, 55);
            this.n9.TabIndex = 4;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(81, 196);
            this.n8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(54, 55);
            this.n8.TabIndex = 5;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(143, 131);
            this.n6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(54, 55);
            this.n6.TabIndex = 6;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(81, 131);
            this.n5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(54, 55);
            this.n5.TabIndex = 7;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(18, 131);
            this.n4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(54, 55);
            this.n4.TabIndex = 8;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(143, 66);
            this.n3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(54, 55);
            this.n3.TabIndex = 9;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click_1);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(81, 66);
            this.n2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(54, 55);
            this.n2.TabIndex = 10;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(205, 66);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(54, 55);
            this.btnDiv.TabIndex = 11;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(205, 196);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(54, 55);
            this.btnSub.TabIndex = 12;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(205, 261);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 55);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(81, 337);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(117, 41);
            this.btnEqual.TabIndex = 14;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // nDot
            // 
            this.nDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nDot.Location = new System.Drawing.Point(18, 260);
            this.nDot.Name = "nDot";
            this.nDot.Size = new System.Drawing.Size(56, 55);
            this.nDot.TabIndex = 0;
            this.nDot.Text = ".";
            this.nDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nDot.Click += new System.EventHandler(this.nDot_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(143, 261);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 55);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(205, 131);
            this.btnMul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(54, 55);
            this.btnMul.TabIndex = 16;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(225, 1);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 23);
            this.lblDisplay.TabIndex = 18;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDisplay.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 384);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nDot);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.txtResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button nDot;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Label lblDisplay;
    }
}

