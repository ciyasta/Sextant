using k8s;

namespace Sextant.Maui.Views.Workloads;

public partial class Namespaces : ContentPage
{
	public Namespaces()
	{
		InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if(App.Kubernetes is null) return;
        var namespaceList = await App.Kubernetes.CoreV1.ListNamespaceAsync();
        namespacesTbl.Clear();
        foreach (var item in namespaceList.Items)
        {
            namespacesTbl.Add(new TextCell() { Text = item.Metadata.Name, Detail = item.Status.Phase });
        }

    }

}