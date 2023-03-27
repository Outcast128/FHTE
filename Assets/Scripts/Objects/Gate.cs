using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gate : Interactable
{
    public bool isOpen;
    public Inventory playerInventory;
    public Upgrades menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            if (playerInventory.numberOfKeys > 0)
            {
                playerInventory.numberOfKeys--;
                this.gameObject.SetActive(false);
                isOpen = true;

                menu.StartUpgrading();

            }
            else
            {
                return;
            }
        }
    }
}
