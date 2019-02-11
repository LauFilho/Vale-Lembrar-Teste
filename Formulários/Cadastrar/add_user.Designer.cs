namespace Vale_Lembrar_Teste.Cadastrar
{
    partial class add_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_user));
            this.txt_add_senha = new System.Windows.Forms.TextBox();
            this.txt_add_user = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.btn_cancel_add_user = new System.Windows.Forms.Button();
            this.user_comum = new System.Windows.Forms.RadioButton();
            this.user_admin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_add_senha
            // 
            this.txt_add_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_add_senha.Location = new System.Drawing.Point(221, 84);
            this.txt_add_senha.Name = "txt_add_senha";
            this.txt_add_senha.PasswordChar = '*';
            this.txt_add_senha.Size = new System.Drawing.Size(136, 26);
            this.txt_add_senha.TabIndex = 9;
            // 
            // txt_add_user
            // 
            this.txt_add_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_add_user.Location = new System.Drawing.Point(221, 54);
            this.txt_add_user.Name = "txt_add_user";
            this.txt_add_user.Size = new System.Drawing.Size(136, 26);
            this.txt_add_user.TabIndex = 8;
            this.txt_add_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(136, 86);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(80, 24);
            this.lbl_senha.TabIndex = 7;
            this.lbl_senha.Text = "Senha  :";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(132, 54);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(84, 24);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "Usuário :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(155, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adicionar Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_add_user
            // 
            this.btn_add_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_add_user.Location = new System.Drawing.Point(67, 172);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(90, 36);
            this.btn_add_user.TabIndex = 12;
            this.btn_add_user.Text = "Adicionar";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // btn_cancel_add_user
            // 
            this.btn_cancel_add_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_cancel_add_user.Location = new System.Drawing.Point(285, 172);
            this.btn_cancel_add_user.Name = "btn_cancel_add_user";
            this.btn_cancel_add_user.Size = new System.Drawing.Size(90, 36);
            this.btn_cancel_add_user.TabIndex = 13;
            this.btn_cancel_add_user.Text = "Cancelar";
            this.btn_cancel_add_user.UseVisualStyleBackColor = true;
            this.btn_cancel_add_user.Click += new System.EventHandler(this.btn_cancel_add_user_Click);
            // 
            // user_comum
            // 
            this.user_comum.AutoSize = true;
            this.user_comum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_comum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.user_comum.Location = new System.Drawing.Point(200, 122);
            this.user_comum.Name = "user_comum";
            this.user_comum.Size = new System.Drawing.Size(95, 28);
            this.user_comum.TabIndex = 14;
            this.user_comum.Text = "Comum";
            this.user_comum.UseVisualStyleBackColor = true;
            // 
            // user_admin
            // 
            this.user_admin.AutoSize = true;
            this.user_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.user_admin.Location = new System.Drawing.Point(292, 122);
            this.user_admin.Name = "user_admin";
            this.user_admin.Size = new System.Drawing.Size(83, 28);
            this.user_admin.TabIndex = 15;
            this.user_admin.Text = "Admin";
            this.user_admin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo :";
            // 
            // add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 216);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_admin);
            this.Controls.Add(this.user_comum);
            this.Controls.Add(this.btn_cancel_add_user);
            this.Controls.Add(this.btn_add_user);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_add_senha);
            this.Controls.Add(this.txt_add_user);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_add_senha;
        private System.Windows.Forms.TextBox txt_add_user;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.Button btn_cancel_add_user;
        private System.Windows.Forms.RadioButton user_comum;
        private System.Windows.Forms.RadioButton user_admin;
        private System.Windows.Forms.Label label2;
    }
}