namespace AnalisisNumericoo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.unidad1 = new System.Windows.Forms.TabPage();
            this.unidad2 = new System.Windows.Forms.TabPage();
            this.unidad3 = new System.Windows.Forms.TabPage();
            this.unidad4 = new System.Windows.Forms.TabPage();
            this.warningLabel = new System.Windows.Forms.Label();
            this.biseccionBtn = new System.Windows.Forms.Button();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.xdLabel = new System.Windows.Forms.Label();
            this.xiLabel = new System.Windows.Forms.Label();
            this.functionLabel = new System.Windows.Forms.Label();
            this.iterationValue = new System.Windows.Forms.TextBox();
            this.toleranceValue = new System.Windows.Forms.TextBox();
            this.xdValue = new System.Windows.Forms.TextBox();
            this.xiValue = new System.Windows.Forms.TextBox();
            this.functionInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.unidad1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.unidad1);
            this.tabControl1.Controls.Add(this.unidad2);
            this.tabControl1.Controls.Add(this.unidad3);
            this.tabControl1.Controls.Add(this.unidad4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 503);
            this.tabControl1.TabIndex = 12;
            // 
            // unidad1
            // 
            this.unidad1.Controls.Add(this.warningLabel);
            this.unidad1.Controls.Add(this.biseccionBtn);
            this.unidad1.Controls.Add(this.iterationLabel);
            this.unidad1.Controls.Add(this.toleranceLabel);
            this.unidad1.Controls.Add(this.xdLabel);
            this.unidad1.Controls.Add(this.xiLabel);
            this.unidad1.Controls.Add(this.functionLabel);
            this.unidad1.Controls.Add(this.iterationValue);
            this.unidad1.Controls.Add(this.toleranceValue);
            this.unidad1.Controls.Add(this.xdValue);
            this.unidad1.Controls.Add(this.xiValue);
            this.unidad1.Controls.Add(this.functionInput);
            this.unidad1.Location = new System.Drawing.Point(4, 25);
            this.unidad1.Name = "unidad1";
            this.unidad1.Padding = new System.Windows.Forms.Padding(3);
            this.unidad1.Size = new System.Drawing.Size(1032, 474);
            this.unidad1.TabIndex = 0;
            this.unidad1.Text = "Unidad_1";
            this.unidad1.UseVisualStyleBackColor = true;
            this.unidad1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // unidad2
            // 
            this.unidad2.Location = new System.Drawing.Point(4, 25);
            this.unidad2.Name = "unidad2";
            this.unidad2.Padding = new System.Windows.Forms.Padding(3);
            this.unidad2.Size = new System.Drawing.Size(995, 476);
            this.unidad2.TabIndex = 1;
            this.unidad2.Text = "Unidad_2";
            this.unidad2.UseVisualStyleBackColor = true;
            // 
            // unidad3
            // 
            this.unidad3.Location = new System.Drawing.Point(4, 25);
            this.unidad3.Name = "unidad3";
            this.unidad3.Size = new System.Drawing.Size(995, 476);
            this.unidad3.TabIndex = 2;
            this.unidad3.Text = "Unidad_3";
            this.unidad3.UseVisualStyleBackColor = true;
            // 
            // unidad4
            // 
            this.unidad4.Location = new System.Drawing.Point(4, 25);
            this.unidad4.Name = "unidad4";
            this.unidad4.Size = new System.Drawing.Size(995, 476);
            this.unidad4.TabIndex = 3;
            this.unidad4.Text = "Unidad_4";
            this.unidad4.UseVisualStyleBackColor = true;
            // 
            // warningLabel
            // 
            this.warningLabel.Location = new System.Drawing.Point(329, 304);
            this.warningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(181, 38);
            this.warningLabel.TabIndex = 23;
            // 
            // biseccionBtn
            // 
            this.biseccionBtn.Location = new System.Drawing.Point(116, 304);
            this.biseccionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.biseccionBtn.Name = "biseccionBtn";
            this.biseccionBtn.Size = new System.Drawing.Size(151, 50);
            this.biseccionBtn.TabIndex = 22;
            this.biseccionBtn.Text = "Biseccion";
            this.biseccionBtn.UseVisualStyleBackColor = true;
            // 
            // iterationLabel
            // 
            this.iterationLabel.Location = new System.Drawing.Point(384, 160);
            this.iterationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(97, 16);
            this.iterationLabel.TabIndex = 21;
            this.iterationLabel.Text = "Iterations";
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.Location = new System.Drawing.Point(76, 157);
            this.toleranceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(124, 18);
            this.toleranceLabel.TabIndex = 20;
            this.toleranceLabel.Text = "Tolerance";
            // 
            // xdLabel
            // 
            this.xdLabel.Location = new System.Drawing.Point(546, 23);
            this.xdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xdLabel.Name = "xdLabel";
            this.xdLabel.Size = new System.Drawing.Size(88, 22);
            this.xdLabel.TabIndex = 19;
            this.xdLabel.Text = "Xd";
            // 
            // xiLabel
            // 
            this.xiLabel.Location = new System.Drawing.Point(294, 23);
            this.xiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xiLabel.Name = "xiLabel";
            this.xiLabel.Size = new System.Drawing.Size(88, 22);
            this.xiLabel.TabIndex = 18;
            this.xiLabel.Text = "Xi";
            // 
            // functionLabel
            // 
            this.functionLabel.Location = new System.Drawing.Point(9, 23);
            this.functionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(93, 20);
            this.functionLabel.TabIndex = 17;
            this.functionLabel.Text = "Function";
            // 
            // iterationValue
            // 
            this.iterationValue.Location = new System.Drawing.Point(384, 179);
            this.iterationValue.Margin = new System.Windows.Forms.Padding(4);
            this.iterationValue.Name = "iterationValue";
            this.iterationValue.Size = new System.Drawing.Size(177, 22);
            this.iterationValue.TabIndex = 16;
            // 
            // toleranceValue
            // 
            this.toleranceValue.Location = new System.Drawing.Point(76, 179);
            this.toleranceValue.Margin = new System.Windows.Forms.Padding(4);
            this.toleranceValue.Name = "toleranceValue";
            this.toleranceValue.Size = new System.Drawing.Size(141, 22);
            this.toleranceValue.TabIndex = 15;
            // 
            // xdValue
            // 
            this.xdValue.Location = new System.Drawing.Point(546, 49);
            this.xdValue.Margin = new System.Windows.Forms.Padding(4);
            this.xdValue.Name = "xdValue";
            this.xdValue.Size = new System.Drawing.Size(137, 22);
            this.xdValue.TabIndex = 14;
            // 
            // xiValue
            // 
            this.xiValue.Location = new System.Drawing.Point(294, 49);
            this.xiValue.Margin = new System.Windows.Forms.Padding(4);
            this.xiValue.Name = "xiValue";
            this.xiValue.Size = new System.Drawing.Size(152, 22);
            this.xiValue.TabIndex = 13;
            // 
            // functionInput
            // 
            this.functionInput.Location = new System.Drawing.Point(9, 49);
            this.functionInput.Margin = new System.Windows.Forms.Padding(4);
            this.functionInput.Name = "functionInput";
            this.functionInput.Size = new System.Drawing.Size(163, 22);
            this.functionInput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.unidad1.ResumeLayout(false);
            this.unidad1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage unidad1;
        private System.Windows.Forms.TabPage unidad2;
        private System.Windows.Forms.TabPage unidad3;
        private System.Windows.Forms.TabPage unidad4;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button biseccionBtn;
        private System.Windows.Forms.Label iterationLabel;
        private System.Windows.Forms.Label toleranceLabel;
        private System.Windows.Forms.Label xdLabel;
        private System.Windows.Forms.Label xiLabel;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.TextBox iterationValue;
        private System.Windows.Forms.TextBox toleranceValue;
        private System.Windows.Forms.TextBox xdValue;
        private System.Windows.Forms.TextBox xiValue;
        private System.Windows.Forms.TextBox functionInput;
    }
}