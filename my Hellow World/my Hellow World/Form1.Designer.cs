namespace my_Hellow_World
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.cmd_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(71, 6);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(492, 20);
            this.txtMessage.TabIndex = 1;
            // 
            // cmd_Send
            // 
            this.cmd_Send.Location = new System.Drawing.Point(487, 32);
            this.cmd_Send.Name = "cmd_Send";
            this.cmd_Send.Size = new System.Drawing.Size(75, 23);
            this.cmd_Send.TabIndex = 2;
            this.cmd_Send.Text = "Send";
            this.cmd_Send.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 65);
            this.Controls.Add(this.cmd_Send);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button cmd_Send;
    }
}

