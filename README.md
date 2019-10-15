# Arcade Control Panel
Keyboard input simulator for physical pushbuttons on (for example) Windows-based arcade game systems, utilizing the FT232 USB serial/GPIO device

![Screenshot of beta version](https://raw.githubusercontent.com/cathoderaydude/ArcadeControlPanel/master/ArcadeControlPanel/1.0d-screenshot.png)

![Diagram of FT232 device](https://raw.githubusercontent.com/cathoderaydude/ArcadeControlPanel/master/docs/images/ft232%20banner.png)

# Overview

This app allows you to connect pushbuttons to your PC using an inexpensive USB device called an FT232, then trigger arbitrary key sequences when you press them. This was intended for triggering "insert coin" and "exit" actions on MAME, but you can use it with any application.

An example device is [this one](https://www.amazon.com/FT232R-FT232RL-Serial-Converter-XYGStudy/dp/B00DTRFKM4), but there are many others - see the "Requirements" section below.

# Features

* Connect up to 8 buttons of any type
* Set a unique key combo to be sent when a button is pressed (full documentation in progress)
* Set a length of time the user must hold a button before it triggers
   * "Dangerous" buttons, like "exit current game" or Alt-F4 can be protected from accidental presses this way
   * Coming soon: A "chirp" will play at intervals while holding down protected buttons so the user knows to keep holding them
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

[![Image of wiring diagram](https://raw.githubusercontent.com/cathoderaydude/ArcadeControlPanel/master/docs/images/ft232%20btn1%20sm.png)](https://raw.githubusercontent.com/cathoderaydude/ArcadeControlPanel/master/docs/images/ft232%20btn1.png)
(Click to enlarge)

1. Locate the pin labeled **VCCIO** on the board.
1. Attach a wire from **VCCIO** to one leg of each of your buttons
  1. If using multiple buttons, "daisy-chain" from one to the next with several pieces of wire
1. Attach a wire from the second leg of your first button to the pin labeled **TXD** on the board.

You are now ready. Plug the device in to your PC, start ACP, click the systray icon, and you'll be able to press the button and see the big "1" turn green in the UI.

Here are all the button-to-pin assignments:

1. TXD
1. RXD
1. RTS#
1. CTS#
1. DTR#
1. DSR#
1. DCO#
1. RI#

# Using the application

Right now the application automatically detects the first FT232 it finds on startup and binds to it. If you have multiple, you will have to unplug all but one for now.

- Launch ArcadeControlPanel.exe; it will appear in your systray
- Click the systray icon to view the configuration window
- Press each button on your FT232 to verify inputs are working
  - You can leave the app running while you experiment with the inputs as long as you don't short out the device
  - If nothing is working, check the debug log to ensure the device was detected and the serial number matches  
- Enter [macros](https://github.com/cathoderaydude/ArcadeControlPanel/blob/master/docs/macro.md) for each button.
  - If a key name is invalid, you'll be told so when you try to trigger the button 
- If you want to require a button to be held down before it triggers, enter a *number of milliseconds divided by ten* in the Delay field; so for half a second, enter "50"
- If you want a button to play a sound effect, check the speaker icon next to it
  - Right now it's always a "insert coin" effect; replace "coin in.mp3" in the program folder to change that
  - This will be replaced with a file picker later
- When you think you have everything set up, check the "Enable binds" box. Now you're *armed* - pressing buttons will execute their macros
- That's it. You're ready to go. Minimize the app to hide it in the systray.
- When you exit, your settings will be saved automatically to an INI in the program folder.

# Requirements

* Windows
  * Any version that supports .NET 4.6 should work. Developed on Windows 10.
  * I don't know if there's a FT232 library for Linux but if so, compiling on Mono might work
* FT232 USB device
  * There are multiple versions of this chip (FT232R, FT232RL, etc.) but all should work
  * Some boards only have six pins (*TX, RX, RTS, CTS,* power and ground) and you will _not_ be able to get full usage out of those, only the first four inputs. You want the ones that have two extra rows of pins with labels like *DTR#, DSR#*, etc. to get all eight inputs.
  
## Disclaimer: Counterfeit FT232s

A couple years ago there was an incident - known as FTDIgate to some - in which FTDI, the manufacturer of the FT232 chip, released a driver update that bricked a lot of devices, which all turned out to be using counterfeit chips. There was a backlash (understandably) from customers and FTDI removed the destructive code, but their drivers still won't work with counterfeits.

**Is this likely?** Good question. FTDIgate was a couple years ago, so I expect the arms race has proceeded to a point where the counterfeits no longer trip detection, or nobody is selling them anymore because FTDIs scheme worked.

**How will I know if this happened to me?** I don't know yet, since I don't have a counterfeit to test with, but from what I understand you'll just see your button inputs get real flaky or maybe activate on their own. If this happens to you, [contact me](mailto:cathoderaydude@gekk.info) and I may be able to send you a verified working device in return for the broken one, since I need a bad one for testing.

**What can I do about this?** - Buy a real one. [This](https://www.amazon.com/FT232R-FT232RL-Serial-Converter-XYGStudy/dp/B00DTRFKM4) is the one I ordered that works perfectly. I intend to buy several other models soon and will try to build a compatibility database.

# Why?

I started this project because I needed button inputs for a touchscreen-only arcade machine I acquired. I was running MAME, which needed an "insert coin" button, and Steam games which required a keypress to exit. I didn't want a keyboard hanging out of the cabinet, just some basic buttons to send preassigned keystrokes to whatever program was in focus.

The FT232 is a $10 USB "COM port adapter" which can be used in a mode called "GPIO" or "bit-bang," in which you can use all 8 pins as generic inputs or outputs. This allowed me to connect up to eight physical buttons and access them from software.

There are many advantages to this approach. Because the FT232 is not a "keyboard" or "gamepad," there's no possibility of its inputs becoming confused with regular user input - the device itself doesn't simulate keystrokes, it sends unique signals that this application recognizes directly, making input absolutely unambiguous.

Also, each one has a unique serial number, so it will eventually be possible to configure several of these devices and have ACP remember which one is assigned to which buttons, even if you unplug them and move them to different ports.

I've gotten several suggestions of using an Arduino or Teensy in HID mode. I explicitly don't want to do this for countless reasons, not the least of which is I don't want to have to "program" the outboard device - I want everything software-driven, and the FT232 is completely fire-and-forget - but also because I don't want to be limited to just simple keypresses.

# Future

Here are things I would like to do eventually:

* Allow more actions. Right now I am only sending keyboard events. More actions should be made available. Anything you might find in a "macro" program could apply here, but considerations are:
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

# License

This software is licensed under the Mozilla Public License Version 2.0, the details of which can be found in the file LICENSE
