# Hared Edits

This fork DS4Windows will only have minor changes and no major updates,
It's mainly to keep DS4Windows and keep it working with very little maintenance

## Adding devices via the ExtDevices.json

In the root folder you will now find a "ExtDevices.json" it will contain following text:
```
[
  {
    "vid": "3285",
    "pid": "0d19",
    "name": "Nacon Revolution 5 pro",
    "type": "ds5"
  }
]
```
To add a new device just copy everything including "{" to "}" and replace the values with corrsponding values of your controller and adding "," before pasting.
Example:
```
[
  {
    "vid": "3285",
    "pid": "0d19",
    "name": "Nacon Revolution 5 pro",
    "type": "ds5"
  },
  {
    "vid": "Your Vid",
    "pid": "Your Pid",
    "name": "Your Name",
    "type": "Your type"
  }
]
```

### What you should set as the vid, pid, name, and type

> [!IMPORTANT]
> **If your controller has a switch for "PS4", "PS5, and/or "PC", set the switch to any of the PS alternatives NOT "PC". Recommended is "PS5" if your controller have it**

The "name" can be whatever you want, it's only used to display the name of the controller

The "pid" and "vid" is used to identify the controller, you can get it on https://hardwaretester.com/gamepad
The "vid" is the Vendor and "pid" is the "product", see the image below to find where too look for them.
![DS4Windows Preview](https://raw.githubusercontent.com/HaredDev/DS4Windows/5a945cefdcc956431dab3370b033d855f9179e1b/gamepad-tester.png)


The "type" can either be set to "ds4" or "ds5".
You can check what the games such as Warezone or Fortnite detectes your controller and put the "type" accordingly if you don't know.

# DS4Windows **Unedited inforamtion below**

Like those other DS4 tools, but sexier.

DS4Windows is an extract anywhere program that allows you to get the best
DualShock 4 experience on your PC. By emulating an Xbox 360 controller, many
more games are accessible. Other input controllers are also supported including the
DualSense, Switch Pro, and JoyCon controllers (**first party hardware only**).

This project is a fork of the work of Jays2Kings.

![DS4Windows Preview](https://raw.githubusercontent.com/Ryochan7/DS4Windows/jay/ds4winwpf_screen_20200412.png)

## License

DS4Windows is licensed under the terms of the GNU General Public License version 3.
You can find a copy of the terms and conditions of that license at
[https://www.gnu.org/licenses/gpl-3.0.txt](https://www.gnu.org/licenses/gpl-3.0.txt). The license is also
available in this source code from the COPYING file.

## Downloads

- **[Main builds of DS4Windows](https://github.com/Ryochan7/DS4Windows/releases)**

## Requirements

- Windows 10 or newer (Thanks Microsoft)
- Microsoft .NET 8.0 Desktop Runtime. [x64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-8.0.0-windows-x64-installer) or [x86](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-8.0.0-windows-x86-installer)
- Visual C++ 2015-2022 Redistributable. [x64](https://aka.ms/vs/17/release/vc_redist.x64.exe) or [x86](https://aka.ms/vs/17/release/vc_redist.x86.exe)
- [ViGEmBus](https://vigem.org/) driver (DS4Windows will install it for you)
- **Sony** DualShock 4 or other supported controller
- Connection method:
  - Micro USB cable
  - [Sony Wireless Adapter](https://www.amazon.com/gp/product/B01KYVLKG2)
  - Bluetooth 4.0 (via an
  [adapter like this](https://www.newegg.com/Product/Product.aspx?Item=N82E16833166126)
  or built in pc). Only use of Microsoft BT stack is supported. CSR BT stack is
  confirmed to not work with the DS4 even though some CSR adapters work fine
  using Microsoft BT stack. Toshiba's adapters currently do not work.
  *Disabling 'Enable output data' in the controller profile settings might help with latency issues, but will disable lightbar and rumble support.*
- Disable **PlayStation Configuration Support** and
**Xbox Configuration Support** options in Steam
