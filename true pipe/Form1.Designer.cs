namespace true_pipe
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.GroupBox groupBoxInputPipe;
            System.Windows.Forms.GroupBox groupBoxOutputPipe;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            this.textBoxArgumentsInputPipe = new System.Windows.Forms.TextBox();
            this.textBoxExacutableFileInputPipe = new System.Windows.Forms.TextBox();
            this.textBoxExacutableFileOutputPipe = new System.Windows.Forms.TextBox();
            this.textBoxArgumentsOutputPipe = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBoxInputPipe = new System.Windows.Forms.GroupBox();
            groupBoxOutputPipe = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBoxInputPipe.SuspendLayout();
            groupBoxOutputPipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(20, 13);
            label1.TabIndex = 1;
            label1.Text = "file";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(159, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 13);
            label2.TabIndex = 1;
            label2.Text = "arguments";
            // 
            // groupBoxInputPipe
            // 
            groupBoxInputPipe.Controls.Add(label1);
            groupBoxInputPipe.Controls.Add(label2);
            groupBoxInputPipe.Controls.Add(this.textBoxArgumentsInputPipe);
            groupBoxInputPipe.Controls.Add(this.textBoxExacutableFileInputPipe);
            groupBoxInputPipe.Location = new System.Drawing.Point(4, 3);
            groupBoxInputPipe.Name = "groupBoxInputPipe";
            groupBoxInputPipe.Size = new System.Drawing.Size(666, 66);
            groupBoxInputPipe.TabIndex = 2;
            groupBoxInputPipe.TabStop = false;
            groupBoxInputPipe.Text = "input pipe";
            // 
            // textBoxArgumentsInputPipe
            // 
            this.textBoxArgumentsInputPipe.Location = new System.Drawing.Point(161, 35);
            this.textBoxArgumentsInputPipe.Name = "textBoxArgumentsInputPipe";
            this.textBoxArgumentsInputPipe.Size = new System.Drawing.Size(499, 20);
            this.textBoxArgumentsInputPipe.TabIndex = 1;
            // 
            // textBoxExacutableFileInputPipe
            // 
            this.textBoxExacutableFileInputPipe.Location = new System.Drawing.Point(8, 35);
            this.textBoxExacutableFileInputPipe.Name = "textBoxExacutableFileInputPipe";
            this.textBoxExacutableFileInputPipe.Size = new System.Drawing.Size(147, 20);
            this.textBoxExacutableFileInputPipe.TabIndex = 0;
            // 
            // groupBoxOutputPipe
            // 
            groupBoxOutputPipe.Controls.Add(label4);
            groupBoxOutputPipe.Controls.Add(label3);
            groupBoxOutputPipe.Controls.Add(this.textBoxExacutableFileOutputPipe);
            groupBoxOutputPipe.Controls.Add(this.textBoxArgumentsOutputPipe);
            groupBoxOutputPipe.Location = new System.Drawing.Point(4, 69);
            groupBoxOutputPipe.Name = "groupBoxOutputPipe";
            groupBoxOutputPipe.Size = new System.Drawing.Size(666, 66);
            groupBoxOutputPipe.TabIndex = 2;
            groupBoxOutputPipe.TabStop = false;
            groupBoxOutputPipe.Text = "output pipe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(8, 18);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(20, 13);
            label4.TabIndex = 1;
            label4.Text = "file";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(159, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 13);
            label3.TabIndex = 1;
            label3.Text = "arguments";
            // 
            // textBoxExacutableFileOutputPipe
            // 
            this.textBoxExacutableFileOutputPipe.Location = new System.Drawing.Point(8, 34);
            this.textBoxExacutableFileOutputPipe.Name = "textBoxExacutableFileOutputPipe";
            this.textBoxExacutableFileOutputPipe.Size = new System.Drawing.Size(147, 20);
            this.textBoxExacutableFileOutputPipe.TabIndex = 2;
            // 
            // textBoxArgumentsOutputPipe
            // 
            this.textBoxArgumentsOutputPipe.Location = new System.Drawing.Point(161, 34);
            this.textBoxArgumentsOutputPipe.Name = "textBoxArgumentsOutputPipe";
            this.textBoxArgumentsOutputPipe.Size = new System.Drawing.Size(499, 20);
            this.textBoxArgumentsOutputPipe.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(588, 142);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 172);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(groupBoxOutputPipe);
            this.Controls.Add(groupBoxInputPipe);
            this.Name = "Form1";
            this.Text = "true pipe";
            this.Load += new System.EventHandler(this.Form1_Load);
            groupBoxInputPipe.ResumeLayout(false);
            groupBoxInputPipe.PerformLayout();
            groupBoxOutputPipe.ResumeLayout(false);
            groupBoxOutputPipe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxExacutableFileInputPipe;
        private System.Windows.Forms.TextBox textBoxArgumentsInputPipe;
        private System.Windows.Forms.TextBox textBoxExacutableFileOutputPipe;
        private System.Windows.Forms.TextBox textBoxArgumentsOutputPipe;
        private System.Windows.Forms.Button buttonStart;
    }
}

