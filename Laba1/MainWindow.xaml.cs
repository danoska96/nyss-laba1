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
using System.IO;
using Microsoft.Win32;

namespace Laba1
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

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                inputTxt.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, outputTxt.Text);
        }

        string direction = null;
        string alphabet = null;

        private void Dir_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            direction = radioButton.Name;
        }

        private void Alph_Checked(object sender, RoutedEventArgs e)
        {
            int length;
            var radioButton = sender as RadioButton;
            alphabet = radioButton.Name;
            if (alphabet == "one")
            {
                length = 44;
            }
            else
            {
                length = 34;
            }
            Nums.Items.Clear();
            for (int i = 1; i < length; i++)
            {                
                TextBox newNote = new TextBox();
                newNote.Text = i.ToString();
                newNote.IsReadOnly = true;
                Nums.Items.Add(newNote);
            }
        }

        private void Oper_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (!String.IsNullOrEmpty(direction)&&!String.IsNullOrEmpty(alphabet)&&Nums.SelectedIndex>-1&&!String.IsNullOrWhiteSpace(inputTxt.Text))
            {
                MessageBox.Show("Успешно!");                
                if (button.Name=="encode")
                {
                    outputTxt.Text = Caesar.CaesarMethod(inputTxt.Text, (uint)(Nums.SelectedIndex + 1), direction, alphabet, "encode");
                }
                else if (button.Name == "decode")
                {
                    outputTxt.Text = Caesar.CaesarMethod(inputTxt.Text, (uint)(Nums.SelectedIndex + 1), direction, alphabet, "decode");
                }
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля!");
            }
        }
    }
}
