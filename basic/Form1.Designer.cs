namespace basic
{
    partial class merge_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(merge_page));
            this.choose_btn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.back_btn = new System.Windows.Forms.Button();
            this.merge_btn = new System.Windows.Forms.Button();
            this.path_box = new System.Windows.Forms.TextBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.heading_label = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // choose_btn
            // 
            this.choose_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.choose_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("choose_btn.BackgroundImage")));
            this.choose_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.choose_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choose_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_btn.Location = new System.Drawing.Point(473, 194);
            this.choose_btn.Name = "choose_btn";
            this.choose_btn.Size = new System.Drawing.Size(105, 32);
            this.choose_btn.TabIndex = 0;
            this.choose_btn.Text = "choose file";
            this.choose_btn.UseVisualStyleBackColor = false;
            this.choose_btn.Click += new System.EventHandler(this.choose_btn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(251, 267);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(128, 41);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // merge_btn
            // 
            this.merge_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.merge_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.merge_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merge_btn.Location = new System.Drawing.Point(52, 267);
            this.merge_btn.Name = "merge_btn";
            this.merge_btn.Size = new System.Drawing.Size(128, 41);
            this.merge_btn.TabIndex = 3;
            this.merge_btn.Text = "MERGE";
            this.merge_btn.UseVisualStyleBackColor = false;
            this.merge_btn.Click += new System.EventHandler(this.merge_btn_Click);
            // 
            // path_box
            // 
            this.path_box.Location = new System.Drawing.Point(12, 200);
            this.path_box.Name = "path_box";
            this.path_box.ReadOnly = true;
            this.path_box.Size = new System.Drawing.Size(444, 22);
            this.path_box.TabIndex = 4;
            this.path_box.TextChanged += new System.EventHandler(this.path_box_TextChanged);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(528, 397);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(128, 41);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(685, 347);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(116, 105);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // heading_label
            // 
            this.heading_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.heading_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.Location = new System.Drawing.Point(268, 121);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(188, 27);
            this.heading_label.TabIndex = 7;
            this.heading_label.Text = "FOR PDFs";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // merge_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.heading_label);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.path_box);
            this.Controls.Add(this.merge_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.choose_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "merge_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUSION (FOR PDFs)";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choose_btn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button merge_btn;
        private System.Windows.Forms.TextBox path_box;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

