using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        if (other)
        {
            TriggerMonologue();
            Debug.Log("Trigger2");
            Time.timeScale = 0.0f;
            
        }
    }
    public void TriggerMonologue()
    {
        FindObjectOfType<DialogueManager>().StartMonolugue(dialogue);
    }
    
}
