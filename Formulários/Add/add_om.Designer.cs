namespace Vale_Lembrar_Teste
{
    partial class add_om
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_om));
            this.btn_add_om = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descricao_om = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel_om = new System.Windows.Forms.Button();
            this.txt_data_om = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_statusnovo_om = new System.Windows.Forms.RadioButton();
            this.btn_statusandamento_om = new System.Windows.Forms.RadioButton();
            this.btn_statusatrasada_om = new System.Windows.Forms.RadioButton();
            this.btn_statusconcluida_om = new System.Windows.Forms.RadioButton();
            this.txt_id_om = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_add_om
            // 
            this.btn_add_om.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_add_om.Location = new System.Drawing.Point(19, 191);
            this.btn_add_om.Margin = new System.Windows.Forms.Padding(6);
            this.btn_add_om.Name = "btn_add_om";
            this.btn_add_om.Size = new System.Drawing.Size(137, 42);
            this.btn_add_om.TabIndex = 0;
            this.btn_add_om.Text = "Adicionar OM";
            this.btn_add_om.UseVisualStyleBackColor = true;
            this.btn_add_om.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número da OM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição da OM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_descricao_om
            // 
            this.txt_descricao_om.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_descricao_om.Location = new System.Drawing.Point(191, 58);
            this.txt_descricao_om.Margin = new System.Windows.Forms.Padding(6);
            this.txt_descricao_om.Multiline = true;
            this.txt_descricao_om.Name = "txt_descricao_om";
            this.txt_descricao_om.Size = new System.Drawing.Size(410, 29);
            this.txt_descricao_om.TabIndex = 4;
            this.txt_descricao_om.TextChanged += new System.EventHandler(this.descricao_om_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de Lembrança da OM ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_cancel_om
            // 
            this.btn_cancel_om.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel_om.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_cancel_om.Location = new System.Drawing.Point(467, 191);
            this.btn_cancel_om.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cancel_om.Name = "btn_cancel_om";
            this.btn_cancel_om.Size = new System.Drawing.Size(134, 42);
            this.btn_cancel_om.TabIndex = 7;
            this.btn_cancel_om.Text = "Cancelar";
            this.btn_cancel_om.UseVisualStyleBackColor = true;
            this.btn_cancel_om.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_data_om
            // 
            this.txt_data_om.CustomFormat = "yyyy-MM-dd ";
            this.txt_data_om.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_data_om.Location = new System.Drawing.Point(467, 98);
            this.txt_data_om.Name = "txt_data_om";
            this.txt_data_om.Size = new System.Drawing.Size(134, 29);
            this.txt_data_om.TabIndex = 8;
            this.txt_data_om.Value = new System.DateTime(2018, 5, 14, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status da OM";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_statusnovo_om
            // 
            this.btn_statusnovo_om.AutoSize = true;
            this.btn_statusnovo_om.Location = new System.Drawing.Point(156, 143);
            this.btn_statusnovo_om.Name = "btn_statusnovo_om";
            this.btn_statusnovo_om.Size = new System.Drawing.Size(72, 28);
            this.btn_statusnovo_om.TabIndex = 9;
            this.btn_statusnovo_om.TabStop = true;
            this.btn_statusnovo_om.Text = "Nova";
            this.btn_statusnovo_om.UseVisualStyleBackColor = true;
            // 
            // btn_statusandamento_om
            // 
            this.btn_statusandamento_om.AutoSize = true;
            this.btn_statusandamento_om.Location = new System.Drawing.Point(234, 143);
            this.btn_statusandamento_om.Name = "btn_statusandamento_om";
            this.btn_statusandamento_om.Size = new System.Drawing.Size(126, 28);
            this.btn_statusandamento_om.TabIndex = 9;
            this.btn_statusandamento_om.TabStop = true;
            this.btn_statusandamento_om.Text = "Andamento";
            this.btn_statusandamento_om.UseVisualStyleBackColor = true;
            // 
            // btn_statusatrasada_om
            // 
            this.btn_statusatrasada_om.AutoSize = true;
            this.btn_statusatrasada_om.Location = new System.Drawing.Point(366, 143);
            this.btn_statusatrasada_om.Name = "btn_statusatrasada_om";
            this.btn_statusatrasada_om.Size = new System.Drawing.Size(101, 28);
            this.btn_statusatrasada_om.TabIndex = 9;
            this.btn_statusatrasada_om.TabStop = true;
            this.btn_statusatrasada_om.Text = "Atrasada";
            this.btn_statusatrasada_om.UseVisualStyleBackColor = true;
            // 
            // btn_statusconcluida_om
            // 
            this.btn_statusconcluida_om.AutoSize = true;
            this.btn_statusconcluida_om.Location = new System.Drawing.Point(473, 143);
            this.btn_statusconcluida_om.Name = "btn_statusconcluida_om";
            this.btn_statusconcluida_om.Size = new System.Drawing.Size(113, 28);
            this.btn_statusconcluida_om.TabIndex = 9;
            this.btn_statusconcluida_om.TabStop = true;
            this.btn_statusconcluida_om.Text = "Concluída";
            this.btn_statusconcluida_om.UseVisualStyleBackColor = true;
            // 
            // txt_id_om
            // 
            this.txt_id_om.Location = new System.Drawing.Point(191, 17);
            this.txt_id_om.Name = "txt_id_om";
            this.txt_id_om.Size = new System.Drawing.Size(408, 29);
            this.txt_id_om.TabIndex = 10;
            this.txt_id_om.TextChanged += new System.EventHandler(this.txt_id_om_TextChanged);
            // 
            // add_om
            // 
            this.AcceptButton = this.btn_add_om;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel_om;
            this.ClientSize = new System.Drawing.Size(611, 248);
            this.Controls.Add(this.txt_id_om);
            this.Controls.Add(this.btn_statusconcluida_om);
            this.Controls.Add(this.btn_statusatrasada_om);
            this.Controls.Add(this.btn_statusandamento_om);
            this.Controls.Add(this.btn_statusnovo_om);
            this.Controls.Add(this.txt_data_om);
            this.Controls.Add(this.btn_cancel_om);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_descricao_om);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_om);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "add_om";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Ordem de Manutenção";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add_om;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_descricao_om;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel_om;
        private System.Windows.Forms.DateTimePicker txt_data_om;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton btn_statusnovo_om;
        private System.Windows.Forms.RadioButton btn_statusandamento_om;
        private System.Windows.Forms.RadioButton btn_statusatrasada_om;
        private System.Windows.Forms.RadioButton btn_statusconcluida_om;
        private System.Windows.Forms.TextBox txt_id_om;
    }
}