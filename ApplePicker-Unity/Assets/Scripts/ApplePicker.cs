using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{

    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;

    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
     for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppleDestroyed ()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGo in tAppleArray)
        {
            Destroy(tGo);
        } // end foreach

        //Destroy one of the Baskets
        //Get the index of the last Basket in the basketList
        int basketIndex = basketList.Count - 1;
        //Get a reference to that Basket GameObject
        GameObject tbasketGO = basketList[basketIndex];
        //Remove the Basket from the List and destroy the GameObject
        basketList.RemoveAt(basketIndex);
        Destroy(tbasketGO);

        //Restart the game, which doesn't affect HighScore.score
        if (basketList.Count == 0)
        {
            Application.LoadLevel("_Scene-00");  
        }
    }

}
