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

namespace Vigenere
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
        readonly VigenereCipher cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
        private void ButtonClickEncrypt(object sender, RoutedEventArgs e)
        {
            encryptedText.Text = cipher.Encrypt(inputText.Text.ToUpper(), password.Text.ToUpper());
        }

        private void ButtonClickDecrypt(object sender, RoutedEventArgs e)
        {
            encryptedText.Text = cipher.Decrypt(inputText.Text.ToUpper(), password.Text.ToUpper());
        }
    }
}
