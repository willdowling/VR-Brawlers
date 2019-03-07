using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Collider[] colliders = Physics.OverlapBox(position, boxSize, rotation, mask);

if (colliders.Length > 0) {
    Debug.Log("We hit something");
}
*/


public enum ColliderState
{

    Closed,

    Open,

    Colliding

}
public class hitBoxScript : MonoBehaviour
{
    public LayerMask mask;

    public bool useSphere = false;

    public Vector3 hitboxSize = Vector3.one;

    public float radius = 0.5f;

    public Color inactiveColor;

    public Color collisionOpenColor;

    public Color collidingColor;

    private ColliderState _state;
    private float sphereSize;

    private void checkGizmoColor()
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
    private void OnDrawGizmos()
    {
        //Gizmos.color = Color.red;
        checkGizmoColor();

        Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, transform.localScale);

       Gizmos.DrawSphere(Vector3.zero, sphereSize); // Because size is halfExtents

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (_state == ColliderState.Closed) { return; }

        Collider[] colliders = Physics.OverlapSphere(transform.position, sphereSize, mask);


        if (colliders.Length > 0)
        {

            _state = ColliderState.Colliding;
           
             Debug.Log("We hit something");
            
            // We should do something with the colliders

        }
        else
        {

            _state = ColliderState.Open;

        }

    }
}
