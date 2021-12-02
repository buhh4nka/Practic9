using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Practic9
{
    /// <summary>
    /// ИСП-31. Назаров Д. Вариант 2. 
    /// Заполнить таблицу с аппаратными средствами на 5 компьютеров с полями: тип процессор, память, HDD, видео.
    /// Вывести результат на экран.Вывести средний объем памяти.
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Computer> _pcToAdd = null;
        Computer _computer;
        int _averageRam = 0;
        int _averageMemory = 0;
         public MainWindow()
        {
            InitializeComponent();
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-31. Назаров Д. Вариант 2. \nЗаполнить таблицу с аппаратными средствами на 5 компьютеров с полями: тип процессор, память, HDD, видео.Вывести результат на экран. Вывести средний объем памяти.", "О программе");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addPC_Click(object sender, RoutedEventArgs e)
        {
            bool isNotErrorInRam = Int32.TryParse(ramOutput.Text, out int pcRAM);
            bool isNotErrorInMemory = Int32.TryParse(memoryOutput.Text, out int pcMemory);
            if (isNotErrorInRam && isNotErrorInMemory)
            {
                _computer.Processor = processorOutput.Text;
                _computer.RAM = pcRAM;
                _computer.Memory = pcMemory;
                _computer.GPU = gpuOutput.Text;

                if (_pcToAdd == null)
                {
                    _pcToAdd = new ObservableCollection<Computer>();
                    dataGrid.ItemsSource = _pcToAdd;
                }
                _pcToAdd.Add(_computer);

                _averageRam += pcRAM;
                averageRAM.Text = (_averageRam / _pcToAdd.Count()).ToString();
                _averageMemory += pcMemory;
                averageMemory.Text = (_averageMemory / _pcToAdd.Count()).ToString();

                processorOutput.Clear();
                ramOutput.Clear();
                memoryOutput.Clear();
                gpuOutput.Clear();
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                memoryOutput.Clear();
                ramOutput.Clear();
            }

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            processorOutput.Clear();
            ramOutput.Clear();
            memoryOutput.Clear();
            gpuOutput.Clear();
        }
    }
}
