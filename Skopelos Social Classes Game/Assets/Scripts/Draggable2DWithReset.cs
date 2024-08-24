using System.Collections;
using UnityEngine;

public class Draggable2DWithReset : MonoBehaviour
{
    [SerializeField] string objectType;

    public string GetObjectType()
    {
        return objectType;
    }

    private bool isDragging = false;
    private Vector3 offset;
    private Vector3 initialPosition;

// in start, check if the correct piece is placed in the correct hole. if it is, destroy the piece
    void Start()
    {
        if (Hole.SavePiece_1 && objectType == "1")
        {
            Destroy(gameObject);
        }
        else if (Hole.SavePiece_2 && objectType == "2")
        {
            Destroy(gameObject);
        }
        else if (Hole.SavePiece_3 && objectType == "3")
        {
            Destroy(gameObject);
        }
        else if (Hole.SavePiece_4 && objectType == "4")
        {
            Destroy(gameObject);
        }
        else if (Hole.SavePiece_5 && objectType == "5")
        {
            Destroy(gameObject);
        }
        else if (Hole.SavePiece_6 && objectType == "6")
        {
            Destroy(gameObject);
        }
        else if (Hole.SavePiece_7 && objectType == "7")
        {
            Destroy(gameObject);
        }
        else if (Hole.SavePiece_8 && objectType == "8")
        {
            Destroy(gameObject);
        }
        else if (Hole.SavePiece_9 && objectType == "9")
        {
            Destroy(gameObject);
        }

        initialPosition = transform.position;
    }

// if the piece is clicked, it is no longer a collider
    void OnMouseDown()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        isDragging = true;
        offset = transform.position - GetMouseWorldPosition();
    }

// if the piece is released, the piece is reset to its initial position
    void OnMouseUp()
    {
        StartCoroutine(ResetPosition());
    }

    private IEnumerator ResetPosition()
    {
        gameObject.GetComponent<Collider2D>().enabled = true;

        yield return new WaitForSeconds(0.02f);

        isDragging = false;

        transform.position = initialPosition;
    }

//  if the piece is being dragged, it follows the mouse
    void Update()
    {
        if (isDragging)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }
    }

    // get the mouse position in the world

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mouseScreenPosition);
    }
}
