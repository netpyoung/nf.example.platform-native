『uGUIではじめるUnity UIデザインの教科書』
https://github.com/wikibook/ugui

AsyncTask
http://itmir.tistory.com/624

http://zwyuan.github.io/2015/12/22/three-ways-to-use-android-ndk-cross-compiler/


jar : Java ARchive
aar : Android ARchive
JNI : Java Native Interface
NDK : Native Development Kit

# Gradle
https://docs.gradle.org/current/userguide/userguide.html
## static
~~~c#
using(AndroidJavaClass javaCalss = new AndroidJavaClass("com.example.mylibrary.Say"))
{
      return javaCalss.CallStatic<string>("Hello", a, b);
}
~~~

## method
~~~c#
using(AndroidJavaObject jo = new AndroidJavaObject("com.example.mylibrary.Say"))
{
      return jo.Call<string>("Hello2", a, b);
}
~~~

~~~c#
using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
{
using (AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity"))
{
     Debug.Log(jo.Call<AndroidJavaObject>("getCacheDir").Call<string>("getCanonicalPath"));
}
}
~~~

~~~c#
void Start ()
{
      AndroidJNIHelper.debug = true;
      using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer")) {
           jc.CallStatic("UnitySendMessage", "Main Camera", "JavaMessage", "whoowhoo");
      }
}

void JavaMessage(string message) {
      Debug.Log("message from java: " + message);
}
~~~

~~~
exported_android/
     hello_unity/
          AndroidManifest.xml
               <activity android:name="com.hello.world.UnityPlayerActivity">
          src/com/hello/world/
               UnityPlayerNativeActivity.java // deprecated
               UnityPlayerProxyActivity.java  // deprecated
               UnityPlayerActivity.java

     hello_aar/
~~~


var UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
var currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");



# Fragment

Fragment
https://developer.android.com/reference/android/app/Service.html
프래그먼트는 자체 수명 주기를 가지고, 자체 입력 이벤트를 받으며, 액티비티 실행 중에 추가 및 제거가 가능한 액티비티의 모듈식 섹션이라고 생각하면 됩니다
프래그먼트는 항상 액티비티 내에 포함되어 있어야 하며 해당 프래그먼트의 수명 주기는 호스트 액티비티의 수명 주기에 직접적으로 영향을 받습니다
Android가 프래그먼트를 처음 도입한 것은 Android 3.0(API 레벨 11)부터입니다

https://developer.android.com/guide/topics/manifest/service-element.html

http://eppz.eu/blog/unity-android-plugin-tutorial-1/

https://github.com/eppz/Unity.Blog.Unity_Android_plugin_tutorial/blob/master/Android/EPPZ_Alert_Android/EPPZ_Alert/src/main/java/com/eppz/plugins/EPPZ_Alert.java

TAG = FragmentManager.findFragmentByTag() https://developer.android.com/reference/android/app/FragmentManager.html#findFragmentByTag(java.lang.String)



classes.jar
C:\Program Files\Unity5.4.0f3\Editor\Data\PlaybackEngines\AndroidPlayer\Variations\mono\Release\Classes\classes.jar


library/build.gradle
android.libraryVariants.all {variant ->
    variant.outputs.each {output ->
        output.packageLibrary.exclude ( 'libs / classes.jar')
    }
}

compile files('/Applications/Unity/Unity.app/Contents/PlaybackEngines/AndroidPlayer/release/bin/classes.jar')


~~~java
import com.unity3d.player.UnityPlayer;
UnityPlayer.UnitySendMessage("GameObject (1)", "HIHIHI", ""); // 마지막 인자 null하면 뻑났었음.
~~~



## interop
http://blog.csdn.net/fg5823820/article/details/47865741
