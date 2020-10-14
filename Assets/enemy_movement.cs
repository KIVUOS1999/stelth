using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{
    public float rotation_speed = 5f;
    public float dis = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotation_speed * Time.deltaTime);
        RaycastHit2D hit_info = Physics2D.Raycast(transform.position, transform.right, dis);
        if (hit_info.collider != null)
        {
            Debug.DrawLine(transform.position, hit_info.point, Color.red);
            if(hit_info.collider.CompareTag("Player"))
            {
                Destroy(hit_info.collider.gameObject);
            }
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right*dis, Color.green);
        }
    }
}
