using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject gudHero;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = (transform.position - gudHero.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = gudHero.transform.position + offset;
    }
}
