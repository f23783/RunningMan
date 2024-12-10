using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomization : MonoBehaviour
{
    [SerializeField] private List<GameObject> heads = new List<GameObject>();
    [SerializeField] private List<GameObject> bodies = new List<GameObject>();
    [SerializeField] private List<GameObject> legs = new List<GameObject>();
    [SerializeField] private List<GameObject> foots = new List<GameObject>();
    [SerializeField] private List<GameObject> items = new List<GameObject>();

    [SerializeField] private int headSkinIndex;
    [SerializeField] private int bodySkinIndex;
    [SerializeField] private int legSkinIndex;
    [SerializeField] private int footSkinIndex;
    [SerializeField] private int itemSkinIndex;
    private void Start()
    {
        GetSkin();
    }
    private void Update()
    {
        
    }
}
