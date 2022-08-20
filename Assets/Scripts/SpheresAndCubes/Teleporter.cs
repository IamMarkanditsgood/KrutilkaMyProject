using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private List<Transform> _startPositions;
    private float _timer;
    private LayerMask Mask = DataForLevels.GetDatas.LayerForTeleportCheck;
    private void Start()
    {
        if (gameObject.layer == LayerMask.NameToLayer("Cube"))
        {
            _startPositions = DataForLevels.GetDatas.StartPositionForCubes;
        }
        else if (gameObject.layer == LayerMask.NameToLayer("Sphere"))
        {
            _startPositions = DataForLevels.GetDatas.StartPositionForSpheres;
        }
    }
    private void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        float sizeOfLine = DataForLevels.GetDatas.LengthOfRaycast;
        Debug.DrawRay(transform.position, transform.forward * sizeOfLine, Color.yellow);
        
        if (!Physics.Raycast(ray, out hit, sizeOfLine, Mask.value))
        {
            _timer += Time.deltaTime;
            if (_timer >= DataForLevels.GetDatas.TimeForChangingPosition - 0.2f)
            {
                Instantiate(DataForLevels.GetDatas.TeleportEffect, transform.position, Quaternion.identity);
            }
            if (_timer >= DataForLevels.GetDatas.TimeForChangingPosition)
            {

                int RandomPositionForChanging = Random.Range(0, _startPositions.Count);
                transform.position = new Vector3(_startPositions[RandomPositionForChanging].position.x, _startPositions[RandomPositionForChanging].position.y, transform.position.z);
                _timer = 0;
            }
        }
    }
}
