using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balleController : MonoBehaviour
{

    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        Vector3 mouvement = new Vector3(moveHorizontal, 0.0f, 0.0f); 
        //transform.localScale = new Vector3(direction, 1, 1);
    }

}

