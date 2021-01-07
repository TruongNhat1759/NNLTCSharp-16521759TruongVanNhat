using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace FrostPlay
{
    /// <summary>
    /// Interaction logic for SelectTime.xaml
    /// </summary>
    public partial class SelectTime : Window
    {
        public SelectTime()
        {
            InitializeComponent();
        }
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                long miliSeconds = ((Int32.Parse(inputHours.Text) + Int32.Parse(inputMinutes.Text)) * 60 + Int32.Parse(inputSeconds.Text)) * 1000;
                this.Close();
                MessageBox.Show(String.Concat("Application will close in ", Int32.Parse(inputHours.Text)," hours ", Int32.Parse(inputMinutes.Text), " minutes ", Int32.Parse(inputSeconds.Text), " seconds."), "Notification");
                Timer timer = new Timer();
                timer.Interval = miliSeconds;
                timer.Elapsed += Timer_Elapsed;
                timer.Start();
            }
            catch
            {
                inputHours.Text = String.Empty;
                inputMinutes.Text = String.Empty;
                inputSeconds.Text = String.Empty;
            }
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
