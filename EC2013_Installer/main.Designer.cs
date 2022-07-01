namespace EC2013_Installer
{
    partial class main_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.ext_button = new System.Windows.Forms.Button();
            this.prgrsBar_pt1 = new System.Windows.Forms.Panel();
            this.prgrsBar_pt2 = new System.Windows.Forms.Panel();
            this.test_hash_button = new System.Windows.Forms.Button();
            this.status_bar = new System.Windows.Forms.Label();
            this.dev_button = new System.Windows.Forms.Button();
            this.dev_mode_but = new System.Windows.Forms.Button();
            this.dwnld_but = new System.Windows.Forms.Button();
            this.prog_name = new System.Windows.Forms.Label();
            this.settings_but = new System.Windows.Forms.Button();
            this.settings_menu_panel = new EC2013_Installer.settings_menu();
            this.prgrsBar_pt1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ext_button
            // 
            this.ext_button.BackColor = System.Drawing.Color.Transparent;
            this.ext_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ext_button.BackgroundImage")));
            this.ext_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ext_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ext_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ext_button.FlatAppearance.BorderSize = 0;
            this.ext_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ext_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.ext_button.ForeColor = System.Drawing.Color.Red;
            this.ext_button.Location = new System.Drawing.Point(590, 5);
            this.ext_button.Name = "ext_button";
            this.ext_button.Size = new System.Drawing.Size(45, 45);
            this.ext_button.TabIndex = 0;
            this.ext_button.UseVisualStyleBackColor = false;
            this.ext_button.Click += new System.EventHandler(this.ext_button_Click);
            // 
            // prgrsBar_pt1
            // 
            this.prgrsBar_pt1.Controls.Add(this.prgrsBar_pt2);
            this.prgrsBar_pt1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgrsBar_pt1.Location = new System.Drawing.Point(20, 328);
            this.prgrsBar_pt1.Name = "prgrsBar_pt1";
            this.prgrsBar_pt1.Padding = new System.Windows.Forms.Padding(2);
            this.prgrsBar_pt1.Size = new System.Drawing.Size(600, 25);
            this.prgrsBar_pt1.TabIndex = 1;
            // 
            // prgrsBar_pt2
            // 
            this.prgrsBar_pt2.BackColor = System.Drawing.Color.LimeGreen;
            this.prgrsBar_pt2.Dock = System.Windows.Forms.DockStyle.Left;
            this.prgrsBar_pt2.Location = new System.Drawing.Point(2, 2);
            this.prgrsBar_pt2.Name = "prgrsBar_pt2";
            this.prgrsBar_pt2.Size = new System.Drawing.Size(0, 21);
            this.prgrsBar_pt2.TabIndex = 0;
            // 
            // test_hash_button
            // 
            this.test_hash_button.Location = new System.Drawing.Point(20, 252);
            this.test_hash_button.Name = "test_hash_button";
            this.test_hash_button.Size = new System.Drawing.Size(138, 23);
            this.test_hash_button.TabIndex = 3;
            this.test_hash_button.Text = "test_hasher";
            this.test_hash_button.UseVisualStyleBackColor = true;
            this.test_hash_button.Click += new System.EventHandler(this.test_hash_button_Click);
            // 
            // status_bar
            // 
            this.status_bar.BackColor = System.Drawing.Color.Transparent;
            this.status_bar.ForeColor = System.Drawing.SystemColors.Control;
            this.status_bar.Location = new System.Drawing.Point(20, 307);
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(600, 20);
            this.status_bar.TabIndex = 6;
            this.status_bar.Text = "Status:";
            this.status_bar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dev_button
            // 
            this.dev_button.Location = new System.Drawing.Point(23, 79);
            this.dev_button.Name = "dev_button";
            this.dev_button.Size = new System.Drawing.Size(142, 25);
            this.dev_button.TabIndex = 7;
            this.dev_button.Text = "GenerateOriginalHash";
            this.dev_button.UseVisualStyleBackColor = true;
            this.dev_button.Visible = false;
            this.dev_button.Click += new System.EventHandler(this.dev_button_Click);
            // 
            // dev_mode_but
            // 
            this.dev_mode_but.Location = new System.Drawing.Point(23, 47);
            this.dev_mode_but.Name = "dev_mode_but";
            this.dev_mode_but.Size = new System.Drawing.Size(75, 26);
            this.dev_mode_but.TabIndex = 8;
            this.dev_mode_but.Text = "dev_mode";
            this.dev_mode_but.UseVisualStyleBackColor = true;
            this.dev_mode_but.Click += new System.EventHandler(this.button3_Click);
            // 
            // dwnld_but
            // 
            this.dwnld_but.Location = new System.Drawing.Point(20, 223);
            this.dwnld_but.Name = "dwnld_but";
            this.dwnld_but.Size = new System.Drawing.Size(138, 23);
            this.dwnld_but.TabIndex = 3;
            this.dwnld_but.Text = "download_test";
            this.dwnld_but.UseVisualStyleBackColor = true;
            this.dwnld_but.Click += new System.EventHandler(this.dwnld_but_Click);
            // 
            // prog_name
            // 
            this.prog_name.BackColor = System.Drawing.Color.Black;
            this.prog_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prog_name.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.prog_name.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.prog_name.Location = new System.Drawing.Point(6, 5);
            this.prog_name.Name = "prog_name";
            this.prog_name.Size = new System.Drawing.Size(532, 39);
            this.prog_name.TabIndex = 11;
            this.prog_name.Text = "prog_name";
            this.prog_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prog_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.prog_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // settings_but
            // 
            this.settings_but.BackColor = System.Drawing.Color.Transparent;
            this.settings_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settings_but.BackgroundImage")));
            this.settings_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_but.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.settings_but.FlatAppearance.BorderSize = 0;
            this.settings_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.settings_but.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.settings_but.Location = new System.Drawing.Point(540, 5);
            this.settings_but.Name = "settings_but";
            this.settings_but.Size = new System.Drawing.Size(45, 45);
            this.settings_but.TabIndex = 12;
            this.settings_but.UseVisualStyleBackColor = false;
            this.settings_but.Click += new System.EventHandler(this.settings_but_Click);
            // 
            // settings_menu_panel
            // 
            this.settings_menu_panel.BackColor = System.Drawing.Color.Transparent;
            this.settings_menu_panel.ForeColor = System.Drawing.Color.Black;
            this.settings_menu_panel.Location = new System.Drawing.Point(0, 0);
            this.settings_menu_panel.Name = "settings_menu_panel";
            this.settings_menu_panel.Size = new System.Drawing.Size(0, 0);
            this.settings_menu_panel.TabIndex = 13;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 368);
            this.Controls.Add(this.prog_name);
            this.Controls.Add(this.settings_but);
            this.Controls.Add(this.ext_button);
            this.Controls.Add(this.settings_menu_panel);
            this.Controls.Add(this.dev_mode_but);
            this.Controls.Add(this.dev_button);
            this.Controls.Add(this.status_bar);
            this.Controls.Add(this.dwnld_but);
            this.Controls.Add(this.test_hash_button);
            this.Controls.Add(this.prgrsBar_pt1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_form";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 15);
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.prgrsBar_pt1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ext_button;
        private System.Windows.Forms.Panel prgrsBar_pt1;
        private System.Windows.Forms.Panel prgrsBar_pt2;
        private System.Windows.Forms.Button test_hash_button;
        private System.Windows.Forms.Label status_bar;
        private System.Windows.Forms.Button dev_mode_but;
        private System.Windows.Forms.Button dev_button;
        private System.Windows.Forms.Button dwnld_but;
        private System.Windows.Forms.Label prog_name;
        private System.Windows.Forms.Button settings_but;
        private settings_menu settings_menu_panel;
    }
}

