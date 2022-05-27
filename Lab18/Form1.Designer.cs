
namespace Lab18
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lamda = new System.Windows.Forms.NumericUpDown();
            this.mu = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txOperator = new System.Windows.Forms.TextBox();
            this.txQueue = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Statistic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.lamda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "λ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "μ";
            // 
            // lamda
            // 
            this.lamda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lamda.DecimalPlaces = 2;
            this.lamda.Location = new System.Drawing.Point(59, 25);
            this.lamda.Name = "lamda";
            this.lamda.Size = new System.Drawing.Size(120, 23);
            this.lamda.TabIndex = 2;
            // 
            // mu
            // 
            this.mu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mu.DecimalPlaces = 2;
            this.mu.Location = new System.Drawing.Point(255, 25);
            this.mu.Name = "mu";
            this.mu.Size = new System.Drawing.Size(120, 23);
            this.mu.TabIndex = 3;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Start.Location = new System.Drawing.Point(418, 24);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(116, 39);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 174);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(499, 325);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txOperator
            // 
            this.txOperator.Location = new System.Drawing.Point(769, 21);
            this.txOperator.Name = "txOperator";
            this.txOperator.Size = new System.Drawing.Size(347, 23);
            this.txOperator.TabIndex = 6;
            // 
            // txQueue
            // 
            this.txQueue.Location = new System.Drawing.Point(769, 70);
            this.txQueue.Name = "txQueue";
            this.txQueue.Size = new System.Drawing.Size(347, 23);
            this.txQueue.TabIndex = 7;
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(538, 174);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(499, 325);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // Statistic
            // 
            this.Statistic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Statistic.Location = new System.Drawing.Point(418, 70);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(116, 39);
            this.Statistic.TabIndex = 9;
            this.Statistic.Text = "Statistic";
            this.Statistic.UseVisualStyleBackColor = false;
            this.Statistic.Click += new System.EventHandler(this.Statistic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "number of operators";
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num.Location = new System.Drawing.Point(190, 87);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(120, 23);
            this.num.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1158, 557);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Statistic);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.txQueue);
            this.Controls.Add(this.txOperator);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.mu);
            this.Controls.Add(this.lamda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lamda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lamda;
        private System.Windows.Forms.NumericUpDown mu;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txOperator;
        private System.Windows.Forms.TextBox txQueue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button Statistic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num;
    }
}

