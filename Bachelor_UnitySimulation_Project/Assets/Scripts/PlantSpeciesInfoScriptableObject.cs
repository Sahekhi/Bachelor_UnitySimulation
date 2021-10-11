using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "PlantSpeciesInfo", order = 1)]
public class PlantSpeciesInfoScriptableObject : ScriptableObject
{
    [Header("Reproduction")]
    [SerializeField] private GameObject m_OwnSpeciesPrefab;     public GameObject ownSpeciesPrefab { get { return m_OwnSpeciesPrefab; } }
    [SerializeField] private int m_MaturityAge;                 public int maturityAge { get { return m_MaturityAge; } }
    [SerializeField] private int m_DeathAge;                    public int deathAge { get { return m_DeathAge; } }
    [SerializeField] private int m_SeedDistributionAmount;      public int seedDistributionAmount { get { return m_SeedDistributionAmount; } }
    [SerializeField] private float m_MaxDistributionDistance;   public float maxDistributionDistance { get { return m_MaxDistributionDistance; } }


    [SerializeField] private float m_OptimalOcclusion;          public float optimalOcclusion { get { return m_OptimalOcclusion; } }
    [Range(0.0f, 1.0f)]
    [SerializeField] private float m_OcclusionFactorWeight;     public float occlusionFactorWeight { get { return m_OcclusionFactorWeight; } }
    [SerializeField] private float m_OptimalFlow;               public float optimalflow { get { return m_OptimalFlow; } }
    [Range(0.0f, 1.0f)]
    [SerializeField] private float m_FlowFactorWeight;          public float flowFactorWeight { get { return m_FlowFactorWeight; } }
    [SerializeField] private float m_OptimalTemperature;        public float optimalTemperature { get { return m_OptimalTemperature; } }
    [Range(0.0f, 1.0f)]
    [SerializeField] private float m_TemperatureWeight; public float temperatureWeight { get { return m_TemperatureWeight; } }

    //Viability 
    //We have altitude, occlusion, flow & soil composition
    //each species should probably have own specifics for each of these values on what it needs and how important it is
    //example: occlusion: needs a lot of sunlight, flow: needs not so much water
    //ambivalence of factors by giving factors a priority? 

}