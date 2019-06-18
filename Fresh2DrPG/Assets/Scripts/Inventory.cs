using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public static Inventory instance;

    public Item[] itemList = new Item[20];
    public InventorySlot[] inventorySlots = new InventorySlot[20];
    public Canvas inventoryCanvas;
    private Canvas skillCanvas;
    private GameObject skillCanvasGO;
    private Canvas skillmenuCanvas;
    private GameObject SkillMenuGO;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        UpdateSlotUI();
        inventoryCanvas.enabled = false;
        skillCanvasGO = GameObject.FindGameObjectWithTag("SkillPanel");
        skillCanvas = skillCanvasGO.GetComponent<Canvas>();
        SkillMenuGO = GameObject.FindGameObjectWithTag("SkillMenu");
        skillmenuCanvas = SkillMenuGO.GetComponent<Canvas>();
        skillmenuCanvas.enabled = false;
    }

    private bool add(Item item)
    {
        for (int i = 0; i < itemList.Length; i++)
        {
            if (itemList[i] == null)
            {
                itemList[i] = item;
                return true;
            } 
        }
        return false;
    }

    public void UpdateSlotUI()
    {
        for(int i = 0; i < inventorySlots.Length; i++)
        {
            inventorySlots[i].UpdateSlot();
        }
    }

    public void addItem(Item item)
    {
        bool hasAdded = add(item);
            if(hasAdded)
            {
            UpdateSlotUI();
            }
        }

    void Update()
    {
        if (inventoryCanvas.enabled == false)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                inventoryCanvas.enabled = true;
                skillCanvas.enabled = false;
            }
        } else
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                inventoryCanvas.enabled = false;
                skillCanvas.enabled = true;
            }
        }

        if(skillmenuCanvas.enabled == false)
        {
            if(Input.GetKeyDown(KeyCode.O))
            {
                skillmenuCanvas.enabled = true;
            }
        } else
        {
            if(Input.GetKeyDown(KeyCode.O))
            {
                skillmenuCanvas.enabled = false;
            }
        }

        if(inventoryCanvas.enabled == true)
        {
            skillmenuCanvas.enabled = false;
        }

        if(skillmenuCanvas.enabled == true)
        {
            inventoryCanvas.enabled = false;
        }
    }
}

