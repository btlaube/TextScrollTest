using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkScript : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("x")) {
            transform.GetComponent<DialogueTrigger>().TriggerDialogue();
            gameObject.SetActive(false);
        }
    }
}
