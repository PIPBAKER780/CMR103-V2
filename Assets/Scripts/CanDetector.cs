using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanDetector : MonoBehaviour
{
    public Material GreenTransparent, RedTransparent;
    Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        r.material = RedTransparent;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Can")
        {
            r.material = GreenTransparent;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Can")
        {
            r.material = RedTransparent;
        }
    }
}
