/****
 * Created by: Zhiyong Lu
 * Date Created: Jan 31, 2022
 * 
 * Last Edited by: Zhiyong Lu
 * Last Edited: Jan 31, 2022
 * 
 * Description: Controls the movement of the apple tree
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    /****VARIABLES****/
    [Header ("SET IN INSPECTOR")]
    public float speed = 1f; // tree speed
    public float leftAndRightEdge = 10f; // distance where the tree turns around
    public GameObject applePrefab; // prefab for instantiating apples
    public float secondsBetweenAppleDrops = 1f; // time between apple drops
    public float chanceToChangeDirections = 0.1f; // chance that the tree will change directions


        // Start is called before the first frame update
    void Start()
    {
        // Dropping apples every second
        InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
    }
    void Update()
    {
        // Basic Movement
        Vector3 pos = transform.position; // record the current position
        pos.x += speed * Time.deltaTime; // add speed to x position
        transform.position = pos; //add the position value

        //Change Direction
        if(pos .x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // set speed to positive
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // set speed to negative value
        }// end Chnage Directions

    }// end Update

    // FixedUpdate is called on fixed intervals(50 times per second)
    private void FixedUpdate()
    {
        // Test chance of direction change
        if (Random .value < chanceToChangeDirections)
        {
            speed *= -1; // change directions
        }
    }// end FixedUpdate()
}
