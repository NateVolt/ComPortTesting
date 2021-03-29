
namespace ComPortTesting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.UseFlowControlCheckbox = new System.Windows.Forms.CheckBox();
            this.PortsComboBox = new System.Windows.Forms.ComboBox();
            this.ScanButton = new System.Windows.Forms.Button();
            this.BaudRatesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendAllButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(12, 30);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(434, 390);
            this.ResultsTextBox.TabIndex = 0;
            // 
            // UseFlowControlCheckbox
            // 
            this.UseFlowControlCheckbox.AutoSize = true;
            this.UseFlowControlCheckbox.Location = new System.Drawing.Point(452, 203);
            this.UseFlowControlCheckbox.Name = "UseFlowControlCheckbox";
            this.UseFlowControlCheckbox.Size = new System.Drawing.Size(168, 24);
            this.UseFlowControlCheckbox.TabIndex = 4;
            this.UseFlowControlCheckbox.Text = "Use RTS and DTR";
            this.UseFlowControlCheckbox.UseVisualStyleBackColor = true;
            this.UseFlowControlCheckbox.CheckedChanged += new System.EventHandler(this.UseFlowControlCheckbox_CheckChanged);
            // 
            // PortsComboBox
            // 
            this.PortsComboBox.FormattingEnabled = true;
            this.PortsComboBox.Location = new System.Drawing.Point(533, 36);
            this.PortsComboBox.Name = "PortsComboBox";
            this.PortsComboBox.Size = new System.Drawing.Size(121, 28);
            this.PortsComboBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.PortsComboBox, "Lists all COM ports discovered by the scan button");
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(452, 30);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(75, 39);
            this.ScanButton.TabIndex = 6;
            this.ScanButton.Text = "Scan";
            this.toolTip1.SetToolTip(this.ScanButton, "Scans for all available COM ports");
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // BaudRatesTextBox
            // 
            this.BaudRatesTextBox.Location = new System.Drawing.Point(452, 95);
            this.BaudRatesTextBox.Multiline = true;
            this.BaudRatesTextBox.Name = "BaudRatesTextBox";
            this.BaudRatesTextBox.Size = new System.Drawing.Size(175, 102);
            this.BaudRatesTextBox.TabIndex = 7;
            this.BaudRatesTextBox.Text = "115200, 4800, 57600, 38400, 19200, 9600";
            this.toolTip1.SetToolTip(this.BaudRatesTextBox, "Type in comma separated baud rates to use for testing");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Baud Rates to Use:";
            // 
            // SendAllButton
            // 
            this.SendAllButton.Location = new System.Drawing.Point(452, 233);
            this.SendAllButton.Name = "SendAllButton";
            this.SendAllButton.Size = new System.Drawing.Size(175, 31);
            this.SendAllButton.TabIndex = 11;
            this.SendAllButton.Text = "Send IDN to bauds";
            this.toolTip1.SetToolTip(this.SendAllButton, "Sends \"*IDN?\" on the selected COM port at each specified baud rate. Responses are" +
        " shown in the box to the left.");
            this.SendAllButton.UseVisualStyleBackColor = true;
            this.SendAllButton.Click += new System.EventHandler(this.SendAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.SendAllButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BaudRatesTextBox);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.PortsComboBox);
            this.Controls.Add(this.UseFlowControlCheckbox);
            this.Controls.Add(this.ResultsTextBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.CheckBox UseFlowControlCheckbox;
        private System.Windows.Forms.ComboBox PortsComboBox;
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.TextBox BaudRatesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendAllButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

