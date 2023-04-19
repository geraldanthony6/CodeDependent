using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleLights : MonoBehaviour
{
    public Material material;
    Renderer rend;
    public bool isComplete = false;
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    // Function -> used to change light material to indicate completion of a puzzle
    public void indicateCompletion() {
        rend = GetComponent<MeshRenderer> ();
        rend.material = material;
    }
}
