namespace Sistema_de_Asignacion_de_Activos_Fijos
{
    partial class FormEmpleados
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminarEmp = new FontAwesome.Sharp.IconButton();
            this.btnEditarEmp = new FontAwesome.Sharp.IconButton();
            this.btnNuevoEmp = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFormActual)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.iconPictureBoxFormActual);
            this.panel1.Controls.Add(this.lblFrmActual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 69);
            this.panel1.TabIndex = 17;
            // 
            // iconPictureBoxFormActual
            // 
            this.iconPictureBoxFormActual.BackColor = System.Drawing.Color.White;
            this.iconPictureBoxFormActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.iconPictureBoxFormActual.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconPictureBoxFormActual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
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
            this.lblFrmActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblFrmActual.Location = new System.Drawing.Point(54, 22);
            this.lblFrmActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrmActual.Name = "lblFrmActual";
            this.lblFrmActual.Size = new System.Drawing.Size(202, 21);
            this.lblFrmActual.TabIndex = 14;
            this.lblFrmActual.Text = "Listado de Empleados";
            this.lblFrmActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEliminarEmp);
            this.panel3.Controls.Add(this.btnEditarEmp);
            this.panel3.Controls.Add(this.btnNuevoEmp);
            this.panel3.Controls.Add(this.btnSeleccionar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 412);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 80);
            this.panel3.TabIndex = 6;
            // 
            // btnEliminarEmp
            // 
            this.btnEliminarEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnEliminarEmp.FlatAppearance.BorderSize = 0;
            this.btnEliminarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmp.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmp.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEmp.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarEmp.IconColor = System.Drawing.Color.White;
            this.btnEliminarEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarEmp.IconSize = 30;
            this.btnEliminarEmp.Location = new System.Drawing.Point(323, 15);
            this.btnEliminarEmp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarEmp.Name = "btnEliminarEmp";
            this.btnEliminarEmp.Padding = new System.Windows.Forms.Padding(6);
            this.btnEliminarEmp.Size = new System.Drawing.Size(150, 50);
            this.btnEliminarEmp.TabIndex = 7;
            this.btnEliminarEmp.Text = "   Eliminar";
            this.btnEliminarEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarEmp.UseVisualStyleBackColor = false;
            // 
            // btnEditarEmp
            // 
            this.btnEditarEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnEditarEmp.FlatAppearance.BorderSize = 0;
            this.btnEditarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEmp.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEmp.ForeColor = System.Drawing.Color.White;
            this.btnEditarEmp.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnEditarEmp.IconColor = System.Drawing.Color.White;
            this.btnEditarEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarEmp.IconSize = 30;
            this.btnEditarEmp.Location = new System.Drawing.Point(168, 15);
            this.btnEditarEmp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditarEmp.Name = "btnEditarEmp";
            this.btnEditarEmp.Padding = new System.Windows.Forms.Padding(6);
            this.btnEditarEmp.Size = new System.Drawing.Size(150, 50);
            this.btnEditarEmp.TabIndex = 6;
            this.btnEditarEmp.Text = "   Editar";
            this.btnEditarEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarEmp.UseVisualStyleBackColor = false;
            // 
            // btnNuevoEmp
            // 
            this.btnNuevoEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnNuevoEmp.FlatAppearance.BorderSize = 0;
            this.btnNuevoEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEmp.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEmp.ForeColor = System.Drawing.Color.White;
            this.btnNuevoEmp.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.btnNuevoEmp.IconColor = System.Drawing.Color.White;
            this.btnNuevoEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoEmp.IconSize = 30;
            this.btnNuevoEmp.Location = new System.Drawing.Point(13, 15);
            this.btnNuevoEmp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevoEmp.Name = "btnNuevoEmp";
            this.btnNuevoEmp.Padding = new System.Windows.Forms.Padding(6);
            this.btnNuevoEmp.Size = new System.Drawing.Size(150, 50);
            this.btnNuevoEmp.TabIndex = 5;
            this.btnNuevoEmp.Text = "   Nuevo";
            this.btnNuevoEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoEmp.UseVisualStyleBackColor = false;
            this.btnNuevoEmp.Click += new System.EventHandler(this.btnNuevoEmp_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewEmpleados, 0, 0);
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
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(736, 392);
            this.dataGridViewEmpleados.TabIndex = 0;
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
            this.panel2.TabIndex = 18;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSeleccionar.IconColor = System.Drawing.Color.White;
            this.btnSeleccionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeleccionar.IconSize = 30;
            this.btnSeleccionar.Location = new System.Drawing.Point(13, 15);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Padding = new System.Windows.Forms.Padding(6);
            this.btnSeleccionar.Size = new System.Drawing.Size(150, 50);
            this.btnSeleccionar.TabIndex = 8;
            this.btnSeleccionar.Text = "   Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Visible = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimizar.IconSize = 28;
            this.btnMinimizar.Location = new System.Drawing.Point(609, 9);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 50);
            this.btnMinimizar.TabIndex = 21;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Visible = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaximizar.BackColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMaximizar.IconSize = 28;
            this.btnMaximizar.Location = new System.Drawing.Point(659, 9);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(50, 50);
            this.btnMaximizar.TabIndex = 20;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Visible = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrar.IconSize = 28;
            this.btnCerrar.Location = new System.Drawing.Point(709, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 50);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Visible = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFormActual)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxFormActual;
        private System.Windows.Forms.Label lblFrmActual;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Panel panel2;
        public FontAwesome.Sharp.IconButton btnSeleccionar;
        public FontAwesome.Sharp.IconButton btnEliminarEmp;
        public FontAwesome.Sharp.IconButton btnEditarEmp;
        public FontAwesome.Sharp.IconButton btnNuevoEmp;
        public FontAwesome.Sharp.IconButton btnMinimizar;
        public FontAwesome.Sharp.IconButton btnMaximizar;
        public FontAwesome.Sharp.IconButton btnCerrar;
    }
}