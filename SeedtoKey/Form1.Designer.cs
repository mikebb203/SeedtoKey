
namespace SeedtoKey
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Seed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Algo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Seed
            // 
            this.Seed.Location = new System.Drawing.Point(67, 130);
            this.Seed.MaxLength = 4;
            this.Seed.Name = "Seed";
            this.Seed.Size = new System.Drawing.Size(75, 23);
            this.Seed.TabIndex = 1;
            this.Seed.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key";
            // 
            // Algo
            // 
            this.Algo.Location = new System.Drawing.Point(67, 51);
            this.Algo.MaxLength = 2;
            this.Algo.Name = "Algo";
            this.Algo.Size = new System.Drawing.Size(75, 23);
            this.Algo.TabIndex = 0;
            this.Algo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Algo #";
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(176, 130);
            this.Key.MaxLength = 4;
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(75, 23);
            this.Key.TabIndex = 7;
            this.Key.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 318);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Algo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Seed);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Seed to Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Seed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Algo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Key;
    }
}

