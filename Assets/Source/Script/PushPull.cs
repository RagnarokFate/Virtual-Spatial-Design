using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPull : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cube cube = new Cube();
        DrawCube(cube);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PushPullEffect(Cube cube)
    {
        List<Vector3> vertices = cube.GetVertices();
        List<Vector3> faces = cube.GetFaces();

        //TODO - APPLYING PushPull Logic with GUI


    }

    void DrawCube(Cube cube)
    {

    }
}
