using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web;
using System.Xml;
using Microsoft.VisualBasic;
using System.Collections;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;

namespace Emails_Projeto
{
    public partial class Form1 : Form
    {
        string message_subject;

        string message_author;

        string tagline;

        string message_summary;
        private object listBox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_Click(object sender, EventArgs e)
        {

            Getfeeds();

        }



        public void GetAllmails()
        {
            System.Net.WebClient objeclient = new WebClient();

            string response = null;

            XmlDocument xdoc = new XmlDocument();



            try
            {

                objeclient.Credentials = new System.Net.NetworkCredential(txtNome.Text.Trim(), textBox2.Text.Trim());

                response = Encoding.UTF8.GetString(objeclient.DownloadData("https://mail.google.com/mail/feed/atom"));

                response = response.Replace("<feed version=\"0.3\" xmlns=\"http://purl.org/atom/ns#\">", "<feed>");

                xdoc.LoadXml(response);

                if (response != null)
                {

                    foreach (XmlNode node in xdoc.SelectNodes("feed/entry"))
                    {
                        listBox2.Items.Add(node.SelectSingleNode("title").InnerText + node.SelectSingleNode("summary").InnerText);


                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        public void Getfeeds()
        {
            System.Net.WebClient webClient = new WebClient();

            XmlNodeList nodelist = default(XmlNodeList);

            XmlNode node = default(XmlNode);

            XmlNode node2 = default(XmlNode);

            string response = null;

            XmlDocument xdoc = new XmlDocument();


            try
            {

                webClient.Credentials = new NetworkCredential(txtNome.Text.Trim(), textBox2.Text.Trim());

                response = Encoding.UTF8.GetString(webClient.DownloadData("https://mail.google.com/mail/feed/atom"));

                response = response.Replace("<feed version=\"0.3\" xmlns=\"http://purl.org/atom/ns#\">", "<feed>");

                xdoc.LoadXml(response);

                node = xdoc.SelectSingleNode("/feed/fullcount");

                Variables.mailcount = Convert.ToInt16(node.InnerText);

                MessageBox.Show("currently we have" + Variables.mailcount + "emails");

                tagline = xdoc.SelectSingleNode("/feed/tagline").InnerText;

                MessageBox.Show("sir , you have" + tagline);

                if (Variables.mailcount > 0)
                {
                    node2 = xdoc.SelectSingleNode("feed").SelectSingleNode("entry");

                    message_subject = node2.SelectSingleNode("title").InnerText;

                    message_author = node2.SelectSingleNode("author").SelectSingleNode("name").InnerText;

                    message_summary = node2.SelectSingleNode("summary").InnerText;

                    MessageBox.Show("sir, a message from" + message_author.ToString());

                    MessageBox.Show("the subject is" + message_subject);

                    MessageBox.Show("the summary of message is");

                    MessageBox.Show(message_summary.ToString());




                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            GetAllmails();
        }

        private void btnObterTodosemails_Click(object sender, EventArgs e)
        {
            GetAllmails();
        }

        private void btnObter_Click(object sender, EventArgs e)
        {
            Getfeeds();
        }

    }

}
