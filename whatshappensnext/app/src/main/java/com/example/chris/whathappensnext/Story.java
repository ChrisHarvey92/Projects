package com.example.chris.whathappensnext;

import java.util.Date;

public class Story {


    String storyid, stusername, sttitle, stcategory, story;
    Date datecreated;

    public String getStoryid() {
        return storyid;
    }

    public void setStoryid(String storyid) {
        this.storyid = storyid;
    }

    public String getStusername() {
        return stusername;
    }

    public void setStusername(String stusername) {
        this.stusername = stusername;
    }

    public String getSttitle() {
        return sttitle;
    }

    public void setSttitle(String sttitle) {
        this.sttitle = sttitle;
    }

    public String getStcategory() {
        return stcategory;
    }

    public void setStcategory(String stcategory) {
        this.stcategory = stcategory;
    }

    public String getStory() {
        return story;
    }

    public void setStory(String story) {
        this.story = story;
    }

    public Date getDatecreated() {
        return datecreated;
    }

    public void setDatecreated(Date datecreated) {
        this.datecreated = datecreated;
    }

    public Story(String storyid, String stusername, String sttitle, String stcategory, String story, Date datecreated) {
        this.storyid = storyid;
        this.stusername = stusername;
        this.sttitle = sttitle;
        this.stcategory = stcategory;
        this.story = story;
        this.datecreated = datecreated;
    }

    public Story () {

    }
}

