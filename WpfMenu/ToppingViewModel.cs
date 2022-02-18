using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMenu;
public partial class ToppingViewModel : ObservableObject
{
    [ObservableProperty] string _name;
    [ObservableProperty] decimal _price;
    [ObservableProperty] bool _isOrdered;

    public ToppingViewModel(string name, decimal price)
    {
        _name = name;
        _price = price;
    }
}
