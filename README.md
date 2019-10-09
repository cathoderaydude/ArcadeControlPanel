# Kiosk Control Panel
Keyboard input simulator (among other things) for custom pushbuttons on a PC-based arcade game system, utilizing the FT232 USB serial/GPIO device

![Screenshot of beta version](https://raw.githubusercontent.com/gravislizard/kioskControlPanel/master/kioskControlPanel/beta-screenshot.png)

# Overview

This app allows you to connect pushbuttons to your PC using an inexpensive USB device called an FT232 like [this one](https://www.amazon.com/FT232R-FT232RL-Serial-Converter-XYGStudy/dp/B00DTRFKM4), then trigger arbitrary key sequences when you press them.

I started this project because I needed button inputs for a touchscreen-only arcade machine I acquired. I was running MAME, which needed an "insert coin" button, and Steam games which required a keypress to exit. I didn't want a keyboard hanging out of the cabinet, just some basic buttons to do preassigned actions to whatever program was in focus.

The FT232 is a $10 USB "COM port adapter" which can be used in a mode called "GPIO" or "bit-bang," in which you can use all 8 pins as generic inputs or outputs. This allowed me to connect up to eight buttons, although I initially only needed four.

There are many advantages to this approach. Because the FT232 is not a keyboard or gamepad, there's no possibility of its inputs becoming confused with regular user input. Also, each one has a unique serial number, so it may eventually be possible to configure multiple of these devices and have KCP remember them even if you unplug them and move them to different ports.

# Features

* Connect up to 8 buttons of any type
* Set a unique key combo to be sent when a button is pressed ([reference](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=netframework-4.8))
* Set a length of time the user must hold a button before it triggers
   * "Dangerous" buttons, like "exit current game" or Alt-F4 can be protected from accidental presses this way
* Fairly low latency (10-20ms)
* Requires only a cheap USB adapter and light soldering to get working

# Circuitry

**Please note:** This is all very preliminary and subject to change. I am new to this hardware and know very little about it, but it seems pretty straightforward to use. Any experts are invited to shoot me off whatever you think is relevant and I'll add it.

***

__You will need:__

* A soldering iron
* FT232 device
* Wire
* Some kind of button or switch
* Optionally, wires with __dupont sockets__, which are little plastic receptacles that fit on to I/O pins
  * Your FT232 probably came with little pin strips you can solder into the empty holes for the I/O lines which will fit, but not hold very positively. Look for longer "pin headers" online if you want a better grip.

In the following instructions, use solder or a dupont connector wherever it says "attach."

  
Connect your buttons as follows:

1. Locate the pin labeled **VCCIO** on the board.
1. Attach a wire from **VCCIO** to one leg of each of your buttons
  1. If using multiple buttons, "daisy-chain" from one to the next with several pieces of wire
1. Attach a wire from the second leg of your first button to the pin labeled **DCD#** on the board.
1. Repeat for **DSR#, RI#, and DTR#**
  1. These instructions will be updated when I have found the rest of the pinout.

You are now ready. Plug the device in to your PC, run KCP, and if it works you'll be able to press buttons and see them light up in the UI.

# System Requirements

* Windows
  * Any version that supports .NET should work. Developed on Windows 10.
  * I don't know if there's a FT232 library for Linux but if so, compiling on Mono might work
* FT232 USB device
  * There are multiple versions of this hardware. All should work, to my knowledge
  
# Future

Here are things I would like to do eventually:

* Allow more actions. Right now I am using the built-in C# SendKeys functionality, which has some limitations (you can't send the Windows key for instance.) More actions should be made available. Anything you might find in a "macro" program could apply here, but considerations are:
  * Write a string to a file
  * Send more complex key sequences
  * Send a key sequence targeting a specific app or targeting apps by name
  * Send a mouse click
    * Position the mouse in a specific place first
    * Send it directly to an app's window as a Win32 message so the window doesn't have to be visible
* Expand to multiple units. It seems to be possible to identify these by serial number, so I could offer an expandable interface where you just keep adding more pages of inputs and assigning them to detected devices (or entering SNs for devices that aren't yet connected)
* Allow other types of inputs
  * Toggle switches for e.g. DIP settings in MAME or windows audio mute
  * Analog input - this would consume an output pin and require a capacitor, but would make it possible to have direct control of the Windows volume level, for instance, if adjusting the volume of your amplifier with an analog control is difficult or undesirable

Pie in the sky:

* Try to improve the core FT232 input code. See issue #10
* Port to other OSes
  * Obviously being bound to .NET could be a problem. I've never looked into Mono. I was going to start this on Python initially but the FT232 lib was fundamentally broken, I didn't want to mess with PyQt, and calling dark win32 APIs from py doesn't sound like fun
* Implement output capabilities. I haven't thought much about this, but if I'm already touching the device, I could set some pins to outputs and do something with that. What value could this have that's on-theme for this project?
* Implement serial/i2c/spi input capabilities. The FT232 natively speaks all sorts of serial protocols; is there something in this?

I haven't seen much software that uses these devices, and general-purpose I/O on PCs has been a sore spot for decades, so I'm interested in whatever I can do to make them available to more people.
