using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleSmooth : MonoBehaviour
{
    public float speed;
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z), step);
    }
}
