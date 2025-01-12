using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;
    [SerializeField]private TMP_Text coinText;
    public int coin;

    private void Awake() {
        Instance = this;

        coin = PlayerPrefs.GetInt("Coin");
        coinText.text = "Coin:" + coin.ToString();
    }

    public void GetCoin(int coinValue)
    {
        coin += coinValue;
        coinText.text = "Coin:" + coin.ToString();
        PlayerPrefs.SetInt("Coin", coin);
    }

    public void CheckCoins()
    {
        coinText.text = "Coin:" + coin.ToString();
    }
}
