using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private float raidus;
    private float areaS;
    private void Start()
    {
        Init("Circle");
        Draw();
        Resize();
        CalculateArea();
        Debug.Log($"Circle raduis : {raidus}");
        Debug.Log($"Circle area : {areaS}");
    }

    public override float CalculateArea()
    {
        raidus = 2;
        float math = raidus * 2;
        areaS = math;
        return areaS;

    }

    public override void Resize()
    {
        Debug.Log($"Resizing Shape");
        Debug.Log($"Resizing {name} in {name} Class");
    }


}
