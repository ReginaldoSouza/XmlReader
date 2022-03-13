
namespace XmlReader.Forms
{
    partial class frmLerXML
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.tabControlXML = new System.Windows.Forms.TabControl();
            this.tabPageXML = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtxml = new System.Windows.Forms.TextBox();
            this.BtnEscolherArquivo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewXML = new System.Windows.Forms.DataGridView();
            this.TabPageErros = new System.Windows.Forms.TabPage();
            this.dataGridViewErros = new System.Windows.Forms.DataGridView();
            this.tabControlXML.SuspendLayout();
            this.tabPageXML.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXML)).BeginInit();
            this.TabPageErros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErros)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlXML
            // 
            this.tabControlXML.Controls.Add(this.tabPageXML);
            this.tabControlXML.Controls.Add(this.TabPageErros);
            this.tabControlXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlXML.Location = new System.Drawing.Point(0, 0);
            this.tabControlXML.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlXML.Name = "tabControlXML";
            this.tabControlXML.SelectedIndex = 0;
            this.tabControlXML.Size = new System.Drawing.Size(1483, 813);
            this.tabControlXML.TabIndex = 7;
            // 
            // tabPageXML
            // 
            this.tabPageXML.AutoScroll = true;
            this.tabPageXML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageXML.Controls.Add(this.panel2);
            this.tabPageXML.Controls.Add(this.panel1);
            this.tabPageXML.Location = new System.Drawing.Point(4, 25);
            this.tabPageXML.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageXML.Name = "tabPageXML";
            this.tabPageXML.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageXML.Size = new System.Drawing.Size(1475, 784);
            this.tabPageXML.TabIndex = 0;
            this.tabPageXML.Text = "XML";
            this.tabPageXML.UseVisualStyleBackColor = true;
            this.tabPageXML.Click += new System.EventHandler(this.tabPageXML_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalRegistros);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtpesquisar);
            this.panel2.Controls.Add(this.BtnEnviar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtxml);
            this.panel2.Controls.Add(this.BtnEscolherArquivo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1461, 165);
            this.panel2.TabIndex = 12;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(19, 140);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(126, 16);
            this.lblTotalRegistros.TabIndex = 14;
            this.lblTotalRegistros.Text = "lblTotaldeRegistros";
            this.lblTotalRegistros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTotalRegistros.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "XML:";
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Enabled = false;
            this.txtpesquisar.Location = new System.Drawing.Point(188, 91);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(563, 22);
            this.txtpesquisar.TabIndex = 12;
            this.txtpesquisar.TextChanged += new System.EventHandler(this.txtpesquisar_TextChanged_2);
            this.txtpesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesquisar_KeyPress);
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(781, 32);
            this.BtnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(100, 28);
            this.BtnEnviar.TabIndex = 10;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pesquisar";
            // 
            // txtxml
            // 
            this.txtxml.BackColor = System.Drawing.Color.White;
            this.txtxml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtxml.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtxml.Location = new System.Drawing.Point(188, 38);
            this.txtxml.Margin = new System.Windows.Forms.Padding(4);
            this.txtxml.Name = "txtxml";
            this.txtxml.Size = new System.Drawing.Size(563, 22);
            this.txtxml.TabIndex = 6;
            // 
            // BtnEscolherArquivo
            // 
            this.BtnEscolherArquivo.Location = new System.Drawing.Point(22, 27);
            this.BtnEscolherArquivo.Name = "BtnEscolherArquivo";
            this.BtnEscolherArquivo.Size = new System.Drawing.Size(159, 43);
            this.BtnEscolherArquivo.TabIndex = 0;
            this.BtnEscolherArquivo.Text = "Escolher Arquivo";
            this.BtnEscolherArquivo.UseVisualStyleBackColor = true;
            this.BtnEscolherArquivo.Click += new System.EventHandler(this.BtnEscolherArquivo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewXML);
            this.panel1.Location = new System.Drawing.Point(4, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1465, 774);
            this.panel1.TabIndex = 11;
            // 
            // dataGridViewXML
            // 
            this.dataGridViewXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewXML.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewXML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXML.Location = new System.Drawing.Point(-1, 4);
            this.dataGridViewXML.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewXML.Name = "dataGridViewXML";
            this.dataGridViewXML.RowHeadersWidth = 51;
            this.dataGridViewXML.Size = new System.Drawing.Size(1458, 532);
            this.dataGridViewXML.TabIndex = 1;
            // 
            // TabPageErros
            // 
            this.TabPageErros.Controls.Add(this.dataGridViewErros);
            this.TabPageErros.Location = new System.Drawing.Point(4, 25);
            this.TabPageErros.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageErros.Name = "TabPageErros";
            this.TabPageErros.Padding = new System.Windows.Forms.Padding(4);
            this.TabPageErros.Size = new System.Drawing.Size(1475, 784);
            this.TabPageErros.TabIndex = 1;
            this.TabPageErros.Text = "Erros";
            this.TabPageErros.UseVisualStyleBackColor = true;
            // 
            // dataGridViewErros
            // 
            this.dataGridViewErros.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewErros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewErros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewErros.GridColor = System.Drawing.Color.White;
            this.dataGridViewErros.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewErros.Name = "dataGridViewErros";
            this.dataGridViewErros.RowHeadersWidth = 51;
            this.dataGridViewErros.RowTemplate.Height = 24;
            this.dataGridViewErros.Size = new System.Drawing.Size(1467, 776);
            this.dataGridViewErros.TabIndex = 0;
            // 
            // frmLerXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1483, 813);
            this.Controls.Add(this.tabControlXML);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLerXML";
            this.Text = "frmLerXML";
            this.tabControlXML.ResumeLayout(false);
            this.tabPageXML.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXML)).EndInit();
            this.TabPageErros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TabControl tabControlXML;
        private System.Windows.Forms.TabPage tabPageXML;
        private System.Windows.Forms.TabPage TabPageErros;
        private System.Windows.Forms.DataGridView dataGridViewErros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewXML;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnEscolherArquivo;
        private System.Windows.Forms.TextBox txtxml;
    
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.Label lblTotalRegistros;
    }
}