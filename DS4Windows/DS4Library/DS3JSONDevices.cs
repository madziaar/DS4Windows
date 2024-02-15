using DS4Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Diagnostics;
using DS4Windows.InputDevices;
using System.Windows.Forms;

namespace DS4Windows
{
    public class DS3JSONDevices
    {

        public DS3JSONDevices() { }

        public List<VidPidInfo> AddJSONDevices(List<VidPidInfo> devices)
        {
            Debug.WriteLine(Path.GetFullPath(".test.json"));
            try
            {
                string deviceList = File.ReadAllText("./ExtDevices.json");
                JSONDevice[]? rawDevices = JsonSerializer.Deserialize<JSONDevice[]>(deviceList);
                foreach (var device in rawDevices) {
                    string name = device.name.ToLower();
                    string type = device.type.ToLower();
                    int vid = Convert.ToInt32(device.vid, 16);
                    int pid = Convert.ToInt32(device.pid, 16);
                    if (type == "ds5")
                        devices.Add(new VidPidInfo(vid, pid, name, InputDeviceType.DualSense, VidPidFeatureSet.DefaultDS4, DualSenseDevice.DetermineConnectionType));
                    else if(type == "ds4")
                        devices.Add(new VidPidInfo(vid, pid, name, InputDeviceType.DS4));
                }
            } catch (Exception e) { 
                Debug.WriteLine("Error reading devices from ExtDevices.json" + e.Message);
            }
            return devices;
        }

    }

    internal class JSONDevice
    {
        public string name { get; set; }
        public string type { get; set; }
        public string vid { get; set; }
        public string pid { get; set; }
    }

}
