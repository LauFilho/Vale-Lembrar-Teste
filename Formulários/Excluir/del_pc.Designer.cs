namespace Vale_Lembrar_Teste.Excluir
{
    partial class del_pc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(del_pc));
            this.btn_cancel_del_pc = new System.Windows.Forms.Button();
            this.btn_del_pc = new System.Windows.Forms.Button();
            this.txt_id_cancel_pc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel_del_pc
            // 
            this.btn_cancel_del_pc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel_del_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_cancel_del_pc.Location = new System.Drawing.Point(209, 59);
            this.btn_cancel_del_pc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_cancel_del_pc.Name = "btn_cancel_del_pc";
            this.btn_cancel_del_pc.Size = new System.Drawing.Size(107, 42);
            this.btn_cancel_del_pc.TabIndex = 12;
            this.btn_cancel_del_pc.Text = "Cancelar";
            this.btn_cancel_del_pc.UseVisualStyleBackColor = true;
            this.btn_cancel_del_pc.Click += new System.EventHandler(this.btn_cancel_del_pc_Click);
            // 
            // btn_del_pc
            // 
            this.btn_del_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_del_pc.Location = new System.Drawing.Point(15, 59);
            this.btn_del_pc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_del_pc.Name = "btn_del_pc";
            this.btn_del_pc.Size = new System.Drawing.Size(107, 42);
            this.btn_del_pc.TabIndex = 11;
            this.btn_del_pc.Text = "Excluir PC";
            this.btn_del_pc.UseVisualStyleBackColor = true;
            this.btn_del_pc.Click += new System.EventHandler(this.btn_del_pc_Click);
            // 
            // txt_id_cancel_pc
            // 
            this.txt_id_cancel_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_id_cancel_pc.Location = new System.Drawing.Point(163, 18);
            this.txt_id_cancel_pc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_id_cancel_pc.Name = "txt_id_cancel_pc";
            this.txt_id_cancel_pc.Size = new System.Drawing.Size(153, 29);
            this.txt_id_cancel_pc.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Número do PC";
            // 
            // del_pc
            // 
            this.AcceptButton = this.btn_del_pc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel_del_pc;
            this.ClientSize = new System.Drawing.Size(335, 111);
            this.Controls.Add(this.btn_cancel_del_pc);
            this.Controls.Add(this.btn_del_pc);
            this.Controls.Add(this.txt_id_cancel_pc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "del_pc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Pedido de Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel_del_pc;
        private System.Windows.Forms.Button btn_del_pc;
        private System.Windows.Forms.TextBox txt_id_cancel_pc;
        private System.Windows.Forms.Label label1;
    }
}