namespace Vale_Lembrar_Teste.Cadastrar
{
    partial class list_user
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.list_cancel_user = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_user = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_user)).BeginInit();
            this.SuspendLayout();
            // 
            // list_cancel_user
            // 
            this.list_cancel_user.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.list_cancel_user.AutoSize = true;
            this.list_cancel_user.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.list_cancel_user.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.list_cancel_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.list_cancel_user.Location = new System.Drawing.Point(373, 316);
            this.list_cancel_user.Name = "list_cancel_user";
            this.list_cancel_user.Size = new System.Drawing.Size(82, 30);
            this.list_cancel_user.TabIndex = 6;
            this.list_cancel_user.Text = "Cancelar";
            this.list_cancel_user.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuários Cadastrados";
            // 
            // grid_user
            // 
            this.grid_user.AllowUserToAddRows = false;
            this.grid_user.AllowUserToDeleteRows = false;
            this.grid_user.AllowUserToOrderColumns = true;
            this.grid_user.AllowUserToResizeColumns = false;
            this.grid_user.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_user.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_user.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_user.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grid_user.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grid_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_user.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_user.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_user.Location = new System.Drawing.Point(5, 54);
            this.grid_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid_user.Name = "grid_user";
            this.grid_user.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grid_user.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_user.RowHeadersVisible = false;
            this.grid_user.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = "-";
            this.grid_user.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_user.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_user.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.grid_user.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.grid_user.RowTemplate.DefaultCellStyle.Format = "d";
            this.grid_user.RowTemplate.DefaultCellStyle.NullValue = null;
            this.grid_user.RowTemplate.ReadOnly = true;
            this.grid_user.Size = new System.Drawing.Size(830, 254);
            this.grid_user.StandardTab = true;
            this.grid_user.TabIndex = 5;
            // 
            // list_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.list_cancel_user;
            this.ClientSize = new System.Drawing.Size(840, 353);
            this.Controls.Add(this.list_cancel_user);
            this.Controls.Add(this.grid_user);
            this.Controls.Add(this.label1);
            this.Name = "list_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Listar Usuários";
            this.Load += new System.EventHandler(this.list_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button list_cancel_user;
        private System.Windows.Forms.DataGridView grid_user;
        private System.Windows.Forms.Label label1;
    }
}