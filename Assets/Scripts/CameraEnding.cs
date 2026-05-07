using UnityEngine;

public class CameraEnding : MonoBehaviour
{
    public GameObject Cameraending;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cameraending.SetActive(false);
    }

    public void ChangeCamera()
    {
        Cameraending.SetActive(true);
    }
}
