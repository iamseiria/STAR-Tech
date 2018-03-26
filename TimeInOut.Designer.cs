namespace Employee_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EmpolyeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginforadmin = new System.Windows.Forms.Button();
            this.timeinout = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(426, 38);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // EmpolyeeID
            // 
            this.EmpolyeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpolyeeID.Location = new System.Drawing.Point(260, 100);
            this.EmpolyeeID.Name = "EmpolyeeID";
            this.EmpolyeeID.Size = new System.Drawing.Size(266, 38);
            this.EmpolyeeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee ID";
            // 
            // loginforadmin
            // 
            this.loginforadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginforadmin.Location = new System.Drawing.Point(33, 234);
            this.loginforadmin.Name = "loginforadmin";
            this.loginforadmin.Size = new System.Drawing.Size(219, 57);
            this.loginforadmin.TabIndex = 3;
            this.loginforadmin.Text = "Login for Admin";
            this.loginforadmin.UseVisualStyleBackColor = true;
            this.loginforadmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeinout
            // 
            this.timeinout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeinout.Location = new System.Drawing.Point(282, 234);
            this.timeinout.Name = "timeinout";
            this.timeinout.Size = new System.Drawing.Size(219, 57);
            this.timeinout.TabIndex = 4;
            this.timeinout.Text = "TIME IN/OUT";
            this.timeinout.UseVisualStyleBackColor = true;
            this.timeinout.Click += new System.EventHandler(this.button2_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(530, 234);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(219, 57);
            this.reset.TabIndex = 5;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 341);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.timeinout);
            this.Controls.Add(this.loginforadmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpolyeeID);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox EmpolyeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginforadmin;
        private System.Windows.Forms.Button timeinout;
        private System.Windows.Forms.Button reset;
    }
}

