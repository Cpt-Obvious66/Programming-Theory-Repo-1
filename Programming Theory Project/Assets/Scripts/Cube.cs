using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shapes
{
    // ENCAPSULATION
    public string objectName { get { return gameObject.name; } private set { } }
    private void OnMouseDown()
    {
        // POLYMORPHISM
        DisplayText("I'm a " + objectName);
    }
}
