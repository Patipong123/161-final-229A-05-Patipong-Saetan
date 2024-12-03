using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side;
    private float area;
    private void Start()
    {
        Init("Squear");
        Draw();
        Resize();
        CalculateArea();
        Debug.Log($"Square side : {side}");
        Debug.Log($"Square area : {area}");
    }

    public override float CalculateArea()
    {
        side = 2;
        float math = side * side;
        area = math;
        return area;
        

    }

    public override void Resize()
    {
        Debug.Log($"Resizing Shape");
        Debug.Log($"{name} is resized");
    }

}
