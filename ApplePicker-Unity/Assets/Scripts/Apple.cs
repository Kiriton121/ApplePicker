using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the y position is less than the bottom y
        if (transform .position.y < bottomY)
        {
            Destroy(this.gameObject); // Destroy game object 
            GameObject gm = GameObject .Find ()
            ApplePicker apScript = GameManager.GetComponent<ApplePicker>();
            apScript.AppleDestroyed();
        } // end if (transform.position.y < bottomY)
    }
}
