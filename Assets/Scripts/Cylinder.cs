using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private void Start()
    {
        shapeName = "Robert";
    }
    public override string DisplayText()
    {
        return $"This is a cylinder, it's name is {shapeName}";
    }
}
