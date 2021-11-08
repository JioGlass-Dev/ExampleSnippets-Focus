using UnityEngine;
using JMRSDK.InputModule;

/// <summary>
/// Example of using focus-
/// 
/// On focus enter changes color to green,
/// On focus exit changes color to gray.
/// </summary>
/// <remarks>
/// No need to add global listener here because focus is done for the particular gameobject.
/// </remarks>
public class FocusManager : MonoBehaviour, IFocusable
{
    /// <summary>
    /// The material assigned to this gameobject mesh
    /// </summary>
    [HideInInspector] public Material ThisMaterial;
    
    /// <summary>
    /// Get the material assigned to this gameobject.
    /// </summary>
    public void Start()
    {
        ThisMaterial = transform.GetComponent<Renderer>().material;    
    }

    ///<summary>
    /// Gets called when laser pointer focuses on the gameobject.
    /// </summary>
    /// <remarks>
    /// Sets the material color to green.
    /// </remarks>
    public void OnFocusEnter()
    {
        ThisMaterial.color = Color.green;
    }

    /// <summary>
    /// Gets called when laser pointer exits focus from the gameobject.
    /// </summary>
    /// <remarks>
    /// Sets the material color to gray.
    /// </remarks>
    public void OnFocusExit()
    {
        ThisMaterial.color = Color.gray;
    }
}
