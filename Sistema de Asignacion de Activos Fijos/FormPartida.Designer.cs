namespace Sistema_de_Asignacion_de_Activos_Fijos
{
    partial class FormPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPartida));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewPartida = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminarPart = new FontAwesome.Sharp.IconButton();
            this.btnEditarPart = new FontAwesome.Sharp.IconButton();
            this.btnNuevoPart = new FontAwesome.Sharp.IconButton();
            this.lblFrmActual = new System.Windows.Forms.Label();
            this.iconPictureBoxFormActual = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartida)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFormActual)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewPartida, 0, 0);
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
            // dataGridViewPartida
            // 
            this.dataGridViewPartida.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewPartida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPartida.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewPartida.Name = "dataGridViewPartida";
            this.dataGridViewPartida.Size = new System.Drawing.Size(736, 392);
            this.dataGridViewPartida.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEliminarPart);
            this.panel3.Controls.Add(this.btnEditarPart);
            this.panel3.Controls.Add(this.btnNuevoPart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 412);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 80);
            this.panel3.TabIndex = 6;
            // 
            // btnEliminarPart
            // 
            this.btnEliminarPart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnEliminarPart.FlatAppearance.BorderSize = 0;
            this.btnEliminarPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPart.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPart.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPart.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarPart.IconColor = System.Drawing.Color.White;
            this.btnEliminarPart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarPart.IconSize = 30;
            this.btnEliminarPart.Location = new System.Drawing.Point(323, 15);
            this.btnEliminarPart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarPart.Name = "btnEliminarPart";
            this.btnEliminarPart.Padding = new System.Windows.Forms.Padding(6);
            this.btnEliminarPart.Size = new System.Drawing.Size(150, 50);
            this.btnEliminarPart.TabIndex = 7;
            this.btnEliminarPart.Text = "   Eliminar";
            this.btnEliminarPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarPart.UseVisualStyleBackColor = false;
            // 
            // btnEditarPart
            // 
            this.btnEditarPart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnEditarPart.FlatAppearance.BorderSize = 0;
            this.btnEditarPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPart.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPart.ForeColor = System.Drawing.Color.White;
            this.btnEditarPart.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnEditarPart.IconColor = System.Drawing.Color.White;
            this.btnEditarPart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarPart.IconSize = 30;
            this.btnEditarPart.Location = new System.Drawing.Point(168, 15);
            this.btnEditarPart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditarPart.Name = "btnEditarPart";
            this.btnEditarPart.Padding = new System.Windows.Forms.Padding(6);
            this.btnEditarPart.Size = new System.Drawing.Size(150, 50);
            this.btnEditarPart.TabIndex = 6;
            this.btnEditarPart.Text = "   Editar";
            this.btnEditarPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarPart.UseVisualStyleBackColor = false;
            // 
            // btnNuevoPart
            // 
            this.btnNuevoPart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnNuevoPart.FlatAppearance.BorderSize = 0;
            this.btnNuevoPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPart.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPart.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPart.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.btnNuevoPart.IconColor = System.Drawing.Color.White;
            this.btnNuevoPart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoPart.IconSize = 30;
            this.btnNuevoPart.Location = new System.Drawing.Point(13, 15);
            this.btnNuevoPart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevoPart.Name = "btnNuevoPart";
            this.btnNuevoPart.Padding = new System.Windows.Forms.Padding(6);
            this.btnNuevoPart.Size = new System.Drawing.Size(150, 50);
            this.btnNuevoPart.TabIndex = 5;
            this.btnNuevoPart.Text = "   Nuevo";
            this.btnNuevoPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoPart.UseVisualStyleBackColor = false;
            // 
            // lblFrmActual
            // 
            this.lblFrmActual.AutoSize = true;
            this.lblFrmActual.BackColor = System.Drawing.Color.White;
            this.lblFrmActual.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(99)))), ((int)(((byte)(228)))));
            this.lblFrmActual.Location = new System.Drawing.Point(54, 22);
            this.lblFrmActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrmActual.Name = "lblFrmActual";
            this.lblFrmActual.Size = new System.Drawing.Size(190, 21);
            this.lblFrmActual.TabIndex = 14;
            this.lblFrmActual.Text = "Listado de la Partida";
            this.lblFrmActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBoxFormActual
            // 
            this.iconPictureBoxFormActual.BackColor = System.Drawing.Color.White;
            this.iconPictureBoxFormActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(99)))), ((int)(((byte)(228)))));
            this.iconPictureBoxFormActual.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconPictureBoxFormActual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(99)))), ((int)(((byte)(228)))));
            this.iconPictureBoxFormActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxFormActual.IconSize = 35;
            this.iconPictureBoxFormActual.Location = new System.Drawing.Point(15, 17);
            this.iconPictureBoxFormActual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconPictureBoxFormActual.Name = "iconPictureBoxFormActual";
            this.iconPictureBoxFormActual.Size = new System.Drawing.Size(35, 35);
            this.iconPictureBoxFormActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxFormActual.TabIndex = 15;
            this.iconPictureBoxFormActual.TabStop = false;
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
            this.panel1.TabIndex = 19;
            // 
            // FormPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPartida";
            this.ShowInTaskbar = false;
            this.Text = "FormPartida";
            this.Load += new System.EventHandler(this.FormPartida_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartida)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFormActual)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewPartida;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnEliminarPart;
        private FontAwesome.Sharp.IconButton btnEditarPart;
        private FontAwesome.Sharp.IconButton btnNuevoPart;
        private System.Windows.Forms.Label lblFrmActual;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxFormActual;
        private System.Windows.Forms.Panel panel1;
    }
}