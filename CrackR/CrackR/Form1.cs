using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrackR
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
            
    }
        public void Writer()
        {
            TextWriter writer = new StreamWriter(path_txt.Text+@"\"+file_name.Text+".vbs",true);
            writer.WriteLine("Dim iURL");
            writer.WriteLine("Dim objShell");
            writer.Write("iURL");
            writer.Write(" = ");
            writer.Write("\"");
            writer.Write(input_txt.Text);
            writer.Write("\"");
            writer.WriteLine("");
            writer.WriteLine("set objShell = CreateObject(\"Shell.Application\")");
            writer.WriteLine("objShell.ShellExecute \"chrome.exe\", iURL, \"\", \"\", 1");
            writer.Close();
            //full_path.Text = "File saved to : "+path_txt.Text + @"\" + file_name.Text + ".vbs";
            DialogResult dialogResult = MessageBox.Show("File saved to : " + path_txt.Text + @"\" + file_name.Text + ".vbs", "Successfully Created Shortcut",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.OK)
            {
                path_txt.Text = "";
                input_txt.Text = "";
                file_name.Text = "";
            }
            
        }
        private void Checker()
        {
            if(Regex.IsMatch(path_txt.Text, @".+(?=\\)"))
            {
                if(file_name.Text!="")
                {
                    if(Regex.IsMatch(input_txt.Text, @"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$"))
                    {
                        Writer();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid webiste url", "Invalid Webiste Url",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a file name", "File Name Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Not a valid file Path", "Path Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void enter_btn_Click(object sender, EventArgs e)
        {
            Checker();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                // shows the path to the selected folder in the folder dialog
                path_txt.Text = fbd.SelectedPath;
        }

        private void full_path_Click(object sender, EventArgs e)
        {

        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink();
        }
        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            link.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            var ps = new ProcessStartInfo("http://www.orjiude.com")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
    }
}