using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes { MouseX = 0, MouseY = 1 }
    public RotationAxes axes = RotationAxes.MouseX;
    public float sensitivityX = 8.0f;
    public float sensitivityY = 8.0f;
    public float minimumX = -360.0f;
    public float maximumX = 360.0f;
    public float minY = -60.0f;
    public float maxY = 60.0f;
    private float rotationY = 0.0f;
        
	// Update is called once per frame
	void Update ()
    {
	    if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("MouseX") * sensitivityX, 0);
        }

        else
        {
            rotationY += Input.GetAxis("MouseY") * sensitivityY;
            rotationY = Mathf.Clamp(rotationY, minY, maxY);

            transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
        }
	}
}
