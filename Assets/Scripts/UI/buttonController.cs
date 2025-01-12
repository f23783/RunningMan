using UnityEngine;

public class buttonController : MonoBehaviour
{
    public GameObject mainMenu, levelMenu, shopMenu, settingsMenu;

    public void PlayButton()
    {
        mainMenu.SetActive(false);
        levelMenu.SetActive(true);
    }
    public void SettingsButton()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    public void ShopButton()
    {
        mainMenu.SetActive(false);
        shopMenu.SetActive(true);
    }

    public void ReturneButton()
    {
        mainMenu.SetActive(true);
        shopMenu.SetActive(false);
        settingsMenu.SetActive(false);
        levelMenu.SetActive(false);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
