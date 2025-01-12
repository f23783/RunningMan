using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    private int coins;
    public ShopItemSO1[] shopItemsSO;
    public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] myPurchaseBtns;

    private bool isPurchased;


    void Start()
    {
        coins = CoinManager.Instance.coin;

        for (int i = 0; i < shopItemsSO.Length - 1; i++)
            shopPanelsGO[i].SetActive(true);

        LoadPanels();
        CheckPurchaseable();
    }
    
    public void CheckPurchaseable()
    { 
        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            if (coins >= shopItemsSO[i].baseCost && !shopPanels[i].isPurchased) //if i have enough money
                myPurchaseBtns[i].interactable = true;
            else
                myPurchaseBtns[i].interactable = false;
        }
    }
    
    
    public void PurchaseItem(int btnNo)
    {
        if (coins >= shopItemsSO[btnNo].baseCost)
        {
            coins = coins - shopItemsSO[btnNo].baseCost;
            CoinManager.Instance.coin = coins;
            CoinManager.Instance.CheckCoins();
            shopPanels[btnNo].isPurchased = true;
            CheckPurchaseable();
            //Unlock Item.
        }
    }
    
    public void LoadPanels()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            shopPanels[i].titleTxt.text = shopItemsSO[i].title;
            shopPanels[i].descriptionTxt.text = shopItemsSO[i].description;
            shopPanels[i].costTxt.text = "Coins: " + shopItemsSO[i].baseCost.ToString();
        }
    }

    
}