namespace Window
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            printDialog1 = new PrintDialog();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(529, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(868, 892);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(818, 930);
            button1.Name = "button1";
            button1.Size = new Size(190, 34);
            button1.TabIndex = 1;
            button1.Text = "Draw a Card";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1505, 248);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 31);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1851, 1007);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private PrintDialog printDialog1;
        private TextBox textBox1;
    }
}
