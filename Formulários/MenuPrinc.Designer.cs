using System;

namespace Vale_Lembrar_Teste
{
    partial class MenuPrinc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrinc));
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_add_om = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_add_rc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_add_pc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit_om = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit_rc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit_pc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_list = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_list_om = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_list_rc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_list_pc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_del = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_del_om = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_del_rc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_del_pc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_user = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_user_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_user_del = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_user_list = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_autenicacao = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.img_cadeado = new System.Windows.Forms.PictureBox();
            this.Lembrador = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_cadeado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(222, 121);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(84, 24);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "Usuário :";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(226, 151);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(80, 24);
            this.lbl_senha.TabIndex = 3;
            this.lbl_senha.Text = "Senha  :";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(311, 121);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(136, 29);
            this.txt_user.TabIndex = 4;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(311, 151);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(136, 29);
            this.txt_senha.TabIndex = 5;
            this.txt_senha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_add,
            this.menu_edit,
            this.menu_list,
            this.menu_del,
            this.menu_user,
            this.menu_logout,
            this.menu_exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menu_add
            // 
            this.menu_add.Checked = true;
            this.menu_add.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_add_om,
            this.menu_add_rc,
            this.menu_add_pc});
            this.menu_add.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_add.Image = ((System.Drawing.Image)(resources.GetObject("menu_add.Image")));
            this.menu_add.Name = "menu_add";
            this.menu_add.Size = new System.Drawing.Size(104, 25);
            this.menu_add.Tag = "hoje";
            this.menu_add.Text = "Adicionar";
            this.menu_add.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // menu_add_om
            // 
            this.menu_add_om.Image = ((System.Drawing.Image)(resources.GetObject("menu_add_om.Image")));
            this.menu_add_om.Name = "menu_add_om";
            this.menu_add_om.Size = new System.Drawing.Size(152, 26);
            this.menu_add_om.Text = "OM";
            this.menu_add_om.Click += new System.EventHandler(this.oMToolStripMenuItem_Click);
            // 
            // menu_add_rc
            // 
            this.menu_add_rc.Image = ((System.Drawing.Image)(resources.GetObject("menu_add_rc.Image")));
            this.menu_add_rc.Name = "menu_add_rc";
            this.menu_add_rc.Size = new System.Drawing.Size(152, 26);
            this.menu_add_rc.Text = "RC";
            this.menu_add_rc.Click += new System.EventHandler(this.rQToolStripMenuItem_Click);
            // 
            // menu_add_pc
            // 
            this.menu_add_pc.Image = ((System.Drawing.Image)(resources.GetObject("menu_add_pc.Image")));
            this.menu_add_pc.Name = "menu_add_pc";
            this.menu_add_pc.Size = new System.Drawing.Size(152, 26);
            this.menu_add_pc.Text = "PC";
            this.menu_add_pc.Click += new System.EventHandler(this.rQToolStripMenuItem1_Click);
            // 
            // menu_edit
            // 
            this.menu_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_edit_om,
            this.menu_edit_rc,
            this.menu_edit_pc});
            this.menu_edit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_edit.Image = ((System.Drawing.Image)(resources.GetObject("menu_edit.Image")));
            this.menu_edit.Name = "menu_edit";
            this.menu_edit.Size = new System.Drawing.Size(78, 25);
            this.menu_edit.Text = "Editar";
            this.menu_edit.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // menu_edit_om
            // 
            this.menu_edit_om.Image = ((System.Drawing.Image)(resources.GetObject("menu_edit_om.Image")));
            this.menu_edit_om.Name = "menu_edit_om";
            this.menu_edit_om.Size = new System.Drawing.Size(152, 26);
            this.menu_edit_om.Text = "OM";
            this.menu_edit_om.Click += new System.EventHandler(this.oMToolStripMenuItem3_Click);
            // 
            // menu_edit_rc
            // 
            this.menu_edit_rc.Image = ((System.Drawing.Image)(resources.GetObject("menu_edit_rc.Image")));
            this.menu_edit_rc.Name = "menu_edit_rc";
            this.menu_edit_rc.Size = new System.Drawing.Size(152, 26);
            this.menu_edit_rc.Text = "RC";
            this.menu_edit_rc.Click += new System.EventHandler(this.menu_edit_rc_Click);
            // 
            // menu_edit_pc
            // 
            //    this.menu_edit_pc.Image = global::ValeLembrar.Properties.Resources.compra;
            MenuPrinc menuPrinc = this;
            menuPrinc.menu_edit_pc.Name = "menu_edit_pc";
            this.menu_edit_pc.Size = new System.Drawing.Size(152, 26);
            this.menu_edit_pc.Text = "PC";
            this.menu_edit_pc.Click += new System.EventHandler(this.menu_edit_pc_Click);
            // 
            // menu_list
            // 
            this.menu_list.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_list_om,
            this.menu_list_rc,
            this.menu_list_pc});
            this.menu_list.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_list.Image = ((System.Drawing.Image)(resources.GetObject("menu_list.Image")));
            this.menu_list.Name = "menu_list";
            this.menu_list.Size = new System.Drawing.Size(76, 25);
            this.menu_list.Text = "Listar";
            // 
            // menu_list_om
            // 
           // this.menu_list_om.Image = global::ValeLembrar.Properties.Resources.Ordem_de_Manutenção;
            this.menu_list_om.Name = "menu_list_om";
            this.menu_list_om.Size = new System.Drawing.Size(152, 26);
            this.menu_list_om.Text = "OM";
            this.menu_list_om.Click += new System.EventHandler(this.menu_list_om_Click);
            // 
            // menu_list_rc
            // 
            //menu_list_rc.Image = global::Vale Lembrar Teste.Resources.Requisição;
            MenuPrinc menuPrinc1 = this;
            menuPrinc1.menu_list_rc.Name = "menu_list_rc";
            this.menu_list_rc.Size = new System.Drawing.Size(152, 26);
            this.menu_list_rc.Text = "RC";
            this.menu_list_rc.Click += new System.EventHandler(this.menu_list_rc_Click);
            // 
            // menu_list_pc
            // 
            //    this.menu_list_pc.Image = global::ValeLembrar.Properties.Resources.compra;
            MenuPrinc menuPrinc2 = this;
            menuPrinc2.menu_list_pc.Name = "menu_list_pc";
            this.menu_list_pc.Size = new System.Drawing.Size(152, 26);
            this.menu_list_pc.Text = "PC";
            this.menu_list_pc.Click += new System.EventHandler(this.menu_list_pc_Click);
            // 
            // menu_del
            // 
            this.menu_del.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_del_om,
            this.menu_del_rc,
            this.menu_del_pc});
            this.menu_del.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_del.Image = ((System.Drawing.Image)(resources.GetObject("menu_del.Image")));
            this.menu_del.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menu_del.Name = "menu_del";
            this.menu_del.Size = new System.Drawing.Size(83, 25);
            this.menu_del.Text = "Excluir";
            // 
            // menu_del_om
            // 
            // this.menu_del_om.Image = Vale2.Resources.Ordem_de_Manutenção;
            MenuPrinc menuPrinc3 = this;
            menuPrinc3.menu_del_om.Name = "menu_del_om";
            this.menu_del_om.Size = new System.Drawing.Size(152, 26);
            this.menu_del_om.Text = "OM";
            this.menu_del_om.Click += new System.EventHandler(this.oMToolStripMenuItem2_Click);
            // 
            // menu_del_rc
            // 
            //this.menu_del_rc.Image = global::ValeLembrar.Properties.Resources.Requisição;
            MenuPrinc menuPrinc4 = this;
            menuPrinc4.menu_del_rc.Name = "menu_del_rc";
            this.menu_del_rc.Size = new System.Drawing.Size(152, 26);
            this.menu_del_rc.Text = "RC";
            this.menu_del_rc.Click += new System.EventHandler(this.rQToolStripMenuItem3_Click);
            // 
            // menu_del_pc
            // 
            //this.menu_del_pc.Image = global::ValeLembrar.Properties.Resources.compra;
            MenuPrinc menuPrinc5 = this;
            menuPrinc5.menu_del_pc.Name = "menu_del_pc";
            this.menu_del_pc.Size = new System.Drawing.Size(152, 26);
            this.menu_del_pc.Text = "PC";
            this.menu_del_pc.Click += new System.EventHandler(this.pDToolStripMenuItem1_Click);
            // 
            // menu_user
            // 
            this.menu_user.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_user_add,
            this.menu_user_del,
            this.menu_user_list});
            this.menu_user.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_user.Image = ((System.Drawing.Image)(resources.GetObject("menu_user.Image")));
            this.menu_user.Name = "menu_user";
            this.menu_user.Size = new System.Drawing.Size(92, 25);
            this.menu_user.Text = "Usuário";
            this.menu_user.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // menu_user_add
            // 
            // this.menu_user_add.Image = global::ValeLembrar.Properties.Resources.add_user;
            MenuPrinc menuPrinc6 = this;
            menuPrinc6.menu_user_add.Name = "menu_user_add";
            this.menu_user_add.Size = new System.Drawing.Size(152, 26);
            this.menu_user_add.Text = "Adicionar ";
            this.menu_user_add.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click_1);
            // 
            // menu_user_del
            // 
            //this.menu_user_del.Image = global::ValeLembrar.Properties.Resources.del_user1;
            MenuPrinc menuPrinc7 = this;
            menuPrinc7.menu_user_del.Name = "menu_user_del";
            this.menu_user_del.Size = new System.Drawing.Size(152, 26);
            this.menu_user_del.Text = "Excluir";
            this.menu_user_del.Click += new System.EventHandler(this.menu_user_del_Click);
            // 
            // menu_user_list
            // 
            //this.menu_user_list.Image = global::ValeLembrar.Properties.Resources.list_user;
            MenuPrinc menuPrinc8 = this;
            menuPrinc8.menu_user_list.Name = "menu_user_list";
            this.menu_user_list.Size = new System.Drawing.Size(152, 26);
            this.menu_user_list.Text = "Listar";
            this.menu_user_list.Click += new System.EventHandler(this.menu_user_list_Click);
            // 
            // menu_logout
            // 
            this.menu_logout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_logout.Image = ((System.Drawing.Image)(resources.GetObject("menu_logout.Image")));
            this.menu_logout.Name = "menu_logout";
            this.menu_logout.Size = new System.Drawing.Size(87, 25);
            this.menu_logout.Text = "Logout";
            this.menu_logout.Click += new System.EventHandler(this.menu_logout_Click);
            // 
            // menu_exit
            // 
            this.menu_exit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_exit.Image = ((System.Drawing.Image)(resources.GetObject("menu_exit.Image")));
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(65, 25);
            this.menu_exit.Text = "Sair";
            this.menu_exit.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lbl_autenicacao
            // 
            this.lbl_autenicacao.AutoSize = true;
            this.lbl_autenicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_autenicacao.Location = new System.Drawing.Point(257, 62);
            this.lbl_autenicacao.Name = "lbl_autenicacao";
            this.lbl_autenicacao.Size = new System.Drawing.Size(172, 31);
            this.lbl_autenicacao.TabIndex = 6;
            this.lbl_autenicacao.Text = "Autenticação";
            // 
            // btn_login
            // 
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_login.Location = new System.Drawing.Point(263, 203);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(89, 44);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // img_cadeado
            // 
            this.img_cadeado.Image = ((System.Drawing.Image)(resources.GetObject("img_cadeado.Image")));
            this.img_cadeado.Location = new System.Drawing.Point(70, 55);
            this.img_cadeado.Name = "img_cadeado";
            this.img_cadeado.Size = new System.Drawing.Size(148, 129);
            this.img_cadeado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_cadeado.TabIndex = 7;
            this.img_cadeado.TabStop = false;
            // 
            // Lembrador
            // 
            this.Lembrador.WorkerReportsProgress = true;
            this.Lembrador.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Lembrador_DoWork);
            this.Lembrador.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Lembrador_ProgressChanged);
            this.Lembrador.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Lembrador_RunWorkerCompleted);
            // 
            // MenuPrinc
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(592, 262);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.img_cadeado);
            this.Controls.Add(this.lbl_autenicacao);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValeLembrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_cadeado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.ToolStripMenuItem menu_add;
        private System.Windows.Forms.ToolStripMenuItem menu_add_om;
        private System.Windows.Forms.ToolStripMenuItem menu_add_rc;
        private System.Windows.Forms.ToolStripMenuItem menu_add_pc;
        private System.Windows.Forms.ToolStripMenuItem menu_edit;
        private System.Windows.Forms.ToolStripMenuItem menu_edit_om;
        private System.Windows.Forms.ToolStripMenuItem menu_edit_rc;
        private System.Windows.Forms.ToolStripMenuItem menu_edit_pc;
        private System.Windows.Forms.ToolStripMenuItem menu_list;
        private System.Windows.Forms.ToolStripMenuItem menu_list_om;
        private System.Windows.Forms.ToolStripMenuItem menu_list_rc;
        private System.Windows.Forms.ToolStripMenuItem menu_list_pc;
        private System.Windows.Forms.ToolStripMenuItem menu_del;
        private System.Windows.Forms.ToolStripMenuItem menu_del_om;
        private System.Windows.Forms.ToolStripMenuItem menu_del_rc;
        private System.Windows.Forms.ToolStripMenuItem menu_del_pc;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_autenicacao;
        private System.Windows.Forms.PictureBox img_cadeado;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ToolStripMenuItem menu_logout;
        private System.Windows.Forms.ToolStripMenuItem menu_user;
        private System.Windows.Forms.ToolStripMenuItem menu_user_add;
        private System.Windows.Forms.ToolStripMenuItem menu_user_del;
        private System.Windows.Forms.ToolStripMenuItem menu_user_list;

        int Hoje;
        int min;
        private System.ComponentModel.BackgroundWorker Lembrador;
    }
}

