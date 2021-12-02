using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnHandler : MonoBehaviour
{
    //SerializeField allows private to be used by other scripts
    //[SerializeField] private Transform player;
    public Transform player;
    public Transform respawnPoint;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}
