# Macro Documentation

## The Basics

The macro language has no special syntax. Enter each key name that you want to send separated by spaces, e.g.:

**DOWN DOWN DOWN ENTER** - presses and releases the down arrow key three times - then presses and releases enter.

That's the simplest way to use ACP. Besides learning the key names, which are listed below, that's all there is to it.

If the "coin in" button in MAME is the number 5, then type "N5" in the field and you're done - although for that specific case, keep in mind that the "number row 5" and the "numpad 5" are different signals and you might need to type "NUMPAD5" instead.

## Modifiers

Modifier keys - that's Control, Alt, Shift and Windows - are treated specially.

Pressing a normal keys sends two separate signals, a "key down" and "key up," so when you enter "F5," ACP sends an "F5 down" followed right away by an "F5 up."

For modifiers, however, you don't want to just press and release the key; you want to press it, send other keypresses, and then release it. So every time one of these keys appears, it "toggles" its state, e.g.:

**CTRL ALT F2 ALT CTRL** - Presses Control and Alt - then presses and releases F2 - then releases Control and Alt

The first time CTRL appears it is pressed; the second time it is released. If you put CTRL in there many times, it would toggle each time. To save time, you don't need to put in "pairs" like this - you can just put in the first one, and ACP will terminate it for you:

**CTRL ALT F2** - Exactly the same as above.

The one other thing to know about modifiers is that there are two of each, since keyboards have them on both sides. "CTRL" means "left control," and there's a matching "RCTRL" for the one on the right side. In most cases the left one is fine.

## Delay

If you want a button to have a "safety cover" you can set a delay. Delays are set in tens of milliseconds, so "50" means "500 milliseconds," or half a second. With that value, the user has to press and _hold_ the button for half a second or it will do nothing. This is a good feature to use for e.g. the button that exits MAME, losing all the players progress.

In the configuration window, the status light for a button will turn orange when pressed if a delay is in use, and then green when the delay expires.

## Suggestions

Please send me any ideas for enhancements to this macro language. You can find my contact info on the main readme.

## Key Mappings

Here are all the key names you can use:

<table>
<tr><th>Modifiers</th></tr>
<tr><td>CTRL</td></tr>
<tr><td>RCTRL</td></tr>
<tr><td>SHIFT</td></tr>
<tr><td>RSHIFT</td></tr>
<tr><td>ALT</td></tr>
<tr><td>RALT</td></tr>
<tr><td>WIN</td></tr>
<tr><td>RWIN</td></tr>

<tr><th>Number row keys</th></tr>
<tr><td>N1</td></tr>
<tr><td>N2</td></tr>
<tr><td>N3</td></tr>
<tr><td>N4</td></tr>
<tr><td>N5</td></tr>
<tr><td>N6</td></tr>
<tr><td>N7</td></tr>
<tr><td>N8</td></tr>
<tr><td>N9</td></tr>
<tr><td>N0</td></tr>

<tr><th>Numpad keys</th></tr>
<tr><td>NUMPAD7</td></tr>
<tr><td>NUMPAD8</td></tr>
<tr><td>NUMPAD9</td></tr>
<tr><td>NUMPAD4</td></tr>
<tr><td>NUMPAD5</td></tr>
<tr><td>NUMPAD6</td></tr>
<tr><td>NUMPAD1</td></tr>
<tr><td>NUMPAD2</td></tr>
<tr><td>NUMPAD3</td></tr>
<tr><td>NUMPAD0</td></tr>
<tr><td>NUMPADENTER</td></tr>
<tr><td>NUMPADEQUALS</td></tr>
<tr><td>NUMPADCOMMA</td></tr>

