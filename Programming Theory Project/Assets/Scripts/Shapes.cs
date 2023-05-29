using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapes : MonoBehaviour
{
    private void OnMouseDown()
    {
        DisplayText("Click");
    }

    // ABSTRACTION
    public void DisplayText(string text)
    {
        print("clicked on shape, printing text: ");
        print(text);
    }
}
