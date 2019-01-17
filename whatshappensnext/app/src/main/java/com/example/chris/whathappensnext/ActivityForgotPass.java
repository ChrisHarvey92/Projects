package com.example.chris.whathappensnext;

import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.FirebaseAuth;

public class ActivityForgotPass extends AppCompatActivity {

    private Button btnVerification;
    private EditText emailet;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_forgotpass);

        btnVerification = (Button) findViewById(R.id.btnVerification);
        emailet = (EditText) findViewById(R.id.emailet);

        btnVerification.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                FirebaseAuth auth = FirebaseAuth.getInstance();

                String email = emailet.getText().toString().trim();

                auth.sendPasswordResetEmail(email)
                        .addOnCompleteListener(new OnCompleteListener<Void>() {
                            @Override
                            public void onComplete(@NonNull Task<Void> task) {
                                if(task.isSuccessful()) {
                                    Toast.makeText(ActivityForgotPass.this, "Email sent", Toast.LENGTH_LONG).show();
                                    Intent i = new Intent(ActivityForgotPass.this, MainActivity.class);
                                    startActivity(i);
                                } else {
                                    Toast.makeText(ActivityForgotPass.this, "Email invalid", Toast.LENGTH_LONG).show();
                                }
                            }
                        });
            }
        });



    }
}
