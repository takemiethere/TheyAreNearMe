/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Force : MonoBehaviour
{

    //public float upForce = 500f;
    public float multiplier = 1.4f;
    public GameObject pickupEffect1;
    public float duration = 4f;
    //public bool FROZEN = false;
    //public bool isControllable = true;
    Rigidbody m_Rigidbody;
    Vector3 m_YAxis;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            StartCoroutine(pickup(other));
        }
        m_Rigidbody = GetComponent<Rigidbody>();
    }


   IEnumerator pickup(Collider player) 
     {
            Instantiate(pickupEffect1, transform.position, transform.rotation);
            
            //player.transform.localPosition *= multiplier /multiplier;
            m_Rigidbody.constraints = RigidbodyConstraints.FreezePosition = ;
            

        //isControllable = false; // disable player controls.

        //FROZEN = true;



        GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;

            yield return new WaitForSeconds(duration);

        //FROZEN = false;
        //isControllable = true;

        =player.transform.localPosition;

        Destroy(gameObject);
     }



}
*/