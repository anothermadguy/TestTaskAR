using System;
using TMPro;
using UnityEngine;

public class StatueInfoPanelController : MonoBehaviour
{
    public static StatueInfoPanelController Instance;

    [SerializeField]private TextMeshProUGUI infoText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else Destroy(this);

        gameObject.SetActive(false);
    }

    public void EnablePanelWithText(string text)
    {
        infoText.text = text;
        gameObject.SetActive(true);
    }
    
    public void HidePanel()
    {
        gameObject.SetActive(false);
    }
}
