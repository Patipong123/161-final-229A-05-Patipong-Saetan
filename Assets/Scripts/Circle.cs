using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private float raidus;
    private float area;
    private void Start()
    {
        Init("Circle");
        Draw();
        Resize();
        CalculateArea();
        Debug.Log($"Circle raduis : {raidus}");
        Debug.Log($"Circle area : {area}");
    }

    public override float CalculateArea()
    {
        raidus = 2;
        float math = Mathf.Pow( 2, raidus );
        area = math;
        return math;

    }

    public override void Resize()
    {
        Debug.Log($"Resizing Shape");
        Debug.Log($"Resizing {name} in {name} Class");
    }


}
