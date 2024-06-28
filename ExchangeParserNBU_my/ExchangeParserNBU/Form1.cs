using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ExchangeParserNBU
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            
        }

        private void ShowGraph()
        {
            // автоочистка графиков
            Graph1.Series[0].Points.Clear();
            Graph2.Series[0].Points.Clear();

            //дни
            double[] x = { 1, 2, 3, 4, 5, 6, 7 }; //массив из чисел 1-7 - дни недели
            double[] y1 = { Convert.ToDouble(labelCurrency1_1.Text),
                            Convert.ToDouble(labelCurrency1_2.Text),
                            Convert.ToDouble(labelCurrency1_3.Text),
                            Convert.ToDouble(labelCurrency1_4.Text), //изменение типа лейбла 1
                            Convert.ToDouble(labelCurrency1_5.Text),
                            Convert.ToDouble(labelCurrency1_6.Text),
                            Convert.ToDouble(labelCurrency1_7.Text),
                          };
            double[] y2 = { Convert.ToDouble(labelCurrency2_1.Text),
                            Convert.ToDouble(labelCurrency2_2.Text),
                            Convert.ToDouble(labelCurrency2_3.Text),
                            Convert.ToDouble(labelCurrency2_4.Text), //изменение типа лейбла 2
                            Convert.ToDouble(labelCurrency2_5.Text),
                            Convert.ToDouble(labelCurrency2_6.Text),
                            Convert.ToDouble(labelCurrency2_7.Text),
                          };
            //Первый график
            Graph1.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(labelMinCur1.Text);
            Graph1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(labelMaxCur1.Text);

            Graph1.ChartAreas[0].AxisX.Minimum = 1;
            Graph1.ChartAreas[0].AxisX.Maximum = 7;

            Graph1.Series[0].Name = labelCurrency1.Text;

            this.Graph1.Series[0].BorderWidth = 4;

            //Второй график

            Graph2.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(labelMinCur2.Text);
            Graph2.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(labelMaxCur2.Text);

            Graph2.ChartAreas[0].AxisX.Minimum = 1;
            Graph2.ChartAreas[0].AxisX.Maximum = 7;

            Graph2.Series[0].Name = labelCurrency2.Text;

            this.Graph2.Series[0].BorderWidth = 4;

            for (int i = 0; i < 7; i++)
            {
                this.Graph1.Series[0].Points.AddXY(x[i], y1[i]);
                this.Graph2.Series[0].Points.AddXY(x[i], y2[i]);
            }

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string picked_value1 = comboBox_First.SelectedItem.ToString();
                string picked_value2 = comboBox_Second.SelectedItem.ToString();
                //labelCurrency1.Text = picked_value1;
                //labelCurrency2.Text = picked_value2;
                try
                {
                    labelCurrency1_1.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value1, labelDate1.Text)).ToString();
                    labelCurrency1_2.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value1, labelDate2.Text)).ToString();
                    labelCurrency1_3.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value1, labelDate3.Text)).ToString();
                    labelCurrency1_4.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value1, labelDate4.Text)).ToString();
                    labelCurrency1_5.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value1, labelDate5.Text)).ToString();
                    labelCurrency1_6.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value1, labelDate6.Text)).ToString();
                    labelCurrency1_7.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value1, labelDate7.Text)).ToString();

                    labelCurrency2_1.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value2, labelDate1.Text)).ToString();
                    labelCurrency2_2.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value2, labelDate2.Text)).ToString();
                    labelCurrency2_3.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value2, labelDate3.Text)).ToString();
                    labelCurrency2_4.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value2, labelDate4.Text)).ToString();
                    labelCurrency2_5.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value2, labelDate5.Text)).ToString();
                    labelCurrency2_6.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value2, labelDate6.Text)).ToString();
                    labelCurrency2_7.Text = Exchange.ParsedExchangeCourse(ParserNBU.Parse(picked_value2, labelDate7.Text)).ToString();
                    try
                    {
                        MinMaxDefinition();
                        try
                        {
                            ShowGraph();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Inability to display a forecast - Graph",
        "Attention",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Inability to display a forecast - Min/Max",
        "Attention",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Inability to display a forecast - Date",
        "Attention",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Inability to display a forecast - Currency",
        "Attention",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        
        private void MinMaxDefinition()
        {
            List<double> currencyList = new List<double>();


            currencyList.Add(Convert.ToDouble(labelCurrency1_1.Text));
            currencyList.Add(Convert.ToDouble(labelCurrency1_2.Text));
            currencyList.Add(Convert.ToDouble(labelCurrency1_3.Text));
            currencyList.Add(Convert.ToDouble(labelCurrency1_4.Text));
            currencyList.Add(Convert.ToDouble(labelCurrency1_5.Text));
            currencyList.Add(Convert.ToDouble(labelCurrency1_6.Text));
            currencyList.Add(Convert.ToDouble(labelCurrency1_7.Text));

            labelMaxCur1.Text = currencyList.Max().ToString();
            labelMinCur1.Text = currencyList.Min().ToString();

            currencyList.Clear();

            currencyList.Add(Convert.ToDouble(labelCurrency2_1.Text));
            currencyList.Add(Convert.ToDouble(labelCurrency2_2.Text));
            currencyList.Add(Convert.ToDouble(labelCurrency2_3.Text));
            currencyList.Add(Convert.ToDouble(labelCurrency2_4.Text));
            currencyList.Add(Convert.ToDouble(labelCurrency2_5.Text));
            currencyList.Add(Convert.ToDouble(labelCurrency2_6.Text));
            currencyList.Add(Convert.ToDouble(labelCurrency2_7.Text));

            labelMaxCur2.Text = currencyList.Max().ToString();
            labelMinCur2.Text = currencyList.Min().ToString();

            currencyList.Clear();

            labelCurrency1.Text = comboBox_First.SelectedItem.ToString();
            labelCurrency2.Text = comboBox_Second.SelectedItem.ToString();

        }
        public void ChangeDaysByCalendar(object sender, EventArgs e)
        {
            labelDate1.Text = DateTimePicker.Value.ToShortDateString();
            labelDate2.Text = DateTimePicker.Value.AddDays(1).ToShortDateString();
            labelDate3.Text = DateTimePicker.Value.AddDays(2).ToShortDateString();
            labelDate4.Text = DateTimePicker.Value.AddDays(3).ToShortDateString();
            labelDate5.Text = DateTimePicker.Value.AddDays(4).ToShortDateString();
            labelDate6.Text = DateTimePicker.Value.AddDays(5).ToShortDateString();
            labelDate7.Text = DateTimePicker.Value.AddDays(6).ToShortDateString();

        }

    }
}
