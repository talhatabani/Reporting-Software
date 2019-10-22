namespace Reporting_soft
{
    partial class SalesReportDashboard
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
            this.from = new System.Windows.Forms.DateTimePicker();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.generate_report = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from.Location = new System.Drawing.Point(33, 75);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(244, 22);
            this.from.TabIndex = 0;
            // 
            // to
            // 
            this.to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to.Location = new System.Drawing.Point(349, 75);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(244, 22);
            this.to.TabIndex = 1;
            // 
            // generate_report
            // 
            this.generate_report.Location = new System.Drawing.Point(233, 136);
            this.generate_report.Name = "generate_report";
            this.generate_report.Size = new System.Drawing.Size(149, 33);
            this.generate_report.TabIndex = 2;
            this.generate_report.Text = "Generate";
            this.generate_report.UseVisualStyleBackColor = true;
            this.generate_report.Click += new System.EventHandler(this.generate_report_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "From Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "To Date:";
            // 
            // SalesReportDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 218);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generate_report);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Name = "SalesReportDashboard";
            this.Text = "SalesReportDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.Button generate_report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}