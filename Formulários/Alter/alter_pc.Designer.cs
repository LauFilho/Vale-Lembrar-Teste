namespace Vale_Lembrar_Teste.Alter
{
    partial class alter_pc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alter_pc));
            this.txt_id_pc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_data_pc = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel_pc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descricao_pc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id2_pc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_alter_pc = new System.Windows.Forms.Button();
            this.btn_statusconcluida_pc = new System.Windows.Forms.RadioButton();
            this.btn_statusatrasada_pc = new System.Windows.Forms.RadioButton();
            this.btn_statusandamento_pc = new System.Windows.Forms.RadioButton();
            this.btn_statusnovo_pc = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_id_pc
            // 
            this.txt_id_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_id_pc.Location = new System.Drawing.Point(202, 24);
            this.txt_id_pc.Margin = new System.Windows.Forms.Padding(6);
            this.txt_id_pc.Name = "txt_id_pc";
            this.txt_id_pc.Size = new System.Drawing.Size(408, 29);
            this.txt_id_pc.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(26, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Número do PC";
            // 
            // txt_data_pc
            // 
            this.txt_data_pc.CustomFormat = "yyyy-MM-dd ";
            this.txt_data_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_data_pc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_data_pc.Location = new System.Drawing.Point(478, 146);
            this.txt_data_pc.Name = "txt_data_pc";
            this.txt_data_pc.Size = new System.Drawing.Size(134, 29);
            this.txt_data_pc.TabIndex = 26;
            this.txt_data_pc.Value = new System.DateTime(2018, 4, 24, 0, 0, 0, 0);
            // 
            // btn_cancel_pc
            // 
            this.btn_cancel_pc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_cancel_pc.Location = new System.Drawing.Point(478, 233);
            this.btn_cancel_pc.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cancel_pc.Name = "btn_cancel_pc";
            this.btn_cancel_pc.Size = new System.Drawing.Size(134, 42);
            this.btn_cancel_pc.TabIndex = 25;
            this.btn_cancel_pc.Text = "Cancelar";
            this.btn_cancel_pc.UseVisualStyleBackColor = true;
            this.btn_cancel_pc.Click += new System.EventHandler(this.btn_cancel_pc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(26, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Data de Lembrança do PC";
            // 
            // txt_descricao_pc
            // 
            this.txt_descricao_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_descricao_pc.Location = new System.Drawing.Point(202, 106);
            this.txt_descricao_pc.Margin = new System.Windows.Forms.Padding(6);
            this.txt_descricao_pc.Multiline = true;
            this.txt_descricao_pc.Name = "txt_descricao_pc";
            this.txt_descricao_pc.Size = new System.Drawing.Size(410, 29);
            this.txt_descricao_pc.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(26, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descrição do PC";
            // 
            // txt_id2_pc
            // 
            this.txt_id2_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_id2_pc.Location = new System.Drawing.Point(202, 65);
            this.txt_id2_pc.Margin = new System.Windows.Forms.Padding(6);
            this.txt_id2_pc.Name = "txt_id2_pc";
            this.txt_id2_pc.Size = new System.Drawing.Size(408, 29);
            this.txt_id2_pc.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Novo Nº do PC";
            // 
            // btn_alter_pc
            // 
            this.btn_alter_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_alter_pc.Location = new System.Drawing.Point(30, 233);
            this.btn_alter_pc.Margin = new System.Windows.Forms.Padding(6);
            this.btn_alter_pc.Name = "btn_alter_pc";
            this.btn_alter_pc.Size = new System.Drawing.Size(137, 42);
            this.btn_alter_pc.TabIndex = 19;
            this.btn_alter_pc.Text = "Editar PC";
            this.btn_alter_pc.UseVisualStyleBackColor = true;
            this.btn_alter_pc.Click += new System.EventHandler(this.btn_alter_pc_Click);
            // 
            // btn_statusconcluida_pc
            // 
            this.btn_statusconcluida_pc.AutoSize = true;
            this.btn_statusconcluida_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_statusconcluida_pc.Location = new System.Drawing.Point(491, 188);
            this.btn_statusconcluida_pc.Name = "btn_statusconcluida_pc";
            this.btn_statusconcluida_pc.Size = new System.Drawing.Size(113, 28);
            this.btn_statusconcluida_pc.TabIndex = 30;
            this.btn_statusconcluida_pc.TabStop = true;
            this.btn_statusconcluida_pc.Text = "Concluída";
            this.btn_statusconcluida_pc.UseVisualStyleBackColor = true;
            // 
            // btn_statusatrasada_pc
            // 
            this.btn_statusatrasada_pc.AutoSize = true;
            this.btn_statusatrasada_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_statusatrasada_pc.Location = new System.Drawing.Point(384, 188);
            this.btn_statusatrasada_pc.Name = "btn_statusatrasada_pc";
            this.btn_statusatrasada_pc.Size = new System.Drawing.Size(101, 28);
            this.btn_statusatrasada_pc.TabIndex = 31;
            this.btn_statusatrasada_pc.TabStop = true;
            this.btn_statusatrasada_pc.Text = "Atrasada";
            this.btn_statusatrasada_pc.UseVisualStyleBackColor = true;
            // 
            // btn_statusandamento_pc
            // 
            this.btn_statusandamento_pc.AutoSize = true;
            this.btn_statusandamento_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_statusandamento_pc.Location = new System.Drawing.Point(252, 188);
            this.btn_statusandamento_pc.Name = "btn_statusandamento_pc";
            this.btn_statusandamento_pc.Size = new System.Drawing.Size(126, 28);
            this.btn_statusandamento_pc.TabIndex = 32;
            this.btn_statusandamento_pc.TabStop = true;
            this.btn_statusandamento_pc.Text = "Andamento";
            this.btn_statusandamento_pc.UseVisualStyleBackColor = true;
            // 
            // btn_statusnovo_pc
            // 
            this.btn_statusnovo_pc.AutoSize = true;
            this.btn_statusnovo_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_statusnovo_pc.Location = new System.Drawing.Point(174, 188);
            this.btn_statusnovo_pc.Name = "btn_statusnovo_pc";
            this.btn_statusnovo_pc.Size = new System.Drawing.Size(72, 28);
            this.btn_statusnovo_pc.TabIndex = 33;
            this.btn_statusnovo_pc.TabStop = true;
            this.btn_statusnovo_pc.Text = "Nova";
            this.btn_statusnovo_pc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(29, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Status do PC";
            // 
            // alter_pc
            // 
            this.AcceptButton = this.btn_alter_pc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel_pc;
            this.ClientSize = new System.Drawing.Size(638, 290);
            this.Controls.Add(this.btn_statusconcluida_pc);
            this.Controls.Add(this.btn_statusatrasada_pc);
            this.Controls.Add(this.btn_statusandamento_pc);
            this.Controls.Add(this.btn_statusnovo_pc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_id_pc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_data_pc);
            this.Controls.Add(this.btn_cancel_pc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_descricao_pc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id2_pc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_alter_pc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "alter_pc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Pedido de Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id_pc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txt_data_pc;
        private System.Windows.Forms.Button btn_cancel_pc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descricao_pc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id2_pc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_alter_pc;
        private System.Windows.Forms.RadioButton btn_statusconcluida_pc;
        private System.Windows.Forms.RadioButton btn_statusatrasada_pc;
        private System.Windows.Forms.RadioButton btn_statusandamento_pc;
        private System.Windows.Forms.RadioButton btn_statusnovo_pc;
        private System.Windows.Forms.Label label5;
    }
}