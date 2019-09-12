using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int hitOrMiss = 1; //0 for a miss, 1 for a hit
    public Sprite[] impactIcons;
    public Button[] spacesAvailable;

    // Start is called before the first frame update
    void Start()
    {
        Setup();
    }

    void Setup()
    {
        for(int i = 0; i < spacesAvailable.Length; i++)
        {
            spacesAvailable[i].interactable = true;
            spacesAvailable[i].GetComponent<Image>().sprite = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BattleshipSpaces(int num)
    {
        spacesAvailable[num].image.sprite = impactIcons[hitOrMiss];
        if(hitOrMiss == 0)
        {
            hitOrMiss = 1;
        }
        else
        {
            hitOrMiss = 0;
        }
        spacesAvailable[num].interactable = false;
    }
}
