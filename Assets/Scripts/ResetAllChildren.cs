using UnityEngine;

public class ResetAllChildren : MonoBehaviour
{
    private ResetPositions[] childResets;

    void Awake()
    {
        childResets = GetComponentsInChildren<ResetPositions>();
    }

    public void ResetAll()
    {
        foreach (var reset in childResets)
        {
            reset.ResetPosition();
        }
    }
}
