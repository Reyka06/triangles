using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace triangles
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
        private void DetermineTriangleType_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(sideA.Text, out double a) &&
               double.TryParse(sideB.Text, out double b) &&
               double.TryParse(sideC.Text, out double c))
            {
                string triangleType;
                if (a == b && b == c)
                {
                    triangleType = "Результат: Равносторонний треугольник";
                }
                else if (a == b || b == c || a == c)
                {
                    triangleType = "Результат: Равнобедренный треугольник";
                }
                else
                {
                    triangleType = "Результат: Разносторонний треугольник";
                }

                result.Text = triangleType;
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для всех сторон.");
            }
        }
    }
}
