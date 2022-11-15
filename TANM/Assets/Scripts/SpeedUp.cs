using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public float multiplier1 = 3f;
    public float duration1 = 1.50f;
    public GameObject pickupEffect1;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            StartCoroutine(Pickup1(other));
        }
    }

    IEnumerator Pickup1(Collider player)
    {
        Instantiate(pickupEffect1, transform.position, transform.rotation);

        PlayerMovementAdvanced PlayerMove = player.GetComponent<PlayerMovementAdvanced>();
        PlayerMove.walkSpeed *= multiplier1;
        PlayerMove.sprintSpeed *= multiplier1;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration1); //(4);

        PlayerMove.walkSpeed /= multiplier1;
        PlayerMove.sprintSpeed /= multiplier1;

        Destroy(gameObject);

    }
}
