using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    private void Start()
    {
        shapeName = "Robert";
    }
    // POLYMORPHISM
    public override string DisplayText()
    {
        return $"This is a cylinder, it's name is {shapeName}";
    }
}
