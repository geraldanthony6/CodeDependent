using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleLights : MonoBehaviour
{
    public Material material;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void indicateCompletion() {
        rend = GetComponent<Renderer> ();
        rend.enabled = true;
        rend.sharedMaterial = material;
    }
}
