namespace MauiApp3;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
        OneTab.IsVisible = true;
    }

    private void OnCityChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            var selectedCity = ((RadioButton)sender).Content.ToString();
            AutoResultEntry.Text = GetCountry(selectedCity);
        }
    }

    private string GetCountry(string city)
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

    private void OnOff_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            DisplayAlert("������", "������������� �������", "OK");
            OneTab.IsVisible = true; 
        }
        else
        {
            DisplayAlert("������", "������������� ��������", "OK");
            OneTab.IsVisible = false;
        }
    }
}