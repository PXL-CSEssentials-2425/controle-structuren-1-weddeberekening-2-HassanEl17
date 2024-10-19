using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControleStructuren_1_Weddeberekening2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double burtoWage;
            double belast1 = 0;
            double belast2 = 0.2;
            double belast3 = 0.3;
            double belast4 = 0.4;
            double belast5 = 0.5;
            double belastWage;
            double netoWage;
            double hourlyWage = double.Parse(hourlyWageTextBox.Text);
            int numberOfHours = int.Parse(numberOfHoursTextBox.Text);
            string name = employeeTextBox.Text;
            burtoWage = hourlyWage * numberOfHours;

            if (burtoWage <= 10000)
            {

                belastWage = burtoWage * belast1;
                //netoWage = burtoWage;
            }
            else if (burtoWage > 10000 && burtoWage <= 15000)
            {

                belastWage = burtoWage * belast2;
                //netoWage = burtoWage - belastWage;
            }
            else if (burtoWage > 15001 && burtoWage <= 25000)
            {
                belastWage = burtoWage * belast3;
                //netoWage = burtoWage - belastWage;
            }
            else if (burtoWage > 25001 && burtoWage < 50000)
            {
                belastWage = (burtoWage - 25000) * belast4;
                //netoWage = burtoWage - belastWage;
            }
            else
            {
                belastWage = burtoWage * belast5;
                //netoWage = burtoWage - belastWage;
            }
            




            //belastWage = burtoWage * belast;
            //belastWage = belast1;
            netoWage = burtoWage - belastWage;
            resultTextBox.Text = $"LOONFICHE VAN {name}\r\n\r\n" +
                $"Antal gewerkte uren: {numberOfHours}\r\n" +
                $"Uurloon : {hourlyWage:c}\r\n" +
                $"Brutojaarwedde : {burtoWage:c}\r\n" +
                $"Belasting : {belastWage:c}\r\n" +
                $"Nettojaarwedde : {netoWage:c}";
        }

        //private void clearButton_Click(object sender, RoutedEventArgs e)
        //{
        //    hourlyWageTextBox.Clear();
        //    numberOfHoursTextBox.Clear();
        //    resultTextBox.Clear();
        //    employeeTextBox.Clear();
        //    employeeTextBox.Focus();
        //}

        //private void Closebutton_Click(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //}

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            hourlyWageTextBox.Clear();
            numberOfHoursTextBox.Clear();
            resultTextBox.Clear();
            employeeTextBox.Clear();
            employeeTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}