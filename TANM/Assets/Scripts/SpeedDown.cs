using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDown : MonoBehaviour
{
    public float multiplier2 = 3f;
    public float duration2 = 5f;
    public GameObject pickupEffect2;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            StartCoroutine(Pickup2(other));
        }
    }

    IEnumerator Pickup2(Collider player)
    {
        /*   Instantiate(pickupEffect2, transform.position, transform.rotation);
           //Debug.Log("BOOM!");

           PlayerStats stats = player.GetComponent<PlayerStats>();
           stats.walkSpeed /= multiplier2;
           stats.sprintSpeed /= multiplier2;

           GetComponent<MeshRenderer>().enabled = false;
           GetComponent<Collider>().enabled = false;

           yield return new WaitForSeconds(duration2); //(4);

           stats.sprintSpeed *= multiplier2;
           stats.sprintSpeed *= multiplier2;

           Destroy(gameObject);

   */
        Instantiate(pickupEffect2, transform.position, transform.rotation);

        PlayerMovementAdvanced PlayerMove = player.GetComponent<PlayerMovementAdvanced>();
        PlayerMove.walkSpeed /= multiplier2;
        PlayerMove.sprintSpeed /= multiplier2;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration2); //(4);

        PlayerMove.walkSpeed *= multiplier2;
        PlayerMove.sprintSpeed *= multiplier2;

        Destroy(gameObject);

    }
}
