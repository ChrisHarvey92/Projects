using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class hotbarOnDrop : MonoBehaviour, IDropHandler
{
    public accessData accessdata;
    private Image icon;


    


    void Update()
    {
       
    }



    public void OnDrop(PointerEventData eventData)
    {
        var getIt = accessdata.skills[0];
        //Debug.Log(getIt);
        accessdata.skills.Clear();
        var getIcon = this.GetComponent<Image>();

        if(getIt == "firebolt")
        {
           getIcon.sprite = Resources.Load<Sprite>("Icons/firebolt");
        }

        if(getIt == "voidburst")
        {
            getIcon.sprite = Resources.Load<Sprite>("Icons/voidburst");
        }

        if (getIt == "earthblast")
        {
            getIcon.sprite = Resources.Load<Sprite>("Icons/earthblast");
        }

        if (getIt == "frostspray")
        {
            getIcon.sprite = Resources.Load<Sprite>("Icons/frostspray");
        }

        if (getIt == "lightshield")
        {
            getIcon.sprite = Resources.Load<Sprite>("Icons/lightshield");
        }

        if (getIt == "arcanewall")
        {
            getIcon.sprite = Resources.Load<Sprite>("Icons/arcanewall");
        }

        if (getIt == "speedaura")
        {
            getIcon.sprite = Resources.Load<Sprite>("Icons/speedaura");
        }

        if (getIt == "unstableburst")
        {
            getIcon.sprite = Resources.Load<Sprite>("Icons/unstableburst");
        }

    }

}
