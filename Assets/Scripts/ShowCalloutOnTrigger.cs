using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShowCalloutOnActivate : MonoBehaviour
{
    [SerializeField] private GameObject callout;

    private void Awake()
    {
        if (callout != null)
            callout.SetActive(false);
    }

    public void OnActivated(ActivateEventArgs args)
    {
        if (callout != null)
            callout.SetActive(!callout.activeSelf);
    }
}
