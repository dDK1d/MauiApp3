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
            "Москва" => "Россия",
            "Каунас" => "Литва",
            "Киев" => "Украина",
            "Харьков" => "Украина",
            "Брест" => "Беларусь",
            "Вильнюс" => "Литва",
            "Рязань" => "Россия",
            "Минск" => "Беларусь",
            _ => "Неизвестно"
        };
    }

    private void OnOff_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            DisplayAlert("Статус", "Переключатель включен", "OK");
            OneTab.IsVisible = true; 
        }
        else
        {
            DisplayAlert("Статус", "Переключатель выключен", "OK");
            OneTab.IsVisible = false;
        }
    }
}