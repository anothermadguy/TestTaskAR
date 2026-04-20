using System;
using TMPro;
using UnityEngine;

public class TargetPlatformController : MonoBehaviour
{
    private int points = 0;

    public TextMeshProUGUI counter;
    
    private void OnTriggerEnter(Collider other)
    {
        points++;
        counter.text = $"Points: {points}";
        AudioController.instance.PlayScoreSound();
    }
}
