using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using com.example.mylibrary;

namespace com.example.mylibrary
{
	public static class LibMain
	{
		const string UNITYPLAYER_CLASS_NAME = "com.unity3d.player.UnityPlayer";
		const string LIB_CLASS_NAME = "com.hello.library.LibMain";
		public static string doTestStaticFunc(int a, int b)
		{
			using(AndroidJavaClass cls = new AndroidJavaClass(LIB_CLASS_NAME))
			{
				return cls.CallStatic<string>("doTestStaticFunc", a, b);
			}
		}

		public static string doTestInstanceFunc(int a, int b)
		{
			AndroidJavaObject cls = new AndroidJavaObject (LIB_CLASS_NAME);
			return cls.Call<string> ("doTestInstanceFunc", a, b);
		}

		public static void doUnitySendMessage(string receiveGameObjectName, string recieveFuncName, int a, int b)
		{
			using (AndroidJavaObject cls = new AndroidJavaObject (LIB_CLASS_NAME))
			{
				cls.Call("doUnitySendMessage", receiveGameObjectName, recieveFuncName, a, b);
			}
		}


		public static void FragmentInit()
		{
			AndroidJavaClass UnityPlayer = new AndroidJavaClass(UNITYPLAYER_CLASS_NAME);
			AndroidJavaObject currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
			AndroidJavaObject lib = new AndroidJavaObject(LIB_CLASS_NAME);
			lib.Call("init", currentActivity, new Callback());
		}
	}

	public class Callback : AndroidJavaProxy
	{
		const string LIB_INTERFACE_NAME = "com.hello.library.ICallBack";

		public Callback() : base(LIB_INTERFACE_NAME)
		{
		}

		void onCallback(string message)
		{
			Debug.Log("Callback : " + message);
		}
	}
}

public class Main : MonoBehaviour
{
	void Start()
	{
		Debug.Log(LibMain.doTestStaticFunc(1, 2));
		Debug.Log(LibMain.doTestInstanceFunc(3, 4));

		LibMain.doUnitySendMessage (this.gameObject.name, "ReceiveFromAndroid", 5, 6);
		LibMain.FragmentInit ();
	}

	public void ReceiveFromAndroid(string msg)
	{
		Debug.Log("GOTIT");
		Debug.Log (msg);
	}
}
