namespace weather_application
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBCITY = new System.Windows.Forms.TextBox();
            this.BTNSEARCH = new System.Windows.Forms.Button();
            this.labcondition = new System.Windows.Forms.Label();
            this.labdetail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labsunrise = new System.Windows.Forms.Label();
            this.labsunset = new System.Windows.Forms.Label();
            this.labwindspeed = new System.Windows.Forms.Label();
            this.labpressure = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "CITY:";
            // 
            // TBCITY
            // 
            this.TBCITY.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCITY.Location = new System.Drawing.Point(247, 144);
            this.TBCITY.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TBCITY.Name = "TBCITY";
            this.TBCITY.Size = new System.Drawing.Size(346, 36);
            this.TBCITY.TabIndex = 2;
            // 
            // BTNSEARCH
            // 
            this.BTNSEARCH.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSEARCH.Location = new System.Drawing.Point(632, 140);
            this.BTNSEARCH.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BTNSEARCH.Name = "BTNSEARCH";
            this.BTNSEARCH.Size = new System.Drawing.Size(141, 42);
            this.BTNSEARCH.TabIndex = 3;
            this.BTNSEARCH.Text = "SEARCH";
            this.BTNSEARCH.UseVisualStyleBackColor = true;
            this.BTNSEARCH.Click += new System.EventHandler(this.BTNSEARCH_Click);
            // 
            // labcondition
            // 
            this.labcondition.AutoSize = true;
            this.labcondition.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcondition.Location = new System.Drawing.Point(178, 303);
            this.labcondition.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labcondition.Name = "labcondition";
            this.labcondition.Size = new System.Drawing.Size(130, 28);
            this.labcondition.TabIndex = 4;
            this.labcondition.Text = "CONDITION:";
            // 
            // labdetail
            // 
            this.labdetail.AutoSize = true;
            this.labdetail.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdetail.Location = new System.Drawing.Point(178, 373);
            this.labdetail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labdetail.Name = "labdetail";
            this.labdetail.Size = new System.Drawing.Size(94, 28);
            this.labdetail.TabIndex = 5;
            this.labdetail.Text = "DETAILS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(536, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "SUNRISE :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "SUNSET:";
            // 
            // labsunrise
            // 
            this.labsunrise.AutoSize = true;
            this.labsunrise.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsunrise.Location = new System.Drawing.Point(653, 292);
            this.labsunrise.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labsunrise.Name = "labsunrise";
            this.labsunrise.Size = new System.Drawing.Size(50, 28);
            this.labsunrise.TabIndex = 8;
            this.labsunrise.Text = "N/A";
            // 
            // labsunset
            // 
            this.labsunset.AutoSize = true;
            this.labsunset.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsunset.Location = new System.Drawing.Point(639, 373);
            this.labsunset.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labsunset.Name = "labsunset";
            this.labsunset.Size = new System.Drawing.Size(50, 28);
            this.labsunset.TabIndex = 9;
            this.labsunset.Text = "N/A";
            // 
            // labwindspeed
            // 
            this.labwindspeed.AutoSize = true;
            this.labwindspeed.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labwindspeed.Location = new System.Drawing.Point(942, 203);
            this.labwindspeed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labwindspeed.Name = "labwindspeed";
            this.labwindspeed.Size = new System.Drawing.Size(50, 28);
            this.labwindspeed.TabIndex = 10;
            this.labwindspeed.Text = "N/A";
            // 
            // labpressure
            // 
            this.labpressure.AutoSize = true;
            this.labpressure.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpressure.Location = new System.Drawing.Point(922, 433);
            this.labpressure.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labpressure.Name = "labpressure";
            this.labpressure.Size = new System.Drawing.Size(50, 28);
            this.labpressure.TabIndex = 12;
            this.labpressure.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(790, 433);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "PRESSURE :";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(183, 203);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(100, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 14;
            this.picIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(790, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "WIND SPEED:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1832, 935);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labpressure);
            this.Controls.Add(this.labwindspeed);
            this.Controls.Add(this.labsunset);
            this.Controls.Add(this.labsunrise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labdetail);
            this.Controls.Add(this.labcondition);
            this.Controls.Add(this.BTNSEARCH);
            this.Controls.Add(this.TBCITY);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCITY;
        private System.Windows.Forms.Button BTNSEARCH;
        private System.Windows.Forms.Label labcondition;
        private System.Windows.Forms.Label labdetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labsunrise;
        private System.Windows.Forms.Label labsunset;
        private System.Windows.Forms.Label labwindspeed;
        private System.Windows.Forms.Label labpressure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label label2;
    }
}

