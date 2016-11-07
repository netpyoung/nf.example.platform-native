xcodebuild : https://developer.apple.com/legacy/library/documentation/Darwin/Reference/ManPages/man1/xcodebuild.1.html

xcrun: https://developer.apple.com/legacy/library/documentation/Darwin/Reference/ManPages/man1/xcrun.1.html

test automation
https://developer.apple.com/library/content/documentation/DeveloperTools/Conceptual/testing_with_xcode/chapters/08-automation.html


## extensions
* .o : static library
* .so // .bundle : dynamic library
  - [ref:so-and-dylib](http://stackoverflow.com/questions/2339679/what-are-the-differences-between-so-and-dylib-on-osx)
  - Loadable modules are called "bundles" in Mach-O speak. They have the file type MH_BUNDLE. They can carry any extension; the extension .bundle is recommended by Apple, but most ported software uses .so for the sake of compatibility
* .dylib : dynamic library
  - Mach-O shared libraries have the file type MH_DYLIB and carry the extension .dylib

* .framework
  - [ref:framework](https://developer.apple.com/library/content/documentation/MacOSX/Conceptual/BPFrameworks/Concepts/WhatAreFrameworks.html)
  - A framework is a hierarchical directory that encapsulates shared resources, such as a dynamic shared library, nib files, image files, localized strings, header files, and reference documentation in a single package.


* [Swift and Objective-C in the Same Project](https://developer.apple.com/library/content/documentation/Swift/Conceptual/BuildingCocoaApps/MixandMatch.html)

## command
* lipo
Fat 타입 라이브러리 만들기 Fat 타입 라이브러리를 만들기 위해서는 i386, armv7, armv7s로 빌드된 라이브러리가 있어야 한다. 각각의 플랫폼 별로 라이브러리가 만들어져 있다면 다음 명령으로 하나의 Fat 파일을 만들 수 있다. - http://10apps.tistory.com/123

    lipo -ouput libtest.a -create libtest_i386.a libtest_armv7.a libtest_armv7s.a

* ditto
     ditto -- copy directory hierarchies, create and extract archives


## interop
* rust : https://www.bignerdranch.com/blog/building-an-ios-app-in-rust-part-4/
http://jakegoulding.com/rust-ffi-omnibus/

## object-c && swift
objc : typedef void (*VoidPtr)(const char *);
swift : typealias VoidPtr = @convention(c) (UnsafePointer<CChar>) -> Void

## Unity
[Build Settings]
Always Embedded Swift Standard Libraries : yes
Runpath Search Paths : @executable/Frameworks

[Build Phases]
Copy Files
Destination => Frameworks / 프레임워크 추가

build target - simulatoion이면 simulation으로 맞추기 중요!!!!!


# package manager
ogdl
Carthage
cocospods

