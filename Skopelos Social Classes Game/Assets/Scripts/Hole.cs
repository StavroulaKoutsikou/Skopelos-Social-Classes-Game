using UnityEngine;
using UnityEngine.UI;

public class Hole : MonoBehaviour
{
    [SerializeField] private string holeType;
    [SerializeField] private Sprite filledHoleSprite;

    public static bool SavePiece_1 = false;
    public static bool SavePiece_2 = false;
    public static bool SavePiece_3 = false;
    public static bool SavePiece_4 = false;
    public static bool SavePiece_5 = false;
    public static bool SavePiece_6 = false;
    public static bool SavePiece_7 = false;
    public static bool SavePiece_8 = false;
    public static bool SavePiece_9 = false;

    private Image holeImage;

    private void Start()
    {
        holeImage = GetComponent<Image>();

        if (SavePiece_1 && holeType == "1")
        {
            FillHole();
        }
        else if (SavePiece_2 && holeType == "2")
        {
            FillHole();
        }
        else if (SavePiece_3 && holeType == "3")
        {
            FillHole();
        }
        else if (SavePiece_4 && holeType == "4")
        {
            FillHole();
        }
        else if (SavePiece_5 && holeType == "5")
        {
            FillHole();
        }
        else if (SavePiece_6 && holeType == "6")
        {
            FillHole();
        }
        else if (SavePiece_7 && holeType == "7")
        {
            FillHole();
        }
        else if (SavePiece_8 && holeType == "8")
        {
            FillHole();
        }
        else if (SavePiece_9 && holeType == "9")
        {
            FillHole();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Draggable2DWithReset draggable = other.GetComponent<Draggable2DWithReset>();

        if (draggable != null && draggable.GetObjectType() == holeType)
        {
            Destroy(other.gameObject); 
            FillHole();

            if (holeType == "1")
            {
                SavePiece_1 = true;
            }
            else if (holeType == "2")
            {
                SavePiece_2 = true;
            }
            else if (holeType == "3")
            {
                SavePiece_3 = true;
            }
            else if (holeType == "4")
            {
                SavePiece_4 = true;
            }
            else if (holeType == "5")
            {
                SavePiece_5 = true;
            }
            else if (holeType == "6")
            {
                SavePiece_6 = true;
            }
            else if (holeType == "7")
            {
                SavePiece_7 = true;
            }
            else if (holeType == "8")
            {
                SavePiece_8 = true;
            }
            else if (holeType == "9")
            {
                SavePiece_9 = true;
            }

            PuzzleManager.PiecePlaced();
        }
    }

    private void FillHole()
    {
        holeImage.sprite = filledHoleSprite;
        holeImage.color = Color.white;  // Change the color to white
    }

    public static void ResetHoles()
    {
        SavePiece_1 = false;
        SavePiece_2 = false;
        SavePiece_3 = false;
        SavePiece_4 = false;
        SavePiece_5 = false;
        SavePiece_6 = false;
        SavePiece_7 = false;
        SavePiece_8 = false;
        SavePiece_9 = false;
    }
}
