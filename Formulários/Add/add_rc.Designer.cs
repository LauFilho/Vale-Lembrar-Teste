namespace Vale_Lembrar_Teste.Add
{
    partial class add_rc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_rc));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descricao_rc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_rc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel_rc = new System.Windows.Forms.Button();
            this.btn_add_rc = new System.Windows.Forms.Button();
            this.txt_data_rc = new System.Windows.Forms.DateTimePicker();
            this.btn_statusconcluida_rc = new System.Windows.Forms.RadioButton();
            this.btn_statusatrasada_rc = new System.Windows.Forms.RadioButton();
            this.btn_statusandamento_rc = new System.Windows.Forms.RadioButton();
            this.btn_statusnovo_rc = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(15, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data de Lembrança da RC ";
            // 
            // txt_descricao_rc
            // 
            this.txt_descricao_rc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_descricao_rc.Location = new System.Drawing.Point(191, 51);
            this.txt_descricao_rc.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_descricao_rc.Name = "txt_descricao_rc";
            this.txt_descricao_rc.Size = new System.Drawing.Size(410, 29);
            this.txt_descricao_rc.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descrição da RC";
            // 
            // txt_id_rc
            // 
            this.txt_id_rc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_id_rc.Location = new System.Drawing.Point(191, 8);
            this.txt_id_rc.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_id_rc.Multiline = true;
            this.txt_id_rc.Name = "txt_id_rc";
            this.txt_id_rc.Size = new System.Drawing.Size(410, 29);
            this.txt_id_rc.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Número da RC";
            // 
            // btn_cancel_rc
            // 
            this.btn_cancel_rc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel_rc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_cancel_rc.Location = new System.Drawing.Point(463, 186);
            this.btn_cancel_rc.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_cancel_rc.Name = "btn_cancel_rc";
            this.btn_cancel_rc.Size = new System.Drawing.Size(138, 42);
            this.btn_cancel_rc.TabIndex = 7;
            this.btn_cancel_rc.Text = "Cancelar";
            this.btn_cancel_rc.UseVisualStyleBackColor = true;
            this.btn_cancel_rc.Click += new System.EventHandler(this.btn_cancel_rc_Click);
            // 
            // btn_add_rc
            // 
            this.btn_add_rc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_add_rc.Location = new System.Drawing.Point(19, 186);
            this.btn_add_rc.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_add_rc.Name = "btn_add_rc";
            this.btn_add_rc.Size = new System.Drawing.Size(132, 42);
            this.btn_add_rc.TabIndex = 8;
            this.btn_add_rc.Text = "Adicionar RC";
            this.btn_add_rc.UseVisualStyleBackColor = true;
            this.btn_add_rc.Click += new System.EventHandler(this.btn_add_rc_Click);
            // 
            // txt_data_rc
            // 
            this.txt_data_rc.CustomFormat = "yyyy-MM-dd ";
            this.txt_data_rc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_data_rc.Location = new System.Drawing.Point(465, 101);
            this.txt_data_rc.Name = "txt_data_rc";
            this.txt_data_rc.Size = new System.Drawing.Size(136, 29);
            this.txt_data_rc.TabIndex = 23;
            this.txt_data_rc.Value = new System.DateTime(2018, 4, 19, 0, 0, 0, 0);
            // 
            // btn_statusconcluida_rc
            // 
            this.btn_statusconcluida_rc.AutoSize = true;
            this.btn_statusconcluida_rc.Location = new System.Drawing.Point(477, 141);
            this.btn_statusconcluida_rc.Name = "btn_statusconcluida_rc";
            this.btn_statusconcluida_rc.Size = new System.Drawing.Size(113, 28);
            this.btn_statusconcluida_rc.TabIndex = 25;
            this.btn_statusconcluida_rc.TabStop = true;
            this.btn_statusconcluida_rc.Text = "Concluída";
            this.btn_statusconcluida_rc.UseVisualStyleBackColor = true;
            // 
            // btn_statusatrasada_rc
            // 
            this.btn_statusatrasada_rc.AutoSize = true;
            this.btn_statusatrasada_rc.Location = new System.Drawing.Point(370, 141);
            this.btn_statusatrasada_rc.Name = "btn_statusatrasada_rc";
            this.btn_statusatrasada_rc.Size = new System.Drawing.Size(101, 28);
            this.btn_statusatrasada_rc.TabIndex = 26;
            this.btn_statusatrasada_rc.TabStop = true;
            this.btn_statusatrasada_rc.Text = "Atrasada";
            this.btn_statusatrasada_rc.UseVisualStyleBackColor = true;
            // 
            // btn_statusandamento_rc
            // 
            this.btn_statusandamento_rc.AutoSize = true;
            this.btn_statusandamento_rc.Location = new System.Drawing.Point(238, 141);
            this.btn_statusandamento_rc.Name = "btn_statusandamento_rc";
            this.btn_statusandamento_rc.Size = new System.Drawing.Size(126, 28);
            this.btn_statusandamento_rc.TabIndex = 27;
            this.btn_statusandamento_rc.TabStop = true;
            this.btn_statusandamento_rc.Text = "Andamento";
            this.btn_statusandamento_rc.UseVisualStyleBackColor = true;
            // 
            // btn_statusnovo_rc
            // 
            this.btn_statusnovo_rc.AutoSize = true;
            this.btn_statusnovo_rc.Location = new System.Drawing.Point(160, 141);
            this.btn_statusnovo_rc.Name = "btn_statusnovo_rc";
            this.btn_statusnovo_rc.Size = new System.Drawing.Size(72, 28);
            this.btn_statusnovo_rc.TabIndex = 28;
            this.btn_statusnovo_rc.TabStop = true;
            this.btn_statusnovo_rc.Text = "Nova";
            this.btn_statusnovo_rc.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(19, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Status da RC";
            // 
            // add_rc
            // 
            this.AcceptButton = this.btn_add_rc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel_rc;
            this.ClientSize = new System.Drawing.Size(607, 237);
            this.Controls.Add(this.btn_statusconcluida_rc);
            this.Controls.Add(this.btn_statusatrasada_rc);
            this.Controls.Add(this.btn_statusandamento_rc);
            this.Controls.Add(this.btn_statusnovo_rc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_data_rc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_descricao_rc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id_rc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel_rc);
            this.Controls.Add(this.btn_add_rc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "add_rc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Requisição de Compra";
            this.Load += new System.EventHandler(this.add_rc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descricao_rc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_rc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel_rc;
        private System.Windows.Forms.Button btn_add_rc;
        private System.Windows.Forms.DateTimePicker txt_data_rc;
        private System.Windows.Forms.RadioButton btn_statusconcluida_rc;
        private System.Windows.Forms.RadioButton btn_statusatrasada_rc;
        private System.Windows.Forms.RadioButton btn_statusandamento_rc;
        private System.Windows.Forms.RadioButton btn_statusnovo_rc;
        private System.Windows.Forms.Label label4;
    }
}