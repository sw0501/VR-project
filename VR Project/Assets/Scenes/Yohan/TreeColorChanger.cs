using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeColorChanger : MonoBehaviour
{
    public LODGroup lodGroup;
    public Color startColor;
    public Color endColor;
    public float transitionDuration = 5f;
    public float delay = 10f;

    private Material[] originalMaterials;
    private Material[] modifiedMaterials;
    private Renderer[] treeRenderers;
    private float transitionTimer = 0f;
    private float delayTimer = 0f;
    private bool hasStartedTransition = false;

    public bool triggerStart = false;

    private void Start()
    {
        if (lodGroup == null)
        {
            Debug.LogError("Invalid LOD Group.");
            return;
        }

        LOD[] lods = lodGroup.GetLODs();
        treeRenderers = GetRenderersFromLODs(lods);

        originalMaterials = GetOriginalMaterials(treeRenderers);
        modifiedMaterials = new Material[originalMaterials.Length];
        for (int i = 0; i < originalMaterials.Length; i++)
        {
            modifiedMaterials[i] = new Material(originalMaterials[i]);
        }
    }

    private void Update()
    {
        /*
        if (hasStartedTransition == false)
        {
            delayTimer += Time.deltaTime;

            if (delayTimer >= delay)
            {
                hasStartedTransition = true;
                Debug.Log("Ω√∞£ ≤Ù¿ø");
            }
        }
        */

        if (triggerStart)
        {
            transitionTimer += Time.deltaTime;
            float transitionProgress = Mathf.Clamp01(transitionTimer / transitionDuration);
            Color currentColor = Color.Lerp(startColor, endColor, transitionProgress);

            foreach (Material material in modifiedMaterials)
            {
                material.color = currentColor;
            }

            foreach (Renderer treeRenderer in treeRenderers)
            {
                treeRenderer.materials = modifiedMaterials;
            }
        }
    }

    private Renderer[] GetRenderersFromLODs(LOD[] lods)
    {
        int totalRendererCount = 0;
        foreach (LOD lod in lods)
        {
            totalRendererCount += lod.renderers.Length;
        }

        Renderer[] renderers = new Renderer[totalRendererCount];
        int index = 0;
        foreach (LOD lod in lods)
        {
            foreach (Renderer renderer in lod.renderers)
            {
                renderers[index] = renderer;
                index++;
            }
        }

        return renderers;
    }

    private Material[] GetOriginalMaterials(Renderer[] renderers)
    {
        Material[] materials = new Material[renderers.Length];

        for (int i = 0; i < renderers.Length; i++)
        {
            materials[i] = renderers[i].sharedMaterial;
        }

        return materials;
    }
}