using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DwMessages
{
    partial class MessageInfo
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
            this.imgMensagem = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOk = new System.Windows.Forms.Button();
            this.txMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMensagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgMensagem
            // 
            this.imgMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgMensagem.Location = new System.Drawing.Point(14, 9);
            this.imgMensagem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.imgMensagem.Name = "imgMensagem";
            this.imgMensagem.Size = new System.Drawing.Size(60, 194);
            this.imgMensagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMensagem.TabIndex = 0;
            this.imgMensagem.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 50);
            this.panel1.TabIndex = 1;
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btOk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btOk.Location = new System.Drawing.Point(184, 5);
            this.btOk.Margin = new System.Windows.Forms.Padding(214, 10, 214, 10);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(116, 40);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "&Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txMessage
            // 
            this.txMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txMessage.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMessage.Location = new System.Drawing.Point(89, 9);
            this.txMessage.Margin = new System.Windows.Forms.Padding(10);
            this.txMessage.Multiline = true;
            this.txMessage.Name = "txMessage";
            this.txMessage.ReadOnly = true;
            this.txMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txMessage.Size = new System.Drawing.Size(387, 194);
            this.txMessage.TabIndex = 2;
            this.txMessage.Text = "txMessage";
            // 
            // MessageInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.txMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgMensagem);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(410, 180);
            this.Name = "MessageInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageOk_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgMensagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox imgMensagem;
        private Panel panel1;
        private Button btOk;
        private TextBox txMessage;
        #endregion
    }
}