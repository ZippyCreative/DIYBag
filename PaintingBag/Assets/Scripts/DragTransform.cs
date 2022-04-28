using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTransform : MonoBehaviour
{
 private Color mouseOverColor = Color.blue;
    private Color originalColor = Color.yellow;
    private bool dragging = false;
    private float distance;
    private Vector3 startDist;
	public GameObject ringsY;
	public GameObject rings;
	public GameObject Sticker;
   
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = mouseOverColor;
    }
 
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = originalColor;
    }
 
    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 rayPoint = ray.GetPoint(distance);
        startDist = transform.position - rayPoint;
    }
 
    void OnMouseUp()
    {
        dragging = false;
		ringsY.SetActive(true);
		rings.SetActive(false);
		Sticker.SetActive(false);
    }
 
    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint + startDist;
        }
    }
}
