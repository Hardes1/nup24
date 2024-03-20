using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NUP23CameraMove : MonoBehaviour {

    private float rSpeed = 3.0f;
    private float mSpeed = 20.0f;
    private float X = 0.0f;
    private float Y = 0.0f;
    float _distance;

    public Transform Target;

    void Start()
    {
        // _distance = Vector3.Distance(Target.position,transform.position);
    }

    void FixedUpdate()
    {

    }

    void Update()
    {
        // Debug.Log(Time.deltaTime);
        // Debug.Log(Time.fixedDeltaTime);
        // Debug.Log(Time.smoothDeltaTime);
        // Move(Time.deltaTime);
    }

    void Move(float dt)
    {
        // transform.position += transform.up*dt;

        // https://docs.unity3d.com/ScriptReference/Vector3.Cross.html
        // transform.position += Vector3.Cross(Vector3.up, Vector3.forward)*dt;
        // For normalized vectors Dot returns 1 if they point in exactly the same direction, -1 if they point in completely opposite directions and zero if the vectors are perpendicular.
        // Debug.Log(Vector3.Dot(Vector3.up, Vector3.forward));
        // transform.position += Vector3.up*dt;

        // Quaternion target = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y,transform.rotation.eulerAngles.z+dt);

        // Dampen towards the target rotation
        // transform.rotation = target;

        // Vector3 direction = (Target.position - transform.position).normalized;

        // float d = Vector3.Distance(Target.position, transform.position);


        // transform.position += direction*dt;
        // transform.position += Vector3.up*dt;

        // transform.Rotate(0, 0, 2 * dt);

        // X += Input.GetAxis("Mouse X") * rSpeed;
        // Y += Input.GetAxis("Mouse Y") * rSpeed;


        // transform.localRotation = Quaternion.AngleAxis(X, Vector3.up);
        // transform.localRotation *= Quaternion.AngleAxis(Y, Vector3.left);


        // transform.position += transform.forward * mSpeed * Input.GetAxis("Vertical")*dt;
        // transform.position += transform.right * mSpeed * Input.GetAxis("Horizontal")*dt;
    }

        //     a.position += Vector3.up*Time.fixedDeltaTime;
        // b.position += Vector3.up*Time.smoothDeltaTime;
        // c.position += Vector3.up*Time.deltaTime;


        // e.position = (a.position+b.position+c.position)/3;
}
