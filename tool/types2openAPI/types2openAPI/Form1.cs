using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace types2openAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string addLine(string str,string input,int spaceCount)
        {
            string space = "";
            for (int i = 0; i < spaceCount; i++)
                space += " ";
            return str + space + input + '\n';
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            string types = origin.Text;
            List<string> nameList = new List<string>();
            List<string> typeList = new List<string>();
            List<string> descriptionList = new List<string>();
            foreach (var line in types.Split('\n')){
                string newLine = line.Trim();
                string description = newLine.Split("//")[1].Trim();
                string frontOfLine = newLine.Split(';')[0].Trim();
                string name = frontOfLine.Split(": ")[0];
                string type = frontOfLine.Split(": ")[1];
                nameList.Add(name);
                typeList.Add(type);
                descriptionList.Add(description);
            }

            string tmp = "";
            for(var i = 0; i < nameList.Count; i++)
            {
                tmp = addLine(tmp, nameList[i] + ":",8);
                tmp = addLine(tmp, "type: " + typeList[i],10);
                tmp = addLine(tmp, "description: " + descriptionList[i], 10);
            }

            result.Text = tmp;
        }
    }
}
