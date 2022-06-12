using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveOfCylinder : MonoBehaviour, IMove
{

    private void Update()
    {
        Move();
    }
    public void Move()
    {
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * 5, Space.Self);
        }
    }
}
