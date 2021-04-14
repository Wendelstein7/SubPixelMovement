
namespace SubPixelMovement
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
        protected override void Dispose( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.checkBoxRun = new System.Windows.Forms.CheckBox();
            this.labelValues = new System.Windows.Forms.Label();
            this.checkBoxTurbo = new System.Windows.Forms.CheckBox();
            this.checkBoxSeperators = new System.Windows.Forms.CheckBox();
            this.checkBoxInvert = new System.Windows.Forms.CheckBox();
            this.linkLabelWiki = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(12, 105);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 200);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // timerMain
            // 
            this.timerMain.Interval = 20;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSpeed.Location = new System.Drawing.Point(12, 35);
            this.trackBarSpeed.Maximum = 150;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(600, 45);
            this.trackBarSpeed.TabIndex = 2;
            this.trackBarSpeed.Value = 50;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // checkBoxRun
            // 
            this.checkBoxRun.AutoSize = true;
            this.checkBoxRun.Checked = true;
            this.checkBoxRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRun.Location = new System.Drawing.Point(12, 12);
            this.checkBoxRun.Name = "checkBoxRun";
            this.checkBoxRun.Size = new System.Drawing.Size(46, 17);
            this.checkBoxRun.TabIndex = 3;
            this.checkBoxRun.Text = "Run";
            this.checkBoxRun.UseVisualStyleBackColor = true;
            this.checkBoxRun.CheckedChanged += new System.EventHandler(this.checkBoxRun_CheckedChanged);
            // 
            // labelValues
            // 
            this.labelValues.AutoSize = true;
            this.labelValues.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValues.Location = new System.Drawing.Point(12, 83);
            this.labelValues.Name = "labelValues";
            this.labelValues.Size = new System.Drawing.Size(107, 17);
            this.labelValues.TabIndex = 4;
            this.labelValues.Text = "information";
            // 
            // checkBoxTurbo
            // 
            this.checkBoxTurbo.AutoSize = true;
            this.checkBoxTurbo.Location = new System.Drawing.Point(88, 12);
            this.checkBoxTurbo.Name = "checkBoxTurbo";
            this.checkBoxTurbo.Size = new System.Drawing.Size(43, 17);
            this.checkBoxTurbo.TabIndex = 5;
            this.checkBoxTurbo.Text = "fast";
            this.checkBoxTurbo.UseVisualStyleBackColor = true;
            this.checkBoxTurbo.CheckedChanged += new System.EventHandler(this.checkBoxTurbo_CheckedChanged);
            // 
            // checkBoxSeperators
            // 
            this.checkBoxSeperators.AutoSize = true;
            this.checkBoxSeperators.Location = new System.Drawing.Point(176, 12);
            this.checkBoxSeperators.Name = "checkBoxSeperators";
            this.checkBoxSeperators.Size = new System.Drawing.Size(75, 17);
            this.checkBoxSeperators.TabIndex = 6;
            this.checkBoxSeperators.Text = "seperators";
            this.checkBoxSeperators.UseVisualStyleBackColor = true;
            // 
            // checkBoxInvert
            // 
            this.checkBoxInvert.AutoSize = true;
            this.checkBoxInvert.Checked = true;
            this.checkBoxInvert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInvert.Location = new System.Drawing.Point(278, 12);
            this.checkBoxInvert.Name = "checkBoxInvert";
            this.checkBoxInvert.Size = new System.Drawing.Size(52, 17);
            this.checkBoxInvert.TabIndex = 7;
            this.checkBoxInvert.Text = "invert";
            this.checkBoxInvert.UseVisualStyleBackColor = true;
            this.checkBoxInvert.CheckedChanged += new System.EventHandler(this.checkBoxInvert_CheckedChanged);
            // 
            // linkLabelWiki
            // 
            this.linkLabelWiki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelWiki.AutoSize = true;
            this.linkLabelWiki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelWiki.Location = new System.Drawing.Point(464, 12);
            this.linkLabelWiki.Name = "linkLabelWiki";
            this.linkLabelWiki.Size = new System.Drawing.Size(148, 13);
            this.linkLabelWiki.TabIndex = 8;
            this.linkLabelWiki.TabStop = true;
            this.linkLabelWiki.Text = "WikiPedia: Subpixel rendering";
            this.linkLabelWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWiki_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 317);
            this.Controls.Add(this.linkLabelWiki);
            this.Controls.Add(this.checkBoxInvert);
            this.Controls.Add(this.checkBoxSeperators);
            this.Controls.Add(this.checkBoxTurbo);
            this.Controls.Add(this.labelValues);
            this.Controls.Add(this.checkBoxRun);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "SubPixel Animation Testing Sandbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.CheckBox checkBoxRun;
        private System.Windows.Forms.Label labelValues;
        private System.Windows.Forms.CheckBox checkBoxTurbo;
        private System.Windows.Forms.CheckBox checkBoxSeperators;
        private System.Windows.Forms.CheckBox checkBoxInvert;
        private System.Windows.Forms.LinkLabel linkLabelWiki;
    }
}

