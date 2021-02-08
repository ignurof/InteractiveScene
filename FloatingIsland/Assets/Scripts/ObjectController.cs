using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    void OnMouseDown()
    {
        if (gameObject.name == "Object 1")
        {
            //transform.position = transform.position + new Vector3(0, 1, 0);
            FunkySize();
        }
        else if (gameObject.name == "Object 2")
        {
            transform.position = transform.position + new Vector3(0, 1, 0);
        }
        else if (gameObject.name == "Object 3")
        {
            transform.position = transform.position + new Vector3(0, 1, 0);
        }
        else if (gameObject.name == "Object 4")
        {
            transform.position = transform.position + new Vector3(0, 1, 0);
        }
        else if (gameObject.name == "Object 5")
        {
            transform.position = transform.position + new Vector3(0, 1, 0);
        }
        else if (gameObject.name == "Object 6")
        {
            transform.position = transform.position + new Vector3(0, 1, 0);
        }
    }

    void FunkySize()
    {
        // Gets the first child object
        transform.GetChild(0).transform.localScale = new Vector3(0.33f, 0.33f, 0.33f);
    }
}
