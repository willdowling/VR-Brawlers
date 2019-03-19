using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleBottle : MonoBehaviour
{
    [SerializeField] GameObject destroyedVersion;
    [SerializeField] float explodeAmount = 5;

    private Rigidbody rb;

    private Vector3 pos, lastPos, lastVel;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(pos + ", " + lastPos);
        if (collision.relativeVelocity.magnitude > 3.25f && collision.collider.gameObject.tag != "Controller")
        {
            //Vector3 bottleVel = rb.velocity;
            Debug.Log("Bottle Vel: " + lastVel);

            Transform destroyed = Instantiate(destroyedVersion, transform.position, transform.rotation).transform;
            foreach (Transform shard in destroyed) {
                Vector3 centreToThis = (shard.position - destroyed.position).normalized;
                shard.GetComponent<Rigidbody>().AddForce((centreToThis * explodeAmount) + lastVel, ForceMode.Impulse);
            }

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
        pos = transform.position;
    }

    void LateUpdate()
    {
        lastPos = pos;
        lastVel = rb.velocity;
    }
}
