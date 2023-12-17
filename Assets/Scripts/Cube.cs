using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    private void Start()
    {
        shapeName = "Adam";
    }
    // POLYMORPHISM
    public override string DisplayText()
    {
        return $"This is a cube, it's name is {shapeName}";
    }
}
