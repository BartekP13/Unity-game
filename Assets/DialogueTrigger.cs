using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Transform player;
    public Dialogue dialogue;
    private float distToPlayer;
    public float interactRange = 2f;
    public GameObject DialogueSystem;

    private void Update()
    {
        distToPlayer = Vector2.Distance(transform.position, player.position);
        if (distToPlayer <= interactRange && Input.GetKeyDown(KeyCode.E))
        {
            this.enabled = !this.enabled;
            TriggerDialogue();
        }

     
    }

    public void TriggerDialogue()
    {
        if (DialogueSystem != null)
        {
            bool isActive = DialogueSystem.activeSelf;

            DialogueSystem.SetActive(!isActive);
        }
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}

