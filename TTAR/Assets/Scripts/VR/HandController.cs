using UnityEngine;
using UnityEngine.InputSystem;

public class HandController : MonoBehaviour
{
    [SerializeField]public InputActionProperty triggerValue;
    [SerializeField]public InputActionProperty gripValue;

    [SerializeField]public Animator animator;

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Trigger", triggerValue.action.ReadValue<float>());
        animator.SetFloat("Grip", gripValue.action.ReadValue<float>());
    }
}
