namespace Lista.Views;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();
    }
    
    private void AddTask_Tapped(object sender, TappedEventArgs e)
    {
       Navigation.PushModalAsync(new AddEditTaskPage());
    }
}