using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class place_joint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.rotation = gameObject.transform.parent.rotation;
        if (gameObject.tag == "bottle")
        {
            gameObject.transform.position = gameObject.transform.parent.position + gameObject.transform.parent.TransformVector(0, 25.4f, 0);
        }
        else
        {
            gameObject.transform.position = gameObject.transform.parent.position + gameObject.transform.parent.TransformVector(0, 0.674f, 0);
        }
    }
}
