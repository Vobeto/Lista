namespace Lista.Views;

public partial class AddEditTaskPage : ContentPage
{
	public AddEditTaskPage()
	{
		InitializeComponent();
	}

    private void ClosePage(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
    



    private void SaveTask(object sender, TappedEventArgs e)
    {
        
    }

    private void AddTaks(object sender, EventArgs e)
    {
        var addStep = DisplayPromptAsync("Adicionar sub-tarefas", "Insira as etapas ", "Close", "Yes");
    }

    
}