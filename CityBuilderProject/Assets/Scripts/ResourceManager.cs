using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    //private Dictionary<ResourceType, int> resources = new Dictionary<ResourceType, int>();
    public static Action<ResourceType, int> GainResource;
    public static Action<ResourceType, int> RemoveResource;
    public static Action<ResourceType, int> UpdateResourceView;

    [SerializeField] private List<ResourceSlot> resourceSlots = new List<ResourceSlot>();

    private void Awake()
    {
        GainResource += UpdateResourceAmountPlus;
        RemoveResource += UpdateResourceAmountMinus;
    }

    private void OnDestroy()
    {
        GainResource -= UpdateResourceAmountPlus;
        RemoveResource -= UpdateResourceAmountMinus;
    }

    public void UpdateResourceAmountPlus(ResourceType type, int amount)
    {
        foreach (var resource in resourceSlots)
        {
            if (resource.ResourceType == type)
            {
                resource.IncreaseValue(amount);
                return;
            }
        }
    }

    public void UpdateResourceAmountMinus(ResourceType type, int amount)
    {
        foreach (var resource in resourceSlots)
        {
            if (resource.ResourceType == type)
            {
                resource.DecreaseValue(amount);
                return;
            }
        }
    }

}
