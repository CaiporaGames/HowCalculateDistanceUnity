using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{   
    public Vector3 vectorA = new Vector3(1, 1, 1);
    public Vector3 vectorB = new Vector3(1, 1, 1);
    

    public float distance = 4;

    [ContextMenu("Start Method")]
    void Start()
    {
        //Using Vector3.SqrMagnitude; x^2 + y^2 + z^2 
        //Debug.Log("Vector3.SqrMagnitude: " + vectorA.sqrMagnitude);

        //Using Vector3.Magnitude();  Mathf.Sqrt(x^2 + y^2 + z^2)
        //Debug.Log("Vector3.magnitude: " + vectorA.magnitude);

        //Using Mathf.Sqrt():  Returns the root of a real number.
        //This is equal to: Mathf.Sqrt(Vector3.SqrMagnitude)
        //Debug.Log("Mathf.Sqrt(): " + Mathf.Sqrt(vectorA.sqrMagnitude));

        //###This is to calculate distance

        //Using Vector3.Distance(); This is the same as vector3.magnitude
       // Debug.Log("Vector3.Distance(): " + Vector3.Distance(vectorA, vectorB));
        //This is the same as above
        //Debug.Log("Vector3.magnitude between VA & VB: " + (vectorA - vectorB).magnitude);

        //We can transform the Vector3.sqrtMagnitude into Vector3.Distance
        //Debug.Log("Vector3.SqrMagnitude as Distance: " + Mathf.Sqrt((vectorA - vectorB).sqrMagnitude));

        //ExampleUsingSqrMagnitude();
       // ExampleUsingDistance();
    }  

    //To know if the object is in range, use this.
    void ExampleUsingSqrMagnitude()
    {
        if ((vectorA - vectorB).sqrMagnitude <= distance * distance)
        {
            Debug.Log("I am using the sqrMagnitude");
        }        
    }

    //For a exact distance use this.
    void ExampleUsingDistance()
    {
        if (Vector3.Distance(vectorA, vectorB) <= distance)
        {
            Debug.Log("I am using the Vector3.Distance()");
        }
    }
}
