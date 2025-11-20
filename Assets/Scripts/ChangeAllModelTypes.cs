using UnityEngine;

public class ChangeAllModelTypes : MonoBehaviour
{
    [SerializeField] private ChangeModelType[] modelChangers;

    public void SwitchAllModels()
    {
        foreach (var changer in modelChangers)
        {
            changer.SwitchModels();
        }
    }
}
