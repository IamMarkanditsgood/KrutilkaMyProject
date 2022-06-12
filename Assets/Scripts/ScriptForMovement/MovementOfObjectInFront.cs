using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOfObjectInFront : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * DataForLevels.GetDatas.SpeedForObjects * Time.deltaTime);
    }
}
