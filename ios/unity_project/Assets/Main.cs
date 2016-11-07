
using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public static class Library {
	const string DLL = "__Internal";

	#region DLL
	[DllImport(DLL, EntryPoint="do_test_static_func")]
	extern public static void do_test_static_func();

	[DllImport(DLL, EntryPoint="do_test_instance_func")]
	extern public static void do_test_instance_func();

	[DllImport(DLL, EntryPoint="do_test_callback")]
	extern public static void do_test_callback(Callback callback);
	#endregion DLL

	public delegate void Callback(string s);

}

public class Main : MonoBehaviour
{
	public void Hello()
	{
		Library.do_test_static_func ();
		Library.do_test_instance_func ();
		Library.do_test_callback(OnCallBack);
	}


	[AOT.MonoPInvokeCallback(typeof(Library.Callback))]
	public static void OnCallBack(string val) {
		UnityEngine.Debug.Log ("OnCallBack : " + val);
	}
}