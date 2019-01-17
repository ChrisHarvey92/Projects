package com.example.chris.whathappensnext;

import android.app.ProgressDialog;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.text.TextUtils;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.auth.UserProfileChangeRequest;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

public class ActivityRegister extends AppCompatActivity implements View.OnClickListener {

    private EditText registerUserName;
    private EditText registerEmail;
    private EditText registerPassword;
    private EditText registerConfirmPassword;
    private Button btnRegister;
    private ProgressDialog progressDialog;

    private FirebaseAuth mAuth;
    private FirebaseAuth.AuthStateListener mAuthListener;
    FirebaseAuth userAuth;
    FirebaseUser firebaseuser;

    DatabaseReference databaseReference;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        mAuth = FirebaseAuth.getInstance();
        firebaseuser = FirebaseAuth.getInstance().getCurrentUser();


        registerUserName = (EditText) findViewById(R.id.registerUserName);
        registerEmail = (EditText) findViewById(R.id.registerEmail);
        registerPassword = (EditText) findViewById(R.id.registerPassword);
        registerConfirmPassword = (EditText) findViewById(R.id.registerConfirmPassword);
        btnRegister = (Button) findViewById(R.id.btnRegister);
        progressDialog = new ProgressDialog(this);

        btnRegister.setOnClickListener(this);


    }

    private void registerUser() {

        final String username = registerUserName.getText().toString().trim();
        final String email = registerEmail.getText().toString().trim();
        String password = registerPassword.getText().toString().trim();
        String confirmpass = registerConfirmPassword.getText().toString().trim();

        if (TextUtils.isEmpty(username)) {
            Toast.makeText(this, "Please enter a Username", Toast.LENGTH_LONG).show();
            return;
        }

        if (TextUtils.isEmpty(email)) {
            Toast.makeText(this, "Please enter your Email", Toast.LENGTH_LONG).show();
        }

        if (TextUtils.isEmpty(password)) {
            Toast.makeText(this, "Please enter a Password", Toast.LENGTH_LONG).show();
        }

        if (TextUtils.isEmpty(confirmpass)) {
            Toast.makeText(this, "Please confirm your Password", Toast.LENGTH_LONG).show();
        }

        progressDialog.setMessage("Registering your account, Please wait...");
        progressDialog.show();

        final String usersname = registerUserName.getText().toString().trim();
        final String uemail = registerEmail.getText().toString().trim();

        mAuth.createUserWithEmailAndPassword(email, password)
                .addOnCompleteListener(this, new OnCompleteListener<AuthResult>() {
                    @Override
                    public void onComplete(@NonNull Task<AuthResult> task) {
                        if (task.isSuccessful()) {
                            Toast.makeText(ActivityRegister.this, "Sign up Successful!", Toast.LENGTH_LONG).show();
                            if(firebaseuser != null) {
                                firebaseuser = FirebaseAuth.getInstance().getCurrentUser();
                                String currentuid = firebaseuser.getUid();
                                DatabaseReference rootRef = FirebaseDatabase.getInstance().getReference().child("Users").child(currentuid);
                                User user = new User(usersname, uemail);
                                rootRef.setValue(user);
                                startActivity(new Intent(ActivityRegister.this, ActivityAccount.class));
                            } else {
                                mAuth.signInWithEmailAndPassword(registerEmail.getText().toString().trim(), registerPassword.getText().toString().trim())
                                        .addOnCompleteListener(ActivityRegister.this, new OnCompleteListener<AuthResult>() {
                                            @Override
                                            public void onComplete(@NonNull Task<AuthResult> task) {
                                                if(task.isSuccessful()) {
                                                    firebaseuser = FirebaseAuth.getInstance().getCurrentUser();
                                                    String currentuid = firebaseuser.getUid();
                                                    DatabaseReference rootRef = FirebaseDatabase.getInstance().getReference().child("Users").child(currentuid);
                                                    User user = new User(usersname, uemail);
                                                    rootRef.setValue(user);
                                                    Toast.makeText(ActivityRegister.this, "Welcome!", Toast.LENGTH_LONG).show();
                                                    startActivity(new Intent(ActivityRegister.this, ActivityAccount.class));
                                                } else {
                                                    Toast.makeText(ActivityRegister.this, "Username or Password is incorrect", Toast.LENGTH_LONG).show();
                                                }

                                            }
                                        });
                            }

                        } else {
                            Toast.makeText(ActivityRegister.this, "Reg failed", Toast.LENGTH_LONG).show();

                        }


                    }
                });

        progressDialog.dismiss();
                    }

    public void onClick(View view) {

        final String username = registerUserName.getText().toString().trim();
        final String email = registerEmail.getText().toString().trim();

        registerUser();

//        String currentuid = firebaseuser.getUid();
//        DatabaseReference rootRef = FirebaseDatabase.getInstance().getReference().child("Users").child(currentuid);
//        User user = new User(username, email);
//        rootRef.setValue(user);

//        startActivity(new Intent(ActivityRegister.this, ActivityAccount.class));


    }


}
