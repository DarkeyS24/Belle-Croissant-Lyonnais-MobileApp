namespace BelleCroissantLyonnaisMobileApp.Views;

public partial class RegistrationScreen : ContentPage
{
	public RegistrationScreen()
	{
		InitializeComponent();
	}

    private void OnButtonClickedToRegister(object sender, EventArgs e)
    {
        if (IsValidFirstName() && IsValidLastName() && IsValidEmail() &&  IsValidPassword() && IsValidAnswer())
        {
            Navigation.PushModalAsync(new LoginScreen());
        }
    }

    private bool IsValidEmail()
    {
        bool value = false;
        if (!string.IsNullOrEmpty(EmailEntry.Text))
        {
            EmailLbl.Style = this.Resources["Valid"] as Style;
            if (!EmailEntry.Text.Contains(".com") || !EmailEntry.Text.Contains(".com.br"))
            {
                EmailLbl.Style = this.Resources["InvalidEmail"] as Style;
                value = false;
            }
            else if (!EmailEntry.Text.Contains("@"))
            {
                EmailLbl.Style = this.Resources["InvalidEmail"] as Style;
                value = false;
            }
            else
            {
                EmailLbl.Style = this.Resources["Valid"] as Style;
                value = true;
            }
        }
        else
        {
            EmailLbl.Text = "Type your email";
        }
            return value;
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
        if (!string.IsNullOrEmpty(FirstNameEntry.Text))
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
        if (!string.IsNullOrEmpty(LastNameEntry.Text))
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
        if (!string.IsNullOrEmpty(AnswerEntry.Text))
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