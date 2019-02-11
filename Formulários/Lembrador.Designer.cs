namespace Vale_Lembrar_Teste.Formulários
{
    partial class lembrador_om
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
            this.BW_1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BW_1
            // 
            this.BW_1.WorkerReportsProgress = true;
            this.BW_1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_1_DoWork);
            this.BW_1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BW_1_ProgressChanged);
            this.BW_1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_1_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "BW1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "BW2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lembrador_om
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "lembrador_om";
            this.Text = "Lembrador";
            this.Load += new System.EventHandler(this.lembrador_om_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BW_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}