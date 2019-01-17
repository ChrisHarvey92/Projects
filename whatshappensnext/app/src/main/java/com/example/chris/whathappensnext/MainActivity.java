package com.example.chris.whathappensnext;

import android.content.Intent;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;

public class MainActivity extends AppCompatActivity {

    private Button btnRegister;
    private Button loginBtn;
    private EditText sUsername;
    private EditText sPassword;
    private TextView passForgot;
    FirebaseAuth mAuth;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        if(FirebaseAuth.getInstance().getCurrentUser() != null) {
                Toast.makeText(MainActivity.this, "Someone is signed in!", Toast.LENGTH_LONG).show();
        } else {
            Toast.makeText(MainActivity.this, "No one is signed in!", Toast.LENGTH_LONG).show();
        }

        btnRegister = (Button) findViewById(R.id.registerBtn);
        loginBtn = (Button) findViewById(R.id.loginBtn);
        sUsername = (EditText) findViewById(R.id.sUsername);
        sPassword = (EditText) findViewById(R.id.sPassword);
        passForgot = (TextView)findViewById(R.id.passForgot);

        mAuth = FirebaseAuth.getInstance();


        btnRegister.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(MainActivity.this, ActivityRegister.class));
            }
        });

        loginBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                mAuth.signInWithEmailAndPassword(sUsername.getText().toString().trim(), sPassword.getText().toString().trim())
                        .addOnCompleteListener(MainActivity.this, new OnCompleteListener<AuthResult>() {
                            @Override
                            public void onComplete(@NonNull Task<AuthResult> task) {
                                if(task.isSuccessful()) {
                                    Toast.makeText(MainActivity.this, "Welcome!", Toast.LENGTH_LONG).show();
                                    startActivity(new Intent(MainActivity.this, ActivityAccount.class));
                                } else {
                                    Toast.makeText(MainActivity.this, "Username or Password is incorrect", Toast.LENGTH_LONG).show();
                                }

                            }
                        });
            }
        });

        passForgot.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(MainActivity.this, ActivityForgotPass.class));
            }
        });


    }
}
