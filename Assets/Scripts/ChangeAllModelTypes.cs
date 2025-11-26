using UnityEngine;

public class ChangeAllModelTypes : MonoBehaviour
{
    public ChangeModelType[] modelChangers;

    public void SwitchAllModels()
    {
        foreach (var changer in modelChangers)
        {
            changer.SwitchModels();
        }
    }
}
