using System.Windows;
using WeatherApp.Services;
using WeatherApp.Models;

namespace WeatherApp;

public partial class MainWindow : Window
{
    private readonly WeatherService _weatherService = new();

    private readonly List<CityInfo> _cities =
[
    new CityInfo
    {
        Name = "東京",
        Latitude = 35.6895,
        Longitude = 139.6917
    },

    new CityInfo
    {
        Name = "大阪",
        Latitude = 34.6937,
        Longitude = 135.5023
    },

    new CityInfo
    {
        Name = "名古屋",
        Latitude = 35.1815,
        Longitude = 136.9066
    },

    new CityInfo
    {
        Name = "札幌",
        Latitude = 43.0618,
        Longitude = 141.3545
    },

    new CityInfo
    {
        Name = "福岡",
        Latitude = 33.5902,
        Longitude = 130.4017
    }
];

    public MainWindow()
    {
        InitializeComponent();

        CityComboBox.ItemsSource = _cities;
        CityComboBox.DisplayMemberPath = "Name";
        CityComboBox.SelectedIndex = 0;

        Loaded += MainWindow_Loaded;
    }

    private async void MainWindow_Loaded(
    object sender,
    RoutedEventArgs e)
    {
        try
        {
            var selectedCity =
    (CityInfo)CityComboBox.SelectedItem;

            var weather =
                await _weatherService.GetCurrentWeatherAsync(
                    selectedCity.Latitude,
                    selectedCity.Longitude);

            Title = $"{selectedCity.Name}の天気";

            WeatherTextBlock.Text =
                $"天気：{GetWeatherDescription(weather.WeatherCode)}";

            TemperatureTextBlock.Text =
                $"気温：{weather.Temperature:F1} ℃";

            HumidityTextBlock.Text =
                $"湿度：{weather.Humidity}%";

            WindSpeedTextBlock.Text =
                $"風速：{weather.WindSpeed:F1} m/s";

            List<ForecastDisplayItem> forecastItems = new();

            foreach (var forecast in weather.Forecasts)
            {
                forecastItems.Add(new ForecastDisplayItem
                {
                    Date = forecast.Date.ToString("MM/dd"),

                    Weather =
                        GetWeatherDescription(
                            forecast.WeatherCode),

                    MaxTemperature =
                        $"{forecast.MaxTemperature:F0}℃",

                    MinTemperature =
                        $"{forecast.MinTemperature:F0}℃",

                    PrecipitationProbability =
                        $"{forecast.PrecipitationProbability}%"
                });
            }

            ForecastDataGrid.ItemsSource = forecastItems;



        }
        catch (Exception ex)
        {
            WeatherTextBlock.Text =
                $"取得失敗: {ex.Message}";
        }
    }
    private string GetWeatherDescription(int weatherCode)
    {
        return weatherCode switch
        {
            0 => "快晴",
            1 => "晴れ",
            2 => "薄曇り",
            3 => "曇り",
            45 => "霧",
            48 => "着氷性の霧",

            51 => "弱い霧雨",
            53 => "霧雨",
            55 => "強い霧雨",

            61 => "弱い雨",
            63 => "雨",
            65 => "強い雨",

            71 => "弱い雪",
            73 => "雪",
            75 => "大雪",

            80 => "にわか雨",
            81 => "強いにわか雨",
            82 => "激しいにわか雨",

            95 => "雷雨",

            _ => "不明"
        };
    }
}