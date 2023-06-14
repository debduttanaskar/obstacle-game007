using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHits : MonoBehaviour
{
     private void OnCollisionEnter(Collision other)
     {

        GetComponent<MeshRenderer>().material.color = Color.red;//cpital c for last and small c for previous
        

    }
}
