using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct GroundInfoStruct 
{
    //fill with info here
    public int posX;
    public int posY;
    public bool onLand;
    //public float DEBUGLandValue;
    public float terrainOcclusion;
    public float waterflow;
    public float sand;
    public float clay;
    public float silt;
    public float ph;
}
