using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class dragSkills : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    Vector2 originalPos;
    public bool isDragging = false;
    public List<string> ActiveskillImages = new List<string>();
    public Image thisComponent;



    

    public void OnBeginDrag(PointerEventData eventData)
    {
        var getImage = this.GetComponent<Image>().sprite.name;
        ActiveskillImages.Add(getImage);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        originalPos = transform.position;
        isDragging = true;

        
    }

    public void OnDrag(PointerEventData eventData)
    {

        transform.position = Input.mousePosition;
        GetComponent<CanvasGroup>().blocksRaycasts = false;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        transform.position = originalPos;
        isDragging = false;
        ActiveskillImages.Clear();
        //StartCoroutine(waiting());

    }
/*
    IEnumerator waiting()
    {
        yield return new WaitForSeconds(3);
        ActiveskillImages.Clear();

    }
    */
}
