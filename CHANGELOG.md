# Changelog
All notable changes to **MotionSentinel** will be documented in this file.

The format is based on [Semantic Versioning](https://semver.org/),  
and this project adheres to the principles of clear, predictable versioning.

---

## [1.0.0] - 2026-03-27
### Added
- Initial public release of MotionSentinel.
- Multiple mouse movement patterns:
  - Circle, LeftRight, UpDown, Jitter, ZigZag, HumanIdle, ShakeBurst.
- Global hotkey support using Win32 `RegisterHotKey`.
- Hotkey configuration via `hotkeys.json`.
- Automatic creation of JSON config if missing.
- Tray icon with synchronized status and hotkey display.
- Status label in UI mirrors tray text.
- Portable, no installation required.
- About dialog with version information and GitHub link.

### Fixed
- N/A (first release)

### Changed
- N/A (first release)

---

## [Unreleased]
### Planned
- JSON configuration for default modifiers.
- Auto‑reload of configuration when JSON changes.
- Profile support (e.g., Work.json, Gaming.json).
- Optional installer (Inno Setup).
- Additional movement patterns.

