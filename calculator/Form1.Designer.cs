namespace calculator
{
    partial class frmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.cmdUndo = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtRunningTotal = new System.Windows.Forms.TextBox();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmd6 = new System.Windows.Forms.Button();
            this.cmd7 = new System.Windows.Forms.Button();
            this.cmd8 = new System.Windows.Forms.Button();
            this.cmd9 = new System.Windows.Forms.Button();
            this.cmd0 = new System.Windows.Forms.Button();
            this.cmdPeriod = new System.Windows.Forms.Button();
            this.cmdEquals = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdSubtract = new System.Windows.Forms.Button();
            this.cmdMultiply = new System.Windows.Forms.Button();
            this.cmdDivision = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdUndo
            // 
            this.cmdUndo.Location = new System.Drawing.Point(12, 248);
            this.cmdUndo.Name = "cmdUndo";
            this.cmdUndo.Size = new System.Drawing.Size(75, 23);
            this.cmdUndo.TabIndex = 1;
            this.cmdUndo.Text = "Undo";
            this.cmdUndo.UseVisualStyleBackColor = true;
            this.cmdUndo.Click += new System.EventHandler(this.cmdUndo_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(94, 248);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 2;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(176, 248);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Enabled = false;
            this.txtDisplay.Location = new System.Drawing.Point(12, 37);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(239, 22);
            this.txtDisplay.TabIndex = 21;
            this.txtDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDisplay_KeyDown);
            this.txtDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisplay_KeyPress);
            // 
            // txtRunningTotal
            // 
            this.txtRunningTotal.Enabled = false;
            this.txtRunningTotal.Location = new System.Drawing.Point(121, 9);
            this.txtRunningTotal.Name = "txtRunningTotal";
            this.txtRunningTotal.Size = new System.Drawing.Size(130, 22);
            this.txtRunningTotal.TabIndex = 20;
            this.txtRunningTotal.TextChanged += new System.EventHandler(this.txtRunningTotal_TextChanged);
            // 
            // cmd1
            // 
            this.cmd1.Location = new System.Drawing.Point(13, 66);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(40, 29);
            this.cmd1.TabIndex = 4;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd2
            // 
            this.cmd2.Location = new System.Drawing.Point(74, 66);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(40, 29);
            this.cmd2.TabIndex = 5;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd3
            // 
            this.cmd3.Location = new System.Drawing.Point(130, 66);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(40, 29);
            this.cmd3.TabIndex = 6;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd4
            // 
            this.cmd4.Location = new System.Drawing.Point(13, 112);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(40, 29);
            this.cmd4.TabIndex = 7;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd5
            // 
            this.cmd5.Location = new System.Drawing.Point(74, 112);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(40, 29);
            this.cmd5.TabIndex = 8;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmd6
            // 
            this.cmd6.Location = new System.Drawing.Point(130, 112);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(40, 29);
            this.cmd6.TabIndex = 9;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = true;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmd7
            // 
            this.cmd7.Location = new System.Drawing.Point(12, 157);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(40, 29);
            this.cmd7.TabIndex = 10;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = true;
            this.cmd7.Click += new System.EventHandler(this.cmd7_Click);
            // 
            // cmd8
            // 
            this.cmd8.Location = new System.Drawing.Point(74, 157);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(40, 29);
            this.cmd8.TabIndex = 11;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = true;
            this.cmd8.Click += new System.EventHandler(this.cmd8_Click);
            // 
            // cmd9
            // 
            this.cmd9.Location = new System.Drawing.Point(130, 157);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(40, 29);
            this.cmd9.TabIndex = 12;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = true;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmd0
            // 
            this.cmd0.Location = new System.Drawing.Point(13, 203);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(40, 29);
            this.cmd0.TabIndex = 13;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = true;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // cmdPeriod
            // 
            this.cmdPeriod.Location = new System.Drawing.Point(74, 203);
            this.cmdPeriod.Name = "cmdPeriod";
            this.cmdPeriod.Size = new System.Drawing.Size(40, 29);
            this.cmdPeriod.TabIndex = 14;
            this.cmdPeriod.Text = ".";
            this.cmdPeriod.UseVisualStyleBackColor = true;
            this.cmdPeriod.Click += new System.EventHandler(this.cmdPeriod_Click);
            this.cmdPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculator_KeyPress);
            // 
            // cmdEquals
            // 
            this.cmdEquals.Location = new System.Drawing.Point(129, 203);
            this.cmdEquals.Name = "cmdEquals";
            this.cmdEquals.Size = new System.Drawing.Size(40, 29);
            this.cmdEquals.TabIndex = 0;
            this.cmdEquals.Text = "=";
            this.cmdEquals.UseVisualStyleBackColor = true;
            this.cmdEquals.Click += new System.EventHandler(this.cmdEquals_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(186, 66);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(65, 29);
            this.cmdAdd.TabIndex = 15;
            this.cmdAdd.Text = "+";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdSubtract
            // 
            this.cmdSubtract.Location = new System.Drawing.Point(186, 112);
            this.cmdSubtract.Name = "cmdSubtract";
            this.cmdSubtract.Size = new System.Drawing.Size(65, 29);
            this.cmdSubtract.TabIndex = 16;
            this.cmdSubtract.Text = "-";
            this.cmdSubtract.UseVisualStyleBackColor = true;
            this.cmdSubtract.Click += new System.EventHandler(this.cmdSubtract_Click);
            // 
            // cmdMultiply
            // 
            this.cmdMultiply.Location = new System.Drawing.Point(186, 157);
            this.cmdMultiply.Name = "cmdMultiply";
            this.cmdMultiply.Size = new System.Drawing.Size(65, 29);
            this.cmdMultiply.TabIndex = 17;
            this.cmdMultiply.Text = "*";
            this.cmdMultiply.UseVisualStyleBackColor = true;
            this.cmdMultiply.Click += new System.EventHandler(this.cmdMultiply_Click);
            // 
            // cmdDivision
            // 
            this.cmdDivision.Location = new System.Drawing.Point(186, 203);
            this.cmdDivision.Name = "cmdDivision";
            this.cmdDivision.Size = new System.Drawing.Size(65, 29);
            this.cmdDivision.TabIndex = 18;
            this.cmdDivision.Text = "/";
            this.cmdDivision.UseVisualStyleBackColor = true;
            this.cmdDivision.Click += new System.EventHandler(this.cmdDivision_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(17, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(97, 17);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "Running Total";
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(264, 287);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmdDivision);
            this.Controls.Add(this.cmdMultiply);
            this.Controls.Add(this.cmdSubtract);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdEquals);
            this.Controls.Add(this.cmdPeriod);
            this.Controls.Add(this.cmd0);
            this.Controls.Add(this.cmd9);
            this.Controls.Add(this.cmd8);
            this.Controls.Add(this.cmd7);
            this.Controls.Add(this.cmd6);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.txtRunningTotal);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdUndo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCalculator_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdUndo;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtRunningTotal;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Button cmd6;
        private System.Windows.Forms.Button cmd7;
        private System.Windows.Forms.Button cmd8;
        private System.Windows.Forms.Button cmd9;
        private System.Windows.Forms.Button cmd0;
        private System.Windows.Forms.Button cmdPeriod;
        private System.Windows.Forms.Button cmdEquals;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdSubtract;
        private System.Windows.Forms.Button cmdMultiply;
        private System.Windows.Forms.Button cmdDivision;
        private System.Windows.Forms.Label lbl1;
    }
}

