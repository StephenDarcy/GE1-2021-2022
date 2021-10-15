using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankDrop : MonoBehaviour
{
    public GameObject tankPrefab;
    int i = 0;
    System.Collections.IEnumerator Drop()
    {
        int maxCount = 5;
        while (true)
        {
            if (i < maxCount)
            {
                GameObject tank = GameObject.Instantiate<GameObject>(tankPrefab);
                tank.transform.position = new Vector3(0, 20, 0);
                tank.AddComponent<Rigidbody>();
                tank.tag = "tank";
                i++;
            }
            yield return new WaitForSeconds(1);
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
