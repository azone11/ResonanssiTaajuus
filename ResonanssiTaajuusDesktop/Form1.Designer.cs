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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagram)).BeginInit();
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
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 225);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
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
            this.pictureBoxDiagram.Location = new System.Drawing.Point(193, 50);
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
            this.descriptionText.Location = new System.Drawing.Point(12, 50);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.ReadOnly = true;
            this.descriptionText.Size = new System.Drawing.Size(175, 137);
            this.descriptionText.TabIndex = 12;
            this.descriptionText.Text = resources.GetString("descriptionText.Text");
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.Color.White;
            this.titleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleText.Location = new System.Drawing.Point(12, 13);
            this.titleText.Name = "titleText";
            this.titleText.ReadOnly = true;
            this.titleText.Size = new System.Drawing.Size(263, 19);
            this.titleText.TabIndex = 13;
            this.titleText.Text = "Resonanssitaajuuden etsiminen RCL-sarjapiiristä";
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(472, 486);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Resonanssitaajuus";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagram)).EndInit();
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
    }
}

