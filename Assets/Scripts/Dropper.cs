using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropTime = 3;
    MeshRenderer meshRenderer;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= dropTime)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
