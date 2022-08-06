using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareket : MonoBehaviour
{
    public Transform Target;
    public Vector3 offset;
    public float damping;

    private void FixedUpdate()
    {
        if (Target!=null)
        {
            transform.position = Vector3.Lerp(transform.position, Target.position, damping) + offset;
        }
        
       
    }



}
