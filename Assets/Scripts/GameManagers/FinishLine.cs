using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    public int coinValue;
    public int level;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {
            CoinManager.Instance.GetCoin(coinValue);
            LevelManager.Instance.UnlockLevel(level + 1);
            LevelManager.Instance.SaveLevel(level + 1);
            SceneManager.LoadScene("mainmenu");
        }
    }
}
