using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int loops = 10;
    public GameObject prefab;
    void Start()
    {
        int num = 10;
        float radius = 3;
        float theta = (2.0f * Mathf.PI) / (float)num;
        for (int i = 0; i < num; i++)
        {
            float angle = theta * i;
            float x = Mathf.Sin(angle) * radius * 1.1f;
            float y = Mathf.Cos(angle) * radius * 1.1f;
            GameObject go = GameObject.Instantiate(< GameObject > (prefab));
            go.transform.position = transform.Transform
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
