using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
	static Animator anim;
	void OnTriggerEnter ( Collider col) {
    	
    		anim.SetBool("isAttacked", true);
    }

    void OnTriggerExit ( Collider col) {
    	if(col.gameObject.layer == 11)
    		anim.SetBool("isAttacked",false);
    }
    // Start is called before the first frame update
    void Start()
    {
         anim = transform.root.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
