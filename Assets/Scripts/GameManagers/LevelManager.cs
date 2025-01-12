using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Level
{
    public int levelID;
    public bool isLocked = true;
}
public class LevelManager : MonoBehaviour
{
    [SerializeField]private int temp;
    public static LevelManager Instance;
    [SerializeField] private List<Level> levels = new List<Level>();
    private void Awake()
    {
        Instance = this;
        temp = PlayerPrefs.GetInt("Level");
        for (int i = 1; i <= temp; i++)
        {
            UnlockLevel(i);
        }
    } 
    public void UnlockLevel(int levelID)
    {
        Level tempLevel = levels.Find(level => level.levelID == levelID);
        if (tempLevel != null)
        { 
            tempLevel.isLocked = false;
        }
    }
    public bool IsLevelLocked(int levelID)
    {
        Level tempLevel = levels.Find(level => level.levelID == levelID);
        if (tempLevel != null)
        {
            return tempLevel.isLocked;
        }
        return false;
    }
    public void SaveLevel(int levelID)
    {
        PlayerPrefs.SetInt("Level" ,levelID);
    }
}
