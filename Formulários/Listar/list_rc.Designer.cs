namespace Vale_Lembrar_Teste.Listar
{
    partial class list_rc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_rc));
            this.label1 = new System.Windows.Forms.Label();
            this.grid_rc = new System.Windows.Forms.DataGridView();
            this.list_cancel_rc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Requisição de Compras Cadastradas";
            // 
            // grid_rc
            // 
            this.grid_rc.AllowUserToAddRows = false;
            this.grid_rc.AllowUserToDeleteRows = false;
            this.grid_rc.AllowUserToResizeColumns = false;
            this.grid_rc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "-";
            this.grid_rc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_rc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_rc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_rc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_rc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grid_rc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grid_rc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grid_rc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_rc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_rc.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_rc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_rc.GridColor = System.Drawing.SystemColors.Control;
            this.grid_rc.Location = new System.Drawing.Point(13, 56);
            this.grid_rc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid_rc.Name = "grid_rc";
            this.grid_rc.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grid_rc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_rc.RowHeadersVisible = false;
            this.grid_rc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = "-";
            this.grid_rc.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_rc.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_rc.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.grid_rc.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.grid_rc.RowTemplate.DefaultCellStyle.Format = "d";
            this.grid_rc.RowTemplate.DefaultCellStyle.NullValue = null;
            this.grid_rc.Size = new System.Drawing.Size(814, 237);
            this.grid_rc.StandardTab = true;
            this.grid_rc.TabIndex = 3;
            this.grid_rc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_rc_CellContentClick);
            // 
            // list_cancel_rc
            // 
            this.list_cancel_rc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.list_cancel_rc.AutoSize = true;
            this.list_cancel_rc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.list_cancel_rc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.list_cancel_rc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.list_cancel_rc.Location = new System.Drawing.Point(375, 311);
            this.list_cancel_rc.Name = "list_cancel_rc";
            this.list_cancel_rc.Size = new System.Drawing.Size(82, 30);
            this.list_cancel_rc.TabIndex = 4;
            this.list_cancel_rc.Text = "Cancelar";
            this.list_cancel_rc.UseVisualStyleBackColor = true;
            // 
            // list_rc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 353);
            this.Controls.Add(this.grid_rc);
            this.Controls.Add(this.list_cancel_rc);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "list_rc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Requisição de Compra";
            this.Load += new System.EventHandler(this.list_rc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_rc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_rc;
        private System.Windows.Forms.Button list_cancel_rc;
    }
}