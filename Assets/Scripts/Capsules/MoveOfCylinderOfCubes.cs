using UnityEngine;

public class MoveOfCylinderOfCubes : MonoBehaviour,IMove
{
    void FixedUpdate()
    {
        Move();
    }
    public void Move()
    {
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * DataForLevels.GetDatas.SpeedForRotation, Space.Self);
        }
    }
}
