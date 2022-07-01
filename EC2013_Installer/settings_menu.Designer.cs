namespace EC2013_Installer
{
    partial class settings_menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.path_txt = new System.Windows.Forms.TextBox();
            this.browse_btn = new System.Windows.Forms.Button();
            this.lang_desc = new System.Windows.Forms.Label();
            this.lang_menu = new System.Windows.Forms.ComboBox();
            this.check_for_updates_desc = new System.Windows.Forms.Button();
            this.update_status_desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // path_txt
            // 
            this.path_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.path_txt.Location = new System.Drawing.Point(51, 71);
            this.path_txt.Multiline = true;
            this.path_txt.Name = "path_txt";
            this.path_txt.Size = new System.Drawing.Size(567, 25);
            this.path_txt.TabIndex = 7;
            this.path_txt.TextChanged += new System.EventHandler(this.path_txt_TextChanged);
            this.path_txt.MouseEnter += new System.EventHandler(this.path_txt_MouseEnter);
            this.path_txt.MouseLeave += new System.EventHandler(this.path_txt_MouseLeave);
            this.path_txt.MouseHover += new System.EventHandler(this.path_txt_MouseHover);
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(18, 71);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(24, 25);
            this.browse_btn.TabIndex = 6;
            this.browse_btn.Text = "...";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // lang_desc
            // 
            this.lang_desc.AutoSize = true;
            this.lang_desc.BackColor = System.Drawing.SystemColors.Control;
            this.lang_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lang_desc.Location = new System.Drawing.Point(19, 117);
            this.lang_desc.Name = "lang_desc";
            this.lang_desc.Size = new System.Drawing.Size(82, 20);
            this.lang_desc.TabIndex = 8;
            this.lang_desc.Text = "lang_desc";
            // 
            // lang_menu
            // 
            this.lang_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lang_menu.FormattingEnabled = true;
            this.lang_menu.Location = new System.Drawing.Point(497, 114);
            this.lang_menu.Name = "lang_menu";
            this.lang_menu.Size = new System.Drawing.Size(121, 28);
            this.lang_menu.TabIndex = 9;
            this.lang_menu.Text = "NONE";
            // 
            // check_for_updates_desc
            // 
            this.check_for_updates_desc.FlatAppearance.BorderSize = 2;
            this.check_for_updates_desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_for_updates_desc.ForeColor = System.Drawing.Color.White;
            this.check_for_updates_desc.Location = new System.Drawing.Point(18, 319);
            this.check_for_updates_desc.Name = "check_for_updates_desc";
            this.check_for_updates_desc.Size = new System.Drawing.Size(156, 32);
            this.check_for_updates_desc.TabIndex = 10;
            this.check_for_updates_desc.Text = "check_for_updates_desc";
            this.check_for_updates_desc.UseVisualStyleBackColor = true;
            // 
            // update_status_desc
            // 
            this.update_status_desc.AutoSize = true;
            this.update_status_desc.BackColor = System.Drawing.SystemColors.Control;
            this.update_status_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_status_desc.Location = new System.Drawing.Point(463, 324);
            this.update_status_desc.Name = "update_status_desc";
            this.update_status_desc.Size = new System.Drawing.Size(155, 20);
            this.update_status_desc.TabIndex = 11;
            this.update_status_desc.Text = "update_status_desc";
            this.update_status_desc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // settings_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.path_txt);
            this.Controls.Add(this.update_status_desc);
            this.Controls.Add(this.check_for_updates_desc);
            this.Controls.Add(this.lang_menu);
            this.Controls.Add(this.lang_desc);
            this.Controls.Add(this.browse_btn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "settings_menu";
            this.Size = new System.Drawing.Size(640, 368);
            this.Load += new System.EventHandler(this.settings_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path_txt;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Label lang_desc;
        private System.Windows.Forms.ComboBox lang_menu;
        private System.Windows.Forms.Button check_for_updates_desc;
        private System.Windows.Forms.Label update_status_desc;
    }
}
