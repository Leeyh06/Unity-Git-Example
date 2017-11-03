using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        Debug.Log("Hello!");
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, 30f * Time.deltaTime, 0);
        Debug.Log("Rotate");

        transform.Rotate(1f, 30f * Time.deltaTime, 1f);
    }
}