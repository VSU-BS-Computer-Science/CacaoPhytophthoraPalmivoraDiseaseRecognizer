namespace CacaoDiseaseRecognizer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.croppedImage150x150ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cropBox = new System.Windows.Forms.PictureBox();
            this.resultBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bulkClassifyButton = new System.Windows.Forms.Button();
            this.classifyButoon = new System.Windows.Forms.Button();
            this.cropButton = new System.Windows.Forms.Button();
            this.classifyBox = new System.Windows.Forms.PictureBox();
            this.loadImageBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cropBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1372, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullImageToolStripMenuItem,
            this.croppedImage150x150ToolStripMenuItem});
            this.loadImageToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            // 
            // fullImageToolStripMenuItem
            // 
            this.fullImageToolStripMenuItem.Name = "fullImageToolStripMenuItem";
            this.fullImageToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.fullImageToolStripMenuItem.Text = "Full Image";
            this.fullImageToolStripMenuItem.Click += new System.EventHandler(this.fullImageToolStripMenuItem_Click);
            // 
            // croppedImage150x150ToolStripMenuItem
            // 
            this.croppedImage150x150ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleImageToolStripMenuItem,
            this.folderedImageToolStripMenuItem});
            this.croppedImage150x150ToolStripMenuItem.Name = "croppedImage150x150ToolStripMenuItem";
            this.croppedImage150x150ToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.croppedImage150x150ToolStripMenuItem.Text = "Cropped Image(150x150)";
            // 
            // singleImageToolStripMenuItem
            // 
            this.singleImageToolStripMenuItem.Name = "singleImageToolStripMenuItem";
            this.singleImageToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.singleImageToolStripMenuItem.Text = "Single Image";
            this.singleImageToolStripMenuItem.Click += new System.EventHandler(this.singleImageToolStripMenuItem_Click);
            // 
            // folderedImageToolStripMenuItem
            // 
            this.folderedImageToolStripMenuItem.Name = "folderedImageToolStripMenuItem";
            this.folderedImageToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.folderedImageToolStripMenuItem.Text = "Foldered Image";
            this.folderedImageToolStripMenuItem.Click += new System.EventHandler(this.folderedImageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.cropBox);
            this.panel1.Location = new System.Drawing.Point(285, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 696);
            this.panel1.TabIndex = 4;
            // 
            // cropBox
            // 
            this.cropBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cropBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cropBox.Location = new System.Drawing.Point(0, 3);
            this.cropBox.Name = "cropBox";
            this.cropBox.Size = new System.Drawing.Size(738, 662);
            this.cropBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cropBox.TabIndex = 0;
            this.cropBox.TabStop = false;
            this.cropBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cropBox_MouseClick);
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.FormattingEnabled = true;
            this.resultBox.Location = new System.Drawing.Point(1073, 645);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(300, 86);
            this.resultBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Actual Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1083, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cropped Image";
            // 
            // bulkClassifyButton
            // 
            this.bulkClassifyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bulkClassifyButton.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkClassifyButton.Location = new System.Drawing.Point(1072, 587);
            this.bulkClassifyButton.Name = "bulkClassifyButton";
            this.bulkClassifyButton.Size = new System.Drawing.Size(301, 57);
            this.bulkClassifyButton.TabIndex = 10;
            this.bulkClassifyButton.Text = "Bulk Classify";
            this.bulkClassifyButton.UseVisualStyleBackColor = true;
            this.bulkClassifyButton.Click += new System.EventHandler(this.bulkClassifyButton_Click_1);
            // 
            // classifyButoon
            // 
            this.classifyButoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.classifyButoon.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classifyButoon.Location = new System.Drawing.Point(1072, 526);
            this.classifyButoon.Name = "classifyButoon";
            this.classifyButoon.Size = new System.Drawing.Size(301, 61);
            this.classifyButoon.TabIndex = 8;
            this.classifyButoon.Text = "Classify";
            this.classifyButoon.UseVisualStyleBackColor = true;
            this.classifyButoon.Click += new System.EventHandler(this.classifyButoon_Click);
            // 
            // cropButton
            // 
            this.cropButton.BackColor = System.Drawing.Color.Silver;
            this.cropButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cropButton.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cropButton.ForeColor = System.Drawing.Color.Black;
            this.cropButton.Location = new System.Drawing.Point(5, 505);
            this.cropButton.Name = "cropButton";
            this.cropButton.Size = new System.Drawing.Size(279, 226);
            this.cropButton.TabIndex = 2;
            this.cropButton.Text = "Crop";
            this.cropButton.UseVisualStyleBackColor = false;
            this.cropButton.Click += new System.EventHandler(this.cropButton_Click);
            // 
            // classifyBox
            // 
            this.classifyBox.BackColor = System.Drawing.Color.White;
            this.classifyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classifyBox.Location = new System.Drawing.Point(1072, 171);
            this.classifyBox.Name = "classifyBox";
            this.classifyBox.Size = new System.Drawing.Size(300, 354);
            this.classifyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.classifyBox.TabIndex = 6;
            this.classifyBox.TabStop = false;
            // 
            // loadImageBox
            // 
            this.loadImageBox.BackColor = System.Drawing.Color.White;
            this.loadImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadImageBox.Location = new System.Drawing.Point(3, 145);
            this.loadImageBox.Name = "loadImageBox";
            this.loadImageBox.Size = new System.Drawing.Size(279, 354);
            this.loadImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadImageBox.TabIndex = 0;
            this.loadImageBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1372, 757);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bulkClassifyButton);
            this.Controls.Add(this.classifyButoon);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.classifyBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cropButton);
            this.Controls.Add(this.loadImageBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cacao Disease Recognizer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cropBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loadImageBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem croppedImage150x150ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderedImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button cropButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cropBox;
        private System.Windows.Forms.PictureBox classifyBox;
        private System.Windows.Forms.ComboBox resultBox;
        private System.Windows.Forms.Button classifyButoon;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button bulkClassifyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

