using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTeleport : MonoBehaviour
{
    //tutorial followed Here: https://www.youtube.com/watch?v=0JXVT28KCIg&t=3s

    //variables
    private GameObject currentTeleporter;
    AudioManager AudioManager;

    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Fire2"))//If button E is press or Y on controller (Im using Xbox controls as reference)
        {
            AudioManager.PlaySFX(AudioManager.Teleporter);
            if(currentTeleporter != null)//checks if current teleporter is not null
            {
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;//changes poosition to matching teleporter
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)//enter teleporter
    {
        if(collision.CompareTag("Teleporter"))//checks if tag collided with is teleporter
        {
            currentTeleporter = collision.gameObject;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)//exit teleporter
    {
         if(collision.CompareTag("Teleporter"))
        {
            currentTeleporter = null;
        }

    }
}