<tr><th>Function keys</th></tr>
<tr><td>F1</td></tr>
<tr><td>F2</td></tr>
<tr><td>F3</td></tr>
<tr><td>F4</td></tr>
<tr><td>F5</td></tr>
<tr><td>F6</td></tr>
<tr><td>F7</td></tr>
<tr><td>F8</td></tr>
<tr><td>F9</td></tr>
<tr><td>F10</td></tr>
<tr><td>F11</td></tr>
<tr><td>F12</td></tr>
<tr><td>F13</td></tr>
<tr><td>F14</td></tr>
<tr><td>F15</td></tr>

<tr><th>Media keys</th></tr>
<tr><td>VOLUMEDOWN</td></tr>
<tr><td>VOLUMEUP</td></tr>
<tr><td>PREVTRACK</td></tr>
<tr><td>NEXTTRACK</td></tr>
<tr><td>PLAYPAUSE</td></tr>
<tr><td>MEDIASTOP</td></tr>
<tr><td>MUTE</td></tr>

<tr><th>Arrow keys</th></tr>
<tr><td>UP</td></tr>
<tr><td>LEFT</td></tr>
<tr><td>RIGHT</td></tr>
<tr><td>DOWN</td></tr>

<tr><th>Web keys</th></tr>
<tr><td>WEBSEARCH</td></tr>
<tr><td>WEBFAVORITES</td></tr>
<tr><td>WEBREFRESH</td></tr>
<tr><td>WEBSTOP</td></tr>
<tr><td>WEBFORWARD</td></tr>
<tr><td>WEBBACK</td></tr>

<tr><th>Everything else</th></tr>
<tr><td>ADD</td></tr>
<tr><td>MINUS</td></tr>
<tr><td>EQUALS</td></tr>
<tr><td>SUBTRACT</td></tr>
<tr><td>MULTIPLY</td></tr>
<tr><td>ESCAPE</td></tr>
<tr><td>BACK</td></tr>
<tr><td>TAB</td></tr>
<tr><td>LBRACKET</td></tr>
<tr><td>RBRACKET</td></tr>
<tr><td>RETURN</td></tr>
<tr><td>SEMICOLON</td></tr>
<tr><td>APOSTROPHE</td></tr>
<tr><td>GRAVE</td></tr>
<tr><td>BACKSLASH</td></tr>
<tr><td>COMMA</td></tr>
<tr><td>PERIOD</td></tr>
<tr><td>SLASH</td></tr>
<tr><td>SPACE</td></tr>
<tr><td>CAPITAL</td></tr>
<tr><td>NUMLOCK</td></tr>
<tr><td>SCROLL</td></tr>
<tr><td>DECIMAL</td></tr>
<tr><td>OEM_102</td></tr>
<tr><td>KANA</td></tr>
<tr><td>ABNT_C1</td></tr>
<tr><td>CONVERT</td></tr>
<tr><td>NOCONVERT</td></tr>
<tr><td>YEN</td></tr>
<tr><td>ABNT_C2</td></tr>
<tr><td>AT</td></tr>
<tr><td>COLON</td></tr>
<tr><td>UNDERLINE</td></tr>
<tr><td>KANJI</td></tr>
<tr><td>STOP</td></tr>
<tr><td>AX</td></tr>
<tr><td>UNLABELED</td></tr>
<tr><td>CALCULATOR</td></tr>
<tr><td>WEBHOME</td></tr>
<tr><td>DIVIDE</td></tr>
<tr><td>SYSRQ</td></tr>
<tr><td>PAUSE</td></tr>
<tr><td>HOME</td></tr>
<tr><td>PRIOR</td></tr>
<tr><td>END</td></tr>
<tr><td>NEXT</td></tr>
<tr><td>INSERT</td></tr>
<tr><td>DELETE</td></tr>
<tr><td>APPS</td></tr>
<tr><td>POWER</td></tr>
<tr><td>SLEEP</td></tr>
<tr><td>WAKE</td></tr>
<tr><td>MYCOMPUTER</td></tr>
<tr><td>MAIL</td></tr>
<tr><td>MEDIASELECT</td></tr>
</table>
