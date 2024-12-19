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
            if (string.IsNullOrWhiteSpace(sideA.Text) || string.IsNullOrWhiteSpace(sideB.Text) || string.IsNullOrWhiteSpace(sideC.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }
            if (int.TryParse(sideA.Text, out int a) &&
               int.TryParse(sideB.Text, out int b) &&
               int.TryParse(sideC.Text, out int c))
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    MessageBox.Show("Длины сторон должны быть положительными числами");
                    return;
                }
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    MessageBox.Show("Указанные стороны не могут образовать треугольник");
                    return;
                }
                const double maxAllowedValue = 1000;
                if (a > maxAllowedValue || b > maxAllowedValue || c > maxAllowedValue)
                {
                    MessageBox.Show($"Длины сторон не должны превышать {maxAllowedValue}");
                    return;
                }
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
                MessageBox.Show("Пожалуйста, введите целые числа для всех сторон");
            }
        }
    }
}
