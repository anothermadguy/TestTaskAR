using UnityEngine;

public class StatueController : MonoBehaviour
{
    [SerializeField]private string info;

    public void OnFocusEntered()
    {
        StatueInfoPanelController.Instance.EnablePanelWithText(info);
    }
    
    public void OnFocusExited()
    {
        StatueInfoPanelController.Instance.HidePanel();
    }
}
