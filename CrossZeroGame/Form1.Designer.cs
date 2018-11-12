namespace CrossZeroGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.goToChoosingLevel = new System.Windows.Forms.Button();
            this.userChooseGhost = new System.Windows.Forms.RadioButton();
            this.userChoosePacman = new System.Windows.Forms.RadioButton();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.starttext = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StartGame = new System.Windows.Forms.Button();
            this.hardLevel = new System.Windows.Forms.RadioButton();
            this.middleLevel = new System.Windows.Forms.RadioButton();
            this.easyLevel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Box4 = new System.Windows.Forms.PictureBox();
            this.Box9 = new System.Windows.Forms.PictureBox();
            this.Box8 = new System.Windows.Forms.PictureBox();
            this.Box7 = new System.Windows.Forms.PictureBox();
            this.Box6 = new System.Windows.Forms.PictureBox();
            this.Box5 = new System.Windows.Forms.PictureBox();
            this.Box3 = new System.Windows.Forms.PictureBox();
            this.Box2 = new System.Windows.Forms.PictureBox();
            this.Box1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(118, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 300);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 6;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.goToChoosingLevel);
            this.tabPage1.Controls.Add(this.userChooseGhost);
            this.tabPage1.Controls.Add(this.userChoosePacman);
            this.tabPage1.Controls.Add(this.img2);
            this.tabPage1.Controls.Add(this.img1);
            this.tabPage1.Controls.Add(this.starttext);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // goToChoosingLevel
            // 
            this.goToChoosingLevel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToChoosingLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.goToChoosingLevel.Location = new System.Drawing.Point(105, 232);
            this.goToChoosingLevel.Name = "goToChoosingLevel";
            this.goToChoosingLevel.Size = new System.Drawing.Size(75, 27);
            this.goToChoosingLevel.TabIndex = 11;
            this.goToChoosingLevel.Text = "Далі";
            this.goToChoosingLevel.UseVisualStyleBackColor = true;
            this.goToChoosingLevel.Click += new System.EventHandler(this.goToChoosingLevel_Click);
            // 
            // userChooseGhost
            // 
            this.userChooseGhost.AutoSize = true;
            this.userChooseGhost.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userChooseGhost.Location = new System.Drawing.Point(167, 188);
            this.userChooseGhost.Name = "userChooseGhost";
            this.userChooseGhost.Size = new System.Drawing.Size(62, 18);
            this.userChooseGhost.TabIndex = 10;
            this.userChooseGhost.TabStop = true;
            this.userChooseGhost.Text = "Ghost";
            this.userChooseGhost.UseVisualStyleBackColor = true;
            // 
            // userChoosePacman
            // 
            this.userChoosePacman.AutoSize = true;
            this.userChoosePacman.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userChoosePacman.Location = new System.Drawing.Point(41, 188);
            this.userChoosePacman.Name = "userChoosePacman";
            this.userChoosePacman.Size = new System.Drawing.Size(74, 18);
            this.userChoosePacman.TabIndex = 9;
            this.userChoosePacman.TabStop = true;
            this.userChoosePacman.Text = "Pacman";
            this.userChoosePacman.UseVisualStyleBackColor = true;
            // 
            // img2
            // 
            this.img2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img2.BackgroundImage")));
            this.img2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img2.Location = new System.Drawing.Point(167, 84);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(81, 83);
            this.img2.TabIndex = 8;
            this.img2.TabStop = false;
            // 
            // img1
            // 
            this.img1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img1.BackgroundImage")));
            this.img1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img1.Location = new System.Drawing.Point(41, 84);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(84, 83);
            this.img1.TabIndex = 7;
            this.img1.TabStop = false;
            // 
            // starttext
            // 
            this.starttext.AutoSize = true;
            this.starttext.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttext.Location = new System.Drawing.Point(51, 27);
            this.starttext.Name = "starttext";
            this.starttext.Size = new System.Drawing.Size(178, 18);
            this.starttext.TabIndex = 6;
            this.starttext.Text = "Choose your player";
            this.starttext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Controls.Add(this.StartGame);
            this.tabPage2.Controls.Add(this.hardLevel);
            this.tabPage2.Controls.Add(this.middleLevel);
            this.tabPage2.Controls.Add(this.easyLevel);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // StartGame
            // 
            this.StartGame.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartGame.Location = new System.Drawing.Point(84, 222);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(118, 39);
            this.StartGame.TabIndex = 9;
            this.StartGame.Text = "START";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // hardLevel
            // 
            this.hardLevel.AutoSize = true;
            this.hardLevel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardLevel.Location = new System.Drawing.Point(93, 164);
            this.hardLevel.Name = "hardLevel";
            this.hardLevel.Size = new System.Drawing.Size(56, 20);
            this.hardLevel.TabIndex = 8;
            this.hardLevel.Text = "Hard";
            this.hardLevel.UseVisualStyleBackColor = true;
            // 
            // middleLevel
            // 
            this.middleLevel.AutoSize = true;
            this.middleLevel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleLevel.Location = new System.Drawing.Point(93, 124);
            this.middleLevel.Name = "middleLevel";
            this.middleLevel.Size = new System.Drawing.Size(75, 20);
            this.middleLevel.TabIndex = 7;
            this.middleLevel.Text = "Medium";
            this.middleLevel.UseVisualStyleBackColor = true;
            // 
            // easyLevel
            // 
            this.easyLevel.AutoSize = true;
            this.easyLevel.Checked = true;
            this.easyLevel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyLevel.Location = new System.Drawing.Point(93, 86);
            this.easyLevel.Name = "easyLevel";
            this.easyLevel.Size = new System.Drawing.Size(57, 20);
            this.easyLevel.TabIndex = 6;
            this.easyLevel.TabStop = true;
            this.easyLevel.Text = "Easy";
            this.easyLevel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose a level:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage3.Controls.Add(this.Box4);
            this.tabPage3.Controls.Add(this.Box9);
            this.tabPage3.Controls.Add(this.Box8);
            this.tabPage3.Controls.Add(this.Box7);
            this.tabPage3.Controls.Add(this.Box6);
            this.tabPage3.Controls.Add(this.Box5);
            this.tabPage3.Controls.Add(this.Box3);
            this.tabPage3.Controls.Add(this.Box2);
            this.tabPage3.Controls.Add(this.Box1);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(292, 291);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // Box4
            // 
            this.Box4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box4.Location = new System.Drawing.Point(107, 21);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(79, 79);
            this.Box4.TabIndex = 18;
            this.Box4.TabStop = false;
            this.Box4.Click += new System.EventHandler(this.Box4_Click);
            // 
            // Box9
            // 
            this.Box9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box9.Location = new System.Drawing.Point(192, 191);
            this.Box9.Name = "Box9";
            this.Box9.Size = new System.Drawing.Size(79, 79);
            this.Box9.TabIndex = 17;
            this.Box9.TabStop = false;
            this.Box9.Click += new System.EventHandler(this.Box9_Click);
            // 
            // Box8
            // 
            this.Box8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box8.Location = new System.Drawing.Point(192, 106);
            this.Box8.Name = "Box8";
            this.Box8.Size = new System.Drawing.Size(79, 79);
            this.Box8.TabIndex = 16;
            this.Box8.TabStop = false;
            this.Box8.Click += new System.EventHandler(this.Box8_Click);
            // 
            // Box7
            // 
            this.Box7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box7.Location = new System.Drawing.Point(192, 21);
            this.Box7.Name = "Box7";
            this.Box7.Size = new System.Drawing.Size(79, 79);
            this.Box7.TabIndex = 15;
            this.Box7.TabStop = false;
            this.Box7.Click += new System.EventHandler(this.Box7_Click);
            // 
            // Box6
            // 
            this.Box6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box6.Location = new System.Drawing.Point(107, 191);
            this.Box6.Name = "Box6";
            this.Box6.Size = new System.Drawing.Size(79, 79);
            this.Box6.TabIndex = 14;
            this.Box6.TabStop = false;
            this.Box6.Click += new System.EventHandler(this.Box6_Click);
            // 
            // Box5
            // 
            this.Box5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box5.Location = new System.Drawing.Point(107, 106);
            this.Box5.Name = "Box5";
            this.Box5.Size = new System.Drawing.Size(79, 79);
            this.Box5.TabIndex = 13;
            this.Box5.TabStop = false;
            this.Box5.Click += new System.EventHandler(this.Box5_Click);
            // 
            // Box3
            // 
            this.Box3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box3.Location = new System.Drawing.Point(22, 191);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(79, 79);
            this.Box3.TabIndex = 11;
            this.Box3.TabStop = false;
            this.Box3.Click += new System.EventHandler(this.Box3_Click);
            // 
            // Box2
            // 
            this.Box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box2.Location = new System.Drawing.Point(22, 106);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(79, 79);
            this.Box2.TabIndex = 10;
            this.Box2.TabStop = false;
            this.Box2.Click += new System.EventHandler(this.Box2_Click);
            // 
            // Box1
            // 
            this.Box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box1.Location = new System.Drawing.Point(22, 21);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(79, 79);
            this.Box1.TabIndex = 9;
            this.Box1.TabStop = false;
            this.Box1.Click += new System.EventHandler(this.Box1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 366);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe with Pac-Man";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button goToChoosingLevel;
        private System.Windows.Forms.RadioButton userChooseGhost;
        private System.Windows.Forms.RadioButton userChoosePacman;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.Label starttext;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.RadioButton hardLevel;
        private System.Windows.Forms.RadioButton middleLevel;
        private System.Windows.Forms.RadioButton easyLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Box9;
        private System.Windows.Forms.PictureBox Box8;
        private System.Windows.Forms.PictureBox Box7;
        private System.Windows.Forms.PictureBox Box6;
        private System.Windows.Forms.PictureBox Box5;
        private System.Windows.Forms.PictureBox Box3;
        private System.Windows.Forms.PictureBox Box2;
        private System.Windows.Forms.PictureBox Box1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Box4;
    }
}

