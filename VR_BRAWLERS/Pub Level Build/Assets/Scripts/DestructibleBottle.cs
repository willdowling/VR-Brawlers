using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class DestructibleBottle : MonoBehaviour
{
    [SerializeField] GameObject broken_s;
    [SerializeField] GameObject broken_l;
    [SerializeField] GameObject broken_w;
    [SerializeField] GameObject broken_weapon;
    [SerializeField] float explodeAmount = 2;

    private Rigidbody rb;
    private VRTK_InteractableObject bottle;
    private bool bKnife = false;

    private Vector3 pos, lastPos, lastVel, cpos;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        bottle = GetComponent<VRTK_InteractableObject>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 3.25f && collision.relativeVelocity.magnitude < 7f && !bottle.IsGrabbed())
        {
            Transform destroyed = Instantiate(broken_s, transform.position, transform.rotation).transform;
            foreach (Transform shard in destroyed) {
                Vector3 centreToThis = (shard.position - destroyed.position).normalized;
                shard.GetComponent<Rigidbody>().AddForce((centreToThis * explodeAmount) + lastVel, ForceMode.Impulse);
            }

            Destroy(gameObject);
        }else if (collision.relativeVelocity.magnitude > 7 && !bottle.IsGrabbed())
        {
            Transform destroyed = Instantiate(broken_l, transform.position, transform.rotation).transform;
            foreach (Transform shard in destroyed) {
                Vector3 centreToThis = (shard.position - destroyed.position).normalized;
                shard.GetComponent<Rigidbody>().AddForce((centreToThis * explodeAmount) + lastVel, ForceMode.Impulse);
            }

            Destroy(gameObject);
        }else if (collision.relativeVelocity.magnitude > 3f && bottle.IsGrabbed() && !bKnife)
        {

            
            bKnife = true;
            Transform destroyed = Instantiate(broken_w, transform.position, transform.rotation).transform;
            foreach (Transform shard in destroyed) {
                Vector3 centreToThis = (shard.position - destroyed.position).normalized;
                shard.GetComponent<Rigidbody>().AddForce((centreToThis * explodeAmount) + lastVel, ForceMode.Impulse);
            }
            Transform t = Instantiate(broken_weapon, bottle.GetGrabbingObject().transform.position, bottle.GetGrabbingObject().transform.rotation).transform;
            bottle.Ungrabbed();
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
        if (bKnife)
        {
            Destroy(gameObject);
        }
    }

    void LateUpdate()
    {
        lastPos = pos;
        lastVel = rb.velocity;
    }
}
