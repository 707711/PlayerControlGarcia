using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPropeller : MonoBehaviour
{
    public Vector3 RoatateAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RoatateAmount * Time.deltaTime);
    }
}
