using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dragdrop : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{


    public Image skillImage;
    private Vector3 originalPosition;
    public GameObject skillButtonPos;
    string imageName;
 


    public void Awake()
    {
        
        skillImage.GetComponent<Image>();
        skillButtonPos = GameObject.FindGameObjectWithTag("S1");
        

    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        originalPosition = transform.position;
        imageName = skillImage.sprite.name;
        Debug.Log(skillButtonPos);

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        Debug.Log(transform.position);
        if (transform.position == skillButtonPos.transform.position)
        {

            Debug.Log("Nice!!");
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
        transform.position = originalPosition;
        Debug.Log(imageName);
        Debug.Log(skillButtonPos.transform.position);
    }
}
