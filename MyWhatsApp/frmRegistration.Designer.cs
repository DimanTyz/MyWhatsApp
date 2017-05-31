namespace MyWhatsApp
{
    partial class frmRegistration
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
            this.grpbRequest = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbPhoneNum = new System.Windows.Forms.TextBox();
            this.txtbFullName = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.grpbConfirm = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtbSMScode = new System.Windows.Forms.TextBox();
            this.lblSms = new System.Windows.Forms.Label();
            this.grpbRequest.SuspendLayout();
            this.grpbConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbRequest
            // 
            this.grpbRequest.Controls.Add(this.btnRequest);
            this.grpbRequest.Controls.Add(this.txtbFullName);
            this.grpbRequest.Controls.Add(this.txtbPhoneNum);
            this.grpbRequest.Controls.Add(this.lblName);
            this.grpbRequest.Controls.Add(this.lblPhone);
            this.grpbRequest.Location = new System.Drawing.Point(29, 12);
            this.grpbRequest.Name = "grpbRequest";
            this.grpbRequest.Size = new System.Drawing.Size(559, 210);
            this.grpbRequest.TabIndex = 0;
            this.grpbRequest.TabStop = false;
            this.grpbRequest.Text = "Step 1: Request";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(21, 47);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(119, 20);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Full Name:";
            // 
            // txtbPhoneNum
            // 
            this.txtbPhoneNum.Location = new System.Drawing.Point(162, 47);
            this.txtbPhoneNum.Name = "txtbPhoneNum";
            this.txtbPhoneNum.Size = new System.Drawing.Size(372, 26);
            this.txtbPhoneNum.TabIndex = 0;
            // 
            // txtbFullName
            // 
            this.txtbFullName.Location = new System.Drawing.Point(162, 94);
            this.txtbFullName.Name = "txtbFullName";
            this.txtbFullName.Size = new System.Drawing.Size(372, 26);
            this.txtbFullName.TabIndex = 1;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(430, 150);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(104, 36);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // grpbConfirm
            // 
            this.grpbConfirm.Controls.Add(this.btnConfirm);
            this.grpbConfirm.Controls.Add(this.txtbSMScode);
            this.grpbConfirm.Controls.Add(this.lblSms);
            this.grpbConfirm.Location = new System.Drawing.Point(29, 255);
            this.grpbConfirm.Name = "grpbConfirm";
            this.grpbConfirm.Size = new System.Drawing.Size(559, 159);
            this.grpbConfirm.TabIndex = 1;
            this.grpbConfirm.TabStop = false;
            this.grpbConfirm.Text = "Step 2: confirm";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(430, 102);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(104, 36);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtbSMScode
            // 
            this.txtbSMScode.Location = new System.Drawing.Point(162, 47);
            this.txtbSMScode.Name = "txtbSMScode";
            this.txtbSMScode.Size = new System.Drawing.Size(372, 26);
            this.txtbSMScode.TabIndex = 0;
            // 
            // lblSms
            // 
            this.lblSms.AutoSize = true;
            this.lblSms.Location = new System.Drawing.Point(21, 47);
            this.lblSms.Name = "lblSms";
            this.lblSms.Size = new System.Drawing.Size(87, 20);
            this.lblSms.TabIndex = 0;
            this.lblSms.Text = "SMS code:";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 435);
            this.Controls.Add(this.grpbConfirm);
            this.Controls.Add(this.grpbRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            this.grpbRequest.ResumeLayout(false);
            this.grpbRequest.PerformLayout();
            this.grpbConfirm.ResumeLayout(false);
            this.grpbConfirm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbRequest;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.TextBox txtbFullName;
        private System.Windows.Forms.TextBox txtbPhoneNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox grpbConfirm;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtbSMScode;
        private System.Windows.Forms.Label lblSms;
    }
}