using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    private void Start()
    {
        shapeName = "Lucia";
    }
    // POLYMORPHISM
    public override string DisplayText()
    {
        return $"This is a sphere, it's name is {shapeName}";
    }
}
