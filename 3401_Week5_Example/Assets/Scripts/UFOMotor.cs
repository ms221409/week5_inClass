using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMotor : MonoBehaviour
{
    Vector3 targetPosition;


    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton (0))
        {
            Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast (cameraRay, out hit))
            {
                targetPosition = new Vector3(hit.point.x, hit.point.y + 5, hit.point.z);
                //transform.position = targetPosition;
            }
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.05f);
    }
}
