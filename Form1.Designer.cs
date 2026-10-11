namespace PizzaGUI
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            Pizzanev = new Label();
            Ar = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            reszossz = new Label();
            kiszallitas = new Label();
            vegossz = new Label();
            kosar = new Button();
            rendeles = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "csak vegetáriánus";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(197, 29);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(85, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "csak csípős";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(534, 29);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 4;
            label1.Text = "Kosár";
            // 
            // Pizzanev
            // 
            Pizzanev.AutoSize = true;
            Pizzanev.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Pizzanev.Location = new Point(136, 333);
            Pizzanev.Name = "Pizzanev";
            Pizzanev.Size = new Size(46, 21);
            Pizzanev.TabIndex = 5;
            Pizzanev.Text = "####";
            // 
            // Ar
            // 
            Ar.AutoSize = true;
            Ar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Ar.Location = new Point(273, 333);
            Ar.Name = "Ar";
            Ar.Size = new Size(46, 21);
            Ar.TabIndex = 6;
            Ar.Text = "####";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(230, 333);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 7;
            label2.Text = "ár:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(26, 333);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 8;
            label3.Text = "kijelölt pizza: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(26, 382);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 9;
            label4.Text = "darab:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(26, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(431, 229);
            listBox1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(529, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(259, 229);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(534, 314);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 12;
            label5.Text = "részösszeg:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(534, 339);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 13;
            label6.Text = "kiszállítás: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(534, 367);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 14;
            label7.Text = "végösszeg:";
            // 
            // reszossz
            // 
            reszossz.AutoSize = true;
            reszossz.Location = new Point(663, 314);
            reszossz.Name = "reszossz";
            reszossz.Size = new Size(35, 15);
            reszossz.TabIndex = 15;
            reszossz.Text = "####";
            // 
            // kiszallitas
            // 
            kiszallitas.AutoSize = true;
            kiszallitas.Location = new Point(663, 339);
            kiszallitas.Name = "kiszallitas";
            kiszallitas.Size = new Size(35, 15);
            kiszallitas.TabIndex = 16;
            kiszallitas.Text = "####";
            // 
            // vegossz
            // 
            vegossz.AutoSize = true;
            vegossz.Location = new Point(663, 367);
            vegossz.Name = "vegossz";
            vegossz.Size = new Size(35, 15);
            vegossz.TabIndex = 17;
            vegossz.Text = "####";
            // 
            // kosar
            // 
            kosar.Location = new Point(162, 373);
            kosar.Name = "kosar";
            kosar.Size = new Size(95, 39);
            kosar.TabIndex = 18;
            kosar.Text = "Kosárba";
            kosar.UseVisualStyleBackColor = true;
            // 
            // rendeles
            // 
            rendeles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rendeles.Location = new Point(534, 398);
            rendeles.Name = "rendeles";
            rendeles.Size = new Size(187, 40);
            rendeles.TabIndex = 19;
            rendeles.Text = "Rendelés leadása";
            rendeles.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 382);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(60, 23);
            textBox1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(rendeles);
            Controls.Add(kosar);
            Controls.Add(vegossz);
            Controls.Add(kiszallitas);
            Controls.Add(reszossz);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Ar);
            Controls.Add(Pizzanev);
            Controls.Add(label1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Pizzarendelés";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private Label Pizzanev;
        private Label Ar;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label reszossz;
        private Label kiszallitas;
        private Label vegossz;
        private Button kosar;
        private Button rendeles;
        private TextBox textBox1;
    }
}
