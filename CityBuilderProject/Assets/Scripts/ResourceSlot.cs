using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResourceSlot : MonoBehaviour
{
    [SerializeField] private ResourceData data;
    [SerializeField] private int value;

    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI valueText;

    public ResourceType ResourceType => data.Type;

    private void Awake()
    {
        icon.sprite = data.Icon;
    }


    public void IncreaseValue(int amount)
    {
        value += amount;
        valueText.text = value.ToString();
    }

    public void DecreaseValue(int amount)
    {
        value -= amount;
        valueText.text = value.ToString();
    }
}
