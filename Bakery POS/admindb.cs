using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bakery_POS
{
    public partial class admindb : UserControl
    {
        public admindb()
        {
            InitializeComponent();
        }

        private void admindb_Load(object sender, EventArgs e)
        {
            LoadGrossRevenueChart();
            LoadTopProductsChart();
        }

        private void LoadGrossRevenueChart()
        {
            chart1.Series.Clear();
            Series series = new Series("Sales")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue
            };

            // Sample bakery sales data (Month, Revenue in Thousands)
            series.Points.AddXY("Jan", 150);
            series.Points.AddXY("Feb", 180);
            series.Points.AddXY("Mar", 220);
            series.Points.AddXY("Apr", 250);
            series.Points.AddXY("May", 300);
            series.Points.AddXY("Jun", 270);
            series.Points.AddXY("Jul", 310);
            series.Points.AddXY("Aug", 290);
            series.Points.AddXY("Sep", 330);
            series.Points.AddXY("Oct", 350);
            series.Points.AddXY("Nov", 370);
            series.Points.AddXY("Dec", 400);

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Months";
            chart1.ChartAreas[0].AxisY.Title = "Revenue (Thousands)";
            chart1.Invalidate();
        }

        private void LoadTopProductsChart()
        {
            chart2.Series.Clear();
            Series series = new Series("Top Products")
            {
                ChartType = SeriesChartType.Pie
            };

            // Sample data (Product Name, Sales Percentage)
            series.Points.AddXY("Cake", 30);
            series.Points.AddXY("Cookies", 25);
            series.Points.AddXY("Bread", 20);
            series.Points.AddXY("Donuts", 15);
            series.Points.AddXY("Brownies", 10);

            chart2.Series.Add(series);
            chart2.ChartAreas[0].AxisX.Title = "Products";
            chart2.ChartAreas[0].AxisY.Title = "Sales %";
            chart2.Legends[0].Enabled = true; // Enable legend to show product names
            chart2.Invalidate();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
