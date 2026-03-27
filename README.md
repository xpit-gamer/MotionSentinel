# MotionSentinel

MotionSentinel is a lightweight, robust, and modular Windows tool designed to prevent the system from entering idle mode by simulating subtle, human‑like mouse activity or other movements.  
It is built for professional environments where stability, predictability, and low resource usage are essential.

## ✨ Features

- Multiple movement patterns:
  - Circle
  - LeftRight
  - UpDown
  - Jitter
  - ZigZag
  - HumanIdle
  - ShakeBurst
- Global hotkey to start/stop movement
- Hotkeys configured via `hotkeys.json`
- Automatic creation of the JSON file if missing
- Tray icon with live status and hotkey display
- Status label synchronized with tray text
- Minimal CPU usage and low system impact
- Fully portable — no installation required

## 📁 Configuration (hotkeys.json)

On first launch, MotionSentinel automatically creates a default configuration file:

```json
{
  "AvailableKeys": [
    "None",
    "C",
    "F10",
    "F11",
    "F12",
    "X",
    "Z"
  ]
}
```

You can edit this file to add or remove keys.
Invalid keys are automatically ignored.

To reset to defaults, simply delete the file.

## 🛠 Technology

- .NET 10 (Windows)
- Windows Forms
- Win32 API (SendInput, RegisterHotKey)
- JSON configuration via System.Text.Json

## 🚀 Usage

1. Launch the application.
2. Select a movement pattern and hotkey.
3. Click Apply.
4. Start/stop movement using the UI or the global hotkey.
5. Minimize/close the window — MotionSentinel continues running in the system tray.

## 📦 Distribution

MotionSentinel is fully portable.
Place the .exe and hotkeys.json (optional) in the same directory.

## 📄 License

MIT License (or your preferred license).

## 👤 Developer

MotionSentinel is developed by XpiT Gamer. xpit.gamer@gmail.com
