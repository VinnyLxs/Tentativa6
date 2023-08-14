namespace Tentativa6
{
    partial class Inicio
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
            this.button1 = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.MaskedTextBox();
            this.acertos = new System.Windows.Forms.Label();
            this.erros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(70, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coloque um Nick para iniciar o Jogo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(378, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(170, 201);
            this.nome.Mask = "aaaaaaaaaa";
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(188, 20);
            this.nome.TabIndex = 3;
            this.nome.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nome_MaskInputRejected);
            // 
            // acertos
            // 
            this.acertos.AutoSize = true;
            this.acertos.BackColor = System.Drawing.Color.Transparent;
            this.acertos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acertos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acertos.Location = new System.Drawing.Point(211, 258);
            this.acertos.Name = "acertos";
            this.acertos.Size = new System.Drawing.Size(63, 18);
            this.acertos.TabIndex = 4;
            this.acertos.Text = "Acertos:";
            // 
            // erros
            // 
            this.erros.AutoSize = true;
            this.erros.BackColor = System.Drawing.Color.Transparent;
            this.erros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.erros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.erros.Location = new System.Drawing.Point(211, 306);
            this.erros.Name = "erros";
            this.erros.Size = new System.Drawing.Size(49, 18);
            this.erros.TabIndex = 5;
            this.erros.Text = "Erros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(142, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Erros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(142, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Acertos:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tentativa6.Properties.Resources.fundo2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.erros);
            this.Controls.Add(this.acertos);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox nome;
        private System.Windows.Forms.Label acertos;
        private System.Windows.Forms.Label erros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}