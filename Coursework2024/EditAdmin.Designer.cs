namespace Coursework2024
{
    partial class EditAdmin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.telephoneBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.workingHoursBox = new System.Windows.Forms.NumericUpDown();
            this.fullTimeCheckbox = new System.Windows.Forms.CheckBox();
            this.salaryBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workingHoursBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tel";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(158, 66);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(189, 34);
            this.nameBox.TabIndex = 10;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(158, 140);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(189, 30);
            this.emailBox.TabIndex = 18;
            // 
            // telephoneBox
            // 
            this.telephoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneBox.Location = new System.Drawing.Point(144, 235);
            this.telephoneBox.Name = "telephoneBox";
            this.telephoneBox.Size = new System.Drawing.Size(203, 30);
            this.telephoneBox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(306, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 61);
            this.button1.TabIndex = 24;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(403, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Part-time(Workinghours) ";
            // 
            // workingHoursBox
            // 
            this.workingHoursBox.Location = new System.Drawing.Point(640, 150);
            this.workingHoursBox.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.workingHoursBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.workingHoursBox.Name = "workingHoursBox";
            this.workingHoursBox.Size = new System.Drawing.Size(120, 22);
            this.workingHoursBox.TabIndex = 31;
            this.workingHoursBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fullTimeCheckbox
            // 
            this.fullTimeCheckbox.AutoSize = true;
            this.fullTimeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullTimeCheckbox.Location = new System.Drawing.Point(408, 203);
            this.fullTimeCheckbox.Name = "fullTimeCheckbox";
            this.fullTimeCheckbox.Size = new System.Drawing.Size(94, 29);
            this.fullTimeCheckbox.TabIndex = 32;
            this.fullTimeCheckbox.Text = "fulltime";
            this.fullTimeCheckbox.UseVisualStyleBackColor = true;
            // 
            // salaryBox
            // 
            this.salaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryBox.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.salaryBox.Location = new System.Drawing.Point(562, 59);
            this.salaryBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.salaryBox.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(198, 36);
            this.salaryBox.TabIndex = 33;
            this.salaryBox.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Salary";
            // 
            // EditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.fullTimeCheckbox);
            this.Controls.Add(this.workingHoursBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telephoneBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "EditAdmin";
            this.Text = "EditAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.workingHoursBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox telephoneBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown workingHoursBox;
        private System.Windows.Forms.CheckBox fullTimeCheckbox;
        private System.Windows.Forms.NumericUpDown salaryBox;
        private System.Windows.Forms.Label label3;
    }
}