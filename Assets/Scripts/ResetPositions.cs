using UnityEngine;

public class ResetPositions : MonoBehaviour
{
    private Vector3 startingPosition;
    private Quaternion startingRotation;

    void Awake()
    {
        startingPosition = transform.position;
        startingRotation = transform.rotation;
    }

    public void ResetPosition()
    {
        transform.position = startingPosition;
        transform.rotation = startingRotation;
    }
}
