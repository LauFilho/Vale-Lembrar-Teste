namespace Vale_Lembrar_Teste.Excluir
{
    partial class del_rc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(del_rc));
            this.btn_cancel_del_rc = new System.Windows.Forms.Button();
            this.btn_del_rc = new System.Windows.Forms.Button();
            this.txt_id_rc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel_del_rc
            // 
            this.btn_cancel_del_rc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel_del_rc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_cancel_del_rc.Location = new System.Drawing.Point(198, 44);
            this.btn_cancel_del_rc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_cancel_del_rc.Name = "btn_cancel_del_rc";
            this.btn_cancel_del_rc.Size = new System.Drawing.Size(115, 42);
            this.btn_cancel_del_rc.TabIndex = 12;
            this.btn_cancel_del_rc.Text = "Cancelar";
            this.btn_cancel_del_rc.UseVisualStyleBackColor = true;
            this.btn_cancel_del_rc.Click += new System.EventHandler(this.btn_cancel_del_rc_Click);
            // 
            // btn_del_rc
            // 
            this.btn_del_rc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_del_rc.Location = new System.Drawing.Point(12, 44);
            this.btn_del_rc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_del_rc.Name = "btn_del_rc";
            this.btn_del_rc.Size = new System.Drawing.Size(115, 42);
            this.btn_del_rc.TabIndex = 11;
            this.btn_del_rc.Text = "Excluir RC";
            this.btn_del_rc.UseVisualStyleBackColor = true;
            this.btn_del_rc.Click += new System.EventHandler(this.btn_del_rc_Click);
            // 
            // txt_id_rc
            // 
            this.txt_id_rc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_id_rc.Location = new System.Drawing.Point(160, 3);
            this.txt_id_rc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_id_rc.Name = "txt_id_rc";
            this.txt_id_rc.Size = new System.Drawing.Size(153, 29);
            this.txt_id_rc.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Número da RC";
            // 
            // del_rc
            // 
            this.AcceptButton = this.btn_del_rc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel_del_rc;
            this.ClientSize = new System.Drawing.Size(327, 100);
            this.Controls.Add(this.btn_cancel_del_rc);
            this.Controls.Add(this.btn_del_rc);
            this.Controls.Add(this.txt_id_rc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "del_rc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Requisição de Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel_del_rc;
        private System.Windows.Forms.Button btn_del_rc;
        private System.Windows.Forms.TextBox txt_id_rc;
        private System.Windows.Forms.Label label1;
    }
}