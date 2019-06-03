using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {
    public float planeHeight = 0;

    Camera cam;
    Plane plane;

    void Start() {
        cam = FindObjectOfType<Camera>();
        plane = new Plane(Vector3.up, planeHeight);
    }

    void Update() {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        float enter;
        plane.Raycast(ray, out enter);
        transform.position = ray.GetPoint(enter);
    }
}
