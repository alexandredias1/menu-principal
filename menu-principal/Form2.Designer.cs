﻿namespace menu_principal
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            listViewClientes = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 88);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 0;
            label1.Text = "Entrar com o nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 181);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 2;
            label2.Text = "Entre com o e-mail";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 23);
            textBox2.TabIndex = 3;
            // 
            // listViewClientes
            // 
            listViewClientes.Location = new Point(422, 47);
            listViewClientes.Name = "listViewClientes";
            listViewClientes.Size = new Size(287, 313);
            listViewClientes.TabIndex = 4;
            listViewClientes.UseCompatibleStateImageBehavior = false;
            listViewClientes.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(103, 279);
            button1.Name = "button1";
            button1.Size = new Size(113, 42);
            button1.TabIndex = 5;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listViewClientes);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private ListView listViewClientes;
        private Button button1;
    }
}