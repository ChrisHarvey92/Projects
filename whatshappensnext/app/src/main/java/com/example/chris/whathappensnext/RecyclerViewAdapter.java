package com.example.chris.whathappensnext;

import android.content.Context;
import android.support.annotation.NonNull;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import java.util.List;

public class RecyclerViewAdapter extends RecyclerView.Adapter<RecyclerViewAdapter.MyViewHolder> {

    private Context mContext;
    private List<Story> mdata;

    public RecyclerViewAdapter(Context mContext, List<Story> mdata) {
        this.mContext = mContext;
        this.mdata = mdata;
    }

    @NonNull
    @Override
    public MyViewHolder onCreateViewHolder(@NonNull ViewGroup viewGroup, int i) {

        View view;
        LayoutInflater mInflater = LayoutInflater.from(mContext);
        view = mInflater.inflate(R.layout.card_layout,viewGroup,false);

        return new MyViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull MyViewHolder myViewHolder, int i) {

        myViewHolder.storyTitle.setText(mdata.get(i).getSttitle());
        myViewHolder.storyCategory.setText(mdata.get(i).getStcategory());
        myViewHolder.storyCreatedBy.setText(mdata.get(i).getStusername());
        myViewHolder.storyCreatedAt.setText(mdata.get(i).getDatecreated().toString());

    }

    @Override
    public int getItemCount() {
        return mdata.size();
    }

    public static class MyViewHolder extends RecyclerView.ViewHolder {

        TextView storyTitle;
        TextView storyCategory;
        TextView storyCreatedBy;
        TextView storyCreatedAt;


        public MyViewHolder(@NonNull View itemView) {
            super(itemView);

            storyTitle = (TextView) itemView.findViewById(R.id.titletv);
            storyCategory = (TextView) itemView.findViewById(R.id.categorytv);
            storyCreatedBy = (TextView) itemView.findViewById(R.id.createdbytv);
            storyCreatedAt = (TextView) itemView.findViewById(R.id.datecreatedtv);
        }
    }


}
