namespace SLACalendar
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
            this.SLAStart = new System.Windows.Forms.DateTimePicker();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtSLA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SLAStart
            // 
            this.SLAStart.Location = new System.Drawing.Point(55, 107);
            this.SLAStart.Name = "SLAStart";
            this.SLAStart.Size = new System.Drawing.Size(197, 20);
            this.SLAStart.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(293, 107);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(94, 46);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtSLA
            // 
            this.txtSLA.Location = new System.Drawing.Point(55, 133);
            this.txtSLA.Name = "txtSLA";
            this.txtSLA.Size = new System.Drawing.Size(197, 20);
            this.txtSLA.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 261);
            this.Controls.Add(this.txtSLA);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.SLAStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SLA Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SLAStart;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtSLA;
    }
}

