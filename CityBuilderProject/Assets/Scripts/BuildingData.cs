using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum BuildingType
{
    Undefined = -1,
    Production,
    Living,
    Economy,
    Special,
}

[System.Serializable]
public class ResourceRequirement
{
    public ResoureData ResoureData;
    public int requiredAmount;
}

[CreateAssetMenu(fileName = "NewBuildingData", menuName = "Data/BuildingData")]
public class BuildingData : ScriptableObject
{
    #region SerializedFields

    [Header("---")]
    [SerializeField] private new string name;
    [SerializeField] private BuildingType buildingType = BuildingType.Undefined;
    [SerializeField] private Sprite icon;
    [SerializeField] private int health;
    [SerializeField] private ResourceRequirement[] requiredResources;
    [SerializeField] private int productionAmount = 1;
    [SerializeField] private float productionTime = 1f;

    #endregion

    #region PublicFields

    public string Name => name;
    public BuildingType BuildingType => buildingType;
    public Sprite Icon => icon;
    public int Health => health;
    public ResourceRequirement[] RequiredResources => requiredResources;
    public int ProductionAmount => productionAmount;
    public float ProductionTime => productionTime;

    #endregion

}
