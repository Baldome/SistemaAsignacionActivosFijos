﻿namespace Sistema_de_Asignacion_de_Activos_Fijos
{
    partial class FormPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.ipbLogin = new FontAwesome.Sharp.IconPictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPartidaMenu = new FontAwesome.Sharp.IconButton();
            this.panelOficinasSubMenu = new System.Windows.Forms.Panel();
            this.btnEncargados = new FontAwesome.Sharp.IconButton();
            this.btnOficinas = new FontAwesome.Sharp.IconButton();
            this.btnMenuOficinas = new FontAwesome.Sharp.IconButton();
            this.panelEmpleadosSubMenu = new System.Windows.Forms.Panel();
            this.btnCargos = new FontAwesome.Sharp.IconButton();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnMenuEmpleados = new FontAwesome.Sharp.IconButton();
            this.panelEquiposSubMenu = new System.Windows.Forms.Panel();
            this.btnEquipos = new FontAwesome.Sharp.IconButton();
            this.btnDevolucionEquipos = new FontAwesome.Sharp.IconButton();
            this.btnAsignarEquipos = new FontAwesome.Sharp.IconButton();
            this.btnMenuEquipos = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.ipbInicio = new FontAwesome.Sharp.IconPictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.groupBoxEstadisticas = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxEmpleados = new System.Windows.Forms.GroupBox();
            this.labelTotalEmpleados = new System.Windows.Forms.Label();
            this.iconPictureBoxFormActual = new FontAwesome.Sharp.IconPictureBox();
            this.groupBoxEquipos = new System.Windows.Forms.GroupBox();
            this.labelNoAsignados = new System.Windows.Forms.Label();
            this.labelAsignados = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFrmActual = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbLogin)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelOficinasSubMenu.SuspendLayout();
            this.panelEmpleadosSubMenu.SuspendLayout();
            this.panelEquiposSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbInicio)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.groupBoxEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFormActual)).BeginInit();
            this.groupBoxEquipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.panelSuperior.Controls.Add(this.ipbLogin);
            this.panelSuperior.Controls.Add(this.lblLogin);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.btnMaximizar);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1000, 35);
            this.panelSuperior.TabIndex = 1;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // ipbLogin
            // 
            this.ipbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.ipbLogin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ipbLogin.IconColor = System.Drawing.Color.White;
            this.ipbLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbLogin.Location = new System.Drawing.Point(671, 0);
            this.ipbLogin.Name = "ipbLogin";
            this.ipbLogin.Size = new System.Drawing.Size(32, 35);
            this.ipbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ipbLogin.TabIndex = 5;
            this.ipbLogin.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(706, 8);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(109, 19);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Administrador";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimizar.IconSize = 28;
            this.btnMinimizar.Location = new System.Drawing.Point(895, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMaximizar.IconSize = 28;
            this.btnMaximizar.Location = new System.Drawing.Point(930, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrar.IconSize = 28;
            this.btnCerrar.Location = new System.Drawing.Point(965, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Asignacion de Activos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.panelMenu.Controls.Add(this.btnPartidaMenu);
            this.panelMenu.Controls.Add(this.panelOficinasSubMenu);
            this.panelMenu.Controls.Add(this.btnMenuOficinas);
            this.panelMenu.Controls.Add(this.panelEmpleadosSubMenu);
            this.panelMenu.Controls.Add(this.btnMenuEmpleados);
            this.panelMenu.Controls.Add(this.panelEquiposSubMenu);
            this.panelMenu.Controls.Add(this.btnMenuEquipos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 35);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 565);
            this.panelMenu.TabIndex = 4;
            // 
            // btnPartidaMenu
            // 
            this.btnPartidaMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPartidaMenu.FlatAppearance.BorderSize = 0;
            this.btnPartidaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidaMenu.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidaMenu.ForeColor = System.Drawing.Color.White;
            this.btnPartidaMenu.IconChar = FontAwesome.Sharp.IconChar.Anchor;
            this.btnPartidaMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(99)))), ((int)(((byte)(228)))));
            this.btnPartidaMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPartidaMenu.IconSize = 40;
            this.btnPartidaMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartidaMenu.Location = new System.Drawing.Point(0, 585);
            this.btnPartidaMenu.Name = "btnPartidaMenu";
            this.btnPartidaMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPartidaMenu.Size = new System.Drawing.Size(223, 50);
            this.btnPartidaMenu.TabIndex = 10;
            this.btnPartidaMenu.Text = "Partida";
            this.btnPartidaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartidaMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPartidaMenu.UseVisualStyleBackColor = true;
            this.btnPartidaMenu.Click += new System.EventHandler(this.btnPartidaMenu_Click);
            // 
            // panelOficinasSubMenu
            // 
            this.panelOficinasSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelOficinasSubMenu.Controls.Add(this.btnEncargados);
            this.panelOficinasSubMenu.Controls.Add(this.btnOficinas);
            this.panelOficinasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOficinasSubMenu.Location = new System.Drawing.Point(0, 500);
            this.panelOficinasSubMenu.Name = "panelOficinasSubMenu";
            this.panelOficinasSubMenu.Size = new System.Drawing.Size(223, 85);
            this.panelOficinasSubMenu.TabIndex = 9;
            // 
            // btnEncargados
            // 
            this.btnEncargados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEncargados.FlatAppearance.BorderSize = 0;
            this.btnEncargados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncargados.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncargados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEncargados.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnEncargados.IconColor = System.Drawing.Color.BurlyWood;
            this.btnEncargados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEncargados.IconSize = 25;
            this.btnEncargados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncargados.Location = new System.Drawing.Point(0, 40);
            this.btnEncargados.Name = "btnEncargados";
            this.btnEncargados.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEncargados.Size = new System.Drawing.Size(223, 40);
            this.btnEncargados.TabIndex = 1;
            this.btnEncargados.Text = "Responsable";
            this.btnEncargados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncargados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEncargados.UseVisualStyleBackColor = true;
            this.btnEncargados.Click += new System.EventHandler(this.btnEncargados_Click);
            // 
            // btnOficinas
            // 
            this.btnOficinas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOficinas.FlatAppearance.BorderSize = 0;
            this.btnOficinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOficinas.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOficinas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOficinas.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyWindow;
            this.btnOficinas.IconColor = System.Drawing.Color.BurlyWood;
            this.btnOficinas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOficinas.IconSize = 25;
            this.btnOficinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOficinas.Location = new System.Drawing.Point(0, 0);
            this.btnOficinas.Name = "btnOficinas";
            this.btnOficinas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOficinas.Size = new System.Drawing.Size(223, 40);
            this.btnOficinas.TabIndex = 0;
            this.btnOficinas.Text = "Oficinas";
            this.btnOficinas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOficinas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOficinas.UseVisualStyleBackColor = true;
            this.btnOficinas.Click += new System.EventHandler(this.btnOficinas_Click);
            // 
            // btnMenuOficinas
            // 
            this.btnMenuOficinas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuOficinas.FlatAppearance.BorderSize = 0;
            this.btnMenuOficinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuOficinas.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuOficinas.ForeColor = System.Drawing.Color.White;
            this.btnMenuOficinas.IconChar = FontAwesome.Sharp.IconChar.LaptopHouse;
            this.btnMenuOficinas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnMenuOficinas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuOficinas.IconSize = 40;
            this.btnMenuOficinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOficinas.Location = new System.Drawing.Point(0, 450);
            this.btnMenuOficinas.Name = "btnMenuOficinas";
            this.btnMenuOficinas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMenuOficinas.Size = new System.Drawing.Size(223, 50);
            this.btnMenuOficinas.TabIndex = 8;
            this.btnMenuOficinas.Text = "Oficinas";
            this.btnMenuOficinas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOficinas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuOficinas.UseVisualStyleBackColor = true;
            this.btnMenuOficinas.Click += new System.EventHandler(this.btnMenuOficinas_Click);
            // 
            // panelEmpleadosSubMenu
            // 
            this.panelEmpleadosSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelEmpleadosSubMenu.Controls.Add(this.btnCargos);
            this.panelEmpleadosSubMenu.Controls.Add(this.btnEmpleados);
            this.panelEmpleadosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpleadosSubMenu.Location = new System.Drawing.Point(0, 365);
            this.panelEmpleadosSubMenu.Name = "panelEmpleadosSubMenu";
            this.panelEmpleadosSubMenu.Size = new System.Drawing.Size(223, 85);
            this.panelEmpleadosSubMenu.TabIndex = 7;
            // 
            // btnCargos
            // 
            this.btnCargos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargos.FlatAppearance.BorderSize = 0;
            this.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCargos.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnCargos.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCargos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargos.IconSize = 25;
            this.btnCargos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargos.Location = new System.Drawing.Point(0, 40);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCargos.Size = new System.Drawing.Size(223, 40);
            this.btnCargos.TabIndex = 1;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnEmpleados.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.IconSize = 25;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(223, 40);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnMenuEmpleados
            // 
            this.btnMenuEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuEmpleados.FlatAppearance.BorderSize = 0;
            this.btnMenuEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEmpleados.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnMenuEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnMenuEmpleados.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(210)))), ((int)(((byte)(149)))));
            this.btnMenuEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuEmpleados.IconSize = 40;
            this.btnMenuEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEmpleados.Location = new System.Drawing.Point(0, 315);
            this.btnMenuEmpleados.Name = "btnMenuEmpleados";
            this.btnMenuEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMenuEmpleados.Size = new System.Drawing.Size(223, 50);
            this.btnMenuEmpleados.TabIndex = 6;
            this.btnMenuEmpleados.Text = "Empleados";
            this.btnMenuEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuEmpleados.UseVisualStyleBackColor = true;
            this.btnMenuEmpleados.Click += new System.EventHandler(this.btnMenuEmpleados_Click);
            // 
            // panelEquiposSubMenu
            // 
            this.panelEquiposSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelEquiposSubMenu.Controls.Add(this.btnEquipos);
            this.panelEquiposSubMenu.Controls.Add(this.btnDevolucionEquipos);
            this.panelEquiposSubMenu.Controls.Add(this.btnAsignarEquipos);
            this.panelEquiposSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEquiposSubMenu.Location = new System.Drawing.Point(0, 190);
            this.panelEquiposSubMenu.Name = "panelEquiposSubMenu";
            this.panelEquiposSubMenu.Size = new System.Drawing.Size(223, 125);
            this.panelEquiposSubMenu.TabIndex = 5;
            // 
            // btnEquipos
            // 
            this.btnEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquipos.FlatAppearance.BorderSize = 0;
            this.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEquipos.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt;
            this.btnEquipos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnEquipos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEquipos.IconSize = 25;
            this.btnEquipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipos.Location = new System.Drawing.Point(0, 80);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEquipos.Size = new System.Drawing.Size(223, 40);
            this.btnEquipos.TabIndex = 2;
            this.btnEquipos.Text = "Equipos";
            this.btnEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEquipos.UseVisualStyleBackColor = true;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // btnDevolucionEquipos
            // 
            this.btnDevolucionEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevolucionEquipos.FlatAppearance.BorderSize = 0;
            this.btnDevolucionEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucionEquipos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucionEquipos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDevolucionEquipos.IconChar = FontAwesome.Sharp.IconChar.ArrowsTurnRight;
            this.btnDevolucionEquipos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnDevolucionEquipos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDevolucionEquipos.IconSize = 25;
            this.btnDevolucionEquipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucionEquipos.Location = new System.Drawing.Point(0, 40);
            this.btnDevolucionEquipos.Name = "btnDevolucionEquipos";
            this.btnDevolucionEquipos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDevolucionEquipos.Size = new System.Drawing.Size(223, 40);
            this.btnDevolucionEquipos.TabIndex = 1;
            this.btnDevolucionEquipos.Text = "Devolucion de Equipos";
            this.btnDevolucionEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucionEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevolucionEquipos.UseVisualStyleBackColor = true;
            this.btnDevolucionEquipos.Click += new System.EventHandler(this.btnDevolucionEquipos_Click);
            // 
            // btnAsignarEquipos
            // 
            this.btnAsignarEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignarEquipos.FlatAppearance.BorderSize = 0;
            this.btnAsignarEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarEquipos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarEquipos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAsignarEquipos.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAsignarEquipos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnAsignarEquipos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsignarEquipos.IconSize = 25;
            this.btnAsignarEquipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarEquipos.Location = new System.Drawing.Point(0, 0);
            this.btnAsignarEquipos.Name = "btnAsignarEquipos";
            this.btnAsignarEquipos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAsignarEquipos.Size = new System.Drawing.Size(223, 40);
            this.btnAsignarEquipos.TabIndex = 0;
            this.btnAsignarEquipos.Text = "Asignar Equipos";
            this.btnAsignarEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsignarEquipos.UseVisualStyleBackColor = true;
            this.btnAsignarEquipos.Click += new System.EventHandler(this.btnAsignarEquipos_Click);
            // 
            // btnMenuEquipos
            // 
            this.btnMenuEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuEquipos.FlatAppearance.BorderSize = 0;
            this.btnMenuEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEquipos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuEquipos.ForeColor = System.Drawing.Color.White;
            this.btnMenuEquipos.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.btnMenuEquipos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(192)))), ((int)(((byte)(242)))));
            this.btnMenuEquipos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuEquipos.IconSize = 40;
            this.btnMenuEquipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEquipos.Location = new System.Drawing.Point(0, 140);
            this.btnMenuEquipos.Name = "btnMenuEquipos";
            this.btnMenuEquipos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMenuEquipos.Size = new System.Drawing.Size(223, 50);
            this.btnMenuEquipos.TabIndex = 4;
            this.btnMenuEquipos.Text = "Inventarios";
            this.btnMenuEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuEquipos.UseVisualStyleBackColor = true;
            this.btnMenuEquipos.Click += new System.EventHandler(this.btnMenuEquipos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.panelLogo.Controls.Add(this.ipbInicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(223, 140);
            this.panelLogo.TabIndex = 3;
            // 
            // ipbInicio
            // 
            this.ipbInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.ipbInicio.IconChar = FontAwesome.Sharp.IconChar.PhoenixSquadron;
            this.ipbInicio.IconColor = System.Drawing.Color.White;
            this.ipbInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbInicio.IconSize = 102;
            this.ipbInicio.Location = new System.Drawing.Point(42, 13);
            this.ipbInicio.Name = "ipbInicio";
            this.ipbInicio.Size = new System.Drawing.Size(110, 102);
            this.ipbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ipbInicio.TabIndex = 1;
            this.ipbInicio.TabStop = false;
            this.ipbInicio.Click += new System.EventHandler(this.ipbInicio_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.groupBoxEstadisticas);
            this.panelContenedor.Controls.Add(this.groupBoxEmpleados);
            this.panelContenedor.Controls.Add(this.iconPictureBoxFormActual);
            this.panelContenedor.Controls.Add(this.groupBoxEquipos);
            this.panelContenedor.Controls.Add(this.lblFrmActual);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(240, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Padding = new System.Windows.Forms.Padding(10);
            this.panelContenedor.Size = new System.Drawing.Size(760, 565);
            this.panelContenedor.TabIndex = 5;
            // 
            // groupBoxEstadisticas
            // 
            this.groupBoxEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEstadisticas.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBoxEstadisticas.Controls.Add(this.chart1);
            this.groupBoxEstadisticas.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.groupBoxEstadisticas.Location = new System.Drawing.Point(17, 258);
            this.groupBoxEstadisticas.Name = "groupBoxEstadisticas";
            this.groupBoxEstadisticas.Size = new System.Drawing.Size(718, 294);
            this.groupBoxEstadisticas.TabIndex = 11;
            this.groupBoxEstadisticas.TabStop = false;
            this.groupBoxEstadisticas.Text = "Estadisticas";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(37, 18);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(644, 258);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBoxEmpleados
            // 
            this.groupBoxEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEmpleados.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBoxEmpleados.Controls.Add(this.labelTotalEmpleados);
            this.groupBoxEmpleados.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.groupBoxEmpleados.Location = new System.Drawing.Point(535, 67);
            this.groupBoxEmpleados.Name = "groupBoxEmpleados";
            this.groupBoxEmpleados.Size = new System.Drawing.Size(202, 177);
            this.groupBoxEmpleados.TabIndex = 11;
            this.groupBoxEmpleados.TabStop = false;
            this.groupBoxEmpleados.Text = "Total Empleados";
            // 
            // labelTotalEmpleados
            // 
            this.labelTotalEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalEmpleados.AutoSize = true;
            this.labelTotalEmpleados.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEmpleados.Location = new System.Drawing.Point(84, 76);
            this.labelTotalEmpleados.Name = "labelTotalEmpleados";
            this.labelTotalEmpleados.Size = new System.Drawing.Size(24, 25);
            this.labelTotalEmpleados.TabIndex = 2;
            this.labelTotalEmpleados.Text = "0";
            // 
            // iconPictureBoxFormActual
            // 
            this.iconPictureBoxFormActual.BackColor = System.Drawing.Color.White;
            this.iconPictureBoxFormActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.iconPictureBoxFormActual.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconPictureBoxFormActual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.iconPictureBoxFormActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxFormActual.IconSize = 30;
            this.iconPictureBoxFormActual.Location = new System.Drawing.Point(19, 18);
            this.iconPictureBoxFormActual.Name = "iconPictureBoxFormActual";
            this.iconPictureBoxFormActual.Size = new System.Drawing.Size(30, 30);
            this.iconPictureBoxFormActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxFormActual.TabIndex = 11;
            this.iconPictureBoxFormActual.TabStop = false;
            // 
            // groupBoxEquipos
            // 
            this.groupBoxEquipos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxEquipos.Controls.Add(this.labelNoAsignados);
            this.groupBoxEquipos.Controls.Add(this.labelAsignados);
            this.groupBoxEquipos.Controls.Add(this.label3);
            this.groupBoxEquipos.Controls.Add(this.label2);
            this.groupBoxEquipos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEquipos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.groupBoxEquipos.Location = new System.Drawing.Point(17, 67);
            this.groupBoxEquipos.Name = "groupBoxEquipos";
            this.groupBoxEquipos.Size = new System.Drawing.Size(508, 177);
            this.groupBoxEquipos.TabIndex = 10;
            this.groupBoxEquipos.TabStop = false;
            this.groupBoxEquipos.Text = "Total Equipos";
            // 
            // labelNoAsignados
            // 
            this.labelNoAsignados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNoAsignados.AutoSize = true;
            this.labelNoAsignados.Location = new System.Drawing.Point(298, 107);
            this.labelNoAsignados.Name = "labelNoAsignados";
            this.labelNoAsignados.Size = new System.Drawing.Size(18, 19);
            this.labelNoAsignados.TabIndex = 3;
            this.labelNoAsignados.Text = "0";
            // 
            // labelAsignados
            // 
            this.labelAsignados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAsignados.AutoSize = true;
            this.labelAsignados.Location = new System.Drawing.Point(298, 57);
            this.labelAsignados.Name = "labelAsignados";
            this.labelAsignados.Size = new System.Drawing.Size(18, 19);
            this.labelAsignados.TabIndex = 2;
            this.labelAsignados.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "No Asignados:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Asignados:";
            // 
            // lblFrmActual
            // 
            this.lblFrmActual.AutoSize = true;
            this.lblFrmActual.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.lblFrmActual.Location = new System.Drawing.Point(52, 22);
            this.lblFrmActual.Name = "lblFrmActual";
            this.lblFrmActual.Size = new System.Drawing.Size(107, 21);
            this.lblFrmActual.TabIndex = 8;
            this.lblFrmActual.Text = "Dashboard";
            this.lblFrmActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbLogin)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelOficinasSubMenu.ResumeLayout(false);
            this.panelEmpleadosSubMenu.ResumeLayout(false);
            this.panelEquiposSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbInicio)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.groupBoxEstadisticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxEmpleados.ResumeLayout(false);
            this.groupBoxEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFormActual)).EndInit();
            this.groupBoxEquipos.ResumeLayout(false);
            this.groupBoxEquipos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private FontAwesome.Sharp.IconPictureBox ipbLogin;
        private System.Windows.Forms.Label lblLogin;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnPartidaMenu;
        private System.Windows.Forms.Panel panelOficinasSubMenu;
        private FontAwesome.Sharp.IconButton btnEncargados;
        private FontAwesome.Sharp.IconButton btnOficinas;
        private FontAwesome.Sharp.IconButton btnMenuOficinas;
        private System.Windows.Forms.Panel panelEmpleadosSubMenu;
        private FontAwesome.Sharp.IconButton btnCargos;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private FontAwesome.Sharp.IconButton btnMenuEmpleados;
        private System.Windows.Forms.Panel panelEquiposSubMenu;
        private FontAwesome.Sharp.IconButton btnEquipos;
        private FontAwesome.Sharp.IconButton btnDevolucionEquipos;
        private FontAwesome.Sharp.IconButton btnAsignarEquipos;
        private FontAwesome.Sharp.IconButton btnMenuEquipos;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconPictureBox ipbInicio;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox groupBoxEquipos;
        private System.Windows.Forms.Label lblFrmActual;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxFormActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNoAsignados;
        private System.Windows.Forms.Label labelAsignados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxEmpleados;
        private System.Windows.Forms.Label labelTotalEmpleados;
        private System.Windows.Forms.GroupBox groupBoxEstadisticas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}