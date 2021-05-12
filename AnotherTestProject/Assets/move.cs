using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;
    float moveSpeed = 10;
    float lastdir = -1;

    [SerializeField]
    public float dir = 0;



    void Update()
    {
        // Get the mouse delta. This is not in the range -1...1
        float h = horizontalSpeed * Input.GetAxis("Horizontal");
        float v = verticalSpeed * Input.GetAxis("Vertical");

        if(h < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (h > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }


        transform.Translate(new Vector3(h, 0, 0) * moveSpeed * Time.deltaTime);

        transform.vel

    }

    protected void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}