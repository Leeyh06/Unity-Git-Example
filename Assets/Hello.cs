using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        Debug.Log("Hello!");
        Debug.Log("Hello!");
    }

    // Update is called once per frame
    private void Update()
    {
<<<<<<< HEAD
        transform.Rotate(0, 30f * Time.deltaTime, 0);
        Debug.Log("Rotate");

=======
>>>>>>> c3a6d350012b4c191407fdd4743edf605d0dd513
        transform.Rotate(1f, 30f * Time.deltaTime, 1f);
    }
}