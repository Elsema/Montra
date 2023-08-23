using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yerde_mi : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask layer;
    public bool yerde = false;
    public float ziplama_gucu;
    public Rigidbody2D rigid;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.3f, layer);
        if(hit.collider != null)
        {
            yerde = true;
        }
        else
        {
            yerde = false;
        }
        if (Input.GetKeyDown(KeyCode.W) && yerde)  //"w" tuşuna bastıktan sonra tek seferlik zıplamasını sağlar
        {
            rigid.velocity += new Vector2(0, ziplama_gucu);
        }
    }
}
