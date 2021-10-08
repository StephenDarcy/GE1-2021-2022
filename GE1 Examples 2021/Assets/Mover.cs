using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class Mover : MonoBehaviour
{
    private static StringBuilder message = new StringBuilder();

    public Transform target;

    public float speed = 5;
    public float time = 10;

    public void OnGUI()
    {
        GUI.color = Color.white;
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height), "" + message);
        if (Event.current.type == EventType.Repaint)
        {
            message.Length = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        speed = distance / time;
<<<<<<< HEAD
=======

>>>>>>> master
    }


    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
=======
    
>>>>>>> master
        float distance = Vector3.Distance(target.position, transform.position);
        Vector3 toTarget = target.position - transform.position;
        float distance1 = toTarget.magnitude;

<<<<<<< HEAD
        message.Append("Hello");


        toTarget = Vector3.Normalize(toTarget);
        /*
        if (distance1 > 0.1f)
        {
            transform.position = transform.position + (toTarget * speed * Time.deltaTime);
        }
        */

        /*
        transform.LookAt(target);
        transform.Translate(0, 0, speed * Time.deltaTime); */

        float dot = Vector3.Dot(transform.forward, toTarget);

        float theta = Mathf.Acos(dot) * Mathf.Rad2Deg;
        message.Append("Angle between mover & target: " + theta + "\n");
        Debug.Log(dot > 0 ? "in front" : "behind");
=======
        message.Append("Distance: " + distance + "\n");
        message.Append("Distance1: " + distance1);

        toTarget = Vector3.Normalize(toTarget);
        
        /*
        if (distance1 > 0.1f)
        {        
            transform.position = transform.position + (toTarget * speed * Time.deltaTime);
        }
        message.Append("Time taken: " + Time.timeSinceLevelLoad);
        */

        /*        transform.LookAt(target);
        transform.Translate(0, 0, speed * Time.deltaTime);
        */

        float dot = Vector3.Dot(transform.forward, toTarget);
        float theta = Mathf.Acos(dot) * Mathf.Rad2Deg;
        Debug.Log(theta);
        //message.Append("Angle between mover & target: " + theta);
        Debug.Log((dot > 0) ? " in front " : "behind");
>>>>>>> master
        if (theta < 45)
        {
            Debug.Log("Inside FOV");
        }
        else
        {
            Debug.Log("Outside FOV");
        }

        float angle1 = Vector3.Angle(toTarget, transform.forward);
<<<<<<< HEAD
        float angle3 = Vector3.SignedAngle(toTarget, transform.forward, Vector3.up);

=======

        float angle3 = Vector3.SignedAngle(toTarget, transform.forward, Vector3.up);
>>>>>>> master
    }
}
