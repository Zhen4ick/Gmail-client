using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using OpenPop.Mime;
using OpenPop.Pop3;
using OpenPop.Common;
using Message = OpenPop.Mime.Message;


namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public bool send_get = true;
        private void Form1_Load(object sender, EventArgs e)
        {
            messages.Location = new Point(170, 93);
            messages.ReadOnly = true;
            messages.Size = new Size(400, 450);
            messages.Visible = false;
            Controls.Add(messages);
            labelMes.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelMes.Location = new Point(messages.Width/2 + 75, 50);
            labelMes.Size = new Size(167, 45);
            labelMes.Text = "Messages";
            labelMes.Visible = false;
            Controls.Add(labelMes);
            refreshButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, 
            System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            refreshButton.Size = new Size(101, 35);
            refreshButton.Text = "Refresh";
            refreshButton.Location = new Point(470,60);
            refreshButton.BackColor = Color.WhiteSmoke;
            refreshButton.Click += new EventHandler(refreshButton_Click);
            refreshButton.Visible = false;            
            Controls.Add(refreshButton);
            



        }  
        private void refreshButton_Click(object sender, EventArgs e)
        {
            GetMessages();
            
        }
        private void SendMessage()
        {
            MailAddress from = new MailAddress(usersEmail.Text);
            MailAddress to = new MailAddress(recipient.Text);
            MailMessage m = new MailMessage(from, to);
            m.Subject = headlin.Text;
            m.Body = "<h2>" + Message.Text + "</h2>";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
            smtp.Credentials = new NetworkCredential(usersEmail.Text, passwordField.Text);
            smtp.EnableSsl = true;
            smtp.Send(m);

        }
        public bool registrated = false;
        private void GetMessages()
        {
            messages.Clear();
            builder.Clear();
            
            if (registrated == false)
            {
                client.Connect("pop.gmail.com", 995, true);
                client.Authenticate(usersEmail.Text, passwordField.Text);
                registrated = true;
            }
            
            for (int i = client.GetMessageCount(); i > 1; i--)
            {
                 
                OpenPop.Mime.Message textMessages = client.GetMessage(i);
               OpenPop.Mime.MessagePart plainText = textMessages.FindFirstPlainTextVersion();
                builder.Append("-----------------------------------------------------------------------------------------------------------------------------\n" + plainText.GetBodyAsText());
                messages.Text = builder.ToString();
                
            }
            


           
        }
                
        private void usersEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            SendMessage();           
            headlin.Clear();            
            Message.Clear();
            

        }

        private void transitionButton_Click(object sender, EventArgs e)
        {
            if (send_get == true)
            {
               LoadIncommingMessages();
            }
            else
            {
                LoadSendMessages();
            }
                
        }
        public RichTextBox messages = new RichTextBox();
        public Label labelMes = new Label();
        public Button refreshButton = new Button();
        static OpenPop.Pop3.Pop3Client client = new OpenPop.Pop3.Pop3Client();
        static StringBuilder builder = new StringBuilder();
        private void LoadIncommingMessages()
        {          
            
            passwordField.Location = new Point(1,106);
            transitionButton.Location = new Point(623, 180);
            transitionButton.Text = "Send Message";
            usersEmail.Location = new Point(1, 30);
            recipient.Visible = false;
            headlin.Visible = false;
            Message.Visible = false;
            SendButton.Visible = false;
            headLine.Visible = false;
            label1.Location = new Point(-4, 0);
            label2.Visible = false;
            label3.Location = new Point(12, 79);
            labelMes.Visible = true;
            messages.Visible = true;
            refreshButton.Visible = true;
            send_get = false;   
            
        }
        private void LoadSendMessages()
        {
            
            
                passwordField.Location = new Point(208,106);
                transitionButton.Location = new Point(1, 180);
                transitionButton.Text = "Messages";
                usersEmail.Location = new Point(208, 30);
                recipient.Visible = true;
                headlin.Visible = true;
                Message.Visible = true;
                SendButton.Visible = true;
                headLine.Visible = true;
                label1.Location = new Point(214, 0);
                label2.Visible = true;
                label3.Location = new Point(238, 79);
            messages.Visible = false;
            labelMes.Visible = false;
            refreshButton.Visible = false;
                send_get = true;

            
        }
    }
}
