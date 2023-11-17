namespace Currency
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CountriesCheckBox = new CheckedListBox();
            CountriesLabel = new Label();
            ConversionLabel = new Label();
            ConversionTextBox = new TextBox();
            ConversionButton = new Button();
            AllCheckBox = new CheckBox();
            OutputRichTextBox = new RichTextBox();
            SaveLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // CountriesCheckBox
            // 
            CountriesCheckBox.FormattingEnabled = true;
            CountriesCheckBox.Location = new Point(25, 89);
            CountriesCheckBox.Name = "CountriesCheckBox";
            CountriesCheckBox.Size = new Size(291, 592);
            CountriesCheckBox.TabIndex = 0;
            // 
            // CountriesLabel
            // 
            CountriesLabel.AutoSize = true;
            CountriesLabel.Location = new Point(25, 61);
            CountriesLabel.Name = "CountriesLabel";
            CountriesLabel.Size = new Size(87, 25);
            CountriesLabel.TabIndex = 1;
            CountriesLabel.Text = "Countries";
            // 
            // ConversionLabel
            // 
            ConversionLabel.AutoSize = true;
            ConversionLabel.Location = new Point(25, 15);
            ConversionLabel.Name = "ConversionLabel";
            ConversionLabel.Size = new Size(140, 25);
            ConversionLabel.TabIndex = 2;
            ConversionLabel.Text = "USD to Convert:";
            // 
            // ConversionTextBox
            // 
            ConversionTextBox.Location = new Point(171, 15);
            ConversionTextBox.Name = "ConversionTextBox";
            ConversionTextBox.Size = new Size(145, 31);
            ConversionTextBox.TabIndex = 3;
            // 
            // ConversionButton
            // 
            ConversionButton.Location = new Point(334, 46);
            ConversionButton.Name = "ConversionButton";
            ConversionButton.Size = new Size(350, 34);
            ConversionButton.TabIndex = 5;
            ConversionButton.Text = "Convert";
            ConversionButton.UseVisualStyleBackColor = true;
            ConversionButton.Click += ConversionButton_Click;
            // 
            // AllCheckBox
            // 
            AllCheckBox.AutoSize = true;
            AllCheckBox.Location = new Point(188, 57);
            AllCheckBox.Name = "AllCheckBox";
            AllCheckBox.Size = new Size(125, 29);
            AllCheckBox.TabIndex = 6;
            AllCheckBox.Text = "Convert All";
            AllCheckBox.UseVisualStyleBackColor = true;
            AllCheckBox.CheckStateChanged += AllCheckBox_CheckStateChanged;
            // 
            // OutputRichTextBox
            // 
            OutputRichTextBox.Location = new Point(334, 86);
            OutputRichTextBox.Name = "OutputRichTextBox";
            OutputRichTextBox.Size = new Size(350, 595);
            OutputRichTextBox.TabIndex = 7;
            OutputRichTextBox.Text = "";
            // 
            // SaveLinkLabel
            // 
            SaveLinkLabel.AutoSize = true;
            SaveLinkLabel.Location = new Point(527, 9);
            SaveLinkLabel.Name = "SaveLinkLabel";
            SaveLinkLabel.Size = new Size(157, 25);
            SaveLinkLabel.TabIndex = 8;
            SaveLinkLabel.TabStop = true;
            SaveLinkLabel.Text = "Export Conversion";
            SaveLinkLabel.LinkClicked += SaveLinkLabel_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 693);
            Controls.Add(SaveLinkLabel);
            Controls.Add(OutputRichTextBox);
            Controls.Add(AllCheckBox);
            Controls.Add(ConversionButton);
            Controls.Add(ConversionTextBox);
            Controls.Add(ConversionLabel);
            Controls.Add(CountriesLabel);
            Controls.Add(CountriesCheckBox);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox CountriesCheckBox;
        private Label CountriesLabel;
        private Label ConversionLabel;
        private TextBox ConversionTextBox;
        private Button ConversionButton;
        private CheckBox AllCheckBox;
        private RichTextBox OutputRichTextBox;
        private LinkLabel SaveLinkLabel;
    }
}