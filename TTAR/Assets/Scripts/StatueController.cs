using System;
using UnityEngine;

public class StatueController : MonoBehaviour
{
    [SerializeField]private string info;
    public Action onStatueDeleted;

    public void OnFocusEntered()
    {
        StatueInfoPanelController.Instance.EnablePanelWithText(info, this);
    }
    
    public void OnFocusExited()
    {
        StatueInfoPanelController.Instance.HidePanel();
    }

    private void OnDestroy()
    {
        onStatueDeleted.Invoke();
    }
}
