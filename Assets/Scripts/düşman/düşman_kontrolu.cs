using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class düşman_kontrolu : MonoBehaviour
{
    // Start is called before the first frame update
    public float hiz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.position += new Vector3(hiz * Time.deltaTime, 0, 0);
    }
    void yön_degiş()
    {
        
    }
}

