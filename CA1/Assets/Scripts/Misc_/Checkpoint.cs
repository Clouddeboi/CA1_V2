// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Checkpoint : MonoBehaviour
// {
//     //video followed: https://www.youtube.com/watch?v=VE_bkPrrZdE&ab_channel=RehopeGames
//     PlayerMovement gameController;

//     private void Awake()
//     {
//         gameController = GameObject.FindGameObjectsWithTag("Player").GetComponent<PlayerMovement>();
//     }

//     private void OnTriggerEnter2D(Collider2D collision)
//     {
//         if(collision.CompareTag("Player"))
//         {
//             gameController.UpdateCheckpoint(transform.position);
//         }
//     }

// }
