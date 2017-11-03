using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
        transform.Translate(1f * Time.deltaTime, 0f, 0f);
    }
}