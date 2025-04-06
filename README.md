# win_notifications
a hacky solution to send native windows notifications via the nvgt scripting language

# Intruduction

A lightweight, fully portable Windows toast notification utility built with C# and .NET Framework.  
This tool is designed to be called from other applications (like NVGT/BGT-based games or scripts) to display native Windows toast popups.

## What It Does

`win_notifications` provides a command-line executable (`notifier.exe`) that displays native Windows 10/11 toast notifications.  
This is ideal for triggering in-game alerts, system reminders, or external event notifications from a script or third-party app.

**Example usage:**
notifier.exe "Title" "This is a toast message"

## Requirements to Build

To compile `notifier.exe` yourself:

### Development Environment

- Visual Studio 2019 or 2022

- .NET Framework 4.7.2 (or higher)

- NuGet Package Manager

### Required NuGet Packages

These will be automatically restored when you build the project:

- `Microsoft.Toolkit.Uwp.Notifications`

- `Fody`

- `Costura.Fody`

### Project Configuration

- Target Framework: **.NET Framework 4.7.2**

- Set your app icon in:  
  `Project Properties > Application > Icon and manifest`

- Ensure the file `FodyWeavers.xml` is present in the project root and contains:

<Weavers>
  <Costura />
</Weavers>
