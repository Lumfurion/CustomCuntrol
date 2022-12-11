using System.Runtime.InteropServices.JavaScript;
using System.Windows.Media;
using CustomControl.App.Commands;

namespace CustomControl.App.ViewModels;

public class MainWindowViewModel
{
    public string TextImageButton { get; set; } = "Text IB";

    public RelayCommand TextImageCommand { get;}

    public MainWindowViewModel()
    {
        TextImageCommand = new RelayCommand(OnImageCommandClick);
    }

    private void OnImageCommandClick(object obj)
    {
        
    }
}