package com.example.chris.whathappensnext;

import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;

import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.UUID;

public class ActivityCreateStory extends AppCompatActivity {

    private EditText titleEditText;
    private Spinner catSpinner;
    private EditText storyEditText;
    private Button submitBtn;
    FirebaseUser firebaseuser;
    DatabaseReference databaseReference;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_create_story);

        titleEditText = (EditText) findViewById(R.id.titleEditText);
        catSpinner = (Spinner) findViewById(R.id.catList);
        storyEditText = (EditText) findViewById(R.id.storyEditText);
        submitBtn = (Button) findViewById(R.id.submitBtn);

        submitBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                titleEditText = (EditText) findViewById(R.id.titleEditText);
                catSpinner = (Spinner) findViewById(R.id.catList);
                storyEditText = (EditText) findViewById(R.id.storyEditText);


                firebaseuser = FirebaseAuth.getInstance().getCurrentUser();
                String currentuid = firebaseuser.getUid();
                DatabaseReference rootRef = FirebaseDatabase.getInstance().getReference().child("Users").child(currentuid).child("username");

//                String uniqueID = UUID.randomUUID().toString();
//                String storyTitle = titleEditText.getText().toString().trim();
//                String category = "Random";
//                String storyContent = storyEditText.getText().toString().trim();
//                Date currentTime = Calendar.getInstance().getTime();
//                String usersname = firebaseuser.getDisplayName();

                FirebaseUser user = FirebaseAuth.getInstance().getCurrentUser();
                String userUID = FirebaseAuth.getInstance().getCurrentUser().getUid();
                databaseReference = FirebaseDatabase.getInstance().getReference().child("Users").child(userUID);
                databaseReference.addValueEventListener(new ValueEventListener() {
                    @Override
                    public void onDataChange(@NonNull DataSnapshot dataSnapshot) {

                        String usersname = dataSnapshot.child("username").getValue(String.class);
                        String uniqueID = UUID.randomUUID().toString();
                        String storyTitle = titleEditText.getText().toString().trim();
                        String category = "Random";
                        String storyContent = storyEditText.getText().toString().trim();
                        Date date = new Date();
                        DateFormat.getDateTimeInstance(DateFormat.SHORT, DateFormat.MEDIUM).format(date);
                        Story story = new Story(uniqueID, usersname,storyTitle,category,storyContent,date);
                        DatabaseReference storyRef = FirebaseDatabase.getInstance().getReference().child("Stories").child(uniqueID);
                        storyRef.setValue(story);

                    }

                    @Override
                    public void onCancelled(@NonNull DatabaseError databaseError) {

                    }
                });

            }
        });

    }
}

