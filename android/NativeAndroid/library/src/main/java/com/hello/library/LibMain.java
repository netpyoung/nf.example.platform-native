package com.hello.library;

import android.app.Activity;
import android.app.Fragment;
import android.util.Log;

import com.unity3d.player.UnityPlayer;

public class LibMain extends Fragment {
    final String LOG_TAG = "LibMain";
    ICallBack iCallBack = null;

    public static String doTestStaticFunc(int a, int b) {
        return String.format("%d + %d = %d", a, b, a + b);
    }

    public String doTestInstanceFunc(int a, int b) {
        return String.format("%d + %d = %d", a, b, a + b);
    }

    public void doUnitySendMessage(String gameObjectName, String functionName, int a, int b) {
        UnityPlayer.UnitySendMessage(gameObjectName, functionName, String.valueOf(a + b));
    }

    public void init(Activity activity, ICallBack iCallBack) {
        this.iCallBack = iCallBack;
        activity.getFragmentManager().beginTransaction().add(this, "LibMain").commit();
    }

    @Override
    public void onStart() {
        super.onStart();
        Log.d(LOG_TAG, "onStart");
        this.iCallBack.onCallback("callback - onStart");
    }

    @Override
    public void onDestroy() {
        super.onDestroy();
        Log.d(LOG_TAG, "onDestroy");
    }
}
