using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{

    [SerializeField] private BuildingData data;


    private void Start()
    {
        InvokeRepeating("ResourceProduced", 0, data.ProductionTime);
    }


    private void ResourceProduced()
    {
        Debug.Log($"Resource Produced: {data.ProducedResource}");
        ResourceManager.GainResource?.Invoke(data.ProducedResource, data.ProductionAmount);
    }

}
