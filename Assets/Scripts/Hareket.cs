using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Hareket : MonoBehaviour
{
     float speed=2.5f;
    
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed* Time.deltaTime;
        
    }
}
