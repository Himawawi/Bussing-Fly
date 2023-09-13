using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The speed in which the obstacles will move towards the left direction.
public class Obstacle_Movement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
