using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if(x != 0 || y != 0)
        {
            move(x, y);
        }
    }

    public void move(float x, float y)
    {
        transform.Translate(new Vector2(x, y).normalized * speed * Time.deltaTime);
    }
}
