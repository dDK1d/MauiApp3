namespace MauiApp3;

public partial class NewPage2 : ContentPage
{

    private string selectedCity = string.Empty;

    public NewPage2()
    {
        InitializeComponent();
        SecondTab.IsVisible = false;
    }

    private void OnOff_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            DisplayAlert("������", "������������� �������", "OK");
            SecondTab.IsVisible = true; 
        }
        else
        {
            DisplayAlert("������", "������������� ��������", "OK");
            SecondTab.IsVisible = false; 
        }
    }

    private void RadioBtn_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            var radioButton = sender as RadioButton;
            selectedCity = radioButton?.Content.ToString();
            OutputEntry.Text = "";
        }
    }

    private void Calculate_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(selectedCity))
        {
            string country = GetCountryByCity(selectedCity);
            OutputEntry.Text = country; 
        }
        else
        {
            OutputEntry.Text = "����������, �������� �����.";
        }
    }

    private string GetCountryByCity(string city)
    {
        return city switch
        {
            "������" => "������",
            "������" => "�����",
            "����" => "�������",
            "�������" => "�������",
            "�����" => "��������",
            "�������" => "�����",
            "������" => "������",
            "�����" => "��������",
            _ => "����������"
        };
    }
}