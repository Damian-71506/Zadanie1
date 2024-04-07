
namespace Zadanie1
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
            this.dzielnaBox = new System.Windows.Forms.TextBox();
            this.obliczButton = new System.Windows.Forms.Button();
            this.dzielnikBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dzielnaBox
            // 
            this.dzielnaBox.Location = new System.Drawing.Point(34, 47);
            this.dzielnaBox.Name = "dzielnaBox";
            this.dzielnaBox.Size = new System.Drawing.Size(100, 20);
            this.dzielnaBox.TabIndex = 0;
            // 
            // obliczButton
            // 
            this.obliczButton.Location = new System.Drawing.Point(34, 87);
            this.obliczButton.Name = "obliczButton";
            this.obliczButton.Size = new System.Drawing.Size(75, 23);
            this.obliczButton.TabIndex = 1;
            this.obliczButton.Text = "Oblicz";
            this.obliczButton.UseVisualStyleBackColor = true;
            this.obliczButton.Click += new System.EventHandler(this.obliczButton_Click);
            // 
            // dzielnikBox
            // 
            this.dzielnikBox.Location = new System.Drawing.Point(140, 47);
            this.dzielnikBox.Name = "dzielnikBox";
            this.dzielnikBox.Size = new System.Drawing.Size(100, 20);
            this.dzielnikBox.TabIndex = 2;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(140, 90);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dzielna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dzielnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 166);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.dzielnikBox);
            this.Controls.Add(this.obliczButton);
            this.Controls.Add(this.dzielnaBox);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dzielnaBox;
        private System.Windows.Forms.Button obliczButton;
        private System.Windows.Forms.TextBox dzielnikBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

