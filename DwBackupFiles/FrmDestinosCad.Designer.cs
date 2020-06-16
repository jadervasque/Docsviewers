namespace DwDwBackupFiles
{
    partial class FrmDestinosCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDestinosCad));
            this.txDescricao = new DwControls.DwTextBox();
            this.txOrigem = new DwControls.DwTextBox();
            this.chbStatus = new DwControls.DwCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txDestino = new DwControls.DwTextBox();
            this.btOrigem = new System.Windows.Forms.Button();
            this.btDestino = new System.Windows.Forms.Button();
            this.fbdLocalizar = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // txDescricao
            // 
            this.txDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txDescricao.ColunaDataBase = null;
            this.txDescricao.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescricao.Label = "Descrição";
            this.txDescricao.Location = new System.Drawing.Point(9, 14);
            this.txDescricao.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txDescricao.MinimumSize = new System.Drawing.Size(125, 25);
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.Size = new System.Drawing.Size(717, 25);
            this.txDescricao.TabIndex = 0;
            // 
            // txOrigem
            // 
            this.txOrigem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txOrigem.ColunaDataBase = null;
            this.txOrigem.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txOrigem.Label = "Origem";
            this.txOrigem.Location = new System.Drawing.Point(24, 49);
            this.txOrigem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txOrigem.MinimumSize = new System.Drawing.Size(110, 25);
            this.txOrigem.Name = "txOrigem";
            this.txOrigem.Size = new System.Drawing.Size(595, 25);
            this.txOrigem.TabIndex = 1;
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chbStatus.Byte = ((byte)(1));
            this.chbStatus.ColunaDataBase = null;
            this.chbStatus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbStatus.Label = "Status";
            this.chbStatus.Location = new System.Drawing.Point(84, 118);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(68, 22);
            this.chbStatus.Status = true;
            this.chbStatus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            this.label2.Visible = false;
            // 
            // lbID
            // 
            this.lbID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(689, 120);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(34, 18);
            this.lbID.TabIndex = 7;
            this.lbID.Text = "lbID";
            this.lbID.Visible = false;
            // 
            // txDestino
            // 
            this.txDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txDestino.ColunaDataBase = null;
            this.txDestino.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDestino.Label = "Destino";
            this.txDestino.Location = new System.Drawing.Point(23, 84);
            this.txDestino.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txDestino.MinimumSize = new System.Drawing.Size(111, 25);
            this.txDestino.Name = "txDestino";
            this.txDestino.Size = new System.Drawing.Size(596, 25);
            this.txDestino.TabIndex = 3;
            // 
            // btOrigem
            // 
            this.btOrigem.Location = new System.Drawing.Point(622, 49);
            this.btOrigem.Margin = new System.Windows.Forms.Padding(0);
            this.btOrigem.Name = "btOrigem";
            this.btOrigem.Size = new System.Drawing.Size(104, 25);
            this.btOrigem.TabIndex = 2;
            this.btOrigem.Tag = "origem";
            this.btOrigem.Text = "Localizar...";
            this.btOrigem.UseVisualStyleBackColor = true;
            this.btOrigem.Click += new System.EventHandler(this.btOrigem_Click);
            // 
            // btDestino
            // 
            this.btDestino.Location = new System.Drawing.Point(622, 84);
            this.btDestino.Margin = new System.Windows.Forms.Padding(0);
            this.btDestino.Name = "btDestino";
            this.btDestino.Size = new System.Drawing.Size(104, 25);
            this.btDestino.TabIndex = 4;
            this.btDestino.Tag = "destino";
            this.btDestino.Text = "Localizar...";
            this.btDestino.UseVisualStyleBackColor = true;
            this.btDestino.Click += new System.EventHandler(this.btDestino_Click);
            // 
            // FrmDestinosCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 198);
            this.Controls.Add(this.btDestino);
            this.Controls.Add(this.btOrigem);
            this.Controls.Add(this.txDestino);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbStatus);
            this.Controls.Add(this.txOrigem);
            this.Controls.Add(this.txDescricao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MostrarIcone = true;
            this.Name = "FrmDestinosCad";
            this.ShowIcon = true;
            this.Text = "Cadastro de Destino";
            this.ValidarCampos = false;
            this.VerificarAlteracoes = false;
            this.Controls.SetChildIndex(this.txDescricao, 0);
            this.Controls.SetChildIndex(this.txOrigem, 0);
            this.Controls.SetChildIndex(this.chbStatus, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.txDestino, 0);
            this.Controls.SetChildIndex(this.btOrigem, 0);
            this.Controls.SetChildIndex(this.btDestino, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DwControls.DwTextBox txDescricao;
        private DwControls.DwTextBox txOrigem;
        private DwControls.DwCheckBox chbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbID;
        private DwControls.DwTextBox txDestino;
        private System.Windows.Forms.Button btOrigem;
        private System.Windows.Forms.Button btDestino;
        private System.Windows.Forms.FolderBrowserDialog fbdLocalizar;
    }
}