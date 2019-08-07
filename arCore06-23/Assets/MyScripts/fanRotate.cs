using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanRotate : MonoBehaviour
{
    public float spinspeed = -1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FanOn()
    {
        transform.Rotate(0, spinspeed * Time.deltaTime, 0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }


}
