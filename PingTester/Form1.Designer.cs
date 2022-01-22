﻿namespace PingTester
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelAddress_Label = new System.Windows.Forms.Label();
            this.labelPingResult_label = new System.Windows.Forms.Label();
            this.outputPingTestResult_richtextbox = new System.Windows.Forms.RichTextBox();
            this.chartPingHistory_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.inputAddress_TextBox = new System.Windows.Forms.TextBox();
            this.buttonStartPingTest_button = new System.Windows.Forms.Button();
            this.buttonAutomatikPingTest_button = new System.Windows.Forms.Button();
            this.dropdownMaxYValue_combobox = new System.Windows.Forms.ComboBox();
            this.labelMaxY_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPingHistory_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddress_Label
            // 
            this.labelAddress_Label.AutoSize = true;
            this.labelAddress_Label.Location = new System.Drawing.Point(11, 12);
            this.labelAddress_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress_Label.Name = "labelAddress_Label";
            this.labelAddress_Label.Size = new System.Drawing.Size(58, 13);
            this.labelAddress_Label.TabIndex = 1;
            this.labelAddress_Label.Text = "IP-Adresse";
            // 
            // labelPingResult_label
            // 
            this.labelPingResult_label.AutoSize = true;
            this.labelPingResult_label.Location = new System.Drawing.Point(7, 77);
            this.labelPingResult_label.Name = "labelPingResult_label";
            this.labelPingResult_label.Size = new System.Drawing.Size(99, 13);
            this.labelPingResult_label.TabIndex = 3;
            this.labelPingResult_label.Text = "Ping Test Ergebnis:";
            // 
            // outputPingTestResult_richtextbox
            // 
            this.outputPingTestResult_richtextbox.BackColor = System.Drawing.SystemColors.Info;
            this.outputPingTestResult_richtextbox.Location = new System.Drawing.Point(7, 93);
            this.outputPingTestResult_richtextbox.Name = "outputPingTestResult_richtextbox";
            this.outputPingTestResult_richtextbox.Size = new System.Drawing.Size(248, 195);
            this.outputPingTestResult_richtextbox.TabIndex = 4;
            this.outputPingTestResult_richtextbox.Text = "";
            // 
            // chartPingHistory_chart
            // 
            this.chartPingHistory_chart.BackColor = System.Drawing.SystemColors.Info;
            this.chartPingHistory_chart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartPingHistory_chart.BorderlineColor = System.Drawing.Color.Black;
            this.chartPingHistory_chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.Name = "ChartArea1";
            this.chartPingHistory_chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartPingHistory_chart.Legends.Add(legend5);
            this.chartPingHistory_chart.Location = new System.Drawing.Point(269, 93);
            this.chartPingHistory_chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartPingHistory_chart.Name = "chartPingHistory_chart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartPingHistory_chart.Series.Add(series5);
            this.chartPingHistory_chart.Size = new System.Drawing.Size(399, 195);
            this.chartPingHistory_chart.TabIndex = 5;
            this.chartPingHistory_chart.Text = "Pingverlauf";
            // 
            // inputAddress_TextBox
            // 
            this.inputAddress_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputAddress_TextBox.Location = new System.Drawing.Point(11, 27);
            this.inputAddress_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputAddress_TextBox.Name = "inputAddress_TextBox";
            this.inputAddress_TextBox.Size = new System.Drawing.Size(248, 26);
            this.inputAddress_TextBox.TabIndex = 0;
            this.inputAddress_TextBox.Text = "web.de";
            this.inputAddress_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterPressedOnIpTextbox);
            // 
            // buttonStartPingTest_button
            // 
            this.buttonStartPingTest_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonStartPingTest_button.Location = new System.Drawing.Point(263, 27);
            this.buttonStartPingTest_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStartPingTest_button.Name = "buttonStartPingTest_button";
            this.buttonStartPingTest_button.Size = new System.Drawing.Size(106, 29);
            this.buttonStartPingTest_button.TabIndex = 0;
            this.buttonStartPingTest_button.Text = "Start";
            this.buttonStartPingTest_button.UseVisualStyleBackColor = true;
            this.buttonStartPingTest_button.Click += new System.EventHandler(this.buttonStartPingTest_button_Click);
            // 
            // buttonAutomatikPingTest_button
            // 
            this.buttonAutomatikPingTest_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonAutomatikPingTest_button.Location = new System.Drawing.Point(374, 28);
            this.buttonAutomatikPingTest_button.Name = "buttonAutomatikPingTest_button";
            this.buttonAutomatikPingTest_button.Size = new System.Drawing.Size(129, 28);
            this.buttonAutomatikPingTest_button.TabIndex = 1;
            this.buttonAutomatikPingTest_button.Text = "Pingverlauf";
            this.buttonAutomatikPingTest_button.UseVisualStyleBackColor = true;
            this.buttonAutomatikPingTest_button.Click += new System.EventHandler(this.buttonAutomatikPingTest_button_Click);
            // 
            // dropdownMaxYValue_combobox
            // 
            this.dropdownMaxYValue_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dropdownMaxYValue_combobox.FormattingEnabled = true;
            this.dropdownMaxYValue_combobox.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "200",
            "dynamisch"});
            this.dropdownMaxYValue_combobox.Location = new System.Drawing.Point(588, 61);
            this.dropdownMaxYValue_combobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dropdownMaxYValue_combobox.Name = "dropdownMaxYValue_combobox";
            this.dropdownMaxYValue_combobox.Size = new System.Drawing.Size(80, 28);
            this.dropdownMaxYValue_combobox.TabIndex = 6;
            this.dropdownMaxYValue_combobox.Text = "100";
            this.dropdownMaxYValue_combobox.SelectedIndexChanged += new System.EventHandler(this.OnDropDownChangeMaxY);
            // 
            // labelMaxY_label
            // 
            this.labelMaxY_label.AutoSize = true;
            this.labelMaxY_label.Location = new System.Drawing.Point(575, 46);
            this.labelMaxY_label.Name = "labelMaxY_label";
            this.labelMaxY_label.Size = new System.Drawing.Size(93, 13);
            this.labelMaxY_label.TabIndex = 7;
            this.labelMaxY_label.Text = "Y-Achse maximum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(679, 300);
            this.Controls.Add(this.labelMaxY_label);
            this.Controls.Add(this.dropdownMaxYValue_combobox);
            this.Controls.Add(this.inputAddress_TextBox);
            this.Controls.Add(this.buttonStartPingTest_button);
            this.Controls.Add(this.buttonAutomatikPingTest_button);
            this.Controls.Add(this.chartPingHistory_chart);
            this.Controls.Add(this.outputPingTestResult_richtextbox);
            this.Controls.Add(this.labelPingResult_label);
            this.Controls.Add(this.labelAddress_Label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "PingTester";
            this.SizeChanged += new System.EventHandler(this.SizeChangedAction);
            ((System.ComponentModel.ISupportInitialize)(this.chartPingHistory_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAddress_Label;
        private System.Windows.Forms.Label labelPingResult_label;
        private System.Windows.Forms.RichTextBox outputPingTestResult_richtextbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPingHistory_chart;
        private System.Windows.Forms.TextBox inputAddress_TextBox;
        private System.Windows.Forms.Button buttonStartPingTest_button;
        private System.Windows.Forms.Button buttonAutomatikPingTest_button;
        private System.Windows.Forms.ComboBox dropdownMaxYValue_combobox;
        private System.Windows.Forms.Label labelMaxY_label;
    }
}
