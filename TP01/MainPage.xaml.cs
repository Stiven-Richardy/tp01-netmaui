using Microsoft.Maui.Controls;

namespace TP01;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnOkClicked(object sender, EventArgs e)
    {
        string inputId = IdEntry.Text ?? string.Empty;
        string inputPass = PassEntry.Text ?? string.Empty;

        if (inputId == "admin" && inputPass == "senha@dmin")
        {
            await DisplayAlert("Sucesso", "Logou com sucesso", "OK");
        }
        else
        {
            await DisplayAlert("Erro", "Login não autorizado", "OK");
        }
    }

    private void OnLimparClicked(object sender, EventArgs e)
    {
        IdEntry.Text = string.Empty;
        PassEntry.Text = string.Empty;
        IdEntry.Focus();
    }

    private async void OnCreditosClicked(object sender, EventArgs e)
    {
        string creditosTexto =
            "Stiven Richardy Silva Rodrigues\nEstudante de Análise e Desenvolvimento de Sistemas | IFSP — Campus Cubatão\n\n" +
            "Guilherme Mendes de Sousa\nEstudante de Análise e Desenvolvimento de Sistemas | IFSP — Campus Cubatão";

        await DisplayAlert("Créditos", creditosTexto, "Fechar");
    }
}