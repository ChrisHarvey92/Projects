using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class accessData : MonoBehaviour
{

    public dragSkills dragging;
    public dragSkills dragging2;
    public dragSkills dragging3;
    public dragSkills dragging4;
    public dragSkills dragging5;
    public dragSkills dragging6;
    public dragSkills dragging7;
    public dragSkills dragging8;

    public List<string> skills = new List<string>();

    public string getSkill;

    // Update is called once per frame
    void Update()
    {
        if (dragging.isDragging == true)
        {
            getSkill = dragging.ActiveskillImages[0];
            skills.Add(getSkill);
            //Debug.Log(getSkill);
        }

        if (dragging2.isDragging == true)
        {
            getSkill = dragging2.ActiveskillImages[0];
            skills.Add(getSkill);
            //Debug.Log(getSkill);
        }

        if (dragging3.isDragging == true)
        {
            getSkill = dragging3.ActiveskillImages[0];
            skills.Add(getSkill);
            //Debug.Log(getSkill);
        }

        if (dragging4.isDragging == true)
        {
            getSkill = dragging4.ActiveskillImages[0];
            skills.Add(getSkill);
            //Debug.Log(getSkill);
        }

        if (dragging5.isDragging == true)
        {
            getSkill = dragging5.ActiveskillImages[0];
            skills.Add(getSkill);
            //Debug.Log(getSkill);
        }

        if (dragging6.isDragging == true)
        {
            getSkill = dragging6.ActiveskillImages[0];
            skills.Add(getSkill);
            //Debug.Log(getSkill);
        }

        if (dragging7.isDragging == true)
        {
            getSkill = dragging7.ActiveskillImages[0];
            skills.Add(getSkill);
            //Debug.Log(getSkill);
        }

        if (dragging8.isDragging == true)
        {
            getSkill = dragging8.ActiveskillImages[0];
            skills.Add(getSkill);
            //Debug.Log(getSkill);
        }
    }
}

