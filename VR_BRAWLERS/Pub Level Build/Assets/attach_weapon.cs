using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class attach_weapon : MonoBehaviour
{

    private VRTK_InteractableObject brokenW;
    private VRTK_InteractGrab weapon;
    private GameObject grabC;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Controllers")
        {
            Debug.Log("controller");
            grabC = collision.collider.gameObject;
            weapon = grabC.GetComponent<VRTK_InteractGrab>();
            if (grabC.GetComponent<VRTK_ControllerEvents>().gripPressed)
            {
                weapon.GetComponent<VRTK_InteractTouch>().ForceTouch(brokenW.gameObject);
                weapon.AttemptGrab();
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        brokenW = GetComponent<VRTK_InteractableObject>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
