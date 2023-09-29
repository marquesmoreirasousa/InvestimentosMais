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
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txbState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txbNeighborhood = new System.Windows.Forms.TextBox();
            this.lblNeighborhood = new System.Windows.Forms.Label();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.txbStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.LtvList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.pnlCadUser.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadUser
            // 
            this.pnlCadUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCadUser.Controls.Add(this.pnlAddress);
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
            this.pnlCadUser.Size = new System.Drawing.Size(745, 216);
            this.pnlCadUser.TabIndex = 0;
            // 
            // pnlAddress
            // 
            this.pnlAddress.Controls.Add(this.txbState);
            this.pnlAddress.Controls.Add(this.lblState);
            this.pnlAddress.Controls.Add(this.txbCity);
            this.pnlAddress.Controls.Add(this.lblCity);
            this.pnlAddress.Controls.Add(this.txbNeighborhood);
            this.pnlAddress.Controls.Add(this.lblNeighborhood);
            this.pnlAddress.Controls.Add(this.txbNumber);
            this.pnlAddress.Controls.Add(this.lblNumber);
            this.pnlAddress.Controls.Add(this.mtbCEP);
            this.pnlAddress.Controls.Add(this.txbStreet);
            this.pnlAddress.Controls.Add(this.lblStreet);
            this.pnlAddress.Controls.Add(this.lblCEP);
            this.pnlAddress.Location = new System.Drawing.Point(252, 9);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(474, 194);
            this.pnlAddress.TabIndex = 10;
            // 
            // txbState
            // 
            this.txbState.Location = new System.Drawing.Point(6, 174);
            this.txbState.Name = "txbState";
            this.txbState.Size = new System.Drawing.Size(232, 20);
            this.txbState.TabIndex = 20;
            this.ttpName.SetToolTip(this.txbState, "Digite o estado...");
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(3, 158);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(40, 13);
            this.lblState.TabIndex = 19;
            this.lblState.Text = "Estado";
            // 
            // txbCity
            // 
            this.txbCity.Location = new System.Drawing.Point(6, 134);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(232, 20);
            this.txbCity.TabIndex = 18;
            this.ttpName.SetToolTip(this.txbCity, "Digite a cidade...");
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(3, 118);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(40, 13);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "Cidade";
            // 
            // txbNeighborhood
            // 
            this.txbNeighborhood.Location = new System.Drawing.Point(6, 95);
            this.txbNeighborhood.Name = "txbNeighborhood";
            this.txbNeighborhood.Size = new System.Drawing.Size(232, 20);
            this.txbNeighborhood.TabIndex = 16;
            this.ttpName.SetToolTip(this.txbNeighborhood, "Digite o bairro...");
            // 
            // lblNeighborhood
            // 
            this.lblNeighborhood.AutoSize = true;
            this.lblNeighborhood.Location = new System.Drawing.Point(3, 79);
            this.lblNeighborhood.Name = "lblNeighborhood";
            this.lblNeighborhood.Size = new System.Drawing.Size(34, 13);
            this.lblNeighborhood.TabIndex = 15;
            this.lblNeighborhood.Text = "Bairro";
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(375, 55);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(96, 20);
            this.txbNumber.TabIndex = 14;
            this.ttpName.SetToolTip(this.txbNumber, "Digite o número");
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(372, 39);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 13;
            this.lblNumber.Text = "Número";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(6, 16);
            this.mtbCEP.Mask = "00000-000";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(127, 20);
            this.mtbCEP.TabIndex = 11;
            this.ttpName.SetToolTip(this.mtbCEP, "Digite o CEP...");
            this.mtbCEP.TextChanged += new System.EventHandler(this.mtbCEP_TextChanged);
            // 
            // txbStreet
            // 
            this.txbStreet.Location = new System.Drawing.Point(6, 55);
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.Size = new System.Drawing.Size(358, 20);
            this.txbStreet.TabIndex = 12;
            this.ttpName.SetToolTip(this.txbStreet, "Digite o logradouro...");
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(3, 39);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(61, 13);
            this.lblStreet.TabIndex = 11;
            this.lblStreet.Text = "Logradouro";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(3, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(78, 13);
            this.lblCEP.TabIndex = 2;
            this.lblCEP.Text = "Digite seu CEP";
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
            this.txbEmail.MaxLength = 40;
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
            this.txbJob.MaxLength = 50;
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
            this.txbName.MaxLength = 100;
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
            this.btnInsert.Location = new System.Drawing.Point(763, 63);
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
            this.btnClear.Location = new System.Drawing.Point(763, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 46);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlList
            // 
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlList.Controls.Add(this.LtvList);
            this.pnlList.Location = new System.Drawing.Point(12, 234);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(848, 137);
            this.pnlList.TabIndex = 3;
            // 
            // LtvList
            // 
            this.LtvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LtvList.FullRowSelect = true;
            this.LtvList.HideSelection = false;
            this.LtvList.Location = new System.Drawing.Point(6, 3);
            this.LtvList.Name = "LtvList";
            this.LtvList.Size = new System.Drawing.Size(840, 127);
            this.LtvList.TabIndex = 0;
            this.LtvList.UseCompatibleStateImageBehavior = false;
            this.LtvList.View = System.Windows.Forms.View.Details;
            this.LtvList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LtvList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Profissão";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-mail";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CPF";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Gênero";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Salmon;
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(763, 115);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(97, 46);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Location = new System.Drawing.Point(763, 167);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(97, 46);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Excluir";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 408);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.pnlCadUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.pnlCadUser.ResumeLayout(false);
            this.pnlCadUser.PerformLayout();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.pnlList.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.ListView LtvList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.TextBox txbNeighborhood;
        private System.Windows.Forms.Label lblNeighborhood;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.TextBox txbStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
    }
}