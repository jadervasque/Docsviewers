namespace DwDwBackupFiles
{
    partial class FrmDwMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDwMain));
            this.gbLocais = new System.Windows.Forms.GroupBox();
            this.dgvLocais = new DwControls.DwDataGridView();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.barraProgresso = new System.Windows.Forms.ProgressBar();
            this.lbStatusProgresso = new System.Windows.Forms.Label();
            this.gbLocais.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLocais
            // 
            this.gbLocais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLocais.Controls.Add(this.dgvLocais);
            this.gbLocais.Location = new System.Drawing.Point(9, 19);
            this.gbLocais.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.gbLocais.Name = "gbLocais";
            this.gbLocais.Size = new System.Drawing.Size(883, 428);
            this.gbLocais.TabIndex = 4;
            this.gbLocais.TabStop = false;
            this.gbLocais.Text = "Locais Backups";
            // 
            // dgvLocais
            // 
            this.dgvLocais.BackColor = System.Drawing.SystemColors.Control;
            this.dgvLocais.CorGrid = System.Drawing.SystemColors.ScrollBar;
            this.dgvLocais.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocais.EstiloCabecalhoColunas = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocais.EstiloCelulas = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLocais.EstiloCelulasAlternadas = dataGridViewCellStyle3;
            this.dgvLocais.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLocais.Location = new System.Drawing.Point(3, 21);
            this.dgvLocais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvLocais.Name = "dgvLocais";
            this.dgvLocais.Size = new System.Drawing.Size(877, 404);
            this.dgvLocais.TabIndex = 0;
            this.dgvLocais.BotaoAdicionarClick += new DwControls.Classes.Click(this.dgvDestinos_BotaoAdicionarClick);
            this.dgvLocais.BotaoEditarClick += new DwControls.Classes.Click(this.dgvDestinos_BotaoEditarClick);
            this.dgvLocais.BotaoExcluirClick += new DwControls.Classes.Click(this.dgvDestinos_BotaoExcluirClick);
            this.dgvLocais.BotaoAtualizarClick += new DwControls.Classes.Click(this.dgvDestinos_BotaoAtualizarClick);
            this.dgvLocais.GridDuploClick += new DwControls.Classes.GridDoubleClick(this.dgvDestinos_BotaoEditarClick);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAtualizar.Location = new System.Drawing.Point(795, 478);
            this.btAtualizar.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(94, 52);
            this.btAtualizar.TabIndex = 5;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // barraProgresso
            // 
            this.barraProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraProgresso.Location = new System.Drawing.Point(12, 478);
            this.barraProgresso.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(773, 52);
            this.barraProgresso.TabIndex = 6;
            this.barraProgresso.Visible = false;
            // 
            // lbStatusProgresso
            // 
            this.lbStatusProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStatusProgresso.AutoSize = true;
            this.lbStatusProgresso.Location = new System.Drawing.Point(12, 457);
            this.lbStatusProgresso.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbStatusProgresso.Name = "lbStatusProgresso";
            this.lbStatusProgresso.Size = new System.Drawing.Size(123, 18);
            this.lbStatusProgresso.TabIndex = 7;
            this.lbStatusProgresso.Text = "lbStatusProgresso";
            this.lbStatusProgresso.Visible = false;
            // 
            // FrmDwMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 543);
            this.Controls.Add(this.lbStatusProgresso);
            this.Controls.Add(this.barraProgresso);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.gbLocais);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(670, 450);
            this.Name = "FrmDwMain";
            this.Text = "Backup Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDwMain_FormClosing);
            this.gbLocais.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbLocais;
        private DwControls.DwDataGridView dgvLocais;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.ProgressBar barraProgresso;
        private System.Windows.Forms.Label lbStatusProgresso;
    }
}

