using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpatialSys.UnitySDK;

public class RotateObjectScript : MonoBehaviour
{
    public GameObject rotateObject;
    //public SpatialTriggerEvent triggerRotateLeft;
    public SpatialInteractable triggerRotateLeft;
    //public SpatialTriggerEvent triggerRotateBottom;
    public SpatialInteractable triggerRotateBottom;

    // Start is called before the first frame update
    void Start()
    {
        triggerRotateLeft.onInteractEvent += RotateLeft;
        triggerRotateBottom.onInteractEvent += RotateBottom;
    }

    private void RotateLeft()
    {
        rotateObject.transform.Rotate(0, rotateObject.transform.rotation.y + 90, 0);
        //rotateObject.transform.eulerAngles = new Vector3(
        //    rotateObject.transform.eulerAngles.x,
        //    rotateObject.transform.eulerAngles.y + 90,
        //    rotateObject.transform.eulerAngles.z
        //);
    }

    private void RotateBottom()
    {
        rotateObject.transform.Rotate(rotateObject.transform.rotation.x + 90, 0, 0);
        //rotateObject.transform.eulerAngles = new Vector3(
        //    rotateObject.transform.eulerAngles.x + 90,
        //    rotateObject.transform.eulerAngles.y,
        //    rotateObject.transform.eulerAngles.z
        //);
    }
}
