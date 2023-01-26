


using BluetoothLE.Core;
using BluetoothLE.Core.Events;

namespace MauiBLE;

public partial class MainPage : ContentPage
{
	IEnumerable<ConnectionProfile> profiles = Connectivity.Current.ConnectionProfiles;
    private static IAdapter _bluetoothAdapter = DependencyService.Get<IAdapter>();
    public static IAdapter BluetoothAdapter { get { return _bluetoothAdapter; } }
    private List<IDevice> devices = new List<IDevice>();
    public MainPage()
	{
        _bluetoothAdapter.ScanTimeout = TimeSpan.FromSeconds(100);
        _bluetoothAdapter.ConnectionTimeout = TimeSpan.FromSeconds(10);
        _bluetoothAdapter.DeviceDiscovered+= DeviceDiscovered;
		InitializeComponent();
	}
    

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}
    private void DeviceDiscovered(object sender, DeviceDiscoveredEventArgs e)
    {
        
        if (devices.All(x => x.Id != e.Device.Id))
        {
            devices.Add(e.Device);
        }
        testing.Text = devices.Count.ToString();
        testing1.Text = "";
        devices.ForEach(x => testing1.Text += "\n"+ x.Name);
    }
    private void BluetoothTest(object s, EventArgs e)
	{
        
        _bluetoothAdapter.StartScanningForDevices();
        testing.Text = "Test started";
    }
}

