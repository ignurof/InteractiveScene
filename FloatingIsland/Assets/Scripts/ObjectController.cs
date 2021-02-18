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
        if (gameObject.CompareTag("Object 1"))
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
        else if (gameObject.CompareTag("Tree 1"))
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
        else if(gameObject.CompareTag("Volcano"))
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
        else if (gameObject.CompareTag("Pond"))
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
