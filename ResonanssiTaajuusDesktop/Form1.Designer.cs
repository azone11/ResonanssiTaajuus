namespace ResonanssiTaajuusDesktop
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBarFreq = new System.Windows.Forms.TrackBar();
            this.textBoxAmper = new System.Windows.Forms.TextBox();
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.pictureBoxDiagram = new System.Windows.Forms.PictureBox();
            this.textBoxMinFreq = new System.Windows.Forms.TextBox();
            this.textBoxMaxFreq = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.RichTextBox();
            this.titleText = new System.Windows.Forms.RichTextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(343, 288);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAll.TabIndex = 2;
            this.buttonClearAll.Text = "Tyhjennä";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chart1
            // 
            chartArea6.AxisX.Maximum = 10000D;
            chartArea6.AxisY.Maximum = 0.6D;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(12, 225);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(300, 202);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // trackBarFreq
            // 
            this.trackBarFreq.AccessibleName = "freqTrack";
            this.trackBarFreq.Location = new System.Drawing.Point(49, 206);
            this.trackBarFreq.Maximum = 10000;
            this.trackBarFreq.Minimum = 20;
            this.trackBarFreq.Name = "trackBarFreq";
            this.trackBarFreq.Size = new System.Drawing.Size(354, 45);
            this.trackBarFreq.TabIndex = 4;
            this.trackBarFreq.TickFrequency = 10;
            this.trackBarFreq.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFreq.Value = 20;
            // 
            // textBoxAmper
            // 
            this.textBoxAmper.BackColor = System.Drawing.Color.White;
            this.textBoxAmper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAmper.Enabled = false;
            this.textBoxAmper.Location = new System.Drawing.Point(328, 257);
            this.textBoxAmper.Name = "textBoxAmper";
            this.textBoxAmper.Size = new System.Drawing.Size(90, 13);
            this.textBoxAmper.TabIndex = 6;
            this.textBoxAmper.Text = "virta";
            this.textBoxAmper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.BackColor = System.Drawing.Color.White;
            this.textBoxFreq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFreq.Enabled = false;
            this.textBoxFreq.ForeColor = System.Drawing.Color.Black;
            this.textBoxFreq.Location = new System.Drawing.Point(328, 231);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(90, 13);
            this.textBoxFreq.TabIndex = 5;
            this.textBoxFreq.Text = "taajuus";
            this.textBoxFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxDiagram
            // 
            this.pictureBoxDiagram.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDiagram.Image")));
            this.pictureBoxDiagram.Location = new System.Drawing.Point(12, 38);
            this.pictureBoxDiagram.Name = "pictureBoxDiagram";
            this.pictureBoxDiagram.Size = new System.Drawing.Size(267, 137);
            this.pictureBoxDiagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDiagram.TabIndex = 7;
            this.pictureBoxDiagram.TabStop = false;
            // 
            // textBoxMinFreq
            // 
            this.textBoxMinFreq.BackColor = System.Drawing.Color.White;
            this.textBoxMinFreq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinFreq.Enabled = false;
            this.textBoxMinFreq.ForeColor = System.Drawing.Color.Black;
            this.textBoxMinFreq.Location = new System.Drawing.Point(12, 206);
            this.textBoxMinFreq.Name = "textBoxMinFreq";
            this.textBoxMinFreq.Size = new System.Drawing.Size(36, 13);
            this.textBoxMinFreq.TabIndex = 9;
            this.textBoxMinFreq.Text = "20 Hz";
            // 
            // textBoxMaxFreq
            // 
            this.textBoxMaxFreq.BackColor = System.Drawing.Color.White;
            this.textBoxMaxFreq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxFreq.Enabled = false;
            this.textBoxMaxFreq.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaxFreq.Location = new System.Drawing.Point(404, 206);
            this.textBoxMaxFreq.Name = "textBoxMaxFreq";
            this.textBoxMaxFreq.Size = new System.Drawing.Size(56, 13);
            this.textBoxMaxFreq.TabIndex = 10;
            this.textBoxMaxFreq.Text = "10000 Hz";
            // 
            // descriptionText
            // 
            this.descriptionText.BackColor = System.Drawing.Color.White;
            this.descriptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionText.Location = new System.Drawing.Point(466, 206);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.ReadOnly = true;
            this.descriptionText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.descriptionText.Size = new System.Drawing.Size(227, 214);
            this.descriptionText.TabIndex = 12;
            this.descriptionText.Text = resources.GetString("descriptionText.Text");
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.Color.White;
            this.titleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(12, 12);
            this.titleText.Name = "titleText";
            this.titleText.ReadOnly = true;
            this.titleText.Size = new System.Drawing.Size(338, 19);
            this.titleText.TabIndex = 13;
            this.titleText.Text = "Resonanssitaajuuden etsiminen RCL-sarjapiiristä";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Image = global::ResonanssiTaajuusDesktop.Properties.Resources.WP_20140929_14_19_03_Smart;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(347, 38);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(241, 137);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 14;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(282, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 13);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "R1 = 40 Ω";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(282, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 13);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "L1 = 2 mH";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(282, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(59, 13);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "C1 = 5 μF";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(282, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(59, 13);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "U = 20 V";
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(696, 432);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.textBoxMaxFreq);
            this.Controls.Add(this.textBoxMinFreq);
            this.Controls.Add(this.pictureBoxDiagram);
            this.Controls.Add(this.textBoxAmper);
            this.Controls.Add(this.textBoxFreq);
            this.Controls.Add(this.trackBarFreq);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonClearAll);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Resonanssitaajuus";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar trackBarFreq;
        private System.Windows.Forms.TextBox textBoxAmper;
        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.PictureBox pictureBoxDiagram;
        private System.Windows.Forms.TextBox textBoxMinFreq;
        private System.Windows.Forms.TextBox textBoxMaxFreq;
        private System.Windows.Forms.RichTextBox descriptionText;
        private System.Windows.Forms.RichTextBox titleText;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

