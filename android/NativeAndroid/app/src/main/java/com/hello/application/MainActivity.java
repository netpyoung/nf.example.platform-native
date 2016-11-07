package com.hello.application;

import android.app.Activity;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

import com.hello.library.ICallBack;
import com.hello.library.LibMain;

public class MainActivity extends AppCompatActivity {
    public static Activity activity;

    public static LibMain libMain = new LibMain();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        MainActivity.activity = this;

        Button btnHello = (Button)findViewById( R.id.btnHello);
        btnHello.setOnClickListener(new Button.OnClickListener() {
            public void onClick(View v) {
                libMain.init(MainActivity.activity, new ICallBack() {
                    @Override
                    public void onCallback(String message) {
                        Log.i("callback", message);
                    }
                });
                Log.d("a", MainActivity.libMain.doTestStaticFunc(1, 2));
            }
        });
    }
}
