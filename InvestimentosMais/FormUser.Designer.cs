namespace InvestimentosMais
{
    partial class FormUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.pnlCadUser = new System.Windows.Forms.Panel();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbJob = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.ttpName = new System.Windows.Forms.ToolTip(this.components);
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlCadUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadUser
            // 
            this.pnlCadUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCadUser.Controls.Add(this.lblGender);
            this.pnlCadUser.Controls.Add(this.cmbGender);
            this.pnlCadUser.Controls.Add(this.lblCPF);
            this.pnlCadUser.Controls.Add(this.mtbCPF);
            this.pnlCadUser.Controls.Add(this.txbEmail);
            this.pnlCadUser.Controls.Add(this.lblEmail);
            this.pnlCadUser.Controls.Add(this.txbJob);
            this.pnlCadUser.Controls.Add(this.lblJob);
            this.pnlCadUser.Controls.Add(this.txbName);
            this.pnlCadUser.Controls.Add(this.lblName);
            this.pnlCadUser.Location = new System.Drawing.Point(12, 12);
            this.pnlCadUser.Name = "pnlCadUser";
            this.pnlCadUser.Size = new System.Drawing.Size(471, 216);
            this.pnlCadUser.TabIndex = 0;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(3, 166);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Gênero";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outro",
            "Prefiro não informar"});
            this.cmbGender.Location = new System.Drawing.Point(6, 182);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(127, 21);
            this.cmbGender.TabIndex = 8;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(3, 127);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(6, 143);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(127, 20);
            this.mtbCPF.TabIndex = 6;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(6, 104);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(196, 20);
            this.txbEmail.TabIndex = 5;
            this.ttpName.SetToolTip(this.txbEmail, "Digite seu e-mail...");
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 88);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txbJob
            // 
            this.txbJob.Location = new System.Drawing.Point(6, 64);
            this.txbJob.Name = "txbJob";
            this.txbJob.Size = new System.Drawing.Size(196, 20);
            this.txbJob.TabIndex = 3;
            this.ttpName.SetToolTip(this.txbJob, "Digite sua profissão...");
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(3, 48);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(50, 13);
            this.lblJob.TabIndex = 2;
            this.lblJob.Text = "Profissão";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(6, 25);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(196, 20);
            this.txbName.TabIndex = 1;
            this.ttpName.SetToolTip(this.txbName, "Digite seu nome completo...");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome Completo";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(489, 62);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(97, 46);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Inserir";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(489, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 46);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 239);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.pnlCadUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.pnlCadUser.ResumeLayout(false);
            this.pnlCadUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadUser;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ToolTip ttpName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
    }
}