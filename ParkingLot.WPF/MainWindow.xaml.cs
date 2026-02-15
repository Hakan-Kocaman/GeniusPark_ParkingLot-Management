using Microsoft.AspNetCore.Http;
using ParkingLot.API;
using ParkingLot.API.Controllers;
using ParkingLot.API.Services;
using ParkingLot.Core;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace ParkingLot.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly PlateService _plateService;
        private readonly HttpClient httpClient;
        public MainWindow()
        {
            InitializeComponent();

             httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5000/")
            };

            _plateService = new PlateService(httpClient);
        }



        private async void Load_Image(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg";
            if (openFileDialog.ShowDialog() != true)
            { return; }


                var filePath = openFileDialog.FileName;
                var file = CreateFormFile(filePath);

                try
                {
                    using var content = new MultipartFormDataContent();
                    using var stream = File.OpenRead(filePath);

                    content.Add(new StreamContent(stream), "file",file.FileName);

                    var response = await httpClient.PostAsync("api/plate/detect", content);

                    var result = await response.Content.ReadAsStringAsync();
                

                MessageBox.Show("Plaka: " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("C# Error: " + ex.Message);
                    if (ex.InnerException != null)
                        MessageBox.Show(ex.InnerException.Message);
                }


            



        }
        private IFormFile CreateFormFile(string filePath)
        {
            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            return new FormFile(stream, 0, stream.Length, "image", System.IO.Path.GetFileName(filePath));
        }


    }
}