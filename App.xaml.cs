using BluetoothLE.Core;

namespace MauiBLE;

public partial class App : Application
{
    
  
    public App()
    {
        
        InitializeComponent();

        MainPage = new AppShell();
    }
}