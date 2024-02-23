using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    string MeshModel = "Cube";

    List<Vector3> Vertices = new List<Vector3>();
    List<Vector3> Faces = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<Vector3> GetVertices() { 
        return Vertices; 
    }

    public List<Vector3> GetFaces() {  
        return Faces; 
    }


}
