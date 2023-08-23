 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class karakter_controlu : MonoBehaviour
{
    // Start is called before the first frame update
    public float hiz;
    float horizontal; //bu değer sabittir.
    public bool ates; //ateş animasyonunu temsil eder.
    public Animator animasyoncum; //animator içindekilere erişim sağlamak için kullanır
    void Start()
    {
        animasyoncum = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) //eğer space tuşuna basarsak bastığımız süre boyunca ateş edecek
        {
            ates = true;
        }
        else
        {
            ates = false;
        }
        animasyoncum.SetBool("ateş", ates);
    }
    private void FixedUpdate()
    {
        bool kosuyormuyum = false;
        horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal * hiz* Time.deltaTime, 0, 0);
        if (horizontal != 0)
        {
            kosuyormuyum = true;
        }
        animasyoncum.SetBool("Koşuyormuyum", kosuyormuyum);
        yon_duzeltme();
    }
    void yon_duzeltme()
    {
        if (horizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (horizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
