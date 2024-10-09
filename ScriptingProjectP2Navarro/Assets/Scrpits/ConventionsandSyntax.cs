using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsandSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //show the position at my game objec at the start of my gamne, specifically the X value
        Debug.Log(transform.position.x);

    }

    // Update is called once per frame
    void Update()
    {
        //if our game objects y value is below 5 we want to show a message on the consol
        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground");
        }
    }
}
