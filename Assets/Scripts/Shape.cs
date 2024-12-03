using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;

    private void Start()
    {
        
    }

    public void Init(string newName)
    {
        shapeName = newName;
    }

    public abstract float CalculateArea();
    public virtual void Resize() 
    {
        string name = shapeName;
        Debug.Log($"Resizing {name}");
        
    }

    public void Draw() 
    {
        string name = shapeName;
        Debug.Log($"Dawing {name}");

    }
    
    
}
