using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ResourceType
{
    Undefined = -1,
    Wood,
    Stone,
    Food,
}

[CreateAssetMenu(fileName = "NewResoureceData", menuName = "Data/ResourceData")]
public class ResoureData : ScriptableObject
{
    [SerializeField] private ResourceType type = ResourceType.Undefined;
    [SerializeField] private Sprite icon;



}
