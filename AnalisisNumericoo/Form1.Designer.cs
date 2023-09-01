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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.secanteBtn = new System.Windows.Forms.Button();
            this.newtonBtn = new System.Windows.Forms.Button();
            this.reglafalsaBtn = new System.Windows.Forms.Button();
            this.biseccionBtn = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.raizResult = new System.Windows.Forms.Label();
            this.raizLabel = new System.Windows.Forms.Label();
            this.errorResult = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.iterResult = new System.Windows.Forms.Label();
            this.iterLabel = new System.Windows.Forms.Label();
            this.convergeResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Resultados = new System.Windows.Forms.Label();
            this.iterValue = new System.Windows.Forms.TextBox();
            this.iter = new System.Windows.Forms.Label();
            this.toleValue = new System.Windows.Forms.TextBox();
            this.tolerancia = new System.Windows.Forms.Label();
            this.xdValue = new System.Windows.Forms.TextBox();
            this.xdLabel = new System.Windows.Forms.Label();
            this.xiValue = new System.Windows.Forms.TextBox();
            this.Xi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.functionInput = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 503);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.secanteBtn);
            this.tabPage1.Controls.Add(this.newtonBtn);
            this.tabPage1.Controls.Add(this.reglafalsaBtn);
            this.tabPage1.Controls.Add(this.biseccionBtn);
            this.tabPage1.Controls.Add(this.warningLabel);
            this.tabPage1.Controls.Add(this.raizResult);
            this.tabPage1.Controls.Add(this.raizLabel);
            this.tabPage1.Controls.Add(this.errorResult);
            this.tabPage1.Controls.Add(this.errorLabel);
            this.tabPage1.Controls.Add(this.iterResult);
            this.tabPage1.Controls.Add(this.iterLabel);
            this.tabPage1.Controls.Add(this.convergeResult);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Resultados);
            this.tabPage1.Controls.Add(this.iterValue);
            this.tabPage1.Controls.Add(this.iter);
            this.tabPage1.Controls.Add(this.toleValue);
            this.tabPage1.Controls.Add(this.tolerancia);
            this.tabPage1.Controls.Add(this.xdValue);
            this.tabPage1.Controls.Add(this.xdLabel);
            this.tabPage1.Controls.Add(this.xiValue);
            this.tabPage1.Controls.Add(this.Xi);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.functionInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unidad_1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(362, 201);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "MÉTODOS ABIERTOS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 201);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "MÉTODOS CERRADOS";
            // 
            // secanteBtn
            // 
            this.secanteBtn.Location = new System.Drawing.Point(465, 223);
            this.secanteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.secanteBtn.Name = "secanteBtn";
            this.secanteBtn.Size = new System.Drawing.Size(100, 28);
            this.secanteBtn.TabIndex = 50;
            this.secanteBtn.Text = "SECANTE";
            this.secanteBtn.UseVisualStyleBackColor = true;
            this.secanteBtn.Click += new System.EventHandler(this.secanteBtn_Click);
            // 
            // newtonBtn
            // 
            this.newtonBtn.Location = new System.Drawing.Point(293, 223);
            this.newtonBtn.Margin = new System.Windows.Forms.Padding(4);
            this.newtonBtn.Name = "newtonBtn";
            this.newtonBtn.Size = new System.Drawing.Size(164, 28);
            this.newtonBtn.TabIndex = 49;
            this.newtonBtn.Text = "NEWTON-RAPHSON";
            this.newtonBtn.UseVisualStyleBackColor = true;
            this.newtonBtn.Click += new System.EventHandler(this.newtonBtn_Click);
            // 
            // reglafalsaBtn
            // 
            this.reglafalsaBtn.Location = new System.Drawing.Point(124, 223);
            this.reglafalsaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reglafalsaBtn.Name = "reglafalsaBtn";
            this.reglafalsaBtn.Size = new System.Drawing.Size(120, 28);
            this.reglafalsaBtn.TabIndex = 48;
            this.reglafalsaBtn.Text = "REGLA FALSA";
            this.reglafalsaBtn.UseVisualStyleBackColor = true;
            this.reglafalsaBtn.Click += new System.EventHandler(this.reglafalsaBtn_Click);
            // 
            // biseccionBtn
            // 
            this.biseccionBtn.Location = new System.Drawing.Point(16, 223);
            this.biseccionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.biseccionBtn.Name = "biseccionBtn";
            this.biseccionBtn.Size = new System.Drawing.Size(100, 28);
            this.biseccionBtn.TabIndex = 47;
            this.biseccionBtn.Text = "BISECCIÓN";
            this.biseccionBtn.UseVisualStyleBackColor = true;
            this.biseccionBtn.Click += new System.EventHandler(this.biseccionBtn_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(20, 120);
            this.warningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 16);
            this.warningLabel.TabIndex = 46;
            // 
            // raizResult
            // 
            this.raizResult.AutoSize = true;
            this.raizResult.Location = new System.Drawing.Point(565, 125);
            this.raizResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.raizResult.Name = "raizResult";
            this.raizResult.Size = new System.Drawing.Size(0, 16);
            this.raizResult.TabIndex = 45;
            // 
            // raizLabel
            // 
            this.raizLabel.AutoSize = true;
            this.raizLabel.Location = new System.Drawing.Point(512, 125);
            this.raizLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.raizLabel.Name = "raizLabel";
            this.raizLabel.Size = new System.Drawing.Size(37, 16);
            this.raizLabel.TabIndex = 44;
            this.raizLabel.Text = "Raíz:";
            // 
            // errorResult
            // 
            this.errorResult.AutoSize = true;
            this.errorResult.Location = new System.Drawing.Point(602, 92);
            this.errorResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorResult.Name = "errorResult";
            this.errorResult.Size = new System.Drawing.Size(0, 16);
            this.errorResult.TabIndex = 43;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(512, 92);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(86, 16);
            this.errorLabel.TabIndex = 42;
            this.errorLabel.Text = "Error relativo:";
            // 
            // iterResult
            // 
            this.iterResult.AutoSize = true;
            this.iterResult.Location = new System.Drawing.Point(648, 75);
            this.iterResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iterResult.Name = "iterResult";
            this.iterResult.Size = new System.Drawing.Size(0, 16);
            this.iterResult.TabIndex = 41;
            // 
            // iterLabel
            // 
            this.iterLabel.AutoSize = true;
            this.iterLabel.Location = new System.Drawing.Point(512, 75);
            this.iterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iterLabel.Name = "iterLabel";
            this.iterLabel.Size = new System.Drawing.Size(128, 16);
            this.iterLabel.TabIndex = 40;
            this.iterLabel.Text = "Cant. de iteraciones:";
            // 
            // convergeResult
            // 
            this.convergeResult.AutoSize = true;
            this.convergeResult.Location = new System.Drawing.Point(598, 59);
            this.convergeResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.convergeResult.Name = "convergeResult";
            this.convergeResult.Size = new System.Drawing.Size(0, 16);
            this.convergeResult.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Converge: ";
            // 
            // Resultados
            // 
            this.Resultados.AutoSize = true;
            this.Resultados.Location = new System.Drawing.Point(512, 27);
            this.Resultados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(79, 16);
            this.Resultados.TabIndex = 37;
            this.Resultados.Text = "Resultados:";
            // 
            // iterValue
            // 
            this.iterValue.Location = new System.Drawing.Point(342, 38);
            this.iterValue.Margin = new System.Windows.Forms.Padding(4);
            this.iterValue.Name = "iterValue";
            this.iterValue.Size = new System.Drawing.Size(132, 22);
            this.iterValue.TabIndex = 36;
            this.iterValue.Text = "100";
            // 
            // iter
            // 
            this.iter.AutoSize = true;
            this.iter.Location = new System.Drawing.Point(225, 41);
            this.iter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iter.Name = "iter";
            this.iter.Size = new System.Drawing.Size(101, 16);
            this.iter.TabIndex = 35;
            this.iter.Text = "Max Iteraciónes";
            // 
            // toleValue
            // 
            this.toleValue.Location = new System.Drawing.Point(342, 9);
            this.toleValue.Margin = new System.Windows.Forms.Padding(4);
            this.toleValue.Name = "toleValue";
            this.toleValue.Size = new System.Drawing.Size(132, 22);
            this.toleValue.TabIndex = 34;
            this.toleValue.Text = "0,0001";
            // 
            // tolerancia
            // 
            this.tolerancia.AutoSize = true;
            this.tolerancia.Location = new System.Drawing.Point(225, 13);
            this.tolerancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tolerancia.Name = "tolerancia";
            this.tolerancia.Size = new System.Drawing.Size(72, 16);
            this.tolerancia.TabIndex = 33;
            this.tolerancia.Text = "Tolerancia";
            // 
            // xdValue
            // 
            this.xdValue.Location = new System.Drawing.Point(49, 66);
            this.xdValue.Margin = new System.Windows.Forms.Padding(4);
            this.xdValue.Name = "xdValue";
            this.xdValue.Size = new System.Drawing.Size(132, 22);
            this.xdValue.TabIndex = 32;
            // 
            // xdLabel
            // 
            this.xdLabel.AutoSize = true;
            this.xdLabel.Location = new System.Drawing.Point(9, 70);
            this.xdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xdLabel.Name = "xdLabel";
            this.xdLabel.Size = new System.Drawing.Size(23, 16);
            this.xdLabel.TabIndex = 31;
            this.xdLabel.Text = "Xd";
            // 
            // xiValue
            // 
            this.xiValue.Location = new System.Drawing.Point(49, 38);
            this.xiValue.Margin = new System.Windows.Forms.Padding(4);
            this.xiValue.Name = "xiValue";
            this.xiValue.Size = new System.Drawing.Size(132, 22);
            this.xiValue.TabIndex = 30;
            // 
            // Xi
            // 
            this.Xi.AutoSize = true;
            this.Xi.Location = new System.Drawing.Point(9, 41);
            this.Xi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Xi.Name = "Xi";
            this.Xi.Size = new System.Drawing.Size(18, 16);
            this.Xi.TabIndex = 29;
            this.Xi.Text = "Xi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "F(x)";
            // 
            // functionInput
            // 
            this.functionInput.Location = new System.Drawing.Point(49, 9);
            this.functionInput.Margin = new System.Windows.Forms.Padding(4);
            this.functionInput.Name = "functionInput";
            this.functionInput.Size = new System.Drawing.Size(132, 22);
            this.functionInput.TabIndex = 27;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unidad_2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1032, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Unidad_3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1032, 474);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Unidad_4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 554);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Analisis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button secanteBtn;
        private System.Windows.Forms.Button newtonBtn;
        private System.Windows.Forms.Button reglafalsaBtn;
        private System.Windows.Forms.Button biseccionBtn;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label raizResult;
        private System.Windows.Forms.Label raizLabel;
        private System.Windows.Forms.Label errorResult;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label iterResult;
        private System.Windows.Forms.Label iterLabel;
        private System.Windows.Forms.Label convergeResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Resultados;
        private System.Windows.Forms.TextBox iterValue;
        private System.Windows.Forms.Label iter;
        private System.Windows.Forms.TextBox toleValue;
        private System.Windows.Forms.Label tolerancia;
        private System.Windows.Forms.TextBox xdValue;
        private System.Windows.Forms.Label xdLabel;
        private System.Windows.Forms.TextBox xiValue;
        private System.Windows.Forms.Label Xi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox functionInput;
    }
}