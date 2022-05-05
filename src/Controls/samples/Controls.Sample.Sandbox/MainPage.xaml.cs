using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MauiListViewTestRC1v172P4;

public partial class MainPage : ContentPage
{
	int count = 0;
	List<smallObject> smallList = new List<smallObject>();
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		LabelCounter.Text = "NUMBER OF OBJECTS: " + count.ToString();
		var obj = new smallObject();
		obj.ID = count;
		obj.Name = count.ToString();
		smallList.Add(obj);
		//	var answer = await DisplayAlert("ListView1", "Refresh ListView now?", "Yes", "No");
		//	if (answer) { listView1.ItemsSource = smallList; } // THIS WILL REFRESH THE LIST ONLY FIRST TIME AFTER THAT IT WON'T WORK
		//if (answer)
		//{
		//	listView1.ItemsSource = null;
		//listView1.ItemsSource = smallList;
		//await Task.Delay(1000);
		listView1.ItemsSource = new List<smallObject>( smallList);
		//}
		//listView1.ItemsSource = smallList;
	}
}

public class smallObject
{
	public int ID { get; set; }
	public string Name { get; set; }
}

