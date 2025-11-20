using UnityEngine;

public class ChangeModelType : MonoBehaviour
{
    public GameObject arcadeModel;
    public GameObject anatomicalModel;

    private void Awake()
    {
        if (arcadeModel != null)
            arcadeModel.SetActive(true);
        if (anatomicalModel != null)
            anatomicalModel.SetActive(false);
    }

    public void SwitchModels()
    {
        if (arcadeModel != null && anatomicalModel != null)
        {
            bool isModelAActive = arcadeModel.activeSelf;
            arcadeModel.SetActive(!isModelAActive);
            anatomicalModel.SetActive(isModelAActive);
        }
    }
}
