namespace Sistema_de_Asignacion_de_Activos_Fijos
{
    partial class FormOficinas
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
            this.dataGridViewOficinas = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminarOfi = new FontAwesome.Sharp.IconButton();
            this.btnEditarOfi = new FontAwesome.Sharp.IconButton();
            this.btnNuevoOfi = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFormActual)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOficinas)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel1.TabIndex = 18;
            // 
            // iconPictureBoxFormActual
            // 
            this.iconPictureBoxFormActual.BackColor = System.Drawing.Color.White;
            this.iconPictureBoxFormActual.ForeColor = System.Drawing.Color.BurlyWood;
            this.iconPictureBoxFormActual.IconChar = FontAwesome.Sharp.IconChar.LaptopHouse;
            this.iconPictureBoxFormActual.IconColor = System.Drawing.Color.BurlyWood;
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
            // lblFrmActual
            // 
            this.lblFrmActual.AutoSize = true;
            this.lblFrmActual.BackColor = System.Drawing.Color.White;
            this.lblFrmActual.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmActual.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblFrmActual.Location = new System.Drawing.Point(54, 22);
            this.lblFrmActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrmActual.Name = "lblFrmActual";
            this.lblFrmActual.Size = new System.Drawing.Size(176, 21);
            this.lblFrmActual.TabIndex = 14;
            this.lblFrmActual.Text = "Listado de Oficinas";
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
            this.panel2.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewOficinas, 0, 0);
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
            // dataGridViewOficinas
            // 
            this.dataGridViewOficinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOficinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOficinas.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewOficinas.Name = "dataGridViewOficinas";
            this.dataGridViewOficinas.Size = new System.Drawing.Size(736, 392);
            this.dataGridViewOficinas.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEliminarOfi);
            this.panel3.Controls.Add(this.btnEditarOfi);
            this.panel3.Controls.Add(this.btnNuevoOfi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 412);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 80);
            this.panel3.TabIndex = 6;
            // 
            // btnEliminarOfi
            // 
            this.btnEliminarOfi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarOfi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnEliminarOfi.FlatAppearance.BorderSize = 0;
            this.btnEliminarOfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarOfi.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarOfi.ForeColor = System.Drawing.Color.White;
            this.btnEliminarOfi.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarOfi.IconColor = System.Drawing.Color.White;
            this.btnEliminarOfi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarOfi.IconSize = 30;
            this.btnEliminarOfi.Location = new System.Drawing.Point(323, 15);
            this.btnEliminarOfi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarOfi.Name = "btnEliminarOfi";
            this.btnEliminarOfi.Padding = new System.Windows.Forms.Padding(6);
            this.btnEliminarOfi.Size = new System.Drawing.Size(150, 50);
            this.btnEliminarOfi.TabIndex = 7;
            this.btnEliminarOfi.Text = "   Eliminar";
            this.btnEliminarOfi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarOfi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarOfi.UseVisualStyleBackColor = false;
            // 
            // btnEditarOfi
            // 
            this.btnEditarOfi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarOfi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnEditarOfi.FlatAppearance.BorderSize = 0;
            this.btnEditarOfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarOfi.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarOfi.ForeColor = System.Drawing.Color.White;
            this.btnEditarOfi.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnEditarOfi.IconColor = System.Drawing.Color.White;
            this.btnEditarOfi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarOfi.IconSize = 30;
            this.btnEditarOfi.Location = new System.Drawing.Point(168, 15);
            this.btnEditarOfi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditarOfi.Name = "btnEditarOfi";
            this.btnEditarOfi.Padding = new System.Windows.Forms.Padding(6);
            this.btnEditarOfi.Size = new System.Drawing.Size(150, 50);
            this.btnEditarOfi.TabIndex = 6;
            this.btnEditarOfi.Text = "   Editar";
            this.btnEditarOfi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarOfi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarOfi.UseVisualStyleBackColor = false;
            // 
            // btnNuevoOfi
            // 
            this.btnNuevoOfi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoOfi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnNuevoOfi.FlatAppearance.BorderSize = 0;
            this.btnNuevoOfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoOfi.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoOfi.ForeColor = System.Drawing.Color.White;
            this.btnNuevoOfi.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.btnNuevoOfi.IconColor = System.Drawing.Color.White;
            this.btnNuevoOfi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoOfi.IconSize = 30;
            this.btnNuevoOfi.Location = new System.Drawing.Point(13, 15);
            this.btnNuevoOfi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevoOfi.Name = "btnNuevoOfi";
            this.btnNuevoOfi.Padding = new System.Windows.Forms.Padding(6);
            this.btnNuevoOfi.Size = new System.Drawing.Size(150, 50);
            this.btnNuevoOfi.TabIndex = 5;
            this.btnNuevoOfi.Text = "   Nuevo";
            this.btnNuevoOfi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoOfi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoOfi.UseVisualStyleBackColor = false;
            // 
            // FormOficinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOficinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOficinas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFormActual)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOficinas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxFormActual;
        private System.Windows.Forms.Label lblFrmActual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewOficinas;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnEliminarOfi;
        private FontAwesome.Sharp.IconButton btnEditarOfi;
        private FontAwesome.Sharp.IconButton btnNuevoOfi;
    }
}