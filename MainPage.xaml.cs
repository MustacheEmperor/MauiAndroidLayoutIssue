using System.Collections.ObjectModel;

namespace AndroidLayoutIssue;

public partial class MainPage : ContentPage
{
	int count = 0;
	public ObservableCollection<string> Items = new ObservableCollection<string>()
	{
		"one","two","three","four","five"
	};
	public MainPage()
	{
		InitializeComponent();
        LayoutProblem.ItemsSource = Items; 

    }

}

