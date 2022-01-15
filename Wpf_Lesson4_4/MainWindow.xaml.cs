using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Lesson4_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double RateDollar = Convert.ToDouble(rate.Text);
            double SumDollar = Convert.ToDouble(sum.Text);
            double ResultDollar = RateDollar * SumDollar;
            resSum.Text = ResultDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double RateEuro = Convert.ToDouble(rateEuro.Text);
            double SumEuro = Convert.ToDouble(sumEuro.Text);
            double ResultEuro = RateEuro * SumEuro;
            resSumEuro.Text = ResultEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double RateGrivna = Convert.ToDouble(rateGrivna.Text);
            double SumGrivna = Convert.ToDouble(sumGrivna.Text);
            double ResultGrivna = RateGrivna * SumGrivna;
            resSumGrivna.Text = ResultGrivna.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double RateKrona = Convert.ToDouble(rateKrona.Text);
            double SumKrona = Convert.ToDouble(sumKrona.Text);
            double ResultKrona = RateKrona * SumKrona;
            resSumKrona.Text = ResultKrona.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double distD = Convert.ToDouble(dist.Text);
            double distD_Metr = distD * 0.0254;
            resdist.Text = distD_Metr.ToString();
           
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double distFt = Convert.ToDouble(distft.Text);
            double distFt_Metr = distFt * 0.3048;
            resdistft.Text = distFt_Metr.ToString();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double distMi = Convert.ToDouble(distmi.Text);
            double distMi_Metr = distMi * 1609.34;
            resdistmi.Text = distMi_Metr.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

            double distVerst = Convert.ToDouble(distverst.Text);
            double distVerst_Metr = distVerst * 1066.8;
            resdistverst.Text = distVerst_Metr.ToString();
        }
    }
}
