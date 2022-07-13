using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    Rigidbody rb;
    System.Random r;
    float t=0;
    // Start is called before the first frame update
    void Start()
    {
        //rb =gameObject.AddComponent<Rigidbody>();
        //rb.isKinematic = true;
        r = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        t+=Time.deltaTime;
        var u = r.Next(-30, 31);
        transform.position=new Vector3(0, u* Time.deltaTime*Mathf.Sin(t)*10, 0);
    }
}
