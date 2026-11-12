namespace Graficos
{
    partial class FormGrafico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxXValor = new System.Windows.Forms.TextBox();
            this.textBoxYValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonInserirValores = new System.Windows.Forms.Button();
            this.dataGridViewdataValores = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonLimpar = new System.Windows.Forms.Button();
            this.ComboBoxtipoGrafico = new System.Windows.Forms.ComboBox();
            this.ComboBoxpalleteCor = new System.Windows.Forms.ComboBox();
            this.checkBoxgrafico3D = new System.Windows.Forms.CheckBox();
            this.ButtonAleatorio = new System.Windows.Forms.Button();
            this.chartGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdataValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor de X ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor de Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxXValor
            // 
            this.textBoxXValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXValor.Location = new System.Drawing.Point(12, 88);
            this.textBoxXValor.Multiline = true;
            this.textBoxXValor.Name = "textBoxXValor";
            this.textBoxXValor.Size = new System.Drawing.Size(157, 31);
            this.textBoxXValor.TabIndex = 2;
            this.textBoxXValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxXValor_KeyPress);
            // 
            // textBoxYValor
            // 
            this.textBoxYValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYValor.Location = new System.Drawing.Point(180, 88);
            this.textBoxYValor.Multiline = true;
            this.textBoxYValor.Name = "textBoxYValor";
            this.textBoxYValor.Size = new System.Drawing.Size(157, 31);
            this.textBoxYValor.TabIndex = 3;
            this.textBoxYValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYValor_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gráfico";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonInserirValores
            // 
            this.ButtonInserirValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInserirValores.Location = new System.Drawing.Point(12, 125);
            this.ButtonInserirValores.Name = "ButtonInserirValores";
            this.ButtonInserirValores.Size = new System.Drawing.Size(325, 44);
            this.ButtonInserirValores.TabIndex = 19;
            this.ButtonInserirValores.Text = "Inserir Valores no Gráfico";
            this.ButtonInserirValores.UseVisualStyleBackColor = true;
            this.ButtonInserirValores.Click += new System.EventHandler(this.ButtonInserirValores_Click);
            // 
            // dataGridViewdataValores
            // 
            this.dataGridViewdataValores.AllowUserToAddRows = false;
            this.dataGridViewdataValores.AllowUserToDeleteRows = false;
            this.dataGridViewdataValores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewdataValores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewdataValores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewdataValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdataValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridViewdataValores.Location = new System.Drawing.Point(12, 175);
            this.dataGridViewdataValores.Name = "dataGridViewdataValores";
            this.dataGridViewdataValores.ReadOnly = true;
            this.dataGridViewdataValores.RowHeadersVisible = false;
            this.dataGridViewdataValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewdataValores.Size = new System.Drawing.Size(325, 213);
            this.dataGridViewdataValores.TabIndex = 21;
            this.dataGridViewdataValores.SelectionChanged += new System.EventHandler(this.dataGridViewdataValores_SelectionChanged);
            // 
            // x
            // 
            this.x.HeaderText = "Eixo X";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            // 
            // y
            // 
            this.y.HeaderText = "Eixo Y";
            this.y.Name = "y";
            this.y.ReadOnly = true;
            // 
            // ButtonLimpar
            // 
            this.ButtonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLimpar.Location = new System.Drawing.Point(12, 394);
            this.ButtonLimpar.Name = "ButtonLimpar";
            this.ButtonLimpar.Size = new System.Drawing.Size(325, 44);
            this.ButtonLimpar.TabIndex = 22;
            this.ButtonLimpar.Text = "Limpar Gráfico";
            this.ButtonLimpar.UseVisualStyleBackColor = true;
            this.ButtonLimpar.Click += new System.EventHandler(this.ButtonLimpar_Click);
            // 
            // ComboBoxtipoGrafico
            // 
            this.ComboBoxtipoGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxtipoGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxtipoGrafico.FormattingEnabled = true;
            this.ComboBoxtipoGrafico.Location = new System.Drawing.Point(10, 457);
            this.ComboBoxtipoGrafico.Name = "ComboBoxtipoGrafico";
            this.ComboBoxtipoGrafico.Size = new System.Drawing.Size(324, 28);
            this.ComboBoxtipoGrafico.TabIndex = 23;
            this.ComboBoxtipoGrafico.SelectedIndexChanged += new System.EventHandler(this.ComboBoxtipoGrafico_SelectedIndexChanged);
            // 
            // ComboBoxpalleteCor
            // 
            this.ComboBoxpalleteCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxpalleteCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxpalleteCor.FormattingEnabled = true;
            this.ComboBoxpalleteCor.Location = new System.Drawing.Point(340, 457);
            this.ComboBoxpalleteCor.Name = "ComboBoxpalleteCor";
            this.ComboBoxpalleteCor.Size = new System.Drawing.Size(324, 28);
            this.ComboBoxpalleteCor.TabIndex = 25;
            this.ComboBoxpalleteCor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxpalleteCor_SelectedIndexChanged);
            // 
            // checkBoxgrafico3D
            // 
            this.checkBoxgrafico3D.AutoSize = true;
            this.checkBoxgrafico3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxgrafico3D.Location = new System.Drawing.Point(670, 457);
            this.checkBoxgrafico3D.Name = "checkBoxgrafico3D";
            this.checkBoxgrafico3D.Size = new System.Drawing.Size(105, 24);
            this.checkBoxgrafico3D.TabIndex = 26;
            this.checkBoxgrafico3D.Text = "Gráfico 3D";
            this.checkBoxgrafico3D.UseVisualStyleBackColor = true;
            this.checkBoxgrafico3D.CheckedChanged += new System.EventHandler(this.checkBoxgrafico3D_CheckedChanged);
            // 
            // ButtonAleatorio
            // 
            this.ButtonAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAleatorio.Location = new System.Drawing.Point(781, 449);
            this.ButtonAleatorio.Name = "ButtonAleatorio";
            this.ButtonAleatorio.Size = new System.Drawing.Size(156, 44);
            this.ButtonAleatorio.TabIndex = 27;
            this.ButtonAleatorio.Text = "Inserir Valores Aleatorios";
            this.ButtonAleatorio.UseVisualStyleBackColor = true;
            this.ButtonAleatorio.Click += new System.EventHandler(this.ButtonAleatorio_Click);
            // 
            // chartGrafico
            // 
            chartArea4.Name = "ChartArea1";
            this.chartGrafico.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartGrafico.Legends.Add(legend4);
            this.chartGrafico.Location = new System.Drawing.Point(358, 12);
            this.chartGrafico.Name = "chartGrafico";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "X vs Y";
            this.chartGrafico.Series.Add(series4);
            this.chartGrafico.Size = new System.Drawing.Size(579, 426);
            this.chartGrafico.TabIndex = 28;
            this.chartGrafico.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 497);
            this.Controls.Add(this.chartGrafico);
            this.Controls.Add(this.ButtonAleatorio);
            this.Controls.Add(this.checkBoxgrafico3D);
            this.Controls.Add(this.ComboBoxpalleteCor);
            this.Controls.Add(this.ComboBoxtipoGrafico);
            this.Controls.Add(this.ButtonLimpar);
            this.Controls.Add(this.dataGridViewdataValores);
            this.Controls.Add(this.ButtonInserirValores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxYValor);
            this.Controls.Add(this.textBoxXValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGrafico";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormGrafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdataValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxXValor;
        private System.Windows.Forms.TextBox textBoxYValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonInserirValores;
        private System.Windows.Forms.DataGridView dataGridViewdataValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Button ButtonLimpar;
        private System.Windows.Forms.ComboBox ComboBoxtipoGrafico;
        private System.Windows.Forms.ComboBox ComboBoxpalleteCor;
        private System.Windows.Forms.CheckBox checkBoxgrafico3D;
        private System.Windows.Forms.Button ButtonAleatorio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafico;
        private System.Windows.Forms.Timer timer1;
    }
}

