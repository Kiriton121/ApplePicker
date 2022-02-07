/****
 * Created by: Zhiyong Lu
 * Date Created: Jan 31, 2022
 * 
 * Last Edited by: Zhiyong Lu
 * Last Edited: Feb 7, 2022
 * 
 * Description: Controls the movement of the basket
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;
  


        // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter"); // score game object
        scoreGT = scoreGO.GetComponent<Text>(); //the text component of the score GO
        scoreGT.text = "0"; //set the text property
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /****
 * check what the basket hit
     GameObject collideWith = coll.gameObject;
     if (collideWith.tag == "Apple")
     {
    Destroy (collideWidth);

 * 
 */

}
