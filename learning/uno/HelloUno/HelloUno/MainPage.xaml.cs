namespace HelloUno;

public sealed partial class MainPage : Page
{
	public MainPage()
	{
		this.InitializeComponent();
	}
	private void OnClick()
	{
    	var dt = DateTime.Now.ToString();
    	txt.Text = dt;
	}
}
