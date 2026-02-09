namespace Pilha_fila
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
            Pilha = new ListBox();
            Fila = new ListBox();
            Adicionarpilha = new Button();
            Removerpilha = new Button();
            AdicionarFila = new Button();
            RemoverFila = new Button();
            textPilha = new TextBox();
            textFila = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Pilha
            // 
            Pilha.FormatString = "txtPilha";
            Pilha.FormattingEnabled = true;
            Pilha.ItemHeight = 15;
            Pilha.Location = new Point(12, 73);
            Pilha.Name = "Pilha";
            Pilha.Size = new Size(301, 274);
            Pilha.TabIndex = 0;
            // 
            // Fila
            // 
            Fila.FormatString = "txtFila";
            Fila.FormattingEnabled = true;
            Fila.ItemHeight = 15;
            Fila.Location = new Point(487, 73);
            Fila.Name = "Fila";
            Fila.Size = new Size(301, 274);
            Fila.TabIndex = 1;
            // 
            // Adicionarpilha
            // 
            Adicionarpilha.Location = new Point(238, 367);
            Adicionarpilha.Name = "Adicionarpilha";
            Adicionarpilha.Size = new Size(75, 23);
            Adicionarpilha.TabIndex = 2;
            Adicionarpilha.Text = "+";
            Adicionarpilha.UseVisualStyleBackColor = true;
            Adicionarpilha.Click += Adicionarpilha_Click;
            // 
            // Removerpilha
            // 
            Removerpilha.Location = new Point(238, 415);
            Removerpilha.Name = "Removerpilha";
            Removerpilha.Size = new Size(75, 23);
            Removerpilha.TabIndex = 3;
            Removerpilha.Text = "-";
            Removerpilha.UseVisualStyleBackColor = true;
            Removerpilha.Click += Removerpilha_Click;
            // 
            // AdicionarFila
            // 
            AdicionarFila.Location = new Point(487, 367);
            AdicionarFila.Name = "AdicionarFila";
            AdicionarFila.Size = new Size(75, 23);
            AdicionarFila.TabIndex = 4;
            AdicionarFila.Text = "+";
            AdicionarFila.UseVisualStyleBackColor = true;
            AdicionarFila.Click += AdicionarFila_Click;
            // 
            // RemoverFila
            // 
            RemoverFila.Location = new Point(487, 415);
            RemoverFila.Name = "RemoverFila";
            RemoverFila.Size = new Size(75, 23);
            RemoverFila.TabIndex = 5;
            RemoverFila.Text = "-";
            RemoverFila.UseVisualStyleBackColor = true;
            RemoverFila.Click += RemoverFila_Click;
            // 
            // textPilha
            // 
            textPilha.Location = new Point(12, 393);
            textPilha.Name = "textPilha";
            textPilha.Size = new Size(191, 23);
            textPilha.TabIndex = 6;
            // 
            // textFila
            // 
            textFila.Location = new Point(568, 393);
            textFila.Name = "textFila";
            textFila.Size = new Size(191, 23);
            textFila.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 8;
            label1.Text = "Pilha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 55);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 9;
            label2.Text = "Fila";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textFila);
            Controls.Add(textPilha);
            Controls.Add(RemoverFila);
            Controls.Add(AdicionarFila);
            Controls.Add(Removerpilha);
            Controls.Add(Adicionarpilha);
            Controls.Add(Fila);
            Controls.Add(Pilha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Pilha;
        private ListBox Fila;
        private Button Adicionarpilha;
        private Button Removerpilha;
        private Button AdicionarFila;
        private Button RemoverFila;
        private TextBox textPilha;
        private TextBox textFila;
        private Label label1;
        private Label label2;
    }
}
