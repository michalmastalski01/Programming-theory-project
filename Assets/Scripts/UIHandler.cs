using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHandler : MonoBehaviour
{
    public static UIHandler Instance { get; private set; }
    [SerializeField] TextMeshProUGUI nameText;

    private void Awake()
    {
        Instance = this;
    }
    public void UpdateText(string name)
    {
        nameText.text = $"Name: {name}";
    }
}
