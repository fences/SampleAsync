namespace SampleWF1
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtClearCount = new System.Windows.Forms.TextBox();
            this.txtDeleteCount = new System.Windows.Forms.TextBox();
            this.txtAddCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtModifyCount = new System.Windows.Forms.TextBox();
            this.lblDataList = new System.Windows.Forms.ListBox();
            this.chDataPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chDataPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 416);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(776, 22);
            this.txtMessage.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtClearCount
            // 
            this.txtClearCount.Location = new System.Drawing.Point(649, 349);
            this.txtClearCount.Name = "txtClearCount";
            this.txtClearCount.Size = new System.Drawing.Size(137, 22);
            this.txtClearCount.TabIndex = 2;
            // 
            // txtDeleteCount
            // 
            this.txtDeleteCount.Location = new System.Drawing.Point(649, 321);
            this.txtDeleteCount.Name = "txtDeleteCount";
            this.txtDeleteCount.Size = new System.Drawing.Size(137, 22);
            this.txtDeleteCount.TabIndex = 3;
            // 
            // txtAddCount
            // 
            this.txtAddCount.Location = new System.Drawing.Point(649, 293);
            this.txtAddCount.Name = "txtAddCount";
            this.txtAddCount.Size = new System.Drawing.Size(137, 22);
            this.txtAddCount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Delete Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clear Count:";
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Modify Count:";
            // 
            // txtModifyCount
            // 
            this.txtModifyCount.Location = new System.Drawing.Point(649, 377);
            this.txtModifyCount.Name = "txtModifyCount";
            this.txtModifyCount.Size = new System.Drawing.Size(137, 22);
            this.txtModifyCount.TabIndex = 8;
            // 
            // lblDataList
            // 
            this.lblDataList.FormattingEnabled = true;
            this.lblDataList.ItemHeight = 16;
            this.lblDataList.Location = new System.Drawing.Point(551, 20);
            this.lblDataList.Name = "lblDataList";
            this.lblDataList.Size = new System.Drawing.Size(235, 260);
            this.lblDataList.TabIndex = 10;
            // 
            // chDataPlot
            // 
            chartArea1.Name = "ChartArea1";
            this.chDataPlot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chDataPlot.Legends.Add(legend1);
            this.chDataPlot.Location = new System.Drawing.Point(12, 47);
            this.chDataPlot.Name = "chDataPlot";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chDataPlot.Series.Add(series1);
            this.chDataPlot.Size = new System.Drawing.Size(522, 351);
            this.chDataPlot.TabIndex = 11;
            this.chDataPlot.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.chDataPlot);
            this.Controls.Add(this.lblDataList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModifyCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddCount);
            this.Controls.Add(this.txtDeleteCount);
            this.Controls.Add(this.txtClearCount);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sample Async";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chDataPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtClearCount;
        private System.Windows.Forms.TextBox txtDeleteCount;
        private System.Windows.Forms.TextBox txtAddCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModifyCount;
        private System.Windows.Forms.ListBox lblDataList;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDataPlot;
    }
}

