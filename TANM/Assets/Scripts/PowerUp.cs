using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float multiplier = 3f;
    public float duration = 2.5f;

    public GameObject pickupEffect;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            StartCoroutine(Pickup(other));
            //Pickup(other);
            /*SpeedUp(other);*/
        }
    }

    IEnumerator Pickup(Collider player)
    //void Pickup(Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        //Debug.Log("BOOM!");

        player.transform.localScale *= multiplier;

        //PlayerStats stats = player.GetComponent<PlayerStats>();
        //stats.health *= multiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration); //(10);

        player.transform.localScale /= multiplier;
        //stats.health /= multiplier;

        Destroy(gameObject);
    }
}