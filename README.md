*This project is a part of The [SOOMLA](http://www.soom.la) Framework, which is a series of open source initiatives with a joint goal to help mobile game developers do more together. SOOMLA encourages better game design, economy modeling, social engagement, and faster development.*

soomla-unity3d-core
===============
The core module is currently included inside the [unity3d-store](https://github.com/soomla/unity3d-store) module. This core library holds common features and utilities used by all other modules of the SOOMLA framework.

It includes:
* Native bridges for on-device storage.
* `SoomlaEntity` - the base class from which all SOOMLA domain objects derive
* Reward domain objects and events - used to grant your users rewards.
* Utilities for logging and JSON manipulation.
* Utilities for the SOOMLA settings panel inside Unity.
* Utilities for platform specific post-build procedures:
  * Android - Manifest manipulation tools
  * iOS - XCode project manipulation tools

SOOMLA modules internally use these features, though we encourage you to use them for your own needs as well.  The settings panel utilities and post-build utilities should be used when creating a SOOMLA plugin for Unity.


## Download

####Pre baked unitypackage:

[soomla-unity3d-core 1.2.7](http://library.soom.la/fetch/unity3d-core/1.2.7?cf=github)

#### From sources:
 - Clone this repository recursively: `git clone --recursive https://github.com/soomla/soomla-unity3d-core.git`
 - Run `./build_all` from project directory

Contribution
---
SOOMLA appreciates code contributions! You are more than welcome to extend the capabilities of SOOMLA.

Fork -> Clone -> Implement -> Add documentation -> Test -> Pull-Request.

IMPORTANT: If you would like to contribute, please follow our [Documentation Guidelines](https://github.com/soomla/unity3d-store/blob/master/documentation.md). Clear, consistent comments will make our code easy to understand.

## SOOMLA, Elsewhere ...

+ [Framework Website](http://www.soom.la/)
+ [Knowledge Base](http://know.soom.la/)


<a href="https://www.facebook.com/pages/The-SOOMLA-Project/389643294427376"><img src="http://know.soom.la/img/tutorial_img/social/Facebook.png"></a><a href="https://twitter.com/Soomla"><img src="http://know.soom.la/img/tutorial_img/social/Twitter.png"></a><a href="https://plus.google.com/+SoomLa/posts"><img src="http://know.soom.la/img/tutorial_img/social/GoogleP.png"></a><a href ="https://www.youtube.com/channel/UCR1-D9GdSRRLD0fiEDkpeyg"><img src="http://know.soom.la/img/tutorial_img/social/Youtube.png"></a>

License
---
Apache License. Copyright (c) 2012-2014 SOOMLA. http://soom.la
+ http://opensource.org/licenses/Apache-2.0
