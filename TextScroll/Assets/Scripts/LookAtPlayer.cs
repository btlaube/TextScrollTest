using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{

    public GameObject target;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target.transform.position.x < transform.position.x) {
            sr.flipX = false;
        }
        else {
            sr.flipX = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("touching me");
        //transform.GetComponent<DialogueTrigger>().TriggerDialogue();\
        transform.GetChild(0).gameObject.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other) {
        transform.GetChild(0).gameObject.SetActive(false);
    }

}
