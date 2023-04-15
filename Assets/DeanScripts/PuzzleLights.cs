using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleLights : MonoBehaviour
{
    public Material material;
    Renderer rend;
    public bool isComplete = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void indicateCompletion() {
        rend = GetComponent<MeshRenderer> ();
        //rend.enabled = true;
        rend.material = material;
    }
}
