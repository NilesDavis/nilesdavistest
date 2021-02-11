using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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
using Newtonsoft.Json;

namespace MonicaClient
{
  /// <summary>
  /// Interaktionslogik für MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private static readonly HttpClient client = new HttpClient();

    public MainWindow()
    {
      InitializeComponent();
    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
      //Header konfigurieren
      client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIyIiwianRpIjoiNjM1ZDg3ZWNmMjQzMDNlMGE0MTE4NDhlNzFhMDZhMzdiOTcyZDY1NDcyOWMwODdmN2NhOTAwOGZmMDhiZDJiOTEzN2VhZGM4Y2Y4ZTRjNDgiLCJpYXQiOjE2MTI2MzAyODgsIm5iZiI6MTYxMjYzMDI4OCwiZXhwIjoxNjQ0MTY2Mjg4LCJzdWIiOiI2MDAyIiwic2NvcGVzIjpbXX0.JJVkbYU0R6LBRumbFW01GyiDRt8DyNV5nASQ5F38q-CoAFoilGLEOPhWJoti6-ZrbNWz7RL2631gqlDExEb4IXOKohdVuUwuYLLu1MedEcwCm_bvSXejxgqeUyFxpHTd56JtUPcdvFnWW9QeJ8gnICTxTbuDTd6ldI0YmblY_55nMPGXRqC5UQeel2krj6v3I4bk5e93bIhG6nMl3I_KWnVO6oaL6KIo2mfNt8ZMgbzxABCP9Hg6MJMg9qcMIJscyosnGzlAfbgBz1cYtktrqzCMmC3XfkrdzNMBFpKlJxkhkoFuJtZzT5GcxPRvKrN8LoR_BgoW3LQg6RgofvMQNLn71NcJgKMJU3TqSqqC5DjkJ9vnPCBJNin76lRQ9SSE0rPV41Xc9j1jo7ADVHr-iET7Av1oOsbIaLHhBQBsy9KRNqJnl7fj_4Jhf__ZZ-m3GMqDxlIijKdGufd_IwNOh7gTEObaP8W_SsMnl_IZ0Mxg0Rp72Me2qDqA7msjW1QnduEti1HzBQwOtUDYcikrhAFF4LzvuEQ0M7E_T70rtFClwqE_peLvgPmQSX3iNRUSbKS3XYJwsAM3dKG1F0Xx2Rk-CyL74I3ehl_uPkhcREDVztYDsLPuaJQvHCzmqtu0ESFyD9Lqpg6JSZJDemW3uwyVKY2TbSky07fQSgADjf4");
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

      //GET Method  
      HttpResponseMessage response = client.GetAsync("https://app.monicahq.com/api/contacts/").Result;
      string resultstring = response.Content.ReadAsStringAsync().Result;

      //Antowrt auswerten
      JSonResponse antwortobjekt = JsonConvert.DeserializeObject<JSonResponse>(resultstring);

      textBox.Text = $"{antwortobjekt.data.Count()} Objekte empfangen";
    }
  }

  /// <summary>
  /// Container, welcher die ankommenden Daten kapselt
  /// </summary>
  public class JSonResponse
  {
    private Contact[] _data;
    public Contact[] data
    {
      get { return _data; }
      set { _data = value; }
    }
  }
}