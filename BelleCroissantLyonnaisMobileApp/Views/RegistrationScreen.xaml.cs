namespace BelleCroissantLyonnaisMobileApp.Views;

public partial class RegistrationScreen : ContentPage
{
	public RegistrationScreen()
	{
		InitializeComponent();
	}

    private void OnButtonClickedToRegister(object sender, EventArgs e)
    {
        var value1 = IsValidFirstName();
        var value2 = IsValidLastName();
        var value3 = IsValidEmail();
        var value4 = IsValidPassword();
        var value5 = IsValidAnswer();

        if (value1 && value2 && value3 && value4 && value5)
        {
            Navigation.PushModalAsync(new ProfileScreen());
        }
    }

    private bool IsValidEmail()
    {
        EmailLbl.Style = this.Resources["Valid"] as Style;
        if (!string.IsNullOrEmpty(EmailEntry.Text) &&
            EmailEntry.Text.Contains("@") &&
            (EmailEntry.Text.EndsWith(".com") || EmailEntry.Text.EndsWith(".com.br")))
        {
            EmailLbl.Style = this.Resources["Valid"] as Style;
            return true;
        }
        else
        {
            EmailLbl.Style = this.Resources["InvalidEmail"] as Style;
            return false;
        }
    }
    private bool IsValidPassword()
    {
        if (PasswordEntry.Text != ConfirmPasswordEntry.Text || string.IsNullOrEmpty(PasswordEntry.Text))
        {
            PasswordLbl.Style = this.Resources["UnmatchPasswords"] as Style;
            return false;
        }
        else
        {
            PasswordLbl.Style = this.Resources["Valid"] as Style;
            return true;
        }
    }
    private bool IsValidFirstName()
    {
        if (string.IsNullOrEmpty(FirstNameEntry.Text))
        {
            FirstNameLbl.Style = this.Resources["InvalidFirstName"] as Style;
            return false;
        }
        else
        {
            FirstNameLbl.Style = this.Resources["Valid"] as Style;
            return true;
        }
    }
    private bool IsValidLastName()
    {
        if (string.IsNullOrEmpty(LastNameEntry.Text))
        {
            LastNameLbl.Style = this.Resources["InvalidLastName"] as Style;
            return false;
        }
        else
        {
            LastNameLbl.Style = this.Resources["Valid"] as Style;
            return true;
        }

    }
    private bool IsValidAnswer()
    {
        if (string.IsNullOrEmpty(AnswerEntry.Text))
        {
            AnswerLbl.Style = this.Resources["InvalidAnswer"] as Style;
            return false;
        }
        else
        {
            AnswerLbl.Style = this.Resources["Valid"] as Style;
            return true;
        }
    }

    private void OnButtonClickedToCancel(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PopAsync();
    }
}