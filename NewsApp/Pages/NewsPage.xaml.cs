using NewsApp.Models;

namespace NewsApp.Pages;

public partial class NewsPage : ContentPage
{
	public List<Article> ArticleList { get; set; }
	public NewsPage()
	{
		InitializeComponent();
		ArticleList = new List<Article>();
	}
	protected override async void OnOppering()
	{
		base.OnAppearing();
		ApiService apiService = new ApiService();
		var newsResult = await apiService.GetNews();
		foreach(var item in newsResult.Articles)
		{
			ArticlesList.Add(item);
		}
	}
}