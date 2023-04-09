﻿namespace WFA_ProDiet.UI
{
    partial class HomePage
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
            this.btnReturnLogin = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.pnlAllMenu = new System.Windows.Forms.Panel();
            this.pnlFoods = new System.Windows.Forms.Panel();
            this.btnEditFoods = new FontAwesome.Sharp.IconButton();
            this.btnFoods = new FontAwesome.Sharp.IconButton();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.btnExtraReports = new FontAwesome.Sharp.IconButton();
            this.btnMonthlyReport = new FontAwesome.Sharp.IconButton();
            this.btnWeeklyReport = new FontAwesome.Sharp.IconButton();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.pnlMeals = new System.Windows.Forms.Panel();
            this.btnProTakip = new FontAwesome.Sharp.IconButton();
            this.btnProPlan = new FontAwesome.Sharp.IconButton();
            this.btnTakip = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlAllMenu.SuspendLayout();
            this.pnlFoods.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.pnlMeals.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WFA_ProDiet.UI.Properties.Resources.HomePageBanner;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btnReturnLogin);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnReturnLogin
            // 
            this.btnReturnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReturnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReturnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnReturnLogin.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            this.btnReturnLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnReturnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturnLogin.IconSize = 45;
            this.btnReturnLogin.Location = new System.Drawing.Point(1228, 0);
            this.btnReturnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturnLogin.Name = "btnReturnLogin";
            this.btnReturnLogin.Size = new System.Drawing.Size(66, 100);
            this.btnReturnLogin.TabIndex = 1;
            this.btnReturnLogin.UseVisualStyleBackColor = true;
            this.btnReturnLogin.Click += new System.EventHandler(this.btnReturnLogin_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.btnUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 45;
            this.btnUser.Location = new System.Drawing.Point(1294, 0);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(51, 100);
            this.btnUser.TabIndex = 0;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pnlAllMenu
            // 
            this.pnlAllMenu.AutoScroll = true;
            this.pnlAllMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.pnlAllMenu.Controls.Add(this.pnlFoods);
            this.pnlAllMenu.Controls.Add(this.btnFoods);
            this.pnlAllMenu.Controls.Add(this.pnlReports);
            this.pnlAllMenu.Controls.Add(this.btnReports);
            this.pnlAllMenu.Controls.Add(this.pnlMeals);
            this.pnlAllMenu.Controls.Add(this.btnTakip);
            this.pnlAllMenu.Controls.Add(this.panel3);
            this.pnlAllMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAllMenu.Location = new System.Drawing.Point(0, 100);
            this.pnlAllMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlAllMenu.Name = "pnlAllMenu";
            this.pnlAllMenu.Size = new System.Drawing.Size(248, 747);
            this.pnlAllMenu.TabIndex = 1;
            // 
            // pnlFoods
            // 
            this.pnlFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.pnlFoods.Controls.Add(this.btnEditFoods);
            this.pnlFoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFoods.Location = new System.Drawing.Point(0, 619);
            this.pnlFoods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFoods.Name = "pnlFoods";
            this.pnlFoods.Size = new System.Drawing.Size(248, 59);
            this.pnlFoods.TabIndex = 7;
            this.pnlFoods.Tag = "1";
            this.pnlFoods.Visible = false;
            // 
            // btnEditFoods
            // 
            this.btnEditFoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditFoods.FlatAppearance.BorderSize = 0;
            this.btnEditFoods.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditFoods.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(171)))));
            this.btnEditFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFoods.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditFoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnEditFoods.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditFoods.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnEditFoods.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditFoods.IconSize = 30;
            this.btnEditFoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFoods.Location = new System.Drawing.Point(0, 0);
            this.btnEditFoods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditFoods.Name = "btnEditFoods";
            this.btnEditFoods.Size = new System.Drawing.Size(248, 53);
            this.btnEditFoods.TabIndex = 5;
            this.btnEditFoods.Text = "Besin Ekle";
            this.btnEditFoods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditFoods.UseVisualStyleBackColor = true;
            this.btnEditFoods.Click += new System.EventHandler(this.btnEditFoods_Click);
            // 
            // btnFoods
            // 
            this.btnFoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoods.FlatAppearance.BorderSize = 0;
            this.btnFoods.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFoods.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(171)))));
            this.btnFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoods.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnFoods.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnFoods.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnFoods.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFoods.IconSize = 40;
            this.btnFoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoods.Location = new System.Drawing.Point(0, 547);
            this.btnFoods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFoods.Name = "btnFoods";
            this.btnFoods.Size = new System.Drawing.Size(248, 72);
            this.btnFoods.TabIndex = 2;
            this.btnFoods.Text = "Besinler";
            this.btnFoods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoods.UseVisualStyleBackColor = true;
            this.btnFoods.Click += new System.EventHandler(this.btnFoods_Click);
            // 
            // pnlReports
            // 
            this.pnlReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.pnlReports.Controls.Add(this.btnExtraReports);
            this.pnlReports.Controls.Add(this.btnMonthlyReport);
            this.pnlReports.Controls.Add(this.btnWeeklyReport);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReports.Location = new System.Drawing.Point(0, 384);
            this.pnlReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(248, 163);
            this.pnlReports.TabIndex = 5;
            this.pnlReports.Tag = "1";
            this.pnlReports.Visible = false;
            // 
            // btnExtraReports
            // 
            this.btnExtraReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtraReports.FlatAppearance.BorderSize = 0;
            this.btnExtraReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExtraReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(171)))));
            this.btnExtraReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtraReports.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExtraReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnExtraReports.IconChar = FontAwesome.Sharp.IconChar.Superpowers;
            this.btnExtraReports.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnExtraReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExtraReports.IconSize = 30;
            this.btnExtraReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtraReports.Location = new System.Drawing.Point(0, 106);
            this.btnExtraReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExtraReports.Name = "btnExtraReports";
            this.btnExtraReports.Size = new System.Drawing.Size(248, 53);
            this.btnExtraReports.TabIndex = 8;
            this.btnExtraReports.Text = "İstatistikler";
            this.btnExtraReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtraReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExtraReports.UseVisualStyleBackColor = true;
            this.btnExtraReports.Click += new System.EventHandler(this.btnExtraReports_Click);
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonthlyReport.FlatAppearance.BorderSize = 0;
            this.btnMonthlyReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMonthlyReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(171)))));
            this.btnMonthlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyReport.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMonthlyReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnMonthlyReport.IconChar = FontAwesome.Sharp.IconChar.Superpowers;
            this.btnMonthlyReport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnMonthlyReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMonthlyReport.IconSize = 30;
            this.btnMonthlyReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthlyReport.Location = new System.Drawing.Point(0, 53);
            this.btnMonthlyReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(248, 53);
            this.btnMonthlyReport.TabIndex = 7;
            this.btnMonthlyReport.Text = "Aylık Rapor";
            this.btnMonthlyReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthlyReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonthlyReport.UseVisualStyleBackColor = true;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWeeklyReport.FlatAppearance.BorderSize = 0;
            this.btnWeeklyReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWeeklyReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(171)))));
            this.btnWeeklyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeeklyReport.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWeeklyReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnWeeklyReport.IconChar = FontAwesome.Sharp.IconChar.Superpowers;
            this.btnWeeklyReport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnWeeklyReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWeeklyReport.IconSize = 30;
            this.btnWeeklyReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeeklyReport.Location = new System.Drawing.Point(0, 0);
            this.btnWeeklyReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(248, 53);
            this.btnWeeklyReport.TabIndex = 6;
            this.btnWeeklyReport.Text = "Haftalık Rapor";
            this.btnWeeklyReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeeklyReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWeeklyReport.UseVisualStyleBackColor = true;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(171)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnReports.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 40;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 312);
            this.btnReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(248, 72);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Raporlar";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.ıconButton4_Click);
            // 
            // pnlMeals
            // 
            this.pnlMeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.pnlMeals.Controls.Add(this.btnProTakip);
            this.pnlMeals.Controls.Add(this.btnProPlan);
            this.pnlMeals.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMeals.Location = new System.Drawing.Point(0, 200);
            this.pnlMeals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMeals.Name = "pnlMeals";
            this.pnlMeals.Size = new System.Drawing.Size(248, 112);
            this.pnlMeals.TabIndex = 3;
            this.pnlMeals.Tag = "1";
            this.pnlMeals.Visible = false;
            // 
            // btnProTakip
            // 
            this.btnProTakip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProTakip.FlatAppearance.BorderSize = 0;
            this.btnProTakip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProTakip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(171)))));
            this.btnProTakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProTakip.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProTakip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnProTakip.IconChar = FontAwesome.Sharp.IconChar.Mask;
            this.btnProTakip.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnProTakip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProTakip.IconSize = 30;
            this.btnProTakip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProTakip.Location = new System.Drawing.Point(0, 55);
            this.btnProTakip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProTakip.Name = "btnProTakip";
            this.btnProTakip.Size = new System.Drawing.Size(248, 53);
            this.btnProTakip.TabIndex = 1;
            this.btnProTakip.Text = "Pro Takip";
            this.btnProTakip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProTakip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProTakip.UseVisualStyleBackColor = true;
            this.btnProTakip.Click += new System.EventHandler(this.btnProTakip_Click);
            // 
            // btnProPlan
            // 
            this.btnProPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProPlan.FlatAppearance.BorderSize = 0;
            this.btnProPlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(171)))));
            this.btnProPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnProPlan.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnProPlan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnProPlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProPlan.IconSize = 30;
            this.btnProPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProPlan.Location = new System.Drawing.Point(0, 0);
            this.btnProPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProPlan.Name = "btnProPlan";
            this.btnProPlan.Size = new System.Drawing.Size(248, 55);
            this.btnProPlan.TabIndex = 0;
            this.btnProPlan.Text = "Pro Planım";
            this.btnProPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProPlan.UseVisualStyleBackColor = true;
            this.btnProPlan.Click += new System.EventHandler(this.btnProPlan_Click);
            // 
            // btnTakip
            // 
            this.btnTakip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTakip.FlatAppearance.BorderSize = 0;
            this.btnTakip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTakip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(171)))));
            this.btnTakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakip.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnTakip.IconChar = FontAwesome.Sharp.IconChar.Road;
            this.btnTakip.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnTakip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTakip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakip.Location = new System.Drawing.Point(0, 128);
            this.btnTakip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTakip.Name = "btnTakip";
            this.btnTakip.Size = new System.Drawing.Size(248, 72);
            this.btnTakip.TabIndex = 0;
            this.btnTakip.Text = "Takip";
            this.btnTakip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTakip.UseVisualStyleBackColor = true;
            this.btnTakip.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.panel3.BackgroundImage = global::WFA_ProDiet.UI.Properties.Resources.PRODİET_TRANSPARAN_DENEME_13;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 128);
            this.panel3.TabIndex = 0;
            // 
            // pnlScreen
            // 
            this.pnlScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScreen.Location = new System.Drawing.Point(248, 100);
            this.pnlScreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(1097, 747);
            this.pnlScreen.TabIndex = 2;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1345, 847);
            this.Controls.Add(this.pnlScreen);
            this.Controls.Add(this.pnlAllMenu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Activated += new System.EventHandler(this.HomePage_Activated);
            this.panel1.ResumeLayout(false);
            this.pnlAllMenu.ResumeLayout(false);
            this.pnlFoods.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.pnlMeals.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnlAllMenu;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnTakip;
        private Panel pnlReports;
        private FontAwesome.Sharp.IconButton btnWeeklyReport;
        private FontAwesome.Sharp.IconButton btnReports;
        private Panel pnlMeals;
        private FontAwesome.Sharp.IconButton btnProPlan;
        private FontAwesome.Sharp.IconButton btnMonthlyReport;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnExtraReports;
        private Panel pnlFoods;
        private FontAwesome.Sharp.IconButton btnEditFoods;
        private FontAwesome.Sharp.IconButton btnFoods;
        public Panel pnlScreen;
        public FontAwesome.Sharp.IconButton btnProTakip;
        private FontAwesome.Sharp.IconButton btnReturnLogin;
    }
}