namespace Sistema_de_Asignacion_de_Activos_Fijos
{
    partial class FormEquiposAsignados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBoxFormActual = new FontAwesome.Sharp.IconPictureBox();
            this.lblFrmActual = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerarQR = new FontAwesome.Sharp.IconButton();
            this.dataGridViewEquiposAsignados = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFormActual)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquiposAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconPictureBoxFormActual);
            this.panel1.Controls.Add(this.lblFrmActual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 69);
            this.panel1.TabIndex = 16;
            // 
            // iconPictureBoxFormActual
            // 
            this.iconPictureBoxFormActual.BackColor = System.Drawing.Color.White;
            this.iconPictureBoxFormActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(210)))), ((int)(((byte)(149)))));
            this.iconPictureBoxFormActual.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.iconPictureBoxFormActual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(210)))), ((int)(((byte)(149)))));
            this.iconPictureBoxFormActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxFormActual.IconSize = 34;
            this.iconPictureBoxFormActual.Location = new System.Drawing.Point(15, 17);
            this.iconPictureBoxFormActual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconPictureBoxFormActual.Name = "iconPictureBoxFormActual";
            this.iconPictureBoxFormActual.Size = new System.Drawing.Size(35, 34);
            this.iconPictureBoxFormActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxFormActual.TabIndex = 15;
            this.iconPictureBoxFormActual.TabStop = false;
            // 
            // lblFrmActual
            // 
            this.lblFrmActual.AutoSize = true;
            this.lblFrmActual.BackColor = System.Drawing.Color.White;
            this.lblFrmActual.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(210)))), ((int)(((byte)(149)))));
            this.lblFrmActual.Location = new System.Drawing.Point(54, 22);
            this.lblFrmActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrmActual.Name = "lblFrmActual";
            this.lblFrmActual.Size = new System.Drawing.Size(267, 21);
            this.lblFrmActual.TabIndex = 14;
            this.lblFrmActual.Text = "Equipos Asignados a Clientes";
            this.lblFrmActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(760, 496);
            this.panel2.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewEquiposAsignados, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 408);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGenerarQR);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 412);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 80);
            this.panel3.TabIndex = 6;
            // 
            // btnGenerarQR
            // 
            this.btnGenerarQR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerarQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnGenerarQR.FlatAppearance.BorderSize = 0;
            this.btnGenerarQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarQR.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarQR.ForeColor = System.Drawing.Color.White;
            this.btnGenerarQR.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.btnGenerarQR.IconColor = System.Drawing.Color.White;
            this.btnGenerarQR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarQR.IconSize = 30;
            this.btnGenerarQR.Location = new System.Drawing.Point(13, 15);
            this.btnGenerarQR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerarQR.Name = "btnGenerarQR";
            this.btnGenerarQR.Padding = new System.Windows.Forms.Padding(6);
            this.btnGenerarQR.Size = new System.Drawing.Size(189, 50);
            this.btnGenerarQR.TabIndex = 5;
            this.btnGenerarQR.Text = "Generar Código QR";
            this.btnGenerarQR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarQR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarQR.UseVisualStyleBackColor = false;
            // 
            // dataGridViewEquiposAsignados
            // 
            this.dataGridViewEquiposAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquiposAsignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEquiposAsignados.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewEquiposAsignados.Name = "dataGridViewEquiposAsignados";
            this.dataGridViewEquiposAsignados.Size = new System.Drawing.Size(736, 392);
            this.dataGridViewEquiposAsignados.TabIndex = 0;
            // 
            // FormEquiposAsignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEquiposAsignados";
            this.Text = "FormEquiposAsignados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFormActual)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquiposAsignados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxFormActual;
        private System.Windows.Forms.Label lblFrmActual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnGenerarQR;
        private System.Windows.Forms.DataGridView dataGridViewEquiposAsignados;
    }
}