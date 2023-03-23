namespace TakeHomeW3_RickyJonathan_0706022210005
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1name = new System.Windows.Forms.TextBox();
            this.textBox2artist = new System.Windows.Forms.TextBox();
            this.checkBox1true = new System.Windows.Forms.CheckBox();
            this.button1submit = new System.Windows.Forms.Button();
            this.buttonnextform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "My Favorite Artist";
            // 
            // textBox1name
            // 
            this.textBox1name.Location = new System.Drawing.Point(192, 67);
            this.textBox1name.Name = "textBox1name";
            this.textBox1name.Size = new System.Drawing.Size(100, 26);
            this.textBox1name.TabIndex = 2;
            this.textBox1name.TextChanged += new System.EventHandler(this.textBox1name_TextChanged);
            // 
            // textBox2artist
            // 
            this.textBox2artist.Location = new System.Drawing.Point(192, 128);
            this.textBox2artist.Name = "textBox2artist";
            this.textBox2artist.Size = new System.Drawing.Size(100, 26);
            this.textBox2artist.TabIndex = 3;
            // 
            // checkBox1true
            // 
            this.checkBox1true.AutoSize = true;
            this.checkBox1true.Location = new System.Drawing.Point(40, 197);
            this.checkBox1true.Name = "checkBox1true";
            this.checkBox1true.Size = new System.Drawing.Size(289, 24);
            this.checkBox1true.TabIndex = 4;
            this.checkBox1true.Text = "All of the content I put above is true!";
            this.checkBox1true.UseVisualStyleBackColor = true;
            this.checkBox1true.CheckedChanged += new System.EventHandler(this.checkBox1true_CheckedChanged);
            // 
            // button1submit
            // 
            this.button1submit.Enabled = false;
            this.button1submit.Location = new System.Drawing.Point(624, 403);
            this.button1submit.Name = "button1submit";
            this.button1submit.Size = new System.Drawing.Size(75, 35);
            this.button1submit.TabIndex = 5;
            this.button1submit.Text = "Submit";
            this.button1submit.UseVisualStyleBackColor = true;
            this.button1submit.Click += new System.EventHandler(this.button1submit_Click);
            // 
            // buttonnextform
            // 
            this.buttonnextform.Location = new System.Drawing.Point(713, 403);
            this.buttonnextform.Name = "buttonnextform";
            this.buttonnextform.Size = new System.Drawing.Size(75, 35);
            this.buttonnextform.TabIndex = 6;
            this.buttonnextform.Text = "Next Form";
            this.buttonnextform.UseVisualStyleBackColor = true;
            this.buttonnextform.Click += new System.EventHandler(this.buttonnextform_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonnextform);
            this.Controls.Add(this.button1submit);
            this.Controls.Add(this.checkBox1true);
            this.Controls.Add(this.textBox2artist);
            this.Controls.Add(this.textBox1name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1name;
        private System.Windows.Forms.TextBox textBox2artist;
        private System.Windows.Forms.CheckBox checkBox1true;
        private System.Windows.Forms.Button button1submit;
        private System.Windows.Forms.Button buttonnextform;
    }
}

