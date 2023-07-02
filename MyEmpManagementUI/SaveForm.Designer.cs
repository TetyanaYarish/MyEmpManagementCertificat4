namespace MyEmpManagementUI
{
    partial class SaveForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWage = new System.Windows.Forms.TextBox();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnVolunteer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wage";
            // 
            // txtWage
            // 
            this.txtWage.Location = new System.Drawing.Point(112, 58);
            this.txtWage.Name = "txtWage";
            this.txtWage.Size = new System.Drawing.Size(100, 20);
            this.txtWage.TabIndex = 3;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(32, 108);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(75, 55);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Save Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // btnVolunteer
            // 
            this.btnVolunteer.Location = new System.Drawing.Point(136, 108);
            this.btnVolunteer.Name = "btnVolunteer";
            this.btnVolunteer.Size = new System.Drawing.Size(76, 55);
            this.btnVolunteer.TabIndex = 5;
            this.btnVolunteer.Text = "Save Volunteer";
            this.btnVolunteer.UseVisualStyleBackColor = true;
            this.btnVolunteer.Click += new System.EventHandler(this.BtnVolunteer_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 194);
            this.Controls.Add(this.btnVolunteer);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.txtWage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "SaveForm";
            this.Text = "SaveForm";
            this.Load += new System.EventHandler(this.SaveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWage;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnVolunteer;
    }
}