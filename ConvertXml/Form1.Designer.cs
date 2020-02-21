namespace ConvertXml
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Convert_Xml = new System.Windows.Forms.Button();
            this.Company_ComboBox = new System.Windows.Forms.ComboBox();
            this.Open_Xml = new System.Windows.Forms.Button();
            this.Xml_FileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Convert_Xml
            // 
            this.Convert_Xml.Location = new System.Drawing.Point(234, 260);
            this.Convert_Xml.Name = "Convert_Xml";
            this.Convert_Xml.Size = new System.Drawing.Size(120, 54);
            this.Convert_Xml.TabIndex = 0;
            this.Convert_Xml.Text = "Vertalen";
            this.Convert_Xml.UseVisualStyleBackColor = true;
            this.Convert_Xml.Click += new System.EventHandler(this.Convert_Xml_Click);
            // 
            // Company_ComboBox
            // 
            this.Company_ComboBox.FormattingEnabled = true;
            this.Company_ComboBox.Location = new System.Drawing.Point(234, 197);
            this.Company_ComboBox.Name = "Company_ComboBox";
            this.Company_ComboBox.Size = new System.Drawing.Size(121, 23);
            this.Company_ComboBox.TabIndex = 3;
            this.Company_ComboBox.SelectedIndexChanged +=
                new System.EventHandler(this.Company_ComboBox_SelectedIndexChanged);
            // 
            // Open_Xml
            // 
            this.Open_Xml.Location = new System.Drawing.Point(43, 28);
            this.Open_Xml.Name = "Open_Xml";
            this.Open_Xml.Size = new System.Drawing.Size(111, 51);
            this.Open_Xml.TabIndex = 4;
            this.Open_Xml.Text = "Open XML";
            this.Open_Xml.UseVisualStyleBackColor = true;
            this.Open_Xml.Click += new System.EventHandler(this.Open_Xml_Click);
            // 
            // Xml_FileName
            // 
            this.Xml_FileName.Location = new System.Drawing.Point(259, 31);
            this.Xml_FileName.Name = "Xml_FileName";
            this.Xml_FileName.ReadOnly = true;
            this.Xml_FileName.Size = new System.Drawing.Size(278, 23);
            this.Xml_FileName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 383);
            this.Controls.Add(this.Xml_FileName);
            this.Controls.Add(this.Open_Xml);
            this.Controls.Add(this.Company_ComboBox);
            this.Controls.Add(this.Convert_Xml);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Convert_Xml;
        private System.Windows.Forms.Button Open_Xml;
        private System.Windows.Forms.TextBox Xml_FileName;
        private System.Windows.Forms.ComboBox Company_ComboBox;
    }
}

