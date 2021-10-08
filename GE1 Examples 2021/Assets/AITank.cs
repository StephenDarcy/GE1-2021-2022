using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AITank : MonoBehaviour
{

    public float radius = 10;
    public int numWaypoints = 5;
    public int current = 0;
    public List<Vector3> waypoints = new List<Vector3>();
    public float speed = 10;
    public Transform player;

    public void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            // Task 1
            float theta = (Mathf.PI * 2.0f) / ((float)numWaypoints);

            for (int i = 0; i < numWaypoints; i++)
            {
                float angle = theta * i;

                float x = Mathf.Sin(angle) * radius;
                float y = Mathf.Cos(angle) * radius;

                Vector3 pos = new Vector3(x, 0, y);
                pos = transform.TransformPoint(pos);

                Gizmos.color = Color.blue;
                Gizmos.DrawWireSphere(pos, 1);
            }

        }
    }

    // Use this for initialization
    void Awake()
    {
        // Task 2
        float theta = (Mathf.PI * 2.0f) / ((float)numWaypoints);

        for (int i = 0; i < numWaypoints; i++)
        {
            float angle = theta * i;

            float x = Mathf.Sin(angle) * radius;
            float y = Mathf.Cos(angle) * radius;

            Vector3 pos = new Vector3(x, 0, y);

            pos = transform.TransformPoint(pos);

            waypoints.Add(pos);

        }



    }

    // Update is called once per frame
    void Update()
    {
        // Task 3
        // Put code here to move the tank towards the next waypoint
        // When the tank reaches a waypoint you should advance to the next one
        Vector3 distance = waypoints[current] - transform.position;

        if (distance.magnitude < 1)
        {
            current = (current + 1) % waypoints.Count;
        }

        distance.Normalize();
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(distance), Time.deltaTime * 5);
        transform.Translate(distance * speed * Time.deltaTime, Space.World);


        // Task 4
        // Put code here to check if the player is in front of or behine the tank
        // Task 5
        // Put code here to calculate if the player is inside the field of view and in range
        // You can print stuff to the screen using:
        GameManager.Log("Hello from th AI tank");
    }
}
