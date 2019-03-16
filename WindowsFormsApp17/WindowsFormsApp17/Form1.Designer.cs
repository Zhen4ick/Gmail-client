namespace WindowsFormsApp17
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.usersEmail = new System.Windows.Forms.TextBox();
            this.recipient = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.headlin = new System.Windows.Forms.TextBox();
            this.headLine = new System.Windows.Forms.Label();
            this.transitionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersEmail
            // 
            this.usersEmail.Location = new System.Drawing.Point(208, 30);
            this.usersEmail.Multiline = true;
            this.usersEmail.Name = "usersEmail";
            this.usersEmail.Size = new System.Drawing.Size(139, 48);
            this.usersEmail.TabIndex = 0;
            this.usersEmail.TextChanged += new System.EventHandler(this.usersEmail_TextChanged);
            // 
            // recipient
            // 
            this.recipient.Location = new System.Drawing.Point(487, 30);
            this.recipient.Multiline = true;
            this.recipient.Name = "recipient";
            this.recipient.Size = new System.Drawing.Size(139, 48);
            this.recipient.TabIndex = 1;
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(208, 180);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(418, 138);
            this.Message.TabIndex = 2;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(208, 106);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(139, 20);
            this.passwordField.TabIndex = 3;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.Location = new System.Drawing.Point(208, 349);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(418, 89);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send\r\n";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(214, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your eM@il";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(513, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Recipient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(238, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // headlin
            // 
            this.headlin.Location = new System.Drawing.Point(208, 137);
            this.headlin.Multiline = true;
            this.headlin.Name = "headlin";
            this.headlin.Size = new System.Drawing.Size(418, 37);
            this.headlin.TabIndex = 8;
            // 
            // headLine
            // 
            this.headLine.AutoSize = true;
            this.headLine.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headLine.Location = new System.Drawing.Point(367, 113);
            this.headLine.Name = "headLine";
            this.headLine.Size = new System.Drawing.Size(71, 21);
            this.headLine.TabIndex = 9;
            this.headLine.Text = "Headline";
            // 
            // transitionButton
            // 
            this.transitionButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transitionButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transitionButton.Location = new System.Drawing.Point(1, 180);
            this.transitionButton.Name = "transitionButton";
            this.transitionButton.Size = new System.Drawing.Size(180, 78);
            this.transitionButton.TabIndex = 10;
            this.transitionButton.Text = "Messages";
            this.transitionButton.UseVisualStyleBackColor = true;
            this.transitionButton.Click += new System.EventHandler(this.transitionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transitionButton);
            this.Controls.Add(this.headLine);
            this.Controls.Add(this.headlin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.recipient);
            this.Controls.Add(this.usersEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "eM@il";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usersEmail;
        private System.Windows.Forms.TextBox recipient;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox headlin;
        private System.Windows.Forms.Label headLine;
        private System.Windows.Forms.Button transitionButton;
    }
}

