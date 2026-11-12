using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graficos
{
    public partial class FormGrafico : Form
    {

        Dictionary<double, double> valores;
        int contadorX = 0;

        public FormGrafico()
        {
            InitializeComponent();
            valores = new Dictionary<double, double>();
        }

        private void FormGrafico_Load(object sender, EventArgs e)
        {
            textBoxXValor.Focus();

            for (int i = 0; i < 35; i++) 
            {
                ComboBoxtipoGrafico.Items.Add((SeriesChartType)i);
            }

            for (int i = 0; i < 13; i++) 
            {
                ComboBoxpalleteCor.Items.Add((ChartColorPalette)i);
            }
        }

       

        private void ButtonInserirValores_Click(object sender, EventArgs e)
        {
            InserirValores();
        }

        public void InserirValores() 
        {
            if (string.IsNullOrEmpty(textBoxXValor.Text) || string.IsNullOrEmpty(textBoxYValor.Text))
            {
                MessageBox.Show("Os Valores de X e Y são obrigatórios");
                return;
            }

            // validar o valor repetido e atribuir o novo valor 

            if (valores.ContainsKey(double.Parse(textBoxXValor.Text)))
            {
                valores[double.Parse(textBoxXValor.Text)] = double.Parse(textBoxYValor.Text);
            }
            else 
            {
                valores.Add(double.Parse(textBoxXValor.Text), double.Parse(textBoxYValor.Text));
            }

            var items = from valor in valores orderby valor.Key ascending select valor; // LINQ para ordenar pela chave em ordem ascendente do menor para o maior

            dataGridViewdataValores.Rows.Clear(); // limpar linha do grid
            chartGrafico.Series[0].Points.Clear(); // limpar os pontos do grafico 

            foreach (var item in items)
            {
                dataGridViewdataValores.Rows.Add(item.Key, item.Value);
                chartGrafico.Series[0].Points.AddXY(item.Key, item.Value);
            }

            chartGrafico.Update();

            textBoxXValor.Text = string.Empty;
            textBoxYValor.Text = string.Empty;
            textBoxXValor.Focus();

        }

        private void LimparCampos() 
        {
            valores.Clear();
            chartGrafico.Series[0].Points.Clear();
            dataGridViewdataValores.Rows.Clear();
            contadorX = 0;
            textBoxXValor.Text = string.Empty;
            textBoxYValor.Text = string.Empty;
            textBoxXValor.Focus();
        }

        private void dataGridViewdataValores_SelectionChanged(object sender, EventArgs e)
        {
            textBoxXValor.Text = dataGridViewdataValores.Rows[dataGridViewdataValores.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxYValor.Text = dataGridViewdataValores.Rows[dataGridViewdataValores.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void ComboBoxtipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartGrafico.Series[0].ChartType = (SeriesChartType)ComboBoxtipoGrafico.SelectedItem;
        }

        private void ComboBoxpalleteCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartGrafico.Palette = (ChartColorPalette)ComboBoxpalleteCor.SelectedItem;
        }

        private void checkBoxgrafico3D_CheckedChanged(object sender, EventArgs e)
        {
            chartGrafico.ChartAreas[0].Area3DStyle.Enable3D = checkBoxgrafico3D.Checked;
        }

        private void AtivarTime() 
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void ButtonAleatorio_Click(object sender, EventArgs e)
        {
            AtivarTime();
        }

        private void textBoxXValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // validação para não aceitar nada alem de numeros, backspace , enter , virgula e se ter virgula já no textbox 

            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8  && e.KeyChar != (char)13 && e.KeyChar != (char) 44) || (textBoxXValor.Text.Contains((char) 44) && e.KeyChar == (char) 44))
            {
                e.Handled = true;
            }
        }

        private void textBoxYValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // validação para não aceitar nada alem de numeros, backspace , enter , virgula e se ter virgula já no textbox 

            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44) || (textBoxYValor.Text.Contains((char)44) && e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chartGrafico.Series[0].Points.Count() > 10) 
            {
                chartGrafico.Series[0].Points.RemoveAt(0);
                chartGrafico.Update();
            }

            double y = (double) new Random((int)DateTime.Now.Ticks).Next(1000);

            chartGrafico.Series[0].Points.AddXY(contadorX++,y);
            dataGridViewdataValores.Rows.Add(contadorX, y);
            dataGridViewdataValores.CurrentCell = dataGridViewdataValores.Rows[dataGridViewdataValores.Rows.Count - 1].Cells[0];

        }
    }
}
