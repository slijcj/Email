using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                send_mail();
                txt_statue.Text = "success!";
                
            }
            catch
            {
                txt_statue.Text = "error!";
            }
        }
        /// <summary>
        /// 发送邮件方法
        /// </summary>
        void send_mail()
        {
            MailMessage mms = new MailMessage();
            mms.From = new MailAddress(txt_from.Text);
            mms.To.Add(txt_to.Text);
            mms.Subject = txt_subject.Text;
            mms.Body = txt_body.Text;
            SmtpClient sct = new SmtpClient();
            sct.Credentials = new System.Net.NetworkCredential(txt_from.Text,txt_pwd.Text);
            sct.Host = "smtp.163.com";
            sct.Send(mms);
        }
    }
}
