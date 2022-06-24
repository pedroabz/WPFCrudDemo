﻿using System;
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
using System.Windows.Shapes;

namespace WPFCRUDDemo
{
    /// <summary>
    /// Interaction logic for FuncionarioWindow.xaml
    /// </summary>
    public partial class EditEmployee : Window
    {
        public EditEmployee()
        {
            InitializeComponent();
            GenderComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Gender)).Cast<Enums.Gender>();
            MaritalStateComboBox.ItemsSource = Enum.GetValues(typeof(Enums.MaritalState)).Cast<Enums.MaritalState>();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
