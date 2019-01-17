package com.example.chris.whathappensnext;

import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.GridLayoutManager;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.RelativeLayout;
import android.widget.TextView;

import com.firebase.ui.database.FirebaseRecyclerAdapter;
import com.firebase.ui.database.FirebaseRecyclerOptions;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

public class ActivityStories extends AppCompatActivity {

    private RecyclerView recyclerView;
    private DatabaseReference databaseReference;
    private DatabaseReference databaseReferenceCB;
    private Button createStory;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_recycler_view);
        databaseReference = FirebaseDatabase.getInstance().getReference().child("Stories");
        databaseReferenceCB = FirebaseDatabase.getInstance().getReference().child("Stories").child("datecreated").child("time");

        recyclerView = (RecyclerView) findViewById(R.id.recyclerView);

        createStory = (Button) findViewById(R.id.btnCreateStory);

        createStory.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(ActivityStories.this, ActivityCreateStory.class));
            }
        });

    }
}
