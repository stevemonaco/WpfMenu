using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace WpfMenu;

public enum SizeOption { Small, Medium, Large }

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] ObservableCollection<ToppingViewModel> _toppings;
    [ObservableProperty] SizeOption _sizeOption;

    public MainViewModel()
    {
        _toppings = new ObservableCollection<ToppingViewModel>()
        {
            new ToppingViewModel("Tomato", 0.50m),
            new ToppingViewModel("Salami", 0.50m),
            new ToppingViewModel("Olives", 0.50m),
        };

        _sizeOption = SizeOption.Medium;
    }
}
