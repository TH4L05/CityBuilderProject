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
public class ResourceData : ScriptableObject
{
    [SerializeField] private ResourceType type = ResourceType.Undefined;
    [SerializeField] private Sprite icon;

    public ResourceType Type => type;
    public Sprite Icon => icon;

}
