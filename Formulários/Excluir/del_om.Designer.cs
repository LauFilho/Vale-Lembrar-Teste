namespace Vale_Lembrar_Teste.Excluir
{
    partial class del_om
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(del_om));
            this.txt_id_cancel_om = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_del_om = new System.Windows.Forms.Button();
            this.btn_cancel_del_om = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id_cancel_om
            // 
            this.txt_id_cancel_om.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_id_cancel_om.Location = new System.Drawing.Point(168, 16);
            this.txt_id_cancel_om.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_id_cancel_om.Name = "txt_id_cancel_om";
            this.txt_id_cancel_om.Size = new System.Drawing.Size(153, 29);
            this.txt_id_cancel_om.TabIndex = 6;
            this.txt_id_cancel_om.TextChanged += new System.EventHandler(this.txt_id_om_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número da OM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_del_om
            // 
            this.btn_del_om.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_del_om.Location = new System.Drawing.Point(15, 56);
            this.btn_del_om.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_del_om.Name = "btn_del_om";
            this.btn_del_om.Size = new System.Drawing.Size(115, 42);
            this.btn_del_om.TabIndex = 7;
            this.btn_del_om.Text = "Excluir OM";
            this.btn_del_om.UseVisualStyleBackColor = true;
            this.btn_del_om.Click += new System.EventHandler(this.btn_del_om_Click);
            // 
            // btn_cancel_del_om
            // 
            this.btn_cancel_del_om.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel_del_om.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_cancel_del_om.Location = new System.Drawing.Point(205, 56);
            this.btn_cancel_del_om.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_cancel_del_om.Name = "btn_cancel_del_om";
            this.btn_cancel_del_om.Size = new System.Drawing.Size(116, 40);
            this.btn_cancel_del_om.TabIndex = 8;
            this.btn_cancel_del_om.Text = "Cancelar";
            this.btn_cancel_del_om.UseVisualStyleBackColor = true;
            this.btn_cancel_del_om.Click += new System.EventHandler(this.btn_cancel_del_om_Click);
            // 
            // del_om
            // 
            this.AcceptButton = this.btn_del_om;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel_del_om;
            this.ClientSize = new System.Drawing.Size(335, 105);
            this.Controls.Add(this.btn_cancel_del_om);
            this.Controls.Add(this.btn_del_om);
            this.Controls.Add(this.txt_id_cancel_om);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "del_om";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Ordem de Manutenção";
            this.Load += new System.EventHandler(this.del_om_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id_cancel_om;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_del_om;
        private System.Windows.Forms.Button btn_cancel_del_om;
    }
}