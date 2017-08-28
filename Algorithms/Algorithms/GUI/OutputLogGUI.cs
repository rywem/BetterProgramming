using Algorithms.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms.GUI
{
    public partial class OutputLogGUI : Form
    {
        public OutputLogGUI()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAdd.Text != null || textBoxAdd.Text != string.Empty)
            {
                Program.output.Add(new DataClasses.Output() { startTime = DateTime.Now, endTime = DateTime.Now, title = "Manual Output Message", message = textBoxAdd.Text, status = "OK" });
            }
        }

        private void OutputLogGUI_Load(object sender, EventArgs e)
        {
            if (Program.output != null || Program.output.Count > 0)
            {
                foreach (var output in Program.output)
                {
                    /*
                    richTextBoxOutput.Text += string.Format("Title: {0}, Status: {1}\r\nMessage: {2}, \r\nDistance: {3} \r\nTime:{4}", output.title, output.status,
                                                           output.message, output.distance.ToString(), output.time);
                    richTextBoxOutput.Text += "\r\n..........................";*/
                    richTextBoxOutput.Text += OutputToString(output);
                }
            }
        }

        private string OutputToString(Output output)
        {

            string title = output.title != string.Empty ? string.Format("Title: {0} \r\n", output.title) : string.Empty;
            string type = output.type != string.Empty ? string.Format("type: {0} \r\n", output.type) : string.Empty;
            string status = output.status != string.Empty ? string.Format("Status: {0} \r\n", output.status) : string.Empty;
            string msg = output.message != string.Empty ? string.Format("Message: {0} \r\n", output.message) : string.Empty;
            string elements = output.elements > 0 ? string.Format("Elements: {0} \r\n", output.elements.ToString()) : string.Empty;
            string distance = output.distance > 0.0f ? string.Format("Distance: {0} \r\n", output.distance.ToString()) : string.Empty;
            string time = string.Format("{0}\r\n", output.time);
            string line = string.Format(".......................................\r\n");
            return title + type + status + msg + elements + distance + time + line;
        }
    }
}
