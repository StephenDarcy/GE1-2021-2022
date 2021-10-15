using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickdrop : MonoBehaviour
{
    System.Collections.IEnumerator Drop()
    {
        while (true)
        {
            GameObject block = GameObject.CreatePrimitive(PrimitiveType.Cube);
            block.transform.position = new Vector3(0, 20, 0);
            block.AddComponent<Rigidbody>();
            yield return new WaitForSeconds(1);
            //yield return null; (every frame)
        }
    }

    public void OnEnable()
    {
        StartCoroutine(Drop());
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
