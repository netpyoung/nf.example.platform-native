# Native - url scehme


## Android

* https://developer.android.com/guide/components/intents-filters.html
* https://developer.chrome.com/multidevice/android/intents
* http://westhillapps.blog.jp/archives/25883001.html

AndroidManifest.xml

~~~xml
<activity android:name="com.hello.application.MainActivity">
    <intent-filter>
        <action android:name="android.intent.action.MAIN" />
        <category android:name="android.intent.category.LAUNCHER" />
    </intent-filter>

    <!-- scheme -->
    <intent-filter>
        <action android:name="android.intent.action.VIEW" />
        <category android:name="android.intent.category.DEFAULT" />
        <category android:name="android.intent.category.BROWSABLE" />
        <data android:scheme="myapp" android:host="myaction"/>
    </intent-filter>
    <!-- scheme -->
</activity>
~~~

html

~~~html
<a href="myapp://myaction">hellowrold</a>
~~~


.java

~~~java
Intent intent = getIntent();
Uri data = intent.getData();
if (data != null) {
    Log.d("a", data.toString());
}
~~~


## ios
* http://westhillapps.blog.jp/archives/25881486.html
* http://answers.unity3d.com/questions/654998/launched-from-a-browser.html
* https://github.com/bitstadium/HockeySDK-Unity-iOS/blob/master/Plugin/Editor/PostBuildTrigger.cs

~~~xml
<key>CFBundleURLTypes</key>
<array>
    <dict>
        <key>CFBundleURLSchemes</key>
        <array>
            <string>myapp</string>
        </array>
    </dict>
</array>
~~~


