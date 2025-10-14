using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors; // For XRNearFarInteractor
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit; // For XRBaseInteractable

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
