using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
namespace MavenTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnJarsConfig_Click(object sender, EventArgs e)
        {
            DialogResult jarConfigResult = ofdJarConfig.ShowDialog();
            if (jarConfigResult == DialogResult.OK)
            {
                this.txtJarsConfig.Text = ofdJarConfig.FileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtConsole.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.txtJarsConfig.Text.Length == 0) return;
            
            this.btnStart.Enabled = false;
            XDocument jarsConfig = XDocument.Load(this.txtJarsConfig.Text);
            IEnumerable<XElement> dependencys =  jarsConfig.Root.Elements();
            string jarFolder = Path.GetDirectoryName(ofdJarConfig.FileName)+"\\";
            foreach (var elm in dependencys)
            {
                this.txtConsole.Text += "************开始导入：" +elm.Element("filename").Value+ "************\r\n";
                string command = ConfigurationManager.AppSettings["MAVEN_INSTALL"];
                command = command.Replace("${groupId}", elm.Element("groupId").Value);
                command = command.Replace("${artifactId}", elm.Element("artifactId").Value);
                command = command.Replace("${version}", elm.Element("version").Value);
                command = command.Replace("${filename}", jarFolder+elm.Element("filename").Value);
                this.txtConsole.Text += CmdUtil.Execute(command, 0)+"\r\n";
            }
            this.btnStart.Enabled = true;

        }
    }
}
