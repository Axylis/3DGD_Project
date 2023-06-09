using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{
    [SerializeField] LayerMask ground;
     Camera cam;
    Vector3 aimLocation;
    // Start is called before the first frame update
    Vector3 yAxisRepositioning;
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Aim();
    }

    private void Aim()
        {
            var (success, position) = GetMousePosition();
            if (success)
            {
                // Calculate the direction
                var direction = (position - transform.position);

                // You might want to delete this line.
                // Ignore the height difference.
                direction.y = 0;

                // Make the transform look in the direction.
                transform.forward = direction;
            }
        }

    private (bool success, Vector3 position) GetMousePosition()
    {
        aimLocation = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        var ray = cam.ScreenPointToRay(aimLocation);

            if (Physics.Raycast(ray, out var hitInfo, Mathf.Infinity, ground))
            {
                // The Raycast hit something, return with the position.
                return (success: true, position: hitInfo.point);
            }
            else
            {
                // The Raycast did not hit anything.
                return (success: false, position: Vector3.zero);
            }
    }
}
