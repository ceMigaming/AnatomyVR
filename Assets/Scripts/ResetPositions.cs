using UnityEngine;

public class ResetPositions : MonoBehaviour
{
    private Vector3 startingPosition;
    private Quaternion startingRotation;
    public bool awakeWasCalled = false;
    void Awake()
    {
        startingPosition = transform.position;
        startingRotation = transform.rotation;
        awakeWasCalled = true;
    }

    public void ResetPosition()
    {
        transform.position = startingPosition;
        transform.rotation = startingRotation;
    }
}
