using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShowCalloutOnActivate : MonoBehaviour
{
    public GameObject callout;

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
