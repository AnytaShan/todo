namespace WinFormsApp1
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
            textBox1 = new TextBox();
            Addbutton1 = new Button();
            Delbutton = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 90);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 151);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Addbutton1
            // 
            Addbutton1.Location = new Point(22, 255);
            Addbutton1.Name = "Addbutton1";
            Addbutton1.Size = new Size(105, 23);
            Addbutton1.TabIndex = 1;
            Addbutton1.Text = "Добавить";
            Addbutton1.UseVisualStyleBackColor = true;
            Addbutton1.Click += Addbutton1_Click;
            // 
            // Delbutton
            // 
            Delbutton.Location = new Point(358, 255);
            Delbutton.Name = "Delbutton";
            Delbutton.Size = new Size(144, 23);
            Delbutton.TabIndex = 5;
            Delbutton.Text = "Удалить";
            Delbutton.UseVisualStyleBackColor = true;
            Delbutton.Click += Delbutton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(358, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(304, 229);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(124, 12);
            button2.Name = "button2";
            button2.Size = new Size(97, 50);
            button2.TabIndex = 7;
            button2.Text = "Открыть чек-лист";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(22, 12);
            button1.Name = "button1";
            button1.Size = new Size(105, 50);
            button1.TabIndex = 8;
            button1.Text = "Сохранить чек-лист";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 537);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(Delbutton);
            Controls.Add(Addbutton1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Addbutton1;
        private Button Delbutton;
        private ListBox listBox1;
        private Button button2;
        private Button button1;
    }
}
