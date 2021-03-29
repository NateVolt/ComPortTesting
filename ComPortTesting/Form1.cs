using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPortTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UseFlowControlCheckbox_CheckChanged(object sender, EventArgs e)
        {
            ComObject.UseRtsAndDtr = UseFlowControlCheckbox.Checked;
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            PortsComboBox.DataSource = ComObject.GetAllPorts();
        }

        private int[] GetAllSelectedBauds()
        {
            string text = BaudRatesTextBox.Text;
            string[] splitBaudsText = text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            var bauds = new List<int>();
            foreach (string baudText in splitBaudsText)
            {
                if (int.TryParse(baudText, out int baud))
                {
                    bauds.Add(baud);
                }
                else
                {
                    bauds.Add(int.MinValue);
                }
            }
            return bauds.ToArray();
        }

        private void SendAllButton_Click(object sender, EventArgs e)
        {
            ResultsTextBox.Clear();
            var responses = ComObject.GetResponsesAtBaudRate(PortsComboBox.SelectedItem.ToString(), GetAllSelectedBauds());
            string result = string.Join("\r\n", responses.Select(x => $"Baud {x.Key},{x.Value ?? "No response"}"));
            ResultsTextBox.Text = result;
        }
    }
}
