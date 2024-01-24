using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.CollectCoins();
        Destroy(gameObject);

        //if (other.CompareTag("Player"))
        //{
        //    Playerr player = other.GetComponent<Playerr>();
        //    player.CollectCoins();
        //    if (other.gameObject.tag.Equals("Player"))
        //    {
        //        Destroy(other.gameObject);
        //    }
        //}

    }
}

