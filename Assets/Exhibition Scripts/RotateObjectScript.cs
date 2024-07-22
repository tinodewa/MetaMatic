using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpatialSys.UnitySDK;

public class RotateObjectScript : MonoBehaviour
{
    public GameObject rotateObject;
    public SpatialInteractable triggerRotateLeft;
    public SpatialInteractable triggerRotateBottom;
    public SpatialInteractable triggerRotateReset;

    // Start is called before the first frame update
    void Start()
    {
        triggerRotateLeft.onInteractEvent += RotateLeft;
        triggerRotateBottom.onInteractEvent += RotateBottom;
        triggerRotateReset.onInteractEvent += RotateReset;
    }

    private void RotateLeft()
    {
        rotateObject.transform.Rotate(0, rotateObject.transform.rotation.y + 90, 0);
    }

    private void RotateBottom()
    {
        rotateObject.transform.Rotate(rotateObject.transform.rotation.x + 90, 0, 0);
    }
    private void RotateReset()
    {
        rotateObject.transform.localRotation = Quaternion.identity;
    }
}
