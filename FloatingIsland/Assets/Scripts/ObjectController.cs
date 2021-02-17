using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public GameObject particlePrefab;

    private bool isPlaying;

    void Awake()
    {
        if(particlePrefab != null)
            particlePrefab.SetActive(false);
    }

    void OnMouseDown()
    {
        if (gameObject.name == "Object 1")
        {
            if (!isPlaying)
            {
                particlePrefab.SetActive(true);
                isPlaying = true;
            }
            else
            {
                particlePrefab.SetActive(false);
                isPlaying = false;
            }
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
        else if (gameObject.name == "Island 1" || gameObject.name == "Island 1(Clone)")
        {
            if (!isPlaying)
            {
                particlePrefab.SetActive(true);
                isPlaying = true;
            }
            else
            {
                particlePrefab.SetActive(false);
                isPlaying = false;
            }
        }
        else if(gameObject.name == "Island 2" || gameObject.name == "Island 2(Clone)")
        {
            if (!isPlaying)
            {
                particlePrefab.SetActive(true);
                isPlaying = true;
            }
            else
            {
                particlePrefab.SetActive(false);
                isPlaying = false;
            }
        }
    }

    void FunkySize()
    {
        // Gets the first child object
        transform.GetChild(0).transform.localScale = new Vector3(0.33f, 0.33f, 0.33f);
    }
}
