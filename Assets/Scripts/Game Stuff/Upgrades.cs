using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public Inventory playerInventory;
    public GameSignal signal;
    public GameObject menuBox;

    public void StartUpgrading()
    {
        menuBox.SetActive(true);
    }

    public void IncreaseAttack()
    {

        playerInventory.numberOfSwords++;
        menuBox.SetActive(false);
    }

    public void IncreaseMove()
    {
        playerInventory.numberOfBoots++;
        menuBox.SetActive(false);
    }

    public void IncreaseDash()
    {
        playerInventory.numberOfDash++;
        menuBox.SetActive(false);
    }

    public void IncreaseArrow()
    {
        playerInventory.numberOfArrows++;
        menuBox.SetActive(false);
    }

    public void IncreaseHealth()
    {
        playerInventory.numberOfHearts++;
        menuBox.SetActive(false);
        signal.Raise();
    }
}
