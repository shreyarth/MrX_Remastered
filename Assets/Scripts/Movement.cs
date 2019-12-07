using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().flipX = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0f)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            transform.Translate(0.5f, 0f, 0f);
        }
        else if(Input.GetAxis("Horizontal") < 0f)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            transform.Translate(-0.5f, 0f, 0f);
        }

        if (Input.GetAxis("Vertical") > 0f)
        {
            transform.Translate(0f, 0f, 0.5f);
        }
        else if (Input.GetAxis("Vertical") < 0f)
        {
            transform.Translate(0f, 0f, -0.5f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0f, 0.5f, 0f);
        }
    }
}
