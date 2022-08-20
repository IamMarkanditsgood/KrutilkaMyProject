using UnityEngine;

public class MoveOfCylinder : MonoBehaviour, IMove
{
    private void FixedUpdate()
    {
        Move();
    }
    public void Move()
    {
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {         
            transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * -DataForLevels.GetDatas.SpeedForRotation, Space.Self);
        }
    }
}
