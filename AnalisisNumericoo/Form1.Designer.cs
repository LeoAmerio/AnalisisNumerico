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
            this.functionInput = new System.Windows.Forms.TextBox();
            this.xiValue = new System.Windows.Forms.TextBox();
            this.xdValue = new System.Windows.Forms.TextBox();
            this.toleranceValue = new System.Windows.Forms.TextBox();
            this.iterationValue = new System.Windows.Forms.TextBox();
            this.functionLabel = new System.Windows.Forms.Label();
            this.xiLabel = new System.Windows.Forms.Label();
            this.xdLabel = new System.Windows.Forms.Label();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.biseccionBtn = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // functionInput
            // 
            this.functionInput.Location = new System.Drawing.Point(87, 43);
            this.functionInput.Name = "functionInput";
            this.functionInput.Size = new System.Drawing.Size(123, 20);
            this.functionInput.TabIndex = 0;
            // 
            // xiValue
            // 
            this.xiValue.Location = new System.Drawing.Point(301, 43);
            this.xiValue.Name = "xiValue";
            this.xiValue.Size = new System.Drawing.Size(115, 20);
            this.xiValue.TabIndex = 1;
            // 
            // xdValue
            // 
            this.xdValue.Location = new System.Drawing.Point(490, 43);
            this.xdValue.Name = "xdValue";
            this.xdValue.Size = new System.Drawing.Size(104, 20);
            this.xdValue.TabIndex = 2;
            // 
            // toleranceValue
            // 
            this.toleranceValue.Location = new System.Drawing.Point(137, 149);
            this.toleranceValue.Name = "toleranceValue";
            this.toleranceValue.Size = new System.Drawing.Size(107, 20);
            this.toleranceValue.TabIndex = 3;
            this.toleranceValue.TextChanged += new System.EventHandler(this.toleranceValue_TextChanged);
            // 
            // iterationValue
            // 
            this.iterationValue.Location = new System.Drawing.Point(368, 149);
            this.iterationValue.Name = "iterationValue";
            this.iterationValue.Size = new System.Drawing.Size(134, 20);
            this.iterationValue.TabIndex = 4;
            this.iterationValue.TextChanged += new System.EventHandler(this.iterationValue_TextChanged);
            // 
            // functionLabel
            // 
            this.functionLabel.Location = new System.Drawing.Point(87, 22);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(70, 16);
            this.functionLabel.TabIndex = 5;
            this.functionLabel.Text = "Function";
            // 
            // xiLabel
            // 
            this.xiLabel.Location = new System.Drawing.Point(301, 22);
            this.xiLabel.Name = "xiLabel";
            this.xiLabel.Size = new System.Drawing.Size(66, 18);
            this.xiLabel.TabIndex = 6;
            this.xiLabel.Text = "Xi";
            // 
            // xdLabel
            // 
            this.xdLabel.Location = new System.Drawing.Point(490, 22);
            this.xdLabel.Name = "xdLabel";
            this.xdLabel.Size = new System.Drawing.Size(66, 18);
            this.xdLabel.TabIndex = 7;
            this.xdLabel.Text = "Xd";
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.Location = new System.Drawing.Point(137, 131);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(93, 15);
            this.toleranceLabel.TabIndex = 8;
            this.toleranceLabel.Text = "Tolerance";
            // 
            // iterationLabel
            // 
            this.iterationLabel.Location = new System.Drawing.Point(368, 133);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(73, 13);
            this.iterationLabel.TabIndex = 9;
            this.iterationLabel.Text = "Iterations";
            // 
            // biseccionBtn
            // 
            this.biseccionBtn.Location = new System.Drawing.Point(167, 250);
            this.biseccionBtn.Name = "biseccionBtn";
            this.biseccionBtn.Size = new System.Drawing.Size(113, 41);
            this.biseccionBtn.TabIndex = 10;
            this.biseccionBtn.Text = "Biseccion";
            this.biseccionBtn.UseVisualStyleBackColor = true;
            this.biseccionBtn.Click += new System.EventHandler(this.biseccionBtn_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.Location = new System.Drawing.Point(327, 250);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(136, 31);
            this.warningLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.biseccionBtn);
            this.Controls.Add(this.iterationLabel);
            this.Controls.Add(this.toleranceLabel);
            this.Controls.Add(this.xdLabel);
            this.Controls.Add(this.xiLabel);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.iterationValue);
            this.Controls.Add(this.toleranceValue);
            this.Controls.Add(this.xdValue);
            this.Controls.Add(this.xiValue);
            this.Controls.Add(this.functionInput);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label warningLabel;

        private System.Windows.Forms.Button biseccionBtn;

        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.Label xiLabel;
        private System.Windows.Forms.Label xdLabel;
        private System.Windows.Forms.Label toleranceLabel;
        private System.Windows.Forms.Label iterationLabel;

        private System.Windows.Forms.TextBox toleranceValue;

        private System.Windows.Forms.TextBox iterationValue;
        
        private System.Windows.Forms.TextBox xdValue;

        private System.Windows.Forms.TextBox xiValue;

        private System.Windows.Forms.TextBox functionInput;

        #endregion
    }
}