namespace Calculator
{
    partial class frmcalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalculator));
            this.pnlbuttons = new System.Windows.Forms.Panel();
            this.btnequal = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnsign = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnsubtract = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnbackspace = new System.Windows.Forms.Button();
            this.btnpercentage = new System.Windows.Forms.Button();
            this.btnonoff = new System.Windows.Forms.Button();
            this.txtdisplay2 = new System.Windows.Forms.TextBox();
            this.txtdisplay1 = new System.Windows.Forms.TextBox();
            this.pnlbuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlbuttons
            // 
            this.pnlbuttons.Controls.Add(this.btnequal);
            this.pnlbuttons.Controls.Add(this.btndot);
            this.pnlbuttons.Controls.Add(this.btn0);
            this.pnlbuttons.Controls.Add(this.btnsign);
            this.pnlbuttons.Controls.Add(this.btnsum);
            this.pnlbuttons.Controls.Add(this.btn3);
            this.pnlbuttons.Controls.Add(this.btn2);
            this.pnlbuttons.Controls.Add(this.btn1);
            this.pnlbuttons.Controls.Add(this.btnsubtract);
            this.pnlbuttons.Controls.Add(this.btn6);
            this.pnlbuttons.Controls.Add(this.btn5);
            this.pnlbuttons.Controls.Add(this.btn4);
            this.pnlbuttons.Controls.Add(this.btnmultiply);
            this.pnlbuttons.Controls.Add(this.btn9);
            this.pnlbuttons.Controls.Add(this.btn8);
            this.pnlbuttons.Controls.Add(this.btn7);
            this.pnlbuttons.Controls.Add(this.btndivision);
            this.pnlbuttons.Controls.Add(this.btnclear);
            this.pnlbuttons.Controls.Add(this.btnbackspace);
            this.pnlbuttons.Controls.Add(this.btnpercentage);
            this.pnlbuttons.Enabled = false;
            this.pnlbuttons.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlbuttons.Location = new System.Drawing.Point(-4, 162);
            this.pnlbuttons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlbuttons.Name = "pnlbuttons";
            this.pnlbuttons.Size = new System.Drawing.Size(400, 329);
            this.pnlbuttons.TabIndex = 0;
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.SlateGray;
            this.btnequal.Location = new System.Drawing.Point(298, 265);
            this.btnequal.Margin = new System.Windows.Forms.Padding(4);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(81, 55);
            this.btnequal.TabIndex = 19;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = false;
            this.btnequal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnequal_MouseClick);
            // 
            // btndot
            // 
            this.btndot.Location = new System.Drawing.Point(210, 265);
            this.btndot.Margin = new System.Windows.Forms.Padding(4);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(81, 55);
            this.btndot.TabIndex = 18;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btndot_MouseClick);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(121, 265);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(81, 55);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btnsign
            // 
            this.btnsign.Location = new System.Drawing.Point(32, 265);
            this.btnsign.Margin = new System.Windows.Forms.Padding(4);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(81, 55);
            this.btnsign.TabIndex = 16;
            this.btnsign.Text = "+/-";
            this.btnsign.UseVisualStyleBackColor = true;
            this.btnsign.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnsign_MouseClick);
            // 
            // btnsum
            // 
            this.btnsum.Location = new System.Drawing.Point(298, 201);
            this.btnsum.Margin = new System.Windows.Forms.Padding(4);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(81, 55);
            this.btnsum.TabIndex = 15;
            this.btnsum.Text = "+";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators_MouseClick);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(210, 201);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(81, 55);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(121, 201);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(81, 55);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(32, 201);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(81, 55);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btnsubtract
            // 
            this.btnsubtract.Location = new System.Drawing.Point(298, 137);
            this.btnsubtract.Margin = new System.Windows.Forms.Padding(4);
            this.btnsubtract.Name = "btnsubtract";
            this.btnsubtract.Size = new System.Drawing.Size(81, 55);
            this.btnsubtract.TabIndex = 11;
            this.btnsubtract.Text = "-";
            this.btnsubtract.UseVisualStyleBackColor = true;
            this.btnsubtract.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators_MouseClick);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(210, 137);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(81, 55);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(121, 137);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(81, 55);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(32, 137);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(81, 55);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btnmultiply
            // 
            this.btnmultiply.Location = new System.Drawing.Point(298, 74);
            this.btnmultiply.Margin = new System.Windows.Forms.Padding(4);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(81, 55);
            this.btnmultiply.TabIndex = 7;
            this.btnmultiply.Text = "×";
            this.btnmultiply.UseVisualStyleBackColor = true;
            this.btnmultiply.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators_MouseClick);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(210, 74);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(81, 55);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(121, 74);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(81, 55);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(32, 74);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(81, 55);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btndivision
            // 
            this.btndivision.Location = new System.Drawing.Point(298, 10);
            this.btndivision.Margin = new System.Windows.Forms.Padding(4);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(81, 55);
            this.btndivision.TabIndex = 3;
            this.btndivision.Text = "÷";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators_MouseClick);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(208, 10);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(81, 55);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnclear_MouseClick);
            // 
            // btnbackspace
            // 
            this.btnbackspace.Location = new System.Drawing.Point(120, 10);
            this.btnbackspace.Margin = new System.Windows.Forms.Padding(4);
            this.btnbackspace.Name = "btnbackspace";
            this.btnbackspace.Size = new System.Drawing.Size(81, 55);
            this.btnbackspace.TabIndex = 1;
            this.btnbackspace.Text = "←";
            this.btnbackspace.UseVisualStyleBackColor = true;
            this.btnbackspace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbackspace_MouseClick);
            // 
            // btnpercentage
            // 
            this.btnpercentage.Location = new System.Drawing.Point(32, 10);
            this.btnpercentage.Margin = new System.Windows.Forms.Padding(4);
            this.btnpercentage.Name = "btnpercentage";
            this.btnpercentage.Size = new System.Drawing.Size(81, 55);
            this.btnpercentage.TabIndex = 0;
            this.btnpercentage.Text = "%";
            this.btnpercentage.UseVisualStyleBackColor = true;
            this.btnpercentage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnpercentage_MouseClick);
            // 
            // btnonoff
            // 
            this.btnonoff.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnonoff.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnonoff.Location = new System.Drawing.Point(28, 106);
            this.btnonoff.Margin = new System.Windows.Forms.Padding(4);
            this.btnonoff.Name = "btnonoff";
            this.btnonoff.Size = new System.Drawing.Size(88, 48);
            this.btnonoff.TabIndex = 1;
            this.btnonoff.Text = "ON";
            this.btnonoff.UseVisualStyleBackColor = false;
            this.btnonoff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnonoff_MouseClick);
            // 
            // txtdisplay2
            // 
            this.txtdisplay2.Enabled = false;
            this.txtdisplay2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplay2.Location = new System.Drawing.Point(41, 13);
            this.txtdisplay2.Margin = new System.Windows.Forms.Padding(4);
            this.txtdisplay2.Name = "txtdisplay2";
            this.txtdisplay2.Size = new System.Drawing.Size(340, 24);
            this.txtdisplay2.TabIndex = 2;
            this.txtdisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtdisplay1
            // 
            this.txtdisplay1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplay1.Location = new System.Drawing.Point(41, 52);
            this.txtdisplay1.Margin = new System.Windows.Forms.Padding(4);
            this.txtdisplay1.Name = "txtdisplay1";
            this.txtdisplay1.Size = new System.Drawing.Size(341, 36);
            this.txtdisplay1.TabIndex = 3;
            this.txtdisplay1.Text = "0";
            this.txtdisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(409, 495);
            this.Controls.Add(this.txtdisplay1);
            this.Controls.Add(this.txtdisplay2);
            this.Controls.Add(this.btnonoff);
            this.Controls.Add(this.pnlbuttons);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmcalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmcalculator_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmcalculator_KeyUp);
            this.pnlbuttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlbuttons;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnsign;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnsubtract;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnbackspace;
        private System.Windows.Forms.Button btnpercentage;
        private System.Windows.Forms.Button btnonoff;
        private System.Windows.Forms.TextBox txtdisplay2;
        private System.Windows.Forms.TextBox txtdisplay1;
    }
}

