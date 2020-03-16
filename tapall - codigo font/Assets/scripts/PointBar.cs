using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBar : MonoBehaviour
{
    public float velocity;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0f, velocity * Time.deltaTime));
    }
}
