using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesuareDistance : MonoBehaviour
{

    public Transform transformA;
    public Transform transformB;

    public float maxDistance = 5;
   
    // Update is called once per frame
    void Update()
    {
        ExampleUsingSqrMagnitude();
        ExampleUsingDistance();
    }

    //To know if the object is in range, use this.
    void ExampleUsingSqrMagnitude()
    {
        transformA.GetComponent<Renderer>().material.SetColor("_Color", Color.red);

        if ((transformA.position - transformB.position).sqrMagnitude <= maxDistance * maxDistance)
        {
            transformA.GetComponent<Renderer>().material.SetColor("_Color", Color.green);            
            Debug.Log("I am using the sqrMagnitude");
        }
    }

    //For a exact distance use this.
    void ExampleUsingDistance()
    {
        transformA.GetComponent<Renderer>().material.SetColor("_Color", Color.red);

        if (Vector3.Distance(transformA.position, transformB.position) <= maxDistance)
        {
            transformA.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            Debug.Log("I am using the Vector3.Distance()");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, maxDistance);
    }
}
