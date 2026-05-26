public class MainViewModel : INotifyPropertyChanged
{
    private string _nazwa;
    public string Nazwa
    {
        get => _nazwa;
        set { _nazwa = value; OnPropertyChanged(); }
    }
    public ICommand PrzyciskKomenda { get; }
    // ... implementacja powiadomień i komend
}