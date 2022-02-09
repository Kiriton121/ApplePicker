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
    // [Header("Set Dynamically")]
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
        // Get the current screen position of the mouse from Input 
        Vector3 mousePos2D = Input.mousePosition;

        //The Camera's z position sets the how far to push the mouse into 3D
        mousePos2D.z = -Camera.main.transform.position.z;

        //Convert the point from 2D screen space into 3D game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        // Move the x position of this Basket to the x position of the Mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }


    void OnCollisionEnter(Collision coll)
    {
        // find out what hit this basket
        GameObject collideWith = coll.gameObject;
        if (collideWith.tag == "Apple")
        {
            Destroy(collideWith);
        }
        int score = int.Parse(scoreGT.text);
        // Add points for catching the apple
        score += 100;
        // Convert the score back to a string and display it
        scoreGT.text = score.ToString();

        //Track the high score
        if (score > HighScore.score)
        {
            HighScore.score = score;
        }
    }


}
