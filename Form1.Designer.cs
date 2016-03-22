namespace ShutdownSchedular
{
    partial class Frmscheduler
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScheduler = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.timeScheduler = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRemainTime = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblActualtime = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Time To Shutdown ,Restart Or Hibernate";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(19, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time must be in 24 hrs format";
            // 
            // btnScheduler
            // 
            this.btnScheduler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduler.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnScheduler.Location = new System.Drawing.Point(21, 149);
            this.btnScheduler.Name = "btnScheduler";
            this.btnScheduler.Size = new System.Drawing.Size(75, 23);
            this.btnScheduler.TabIndex = 3;
            this.btnScheduler.Text = "Schedule";
            this.btnScheduler.UseVisualStyleBackColor = true;
            this.btnScheduler.Click += new System.EventHandler(this.btnScheduler_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(239, 154);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 4;
            // 
            // timeScheduler
            // 
            this.timeScheduler.Interval = 1000;
            this.timeScheduler.Tick += new System.EventHandler(this.timeScheduler_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(18, 201);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(133, 23);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Remaining Time ";
            // 
            // lblRemainTime
            // 
            this.lblRemainTime.AutoSize = true;
            this.lblRemainTime.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainTime.ForeColor = System.Drawing.Color.Maroon;
            this.lblRemainTime.Location = new System.Drawing.Point(158, 195);
            this.lblRemainTime.Name = "lblRemainTime";
            this.lblRemainTime.Size = new System.Drawing.Size(0, 38);
            this.lblRemainTime.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnReset.Location = new System.Drawing.Point(114, 149);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblActualtime
            // 
            this.lblActualtime.AutoSize = true;
            this.lblActualtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualtime.Location = new System.Drawing.Point(211, 201);
            this.lblActualtime.Name = "lblActualtime";
            this.lblActualtime.Size = new System.Drawing.Size(0, 13);
            this.lblActualtime.TabIndex = 8;
            this.lblActualtime.Visible = false;
            // 
            // timePicker
            // 
            this.timePicker.Location = new System.Drawing.Point(21, 99);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(168, 20);
            this.timePicker.TabIndex = 9;
            // 
            // cmbOption
            // 
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Hibernate",
            "Sleep"});
            this.cmbOption.Location = new System.Drawing.Point(242, 98);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(121, 21);
            this.cmbOption.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Operation ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Time";
            // 
            // Frmscheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOption);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.lblActualtime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblRemainTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btnScheduler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frmscheduler";
            this.Text = "ShutDown Timer";
            this.Load += new System.EventHandler(this.Frmscheduler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnScheduler;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Timer timeScheduler;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRemainTime;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblActualtime;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

