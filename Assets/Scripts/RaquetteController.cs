using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaquetteController : MonoBehaviour
{
    private Rigidbody rb;
    public float vitesse;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float moveVertical = Input.GetAxis("Vertical"); 
        Vector3 mouvement = new Vector3(0.0f, 0.0f,moveVertical); 
        rb.AddForce(mouvement * vitesse); 
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Balle"))
        {

          
        }
    }
}
