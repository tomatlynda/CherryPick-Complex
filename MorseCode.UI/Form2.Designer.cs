namespace MorseCode.UI
{
    partial class frSettings
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtSpaceSense = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDashSense = new System.Windows.Forms.MaskedTextBox();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWordSpace = new System.Windows.Forms.TextBox();
            this.txtCharSpace = new System.Windows.Forms.TextBox();
            this.txtDash = new System.Windows.Forms.TextBox();
            this.txtDot = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Space Sensivity";
            // 
            // txtSpaceSense
            // 
            this.txtSpaceSense.Location = new System.Drawing.Point(110, 145);
            this.txtSpaceSense.Mask = "000";
            this.txtSpaceSense.Name = "txtSpaceSense";
            this.txtSpaceSense.Size = new System.Drawing.Size(47, 20);
            this.txtSpaceSense.TabIndex = 5;
            this.txtSpaceSense.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSpaceSense_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dash Sensivity";
            // 
            // txtDashSense
            // 
            this.txtDashSense.Location = new System.Drawing.Point(110, 122);
            this.txtDashSense.Mask = "000";
            this.txtDashSense.Name = "txtDashSense";
            this.txtDashSense.Size = new System.Drawing.Size(46, 20);
            this.txtDashSense.TabIndex = 4;
            this.txtDashSense.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDashSense_KeyDown);
            // 
            // chkMute
            // 
            this.chkMute.AutoSize = true;
            this.chkMute.Location = new System.Drawing.Point(106, 171);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(49, 17);
            this.chkMute.TabIndex = 6;
            this.chkMute.Text = "mute";
            this.chkMute.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Char Space";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Word Space";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dash";
            // 
            // txtWordSpace
            // 
            this.txtWordSpace.Location = new System.Drawing.Point(110, 95);
            this.txtWordSpace.Name = "txtWordSpace";
            this.txtWordSpace.Size = new System.Drawing.Size(45, 20);
            this.txtWordSpace.TabIndex = 3;
            this.txtWordSpace.Text = " ";
            // 
            // txtCharSpace
            // 
            this.txtCharSpace.Location = new System.Drawing.Point(110, 66);
            this.txtCharSpace.Name = "txtCharSpace";
            this.txtCharSpace.Size = new System.Drawing.Size(46, 20);
            this.txtCharSpace.TabIndex = 2;
            this.txtCharSpace.Text = " ";
            // 
            // txtDash
            // 
            this.txtDash.Location = new System.Drawing.Point(109, 36);
            this.txtDash.Name = "txtDash";
            this.txtDash.Size = new System.Drawing.Size(48, 20);
            this.txtDash.TabIndex = 1;
            this.txtDash.Text = "D";
            // 
            // txtDot
            // 
            this.txtDot.Location = new System.Drawing.Point(109, 10);
            this.txtDot.Name = "txtDot";
            this.txtDot.Size = new System.Drawing.Size(49, 20);
            this.txtDot.TabIndex = 0;
            this.txtDot.Text = "d";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(89, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(14, 194);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(69, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 224);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSpaceSense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDashSense);
            this.Controls.Add(this.chkMute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWordSpace);
            this.Controls.Add(this.txtCharSpace);
            this.Controls.Add(this.txtDash);
            this.Controls.Add(this.txtDot);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtSpaceSense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtDashSense;
        private System.Windows.Forms.CheckBox chkMute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWordSpace;
        private System.Windows.Forms.TextBox txtCharSpace;
        private System.Windows.Forms.TextBox txtDash;
        private System.Windows.Forms.TextBox txtDot;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;

    }
}