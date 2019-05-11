using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dropHandler : MonoBehaviour, IDropHandler
{

    public Image skillButton;

    private void Awake()
    {
       var droppedSkill = skillButton.GetComponent<Image>();
    }


    public void OnDrop(PointerEventData eventData)
    {
        List<GameObject> hoveredList = eventData.hovered;
        foreach (var GO in hoveredList)
        {
            Debug.Log("Hovering over: " + GO.name);
        }
    }




}
