using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPositionController : MonoBehaviour
{
    [SerializeField]
    private Canvas MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        SetCanvasPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Set main menu position
    private void SetCanvasPosition()
    {
        Camera camera = Camera.main;
        Canvas canvas = MainMenu;
        float cameraY = camera.transform.position.y;
        Vector3 canvasPosition = canvas.transform.position;

        canvasPosition.y = cameraY - .2f;
        canvas.transform.position = canvasPosition;
    }
}
