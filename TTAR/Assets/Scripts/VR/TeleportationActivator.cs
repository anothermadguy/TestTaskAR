using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class TeleportationActivator : MonoBehaviour
{
    [SerializeField] private XRRayInteractor teleportInteractor;
    [SerializeField] private InputActionProperty teleportActivationAction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        teleportInteractor.gameObject.SetActive(false);

        teleportActivationAction.action.performed += ActivationActionPerformed;
    }

    public void ActivationActionPerformed(InputAction.CallbackContext obj)
    {
        teleportInteractor.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (teleportActivationAction.action.WasPerformedThisFrame())
            teleportInteractor.gameObject.SetActive(false);
    }
}
