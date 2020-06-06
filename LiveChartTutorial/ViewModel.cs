using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace LiveChartTutorial
{
    class ViewModel
    {
        private ChartValues<int> series;

        public ChartValues<int> Series
        {
            get
            {
                if (series == null)
                {
                    series = GetSeries();
                }

                return series;
            }
        }

        private ChartValues<int> stacked1;

        public ChartValues<int> Stacked1
        {
            get
            {
                if (stacked1 == null)
                {
                    stacked1 = new ChartValues<int> { 0, 533, 570, 381, 0, 122, 125, 122, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                }

                return stacked1;
            }
        }

        private ChartValues<double> stacked2;

        public ChartValues<double> Stacked2
        {
            get
            {
                if (stacked2 == null)
                {
                    stacked2 = new ChartValues<double> { 0.0, 0.0, 0.0, 0.0, 78.9, 78.9, 78.9, 78.9, 78.9, 78.9, 78.9, 78.9, 78.9, 0.0, 0.0, 0.0, 0.0, 0.0 };
                }

                return stacked2;
            }
        }

        private ChartValues<double> stacked3;

        public ChartValues<double> Stacked3
        {
            get
            {
                if (stacked3 == null)
                {
                    stacked3 = new ChartValues<double> { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 28.0, 167.0, 84.0, 0.0, 0.0, 0.0 };

                }

                return stacked3;
            }
        }

        ChartValues<int> GetSeries()
        {
            ChartValues<int> series = new ChartValues<int> { 0, -534, -570, -381, 497, 506, 396, 408, 544, 555, 580, 469, -167, -84, 0, 0, 0, 0 };

            return series;
        }
        
    }
}
