namespace U3_P2_Practica_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 9);
            label1.Name = "label1";
            label1.Size = new Size(473, 25);
            label1.TabIndex = 0;
            label1.Text = "Este programa suma los numeros capturados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(233, 25);
            label2.TabIndex = 1;
            label2.Text = "Introduce un numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 225);
            label3.Name = "label3";
            label3.Size = new Size(238, 25);
            label3.TabIndex = 2;
            label3.Text = "La suma de todos son:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(251, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 37);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(251, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 37);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(166, 114);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Font = new Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(166, 275);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Sumar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ScrollBar;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(422, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(184, 304);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(625, 364);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Lista y suma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
    }
}