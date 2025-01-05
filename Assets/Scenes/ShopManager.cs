using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public int coins;
    public TMP_Text coinUI;
    public ShopItemSO1[] shopItemSO1s;
   // public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
   // public Button[] anyPurchaseBtns;


    void Start()
    {
     for (int i = 0; 1 < shopItemSO1s.Length; i++)
         shopPanelsGO[i].SetActive(true);
        coinUI.text = "Coins: " + coins.ToString();
       LoadPanels();
     //   CheckPurchaseable();
    }
    void Update()
    {

    }
    public void AddCoins()
    {
        coins++;
        coinUI.text = "Coins: " + coins.ToString();
     //   CheckPurchaseable();
    }
    /*
    public void CheckPurchaseable()
    { 
        for (int i = 0; i < shopItemSO1s.Length; i++)
        {
            if (coins >= shopItemSO1s[i].baseCost) //if i have enough money
                myPurchaseBtns[i].interactable = true;
            else
                myPurchaseBtns[i].interactable = false;
        }
    }
    */
    /*
    public void PurchaseItem(int btnNo)
    {
        if (coins >= shopItemsSO1[btnNo].baseCost)
        {
            coins = coins - shopItemSO1[btnNo].baseCost;
            coinUI.text = "Coins: " + coins.ToString();
            CheckPurchaseable();
            //Unlock Item.
        }
    }
    */
    public void LoadPanels()
    {
        for (int i = 0; i < shopItemSO1s.Length; i++)
        {
            shopPanels[i].titleTxt.text = shopItemSO1s[i].title;
            shopPanels[i].descriptionTxt.text = shopItemSO1s[i].description;
            shopPanels[i].costTxt.text = "Coins: " + shopItemSO1s[i].baseCost.ToString();
        }
    }
}