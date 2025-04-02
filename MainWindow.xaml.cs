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

namespace Module11Practical2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Submit_Click(object sender, RoutedEventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Name: {txtName.Text}");
        sb.AppendLine($"Age: {txtAge.Text}");
        sb.AppendLine($"Gender: {(rbMale.IsChecked == true ? "Male" : rbFemale.IsChecked == true ? "Female" : "Not specified")}");
        sb.AppendLine("Hobbies:");
        if (cbReading.IsChecked == true) sb.AppendLine(" - Reading");
        if (cbTraveling.IsChecked == true) sb.AppendLine(" - Traveling");
        if (cbSports.IsChecked == true) sb.AppendLine(" - Sports");
        sb.AppendLine($"Country: {((ComboBoxItem)cbCountry.SelectedItem)?.Content}");

        MessageBox.Show(sb.ToString(), "Submitted Information");
    }

    private void Clear_Click(object sender, RoutedEventArgs e)
    {
        txtName.Clear();
        txtAge.Clear();
        rbMale.IsChecked = false;
        rbFemale.IsChecked = false;
        cbReading.IsChecked = false;
        cbTraveling.IsChecked = false;
        cbSports.IsChecked = false;
        cbCountry.SelectedIndex = -1;
    }

    private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
    {
        e.Handled = !int.TryParse(e.Text, out _);
    }

    private void txtName_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}
