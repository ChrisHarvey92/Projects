package com.example.chris.whathappensnext;

import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class ActivityAccount extends AppCompatActivity {

    private TextView usernametv;
    private TextView emailad;
    private Button btnResetPass;
    private Button btnLogout;
    private ImageButton searchIcon;
    FirebaseAuth mAuth;
    DatabaseReference databaseReference;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_account);

        usernametv = (TextView) findViewById(R.id.textViewUsername);
        emailad = (TextView) findViewById(R.id.textViewEmail);
        btnResetPass = (Button) findViewById(R.id.btnResetPass);
        btnLogout = (Button) findViewById(R.id.btnLogout);
        searchIcon = (ImageButton) findViewById(R.id.searchIcon);




        FirebaseUser user = FirebaseAuth.getInstance().getCurrentUser();
        if (user != null) {
            // User is signed in
            String userUID = FirebaseAuth.getInstance().getCurrentUser().getUid();
            databaseReference = FirebaseDatabase.getInstance().getReference().child("Users").child(userUID);

            String email = user.getEmail();


            emailad.setText(email);

            databaseReference.addValueEventListener(new ValueEventListener() {
                @Override
                public void onDataChange(@NonNull DataSnapshot dataSnapshot) {

                        String user1 = dataSnapshot.child("username").getValue(String.class);

                        usernametv.setText(user1);

                        if (usernametv != null) {
                            usernametv.setText(user1);
                        } else {
                            usernametv.setText(user1);
                        }

                }

                @Override
                public void onCancelled(@NonNull DatabaseError databaseError) {

                }
            });

        } else {
            // No user is signed in
        }

        btnResetPass.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                FirebaseUser user = FirebaseAuth.getInstance().getCurrentUser();

                String userUID = FirebaseAuth.getInstance().getCurrentUser().getUid();
                databaseReference = FirebaseDatabase.getInstance().getReference().child("Users").child(userUID);

                String email = user.getEmail();


                FirebaseAuth auth = FirebaseAuth.getInstance();
                String emailAddress = email;

                auth.sendPasswordResetEmail(emailAddress)
                        .addOnCompleteListener(new OnCompleteListener<Void>() {
                            @Override
                            public void onComplete(@NonNull Task<Void> task) {
                                if (task.isSuccessful()) {
                                    Toast.makeText(ActivityAccount.this, "Email for password reset sent.", Toast.LENGTH_LONG).show();
                                }
                            }
                        });

            }
        });

        btnLogout.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                FirebaseAuth.getInstance().signOut();
                if(FirebaseAuth.getInstance().getCurrentUser() != null) {

                } else {
                    startActivity(new Intent(ActivityAccount.this, MainActivity.class));
                }
            }
        });

        searchIcon.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(ActivityAccount.this, ActivityStories.class));
            }
        });

    }
}
