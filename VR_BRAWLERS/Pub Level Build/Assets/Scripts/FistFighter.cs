using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColliderState
{

    Closed,

    Open,

    Colliding

}
public class FistFighter : MonoBehaviour
{
    public LayerMask mask;

    public float radius = 0.1f;

    public Color inactiveColor;

    public Color collisionOpenColor;

    public Color collidingColor;

    private ColliderState _state;

    public Collider attackHitbox;

    

    
    private void CheckGizmoColor()
    { 
        switch (_state)
        {

            case ColliderState.Closed:

                Gizmos.color = inactiveColor;

                break;

            case ColliderState.Open:

                Gizmos.color = collisionOpenColor;

                break;

            case ColliderState.Colliding:

                Gizmos.color = collidingColor;

                break;

        }

    }
    public void DetectAttack()
    {
        Collider[] colliders = Physics.OverlapSphere(attackHitbox.transform.position, radius, mask);
        
        if (colliders.Length > 0)
        {
         
            foreach (Collider c in colliders)
            { 
                bool isOk = true;

                foreach (Collider p in transform.root.GetComponentsInChildren<Collider>())
                    if (c == p) isOk = false;
                if(isOk)
                
                Debug.Log(c.name);
                // We should do something with the colliders
            }
        }


    }
        private void OnDrawGizmos()
    {
        //Gizmos.color = Color.red;
        CheckGizmoColor();

        Gizmos.matrix = Matrix4x4.TRS(attackHitbox.transform.position, attackHitbox.transform.rotation, attackHitbox.transform.localScale);

       Gizmos.DrawSphere(Vector3.zero, radius); 

    }

    // Start is called before the first frame update
    void Start()
    {	
       
    }
    // Update is called once per frame
    void Update()
    {  
        //if (_state == ColliderState.Closed) {// return; }
        DetectAttack();
        // _state = ColliderState.Open;
    }
}
