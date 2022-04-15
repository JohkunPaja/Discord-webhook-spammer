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
using System.IO;
using System.Web;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Media;
using System.Windows;
using System.Xml;
using System.Threading;
using System.CodeDom;
using System.Security;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace AutoBuild
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public static void sendWebHook(string Url, string msg, string Username)
        {

            Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "Username",
                    Username

                },

                {
                    "content",
                    msg

                }
            });
        }
        private void Build_Click(object sender, EventArgs e)
        {
            if (Url.Text == "")
            {
                MessageBox.Show("Please write a message!");
                return;
            }


            if (Url.Text == " ")
            {
                MessageBox.Show("Please write a message!");
                return;
            }


            timer1.Start();
            Consolee.Text = "-- Sending";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            try
            {
            sendWebHook(WebhookUrl.Text, Url.Text, ".");
            int de = 0;
            int.TryParse(Delay.Text, out de);
            Thread.Sleep(de);
            }

            catch
            {
                button1.PerformClick();
                MessageBox.Show("Error, Probably too many requests : (");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Consolee.Text = "-- Stopped";
        }
    }
}

