namespace UserLoginSystem
{
    partial class UsersForm2
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
            this.gvUsers = new System.Windows.Forms.DataGridView();
            this.txtAreaAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserNmae = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // gvUsers
            // 
            this.gvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsers.Location = new System.Drawing.Point(43, 54);
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.Size = new System.Drawing.Size(337, 340);
            this.gvUsers.TabIndex = 0;
            this.gvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUsers_CellDoubleClick);
            // 
            // txtAreaAddress
            // 
            this.txtAreaAddress.Location = new System.Drawing.Point(554, 103);
            this.txtAreaAddress.Multiline = true;
            this.txtAreaAddress.Name = "txtAreaAddress";
            this.txtAreaAddress.Size = new System.Drawing.Size(172, 62);
            this.txtAreaAddress.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Address";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(554, 77);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(172, 20);
            this.txtContactNumber.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Contact Number";
            // 
            // txtUserNmae
            // 
            this.txtUserNmae.Location = new System.Drawing.Point(554, 51);
            this.txtUserNmae.Name = "txtUserNmae";
            this.txtUserNmae.Size = new System.Drawing.Size(172, 20);
            this.txtUserNmae.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(651, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UsersForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAreaAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserNmae);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvUsers);
            this.Name = "UsersForm2";
            this.Text = "UsersForm2";
            this.Load += new System.EventHandler(this.UsersForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvUsers;
        private System.Windows.Forms.TextBox txtAreaAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserNmae;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}