using System.Windows.Forms;

namespace Ayubo_Travels
{
    partial class Package
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Package));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.B_Facebook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.B_Close = new System.Windows.Forms.Button();
            this.B_Twitter = new System.Windows.Forms.Button();
            this.B_Mini = new System.Windows.Forms.Button();
            this.B_Instregram = new System.Windows.Forms.Button();
            this.B_Setting = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Text3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Text2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Text1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Text4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Text5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Text6 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Text7 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Text8 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonViwe = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.B_LogOut = new System.Windows.Forms.Button();
            this.B_DayTour = new System.Windows.Forms.Button();
            this.B_Rent = new System.Windows.Forms.Button();
            this.B_pakage = new System.Windows.Forms.Button();
            this.B_Vehicles = new System.Windows.Forms.Button();
            this.B_Home = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Search = new System.Windows.Forms.Button();
            this.bunifuMaterialTextbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 10);
            this.panel2.TabIndex = 97;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDelete.BackColor = System.Drawing.Color.Fuchsia;
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDelete.Location = new System.Drawing.Point(858, 196);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(115, 34);
            this.ButtonDelete.TabIndex = 95;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAdd.BackColor = System.Drawing.Color.Fuchsia;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new System.Drawing.Point(858, 156);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(115, 34);
            this.ButtonAdd.TabIndex = 93;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // B_Facebook
            // 
            this.B_Facebook.FlatAppearance.BorderSize = 0;
            this.B_Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Facebook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Facebook.ForeColor = System.Drawing.Color.Transparent;
            this.B_Facebook.Image = ((System.Drawing.Image)(resources.GetObject("B_Facebook.Image")));
            this.B_Facebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Facebook.Location = new System.Drawing.Point(509, 10);
            this.B_Facebook.Name = "B_Facebook";
            this.B_Facebook.Size = new System.Drawing.Size(36, 34);
            this.B_Facebook.TabIndex = 84;
            this.B_Facebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Facebook.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 19);
            this.label4.TabIndex = 79;
            this.label4.Text = "Package | Ayubo Travels";
            // 
            // B_Close
            // 
            this.B_Close.FlatAppearance.BorderSize = 0;
            this.B_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Close.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.White;
            this.B_Close.Image = ((System.Drawing.Image)(resources.GetObject("B_Close.Image")));
            this.B_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Close.Location = new System.Drawing.Point(941, 11);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(32, 35);
            this.B_Close.TabIndex = 80;
            this.B_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // B_Twitter
            // 
            this.B_Twitter.FlatAppearance.BorderSize = 0;
            this.B_Twitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Twitter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Twitter.ForeColor = System.Drawing.Color.Transparent;
            this.B_Twitter.Image = ((System.Drawing.Image)(resources.GetObject("B_Twitter.Image")));
            this.B_Twitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Twitter.Location = new System.Drawing.Point(539, 10);
            this.B_Twitter.Name = "B_Twitter";
            this.B_Twitter.Size = new System.Drawing.Size(36, 34);
            this.B_Twitter.TabIndex = 83;
            this.B_Twitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Twitter.UseVisualStyleBackColor = true;
            // 
            // B_Mini
            // 
            this.B_Mini.FlatAppearance.BorderSize = 0;
            this.B_Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Mini.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Mini.ForeColor = System.Drawing.Color.White;
            this.B_Mini.Image = ((System.Drawing.Image)(resources.GetObject("B_Mini.Image")));
            this.B_Mini.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Mini.Location = new System.Drawing.Point(884, 11);
            this.B_Mini.Name = "B_Mini";
            this.B_Mini.Size = new System.Drawing.Size(32, 35);
            this.B_Mini.TabIndex = 81;
            this.B_Mini.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Mini.UseVisualStyleBackColor = true;
            // 
            // B_Instregram
            // 
            this.B_Instregram.FlatAppearance.BorderSize = 0;
            this.B_Instregram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Instregram.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Instregram.ForeColor = System.Drawing.Color.Transparent;
            this.B_Instregram.Image = ((System.Drawing.Image)(resources.GetObject("B_Instregram.Image")));
            this.B_Instregram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Instregram.Location = new System.Drawing.Point(567, 10);
            this.B_Instregram.Name = "B_Instregram";
            this.B_Instregram.Size = new System.Drawing.Size(36, 34);
            this.B_Instregram.TabIndex = 82;
            this.B_Instregram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Instregram.UseVisualStyleBackColor = true;
            // 
            // B_Setting
            // 
            this.B_Setting.FlatAppearance.BorderSize = 0;
            this.B_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Setting.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Setting.ForeColor = System.Drawing.Color.White;
            this.B_Setting.Image = ((System.Drawing.Image)(resources.GetObject("B_Setting.Image")));
            this.B_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Setting.Location = new System.Drawing.Point(913, 11);
            this.B_Setting.Name = "B_Setting";
            this.B_Setting.Size = new System.Drawing.Size(32, 35);
            this.B_Setting.TabIndex = 85;
            this.B_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Setting.UseVisualStyleBackColor = true;
            this.B_Setting.Click += new System.EventHandler(this.B_Setting_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Fuchsia;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(193, -6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 115);
            this.panel3.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Text3);
            this.groupBox1.Controls.Add(this.Text2);
            this.groupBox1.Controls.Add(this.Text1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.groupBox1.Location = new System.Drawing.Point(225, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 177);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package  Details";
            // 
            // Text3
            // 
            this.Text3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Text3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text3.HintForeColor = System.Drawing.Color.Empty;
            this.Text3.HintText = "Maximum Hours";
            this.Text3.isPassword = false;
            this.Text3.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text3.LineIdleColor = System.Drawing.Color.Gray;
            this.Text3.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text3.LineThickness = 3;
            this.Text3.Location = new System.Drawing.Point(29, 109);
            this.Text3.Margin = new System.Windows.Forms.Padding(4);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(215, 25);
            this.Text3.TabIndex = 107;
            this.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Text2
            // 
            this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text2.HintForeColor = System.Drawing.Color.Empty;
            this.Text2.HintText = "Maximum KM";
            this.Text2.isPassword = false;
            this.Text2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text2.LineIdleColor = System.Drawing.Color.Gray;
            this.Text2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text2.LineThickness = 3;
            this.Text2.Location = new System.Drawing.Point(29, 72);
            this.Text2.Margin = new System.Windows.Forms.Padding(4);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(215, 25);
            this.Text2.TabIndex = 106;
            this.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Text1
            // 
            this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text1.HintForeColor = System.Drawing.Color.Empty;
            this.Text1.HintText = "Pakage Name";
            this.Text1.isPassword = false;
            this.Text1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text1.LineIdleColor = System.Drawing.Color.Gray;
            this.Text1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text1.LineThickness = 3;
            this.Text1.Location = new System.Drawing.Point(29, 34);
            this.Text1.Margin = new System.Windows.Forms.Padding(4);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(215, 25);
            this.Text1.TabIndex = 105;
            this.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Text4
            // 
            this.Text4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Text4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text4.HintForeColor = System.Drawing.Color.Empty;
            this.Text4.HintText = "Extra KM Charg";
            this.Text4.isPassword = false;
            this.Text4.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text4.LineIdleColor = System.Drawing.Color.Gray;
            this.Text4.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text4.LineThickness = 3;
            this.Text4.Location = new System.Drawing.Point(35, 31);
            this.Text4.Margin = new System.Windows.Forms.Padding(4);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(214, 27);
            this.Text4.TabIndex = 105;
            this.Text4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Text5
            // 
            this.Text5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Text5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text5.HintForeColor = System.Drawing.Color.Empty;
            this.Text5.HintText = "Waititing Charg";
            this.Text5.isPassword = false;
            this.Text5.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text5.LineIdleColor = System.Drawing.Color.Gray;
            this.Text5.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text5.LineThickness = 3;
            this.Text5.Location = new System.Drawing.Point(35, 67);
            this.Text5.Margin = new System.Windows.Forms.Padding(4);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(214, 27);
            this.Text5.TabIndex = 106;
            this.Text5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Text6
            // 
            this.Text6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Text6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text6.HintForeColor = System.Drawing.Color.Empty;
            this.Text6.HintText = "Driver Overnight Charg";
            this.Text6.isPassword = false;
            this.Text6.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text6.LineIdleColor = System.Drawing.Color.Gray;
            this.Text6.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text6.LineThickness = 3;
            this.Text6.Location = new System.Drawing.Point(35, 105);
            this.Text6.Margin = new System.Windows.Forms.Padding(4);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(214, 27);
            this.Text6.TabIndex = 107;
            this.Text6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Text7
            // 
            this.Text7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Text7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text7.HintForeColor = System.Drawing.Color.Empty;
            this.Text7.HintText = "Vehicle Park Charg";
            this.Text7.isPassword = false;
            this.Text7.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text7.LineIdleColor = System.Drawing.Color.Gray;
            this.Text7.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text7.LineThickness = 3;
            this.Text7.Location = new System.Drawing.Point(35, 141);
            this.Text7.Margin = new System.Windows.Forms.Padding(4);
            this.Text7.Name = "Text7";
            this.Text7.Size = new System.Drawing.Size(214, 27);
            this.Text7.TabIndex = 108;
            this.Text7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Text8
            // 
            this.Text8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Text8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text8.HintForeColor = System.Drawing.Color.Empty;
            this.Text8.HintText = "Driver Charg";
            this.Text8.isPassword = false;
            this.Text8.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text8.LineIdleColor = System.Drawing.Color.Gray;
            this.Text8.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Text8.LineThickness = 3;
            this.Text8.Location = new System.Drawing.Point(35, 178);
            this.Text8.Margin = new System.Windows.Forms.Padding(4);
            this.Text8.Name = "Text8";
            this.Text8.Size = new System.Drawing.Size(214, 27);
            this.Text8.TabIndex = 109;
            this.Text8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Text8);
            this.groupBox3.Controls.Add(this.Text7);
            this.groupBox3.Controls.Add(this.Text6);
            this.groupBox3.Controls.Add(this.Text5);
            this.groupBox3.Controls.Add(this.Text4);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.groupBox3.Location = new System.Drawing.Point(530, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 232);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charging Details";
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonUpdate.BackColor = System.Drawing.Color.Fuchsia;
            this.ButtonUpdate.FlatAppearance.BorderSize = 0;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUpdate.Image")));
            this.ButtonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUpdate.Location = new System.Drawing.Point(858, 238);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(115, 34);
            this.ButtonUpdate.TabIndex = 106;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonViwe
            // 
            this.ButtonViwe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonViwe.BackColor = System.Drawing.Color.Fuchsia;
            this.ButtonViwe.FlatAppearance.BorderSize = 0;
            this.ButtonViwe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonViwe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViwe.ForeColor = System.Drawing.Color.White;
            this.ButtonViwe.Image = ((System.Drawing.Image)(resources.GetObject("ButtonViwe.Image")));
            this.ButtonViwe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonViwe.Location = new System.Drawing.Point(858, 278);
            this.ButtonViwe.Name = "ButtonViwe";
            this.ButtonViwe.Size = new System.Drawing.Size(115, 34);
            this.ButtonViwe.TabIndex = 107;
            this.ButtonViwe.Text = "Viwe Off";
            this.ButtonViwe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonViwe.UseVisualStyleBackColor = false;
            this.ButtonViwe.Click += new System.EventHandler(this.ButtonViwe_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonClear.BackColor = System.Drawing.Color.Fuchsia;
            this.ButtonClear.FlatAppearance.BorderSize = 0;
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("ButtonClear.Image")));
            this.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonClear.Location = new System.Drawing.Point(858, 318);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(115, 34);
            this.ButtonClear.TabIndex = 109;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Message.ForeColor = System.Drawing.Color.Crimson;
            this.Message.Location = new System.Drawing.Point(222, 370);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(12, 17);
            this.Message.TabIndex = 110;
            this.Message.Text = ".";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.Crimson;
            this.ID.Location = new System.Drawing.Point(795, 370);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 16);
            this.ID.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(767, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 111;
            this.label1.Text = "ID : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.B_LogOut);
            this.panel1.Controls.Add(this.B_DayTour);
            this.panel1.Controls.Add(this.B_Rent);
            this.panel1.Controls.Add(this.B_pakage);
            this.panel1.Controls.Add(this.B_Vehicles);
            this.panel1.Controls.Add(this.B_Home);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 464);
            this.panel1.TabIndex = 111;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // B_LogOut
            // 
            this.B_LogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_LogOut.FlatAppearance.BorderSize = 0;
            this.B_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_LogOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_LogOut.ForeColor = System.Drawing.Color.Fuchsia;
            this.B_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("B_LogOut.Image")));
            this.B_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_LogOut.Location = new System.Drawing.Point(15, 341);
            this.B_LogOut.Name = "B_LogOut";
            this.B_LogOut.Size = new System.Drawing.Size(179, 57);
            this.B_LogOut.TabIndex = 6;
            this.B_LogOut.Text = "  LogOut";
            this.B_LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_LogOut.UseVisualStyleBackColor = true;
            this.B_LogOut.Click += new System.EventHandler(this.B_LogOut_Click);
            // 
            // B_DayTour
            // 
            this.B_DayTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_DayTour.FlatAppearance.BorderSize = 0;
            this.B_DayTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_DayTour.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_DayTour.ForeColor = System.Drawing.Color.Fuchsia;
            this.B_DayTour.Image = ((System.Drawing.Image)(resources.GetObject("B_DayTour.Image")));
            this.B_DayTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_DayTour.Location = new System.Drawing.Point(15, 278);
            this.B_DayTour.Name = "B_DayTour";
            this.B_DayTour.Size = new System.Drawing.Size(179, 57);
            this.B_DayTour.TabIndex = 8;
            this.B_DayTour.Text = "  Day Tour ";
            this.B_DayTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_DayTour.UseVisualStyleBackColor = true;
            this.B_DayTour.Click += new System.EventHandler(this.B_DayTour_Click);
            // 
            // B_Rent
            // 
            this.B_Rent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Rent.FlatAppearance.BorderSize = 0;
            this.B_Rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Rent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Rent.ForeColor = System.Drawing.Color.Fuchsia;
            this.B_Rent.Image = ((System.Drawing.Image)(resources.GetObject("B_Rent.Image")));
            this.B_Rent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Rent.Location = new System.Drawing.Point(15, 224);
            this.B_Rent.Name = "B_Rent";
            this.B_Rent.Size = new System.Drawing.Size(179, 57);
            this.B_Rent.TabIndex = 9;
            this.B_Rent.Text = "  Rent";
            this.B_Rent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Rent.UseVisualStyleBackColor = true;
            this.B_Rent.Click += new System.EventHandler(this.B_Rent_Click);
            // 
            // B_pakage
            // 
            this.B_pakage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_pakage.FlatAppearance.BorderSize = 0;
            this.B_pakage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_pakage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_pakage.ForeColor = System.Drawing.Color.Fuchsia;
            this.B_pakage.Image = ((System.Drawing.Image)(resources.GetObject("B_pakage.Image")));
            this.B_pakage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_pakage.Location = new System.Drawing.Point(15, 170);
            this.B_pakage.Name = "B_pakage";
            this.B_pakage.Size = new System.Drawing.Size(179, 57);
            this.B_pakage.TabIndex = 10;
            this.B_pakage.Text = "  Package";
            this.B_pakage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_pakage.UseVisualStyleBackColor = true;
            this.B_pakage.Click += new System.EventHandler(this.B_pakage_Click);
            // 
            // B_Vehicles
            // 
            this.B_Vehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Vehicles.FlatAppearance.BorderSize = 0;
            this.B_Vehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Vehicles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Vehicles.ForeColor = System.Drawing.Color.Fuchsia;
            this.B_Vehicles.Image = ((System.Drawing.Image)(resources.GetObject("B_Vehicles.Image")));
            this.B_Vehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Vehicles.Location = new System.Drawing.Point(15, 116);
            this.B_Vehicles.Name = "B_Vehicles";
            this.B_Vehicles.Size = new System.Drawing.Size(179, 57);
            this.B_Vehicles.TabIndex = 11;
            this.B_Vehicles.Text = "  Vehicles";
            this.B_Vehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Vehicles.UseVisualStyleBackColor = true;
            this.B_Vehicles.Click += new System.EventHandler(this.B_Vehicles_Click);
            // 
            // B_Home
            // 
            this.B_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Home.FlatAppearance.BorderSize = 0;
            this.B_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Home.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Home.ForeColor = System.Drawing.Color.Fuchsia;
            this.B_Home.Image = ((System.Drawing.Image)(resources.GetObject("B_Home.Image")));
            this.B_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Home.Location = new System.Drawing.Point(15, 62);
            this.B_Home.Name = "B_Home";
            this.B_Home.Size = new System.Drawing.Size(179, 57);
            this.B_Home.TabIndex = 12;
            this.B_Home.Text = "  Home";
            this.B_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Home.UseVisualStyleBackColor = true;
            this.B_Home.Click += new System.EventHandler(this.B_Home_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DataGrid);
            this.panel4.Controls.Add(this.Search);
            this.panel4.Controls.Add(this.bunifuMaterialTextbox5);
            this.panel4.Location = new System.Drawing.Point(206, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(648, 331);
            this.panel4.TabIndex = 114;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.DoubleBuffered = true;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DataGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.DataGrid.Location = new System.Drawing.Point(3, 3);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.Size = new System.Drawing.Size(640, 286);
            this.DataGrid.TabIndex = 104;
            this.DataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_RowHeaderMouseClick_1);
            // 
            // Search
            // 
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search.BackColor = System.Drawing.Color.Fuchsia;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Fuchsia;
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.Location = new System.Drawing.Point(608, 295);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(35, 32);
            this.Search.TabIndex = 102;
            this.Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Search.UseVisualStyleBackColor = false;
            // 
            // bunifuMaterialTextbox5
            // 
            this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox5.HintText = "Search";
            this.bunifuMaterialTextbox5.isPassword = false;
            this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuMaterialTextbox5.LineThickness = 3;
            this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(435, 296);
            this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(168, 26);
            this.bunifuMaterialTextbox5.TabIndex = 103;
            this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox5.OnValueChanged += new System.EventHandler(this.BunifuMaterialTextbox5_OnValueChanged);
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(975, 459);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonViwe);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.B_Facebook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Twitter);
            this.Controls.Add(this.B_Mini);
            this.Controls.Add(this.B_Instregram);
            this.Controls.Add(this.B_Setting);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Package";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package | Ayubo Travels";
            this.Load += new System.EventHandler(this.Package_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button B_Facebook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Button B_Twitter;
        private System.Windows.Forms.Button B_Mini;
        private System.Windows.Forms.Button B_Instregram;
        private System.Windows.Forms.Button B_Setting;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Text8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Text7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Text6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Text5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Text4;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Text3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Text2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Text1;
        private Button ButtonUpdate;
        private Button ButtonViwe;
        private Button ButtonClear;
        private Label Message;
        private Label ID;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button B_LogOut;
        private Button B_DayTour;
        private Button B_Rent;
        private Button B_pakage;
        private Button B_Vehicles;
        private Button B_Home;
        private Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid;
        private Button Search;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;

        public Button Update1 { get => Update; set => Update = value; }
    }
}