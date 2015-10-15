using UnityEngine;
using System.Collections;

public class MouseSelection : MonoBehaviour {
    Renderer meshRenderer;
    Color initialColor;
    GameManager gm;
    bool isSelected;

    public void Unselect() {
        isSelected = false;
        meshRenderer.material.color = initialColor;
    }

	// Use this for initialization
	void Start () {
        meshRenderer = GetComponent<Renderer>();
        initialColor = meshRenderer.material.color;
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
    void OnMouseEnter() {
        if (!isSelected) {
            meshRenderer.material.color = Color.red;
        }
    }

    void OnMouseExit() {
        if (!isSelected) {
            meshRenderer.material.color = initialColor;
        }
    }

    void OnMouseDown() {
        gm.NewSelection(this);
        isSelected = true;
        meshRenderer.material.color = Color.blue;
    }
}
