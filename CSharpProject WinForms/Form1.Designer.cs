namespace CSharpProject_WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unitSelection2 = new System.Windows.Forms.ComboBox();
            this.unitSelection1 = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.outputUnitBox = new System.Windows.Forms.TextBox();
            this.inputUnitBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unitSelection2);
            this.groupBox1.Controls.Add(this.unitSelection1);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.outputUnitBox);
            this.groupBox1.Controls.Add(this.inputUnitBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(321, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Length Unit Conversion";
            // 
            // unitSelection2
            // 
            this.unitSelection2.FormattingEnabled = true;
            this.unitSelection2.Items.AddRange(new object[] {
            "Nm",
            "μm",
            "Mm",
            "Cm",
            "M",
            "Km",
            "Mile",
            "Yard",
            "Foot",
            "Inch",
            "Nautical Miles"});
            this.unitSelection2.Location = new System.Drawing.Point(155, 140);
            this.unitSelection2.Margin = new System.Windows.Forms.Padding(4);
            this.unitSelection2.Name = "unitSelection2";
            this.unitSelection2.Size = new System.Drawing.Size(160, 24);
            this.unitSelection2.TabIndex = 4;
            // 
            // unitSelection1
            // 
            this.unitSelection1.FormattingEnabled = true;
            this.unitSelection1.Items.AddRange(new object[] {
            "Nm",
            "μm",
            "Mm",
            "Cm",
            "M",
            "Km",
            "Mile",
            "Yard",
            "Foot",
            "Inch",
            "Nautical Miles"});
            this.unitSelection1.Location = new System.Drawing.Point(155, 33);
            this.unitSelection1.Margin = new System.Windows.Forms.Padding(4);
            this.unitSelection1.Name = "unitSelection1";
            this.unitSelection1.Size = new System.Drawing.Size(160, 24);
            this.unitSelection1.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(96, 89);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(73, 28);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // outputUnitBox
            // 
            this.outputUnitBox.Location = new System.Drawing.Point(5, 142);
            this.outputUnitBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputUnitBox.Name = "outputUnitBox";
            this.outputUnitBox.ReadOnly = true;
            this.outputUnitBox.Size = new System.Drawing.Size(100, 22);
            this.outputUnitBox.TabIndex = 1;
            // 
            // inputUnitBox
            // 
            this.inputUnitBox.Location = new System.Drawing.Point(5, 34);
            this.inputUnitBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputUnitBox.Name = "inputUnitBox";
            this.inputUnitBox.Size = new System.Drawing.Size(100, 22);
            this.inputUnitBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(343, 204);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Unit Conversion Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox outputUnitBox;
        private System.Windows.Forms.TextBox inputUnitBox;
        private System.Windows.Forms.ComboBox unitSelection2;
        private System.Windows.Forms.ComboBox unitSelection1;
    }
}

