namespace Vale_Lembrar_Teste.Cadastrar
{
    partial class del_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(del_user));
            this.btn_cancel_del_user = new System.Windows.Forms.Button();
            this.btn_del_user = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_del_user = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel_del_user
            // 
            this.btn_cancel_del_user.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel_del_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_cancel_del_user.Location = new System.Drawing.Point(333, 132);
            this.btn_cancel_del_user.Name = "btn_cancel_del_user";
            this.btn_cancel_del_user.Size = new System.Drawing.Size(90, 36);
            this.btn_cancel_del_user.TabIndex = 21;
            this.btn_cancel_del_user.Text = "Cancelar";
            this.btn_cancel_del_user.UseVisualStyleBackColor = true;
            // 
            // btn_del_user
            // 
            this.btn_del_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_del_user.Location = new System.Drawing.Point(93, 132);
            this.btn_del_user.Name = "btn_del_user";
            this.btn_del_user.Size = new System.Drawing.Size(90, 36);
            this.btn_del_user.TabIndex = 20;
            this.btn_del_user.Text = "Excluir";
            this.btn_del_user.UseVisualStyleBackColor = true;
            this.btn_del_user.Click += new System.EventHandler(this.btn_del_user_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(17, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(166, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Excluir Usuário";
            // 
            // txt_del_user
            // 
            this.txt_del_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_del_user.Location = new System.Drawing.Point(236, 72);
            this.txt_del_user.Name = "txt_del_user";
            this.txt_del_user.Size = new System.Drawing.Size(136, 26);
            this.txt_del_user.TabIndex = 16;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(146, 74);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(84, 24);
            this.lbl_user.TabIndex = 14;
            this.lbl_user.Text = "Usuário :";
            // 
            // del_user
            // 
            this.AcceptButton = this.btn_del_user;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel_del_user;
            this.ClientSize = new System.Drawing.Size(485, 180);
            this.Controls.Add(this.btn_cancel_del_user);
            this.Controls.Add(this.btn_del_user);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_del_user);
            this.Controls.Add(this.lbl_user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "del_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Usuário";
            this.Load += new System.EventHandler(this.del_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel_del_user;
        private System.Windows.Forms.Button btn_del_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_del_user;
        private System.Windows.Forms.Label lbl_user;
    }
}