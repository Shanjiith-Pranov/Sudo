using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public GameObject player;
    public float speed = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.L)){
            player.GetComponent <ConstantForce > ().force = new Vector3(30f, 0f, 0f);
            StartCoroutine(C_SpinObject(new Vector3(0, 0, 90), 2, player));
        } else if(Input.GetKey(KeyCode.J)){
            player.GetComponent <ConstantForce > ().force = new Vector3(-30f, 0f, 0f);
            player.transform.localRotation = Quaternion.Euler(0, 0, -90);
        } else if(Input.GetKey(KeyCode.K)){
            player.GetComponent <ConstantForce > ().force = new Vector3(0f, -30f, 0f);
            player.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        
    }
    public IEnumerator C_SpinObject(Vector3 angles, float duration, GameObject player)
    {
        for (int axis = 0; axis < 3; axis++)
        {
            Quaternion startRot = player.transform.rotation;

            Vector3 angleAxis = Vector3.zero;
            angleAxis[axis] = 2;

            float speed = angles[axis] / duration;
            float deltaAngle = 0;
            while (deltaAngle < angles[axis])
            {
                deltaAngle += speed * Time.deltaTime;
                deltaAngle = Mathf.Min(deltaAngle, angles[axis]);

                player.transform.rotation = startRot * Quaternion.AngleAxis(deltaAngle, angleAxis);

                yield return null;
            }
        }
    }
}
