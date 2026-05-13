using UnityEngine;


[CreateAssetMenu()]
public class TextureData : UpdatableData
{
    public void ApplyToMaterial(Material material)
    {
        
    }

    public void UpdateMeshHeights(Material material, float minHeight, float maxHeight)
    {
        material.SetFloat("_MinHeight", minHeight);
        material.SetFloat("_MaxHeight", maxHeight);
    }
}
