using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caramel : MonoBehaviour
{

    public float multiplier2 = 3f;
    //public float duration2 = 5f;
    //public GameObject pickupEffect2;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject Caramel = collision.gameObject;
        Rigidbody rb = Caramel.GetComponent<Rigidbody>();
        
       // PlayerMovementAdvanced PlayerMove = collision.GetComponent<PlayerMovementAdvanced>();
       // PlayerMove.walkSpeed /= multiplier2;
        //.sprintSpeed /= multiplier2;



    }


}

