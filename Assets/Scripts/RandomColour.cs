using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColour : MonoBehaviour
{
    // Array of colours to use
    [SerializeField] Color[] colors;

    // Int to use a certain colour not a random one
    [SerializeField] int colourIndex = 0;

    // Bool to select random or static colour
    [SerializeField] bool useColourIndex = false;

    // The spriteRenderer this script is attached to
    SpriteRenderer spriteRenderer;

    void Start()
    {
        // Get the spriteRenderer
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Choose if you want a static colour
        if (useColourIndex)
        {
            // Set the spriteRenderer colour to the colour index
            spriteRenderer.color = colors[colourIndex];
        }
        else
        {
            // Get a random colour we use a float as an int will not return the last colour in the array
            float randomColor = Random.Range(0, colors.Length);

            // Set the spriteRenderer colour to the random colour casting the float back to an integer
            spriteRenderer.color = colors[(int)randomColor];
        }
    }
}
