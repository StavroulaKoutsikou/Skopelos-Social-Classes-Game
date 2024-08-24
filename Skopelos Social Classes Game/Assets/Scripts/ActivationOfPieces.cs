using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationOfPieces : MonoBehaviour
{
    public GameObject[] PuzzlePieces;
    // for the first category, the first three pieces are activated
    // for the second category, the next three pieces are activated
    // for the third category, the last three pieces are activated
    // they stay inactive until the correct buttons are clicked
    void Start()
    {
        if (PanelStateManager.CorrectButtonClickCount_1 >= 3)
        {
            PuzzlePieces[0].SetActive(true);
            PuzzlePieces[1].SetActive(true);
            PuzzlePieces[2].SetActive(true);
        }

        if (PanelStateManager.CorrectButtonClickCount_2 >= 3)
        {
            PuzzlePieces[3].SetActive(true);
            PuzzlePieces[4].SetActive(true);
            PuzzlePieces[5].SetActive(true);
        }

        if (PanelStateManager.CorrectButtonClickCount_3 >= 3)
        {
            PuzzlePieces[6].SetActive(true);
            PuzzlePieces[7].SetActive(true);
            PuzzlePieces[8].SetActive(true);
        }
    }

}
