using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleBottle : MonoBehaviour
{
    public GameObject destroyedVersion;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 3.25 && collision.collider.gameObject.tag != "Controller")
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
