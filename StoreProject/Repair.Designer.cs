namespace StoreProject
{
    partial class Repair
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.contactbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.emailbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.brand = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.mod = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.time = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.problems = new Bunifu.Framework.UI.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.st = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.area = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.city = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.countrydrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.countrydrop);
            this.panel1.Controls.Add(this.problems);
            this.panel1.Controls.Add(this.city);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.area);
            this.panel1.Controls.Add(this.mod);
            this.panel1.Controls.Add(this.st);
            this.panel1.Controls.Add(this.brand);
            this.panel1.Controls.Add(this.confirmbtn);
            this.panel1.Controls.Add(this.contactbox);
            this.panel1.Controls.Add(this.emailbox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(254, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 890);
            this.panel1.TabIndex = 0;
            // 
            // confirmbtn
            // 
            this.confirmbtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.Location = new System.Drawing.Point(301, 723);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(185, 38);
            this.confirmbtn.TabIndex = 10;
            this.confirmbtn.Text = "ENTER";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // contactbox
            // 
            this.contactbox.BackColor = System.Drawing.Color.Gray;
            this.contactbox.BorderColorFocused = System.Drawing.Color.White;
            this.contactbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contactbox.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.contactbox.BorderThickness = 1;
            this.contactbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contactbox.ForeColor = System.Drawing.Color.Black;
            this.contactbox.isPassword = false;
            this.contactbox.Location = new System.Drawing.Point(517, 951);
            this.contactbox.Margin = new System.Windows.Forms.Padding(7);
            this.contactbox.Name = "contactbox";
            this.contactbox.Size = new System.Drawing.Size(666, 63);
            this.contactbox.TabIndex = 8;
            this.contactbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailbox
            // 
            this.emailbox.BackColor = System.Drawing.Color.Gray;
            this.emailbox.BorderColorFocused = System.Drawing.Color.White;
            this.emailbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailbox.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.emailbox.BorderThickness = 1;
            this.emailbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailbox.ForeColor = System.Drawing.Color.Black;
            this.emailbox.isPassword = false;
            this.emailbox.Location = new System.Drawing.Point(517, 1043);
            this.emailbox.Margin = new System.Windows.Forms.Padding(7);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(666, 63);
            this.emailbox.TabIndex = 8;
            this.emailbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(64, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = "PHONE NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "REPAIR";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(17, 819);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Products";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "About Us";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 264);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 54);
            this.button5.TabIndex = 5;
            this.button5.Text = "Contact Us";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 324);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(231, 54);
            this.button6.TabIndex = 6;
            this.button6.Text = "Settings";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // brand
            // 
            this.brand.BackColor = System.Drawing.Color.White;
            this.brand.BorderColorFocused = System.Drawing.Color.White;
            this.brand.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brand.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.brand.BorderThickness = 1;
            this.brand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand.ForeColor = System.Drawing.Color.Black;
            this.brand.isPassword = false;
            this.brand.Location = new System.Drawing.Point(380, 90);
            this.brand.Margin = new System.Windows.Forms.Padding(5);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(228, 28);
            this.brand.TabIndex = 12;
            this.brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.brand.OnValueChanged += new System.EventHandler(this.brand_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(64, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "PHONE MODEL:";
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.Color.White;
            this.mod.BorderColorFocused = System.Drawing.Color.White;
            this.mod.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mod.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.mod.BorderThickness = 1;
            this.mod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod.ForeColor = System.Drawing.Color.Black;
            this.mod.isPassword = false;
            this.mod.Location = new System.Drawing.Point(380, 138);
            this.mod.Margin = new System.Windows.Forms.Padding(5);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(228, 28);
            this.mod.TabIndex = 12;
            this.mod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(64, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "TIME USED:";
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.White;
            this.time.BorderColorFocused = System.Drawing.Color.White;
            this.time.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.time.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.time.BorderThickness = 1;
            this.time.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Black;
            this.time.isPassword = false;
            this.time.Location = new System.Drawing.Point(380, 193);
            this.time.Margin = new System.Windows.Forms.Padding(5);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(228, 28);
            this.time.TabIndex = 12;
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(64, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "PHONE PROBLEM:";
            // 
            // problems
            // 
            this.problems.BackColor = System.Drawing.Color.Transparent;
            this.problems.BorderRadius = 3;
            this.problems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problems.ForeColor = System.Drawing.Color.White;
            this.problems.Items = new string[] {
        "SELECT*",
        "Smart Phone Is Running Slowly",
        "Poor Battery Life",
        "Storage Space Problem",
        "Phone or App Crashes",
        "Overheating",
        "Apps not downloading",
        "Synchronization Issue"};
            this.problems.Location = new System.Drawing.Point(380, 234);
            this.problems.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.problems.Name = "problems";
            this.problems.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.problems.onHoverColor = System.Drawing.Color.White;
            this.problems.selectedIndex = 0;
            this.problems.Size = new System.Drawing.Size(238, 36);
            this.problems.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(346, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 37);
            this.label7.TabIndex = 5;
            this.label7.Text = "ADDRESS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(64, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 34);
            this.label8.TabIndex = 6;
            this.label8.Text = "STREET:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(64, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 34);
            this.label9.TabIndex = 6;
            this.label9.Text = "AREA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(64, 519);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 34);
            this.label10.TabIndex = 6;
            this.label10.Text = "CITY:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(64, 568);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 34);
            this.label11.TabIndex = 6;
            this.label11.Text = "COUNTY:";
            // 
            // st
            // 
            this.st.BackColor = System.Drawing.Color.White;
            this.st.BorderColorFocused = System.Drawing.Color.White;
            this.st.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.st.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.st.BorderThickness = 1;
            this.st.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.st.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st.ForeColor = System.Drawing.Color.Black;
            this.st.isPassword = false;
            this.st.Location = new System.Drawing.Point(380, 422);
            this.st.Margin = new System.Windows.Forms.Padding(5);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(228, 28);
            this.st.TabIndex = 12;
            this.st.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // area
            // 
            this.area.BackColor = System.Drawing.Color.White;
            this.area.BorderColorFocused = System.Drawing.Color.White;
            this.area.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.area.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.area.BorderThickness = 1;
            this.area.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.area.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area.ForeColor = System.Drawing.Color.Black;
            this.area.isPassword = false;
            this.area.Location = new System.Drawing.Point(380, 470);
            this.area.Margin = new System.Windows.Forms.Padding(5);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(228, 28);
            this.area.TabIndex = 12;
            this.area.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.Color.White;
            this.city.BorderColorFocused = System.Drawing.Color.White;
            this.city.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.city.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.city.BorderThickness = 1;
            this.city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.city.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.Black;
            this.city.isPassword = false;
            this.city.Location = new System.Drawing.Point(380, 525);
            this.city.Margin = new System.Windows.Forms.Padding(5);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(228, 28);
            this.city.TabIndex = 12;
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // countrydrop
            // 
            this.countrydrop.BackColor = System.Drawing.Color.Transparent;
            this.countrydrop.BorderRadius = 3;
            this.countrydrop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countrydrop.ForeColor = System.Drawing.Color.White;
            this.countrydrop.Items = new string[] {
        "COUNTRIES",
        "Pakistan",
        "Saudi Arabia",
        "Turkey",
        "Iran",
        "China",
        "Qatar"};
            this.countrydrop.Location = new System.Drawing.Point(380, 580);
            this.countrydrop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.countrydrop.Name = "countrydrop";
            this.countrydrop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.countrydrop.onHoverColor = System.Drawing.Color.White;
            this.countrydrop.selectedIndex = 0;
            this.countrydrop.Size = new System.Drawing.Size(275, 36);
            this.countrydrop.TabIndex = 14;
            // 
            // Repair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 890);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Repair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox contactbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox emailbox;
        private System.Windows.Forms.Button confirmbtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox time;
        private Bunifu.Framework.UI.BunifuMetroTextbox mod;
        private Bunifu.Framework.UI.BunifuMetroTextbox brand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown problems;
        private Bunifu.Framework.UI.BunifuMetroTextbox city;
        private Bunifu.Framework.UI.BunifuMetroTextbox area;
        private Bunifu.Framework.UI.BunifuMetroTextbox st;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDropdown countrydrop;
    }
}