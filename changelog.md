### v1.2.7 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.2.6...v1.2.7)

* Changes
  * Stopped using SoomlaApp in android

### v1.2.6 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.2.5...v1.2.6)

* Changes
  * Removed binaries from repo

### v1.2.5 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.2.4...v1.2.5)

* Fixes
  * Hotfix - editor goes into infinite loop

### v1.2.4 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.2.3...v1.2.4)

* Changes
  * Disabled Soomla menu if no other open source module is present

* Fixes
  * Fixed build in Unity 5.3

### v1.2.3 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.2.2...v1.2.3)

* Changes
  * Added saving user settings in PlayerPrefs

### v1.2.2 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.2.1...v1.2.2)

* Changes
  * Minor improvements and rearrangements to Editor script

### v1.2.1 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.2.0...v1.2.1)

* Changes
  * Minor improvements to Editor script

### v1.2.0 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.1.0...v1.2.0)

* Features
  * Added checking for latest version in Soomla Settings panel
  * Added "Remove Soomla" to Soomla menu
  * Added a new way of event handling without prefabs

* Changes
  * Moved all SOOMLA plugins into 'Soomla' folders

### v1.1.0 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.12...v1.1.0)

* New Features
  * Exposed KeyValueStorage DB purge method

### v1.0.12 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.11...v1.0.12)

* Fixes
  * Fixes Wrong access modifiers at _getEncryptedKeys() method

### v1.0.11 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.10...v1.0.11)

* Features
  * Added KeyValStorage.GetEncryptedKeys

* Fixes
  * UserProfile fields do not support Unicode symbols
  * Soomla works with IL2CPP
  * UserProfile fields support Unicode symbols

### v1.0.10 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.9...v1.0.10)

* Fixes
  * WP8 - PostBuild Path Fix for IAPMock
  * iOS - replaced mod_pbxproj.pyc with mod_pbxproj.py

### v1.0.9 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.8...v1.0.9)

* Fixes
  * Minor fixes for Unity v5

* Changes
  * Merged changes in submodules

### v1.0.8 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.7...v1.0.8)

* New Features
  * WP8 Integration

### v1.0.7 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.6...v1.0.7)

* Changes
  * Updated with new version of submodules

### v1.0.6 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.5...v1.0.6)

* Changes
  * Added post build script for core

* Fixes
  * Log error in post build runner
  * Fixing issues with RandomReward and SequenceReward

### v1.0.5 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.4...v1.0.5)

* Fixes
  * Fixing issue with native KVS iOS via submodule
  * Fixing AsyncTask class not found exception (Android) via submodule

### v1.0.4 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.3...v1.0.4)

* Changes
  * Updated new features from submodules

### v1.0.3 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.2...v1.0.3)

* New Features
  * Added option to disable Soomla Unity based messages (Thanks @zentuit)
  * Updated new features from submodules

### v1.0.2 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.1...v1.0.2)

* Changes
  * Updated submodules

### v1.0.1 [view commit logs](https://github.com/soomla/soomla-unity3d-core/compare/v1.0.0...v1.0.1)

* Fixes
  * Fixing SoomlaEntity cloning without new ID
  * Fixing issue in `toJSONObject` function of `Schedule` class
  * Escaping special characters to support special characters in string for JSON
  * Fixed an issue with a duplicated function and bridge project config
  * Fixing typo in java bridge: onRewardGiven -> onRewardTaken

* Changes
  * Updated ios-core with NonConsumableItem changes
  * Reward storage in natives work with ID now

* New Features
  * Adding a default Schedule to returned reward when converted to Dictionary
  * Creating a generic post build process
  * Added function to return rewards list from Reward object

### v1.0.0

Initial version of the SOOMLA Core library for Unity
