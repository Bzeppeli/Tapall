using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject plataform;

    float time;
    public float minTime;
    public float maxTime;
    float timeTotal;

    // Start is called before the first frame update
    void Start()
    {
        timeTotal = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        if(time >= timeTotal){
            Instantiate(plataform, transform.position, transform.rotation);
            timeTotal = Random.Range(minTime, maxTime);
            time = 0f;
        }

    }
}
