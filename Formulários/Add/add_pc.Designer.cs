namespace Vale_Lembrar_Teste.Add
{
    partial class add_pc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_pc));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descricao_pc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_pc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel_pc = new System.Windows.Forms.Button();
            this.btn_add_pc = new System.Windows.Forms.Button();
            this.txt_data_pc = new System.Windows.Forms.DateTimePicker();
            this.btn_statusconcluida_pc = new System.Windows.Forms.RadioButton();
            this.btn_statusatrasada_pc = new System.Windows.Forms.RadioButton();
            this.btn_statusandamento_pc = new System.Windows.Forms.RadioButton();
            this.btn_statusnovo_pc = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Data de Lembrança do PC ";
            // 
            // txt_descricao_pc
            // 
            this.txt_descricao_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_descricao_pc.Location = new System.Drawing.Point(185, 50);
            this.txt_descricao_pc.Margin = new System.Windows.Forms.Padding(6);
            this.txt_descricao_pc.Name = "txt_descricao_pc";
            this.txt_descricao_pc.Size = new System.Drawing.Size(410, 29);
            this.txt_descricao_pc.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descrição do PC";
            // 
            // txt_id_pc
            // 
            this.txt_id_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_id_pc.Location = new System.Drawing.Point(185, 9);
            this.txt_id_pc.Margin = new System.Windows.Forms.Padding(6);
            this.txt_id_pc.Multiline = true;
            this.txt_id_pc.Name = "txt_id_pc";
            this.txt_id_pc.Size = new System.Drawing.Size(410, 29);
            this.txt_id_pc.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Número do PC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_cancel_pc
            // 
            this.btn_cancel_pc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_cancel_pc.Location = new System.Drawing.Point(459, 187);
            this.btn_cancel_pc.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cancel_pc.Name = "btn_cancel_pc";
            this.btn_cancel_pc.Size = new System.Drawing.Size(138, 42);
            this.btn_cancel_pc.TabIndex = 15;
            this.btn_cancel_pc.Text = "Cancelar";
            this.btn_cancel_pc.UseVisualStyleBackColor = true;
            this.btn_cancel_pc.Click += new System.EventHandler(this.btn_cancel_pc_Click);
            // 
            // btn_add_pc
            // 
            this.btn_add_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_add_pc.Location = new System.Drawing.Point(13, 187);
            this.btn_add_pc.Margin = new System.Windows.Forms.Padding(6);
            this.btn_add_pc.Name = "btn_add_pc";
            this.btn_add_pc.Size = new System.Drawing.Size(132, 42);
            this.btn_add_pc.TabIndex = 16;
            this.btn_add_pc.Text = "Adicionar PC";
            this.btn_add_pc.UseVisualStyleBackColor = true;
            this.btn_add_pc.Click += new System.EventHandler(this.btn_add_pc_Click);
            // 
            // txt_data_pc
            // 
            this.txt_data_pc.CustomFormat = "yyyy-MM-dd ";
            this.txt_data_pc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_data_pc.Location = new System.Drawing.Point(459, 98);
            this.txt_data_pc.Name = "txt_data_pc";
            this.txt_data_pc.Size = new System.Drawing.Size(136, 29);
            this.txt_data_pc.TabIndex = 22;
            this.txt_data_pc.Value = new System.DateTime(2018, 4, 19, 0, 0, 0, 0);
            // 
            // btn_statusconcluida_pc
            // 
            this.btn_statusconcluida_pc.AutoSize = true;
            this.btn_statusconcluida_pc.Location = new System.Drawing.Point(474, 137);
            this.btn_statusconcluida_pc.Name = "btn_statusconcluida_pc";
            this.btn_statusconcluida_pc.Size = new System.Drawing.Size(114, 28);
            this.btn_statusconcluida_pc.TabIndex = 24;
            this.btn_statusconcluida_pc.TabStop = true;
            this.btn_statusconcluida_pc.Text = "Concluído";
            this.btn_statusconcluida_pc.UseVisualStyleBackColor = true;
            // 
            // btn_statusatrasada_pc
            // 
            this.btn_statusatrasada_pc.AutoSize = true;
            this.btn_statusatrasada_pc.Location = new System.Drawing.Point(367, 137);
            this.btn_statusatrasada_pc.Name = "btn_statusatrasada_pc";
            this.btn_statusatrasada_pc.Size = new System.Drawing.Size(102, 28);
            this.btn_statusatrasada_pc.TabIndex = 25;
            this.btn_statusatrasada_pc.TabStop = true;
            this.btn_statusatrasada_pc.Text = "Atrasado";
            this.btn_statusatrasada_pc.UseVisualStyleBackColor = true;
            // 
            // btn_statusandamento_pc
            // 
            this.btn_statusandamento_pc.AutoSize = true;
            this.btn_statusandamento_pc.Location = new System.Drawing.Point(235, 137);
            this.btn_statusandamento_pc.Name = "btn_statusandamento_pc";
            this.btn_statusandamento_pc.Size = new System.Drawing.Size(126, 28);
            this.btn_statusandamento_pc.TabIndex = 26;
            this.btn_statusandamento_pc.TabStop = true;
            this.btn_statusandamento_pc.Text = "Andamento";
            this.btn_statusandamento_pc.UseVisualStyleBackColor = true;
            // 
            // btn_statusnovo_pc
            // 
            this.btn_statusnovo_pc.AutoSize = true;
            this.btn_statusnovo_pc.Location = new System.Drawing.Point(156, 137);
            this.btn_statusnovo_pc.Name = "btn_statusnovo_pc";
            this.btn_statusnovo_pc.Size = new System.Drawing.Size(73, 28);
            this.btn_statusnovo_pc.TabIndex = 27;
            this.btn_statusnovo_pc.TabStop = true;
            this.btn_statusnovo_pc.Text = "Novo";
            this.btn_statusnovo_pc.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Status do PC";
            // 
            // add_pc
            // 
            this.AcceptButton = this.btn_add_pc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel_pc;
            this.ClientSize = new System.Drawing.Size(602, 244);
            this.Controls.Add(this.btn_statusconcluida_pc);
            this.Controls.Add(this.btn_statusatrasada_pc);
            this.Controls.Add(this.btn_statusandamento_pc);
            this.Controls.Add(this.btn_statusnovo_pc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_data_pc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_descricao_pc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id_pc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel_pc);
            this.Controls.Add(this.btn_add_pc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "add_pc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Pedido de Compra";
            this.Load += new System.EventHandler(this.add_pc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descricao_pc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_pc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel_pc;
        private System.Windows.Forms.Button btn_add_pc;
        private System.Windows.Forms.DateTimePicker txt_data_pc;
        private System.Windows.Forms.RadioButton btn_statusconcluida_pc;
        private System.Windows.Forms.RadioButton btn_statusatrasada_pc;
        private System.Windows.Forms.RadioButton btn_statusandamento_pc;
        private System.Windows.Forms.RadioButton btn_statusnovo_pc;
        private System.Windows.Forms.Label label4;
    }
}