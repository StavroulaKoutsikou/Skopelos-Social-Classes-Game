using System.Collections;
using UnityEngine;

public class MoveToNextPanel : MonoBehaviour
{
    [SerializeField] private GameObject currentPanel;
    [SerializeField] private GameObject nextPanel;
    [SerializeField] private GameObject congratsPanel;
    [SerializeField] private GameObject tryAgainPanel;
    [SerializeField] private GameObject goToPuzzlePanel;

    private bool coroutineAllowed;
    private bool facedUp;

    void Start()
    {
        currentPanel.SetActive(true);
        nextPanel.SetActive(false);
        congratsPanel.SetActive(false);
        tryAgainPanel.SetActive(false);
        goToPuzzlePanel.SetActive(false);
        coroutineAllowed = true;
        facedUp = false;
    }

    public void OnButtonClick()
    {
        if (coroutineAllowed)
        {
            StartCoroutine(RotatePanel());
        }
    }

    public void ShowCongratsOrTryAgain_1_Category()
    {
        if (coroutineAllowed)
        {
           
            if(PanelStateManager.CorrectButtonClickCount_1 >= 3 &&
                PanelStateManager.CorrectButtonClickCount_2 >= 3 &&
                PanelStateManager.CorrectButtonClickCount_3 >= 3)
            {
                StartCoroutine(RotateAndShowPanel(goToPuzzlePanel));
            }
            else if (PanelStateManager.CorrectButtonClickCount_1 >= 3)
            {
                StartCoroutine(RotateAndShowPanel(congratsPanel));
            }
            else
            {
                StartCoroutine(RotateAndShowPanel(tryAgainPanel));
            }
        }
    }

    public void ShowCongratsOrTryAgain_2_Category()
    {
        if (coroutineAllowed)
        {
            
            if (PanelStateManager.CorrectButtonClickCount_1 >= 3 &&
                PanelStateManager.CorrectButtonClickCount_2 >= 3 &&
                PanelStateManager.CorrectButtonClickCount_3 >= 3)
            {
                StartCoroutine(RotateAndShowPanel(goToPuzzlePanel));
            }
            else if (PanelStateManager.CorrectButtonClickCount_2 >= 3)
            {
                StartCoroutine(RotateAndShowPanel(congratsPanel));
            }
            else
            {
                StartCoroutine(RotateAndShowPanel(tryAgainPanel));
            }
        }
    }

    public void ShowCongratsOrTryAgain_3_Category()
    {
        if (coroutineAllowed)
        {
            
            if (PanelStateManager.CorrectButtonClickCount_1 >= 3 &&
                PanelStateManager.CorrectButtonClickCount_2 >= 3 &&
                PanelStateManager.CorrectButtonClickCount_3 >= 3)
            {
                StartCoroutine(RotateAndShowPanel(goToPuzzlePanel));
            }
            else if (PanelStateManager.CorrectButtonClickCount_3 >= 3)
            {
                StartCoroutine(RotateAndShowPanel(congratsPanel));
            }
            else
            {
                StartCoroutine(RotateAndShowPanel(tryAgainPanel));
            }
        }
    }


    private IEnumerator RotatePanel()
    {
        coroutineAllowed = false;
        yield return new WaitForSeconds(0.25f);
        float rotationSpeed = 2f;
        float waitTime = 0.01f;

        if (!facedUp)
        {
            for (float i = 0f; i <= 180f; i += rotationSpeed)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i >= 100f && i - rotationSpeed < 100f)
                {
                    currentPanel.SetActive(false);
                    nextPanel.SetActive(true);
                }
                yield return new WaitForSeconds(waitTime);
            }
        }
        else
        {
            for (float i = 180f; i >= 0f; i -= rotationSpeed)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i <= 100f && i + rotationSpeed > 100f)
                {
                    currentPanel.SetActive(true);
                    nextPanel.SetActive(false);
                }
                yield return new WaitForSeconds(waitTime);
            }
        }

        coroutineAllowed = true;
        facedUp = !facedUp;
    }

    private IEnumerator RotateAndShowPanel(GameObject panelToShow)
    {
        coroutineAllowed = false;
        yield return new WaitForSeconds(0.25f); 
        float rotationSpeed = 2f;
        float waitTime = 0.01f; 

        // Rotate the current panel out up to 90 degrees
        for (float i = 0f; i <= 90f; i += rotationSpeed)
        {
            transform.rotation = Quaternion.Euler(0f, i, 0f);
            yield return new WaitForSeconds(waitTime);
        }

        // Deactivate the current panel and activate the next panel at 90 degrees
        currentPanel.SetActive(false);
        panelToShow.SetActive(true);

        // Continue rotating to 180 degrees
        for (float i = 90f; i <= 180f; i += rotationSpeed)
        {
            transform.rotation = Quaternion.Euler(0f, i, 0f);
            yield return new WaitForSeconds(waitTime);
        }

        // Rotate the next panel back from 180 degrees to 0 degrees
        for (float i = 180f; i >= 90f; i -= rotationSpeed)
        {
            transform.rotation = Quaternion.Euler(0f, i, 0f);
            yield return new WaitForSeconds(waitTime);
        }

        // Finalize the rotation
        for (float i = 90f; i >= 0f; i -= rotationSpeed)
        {
            transform.rotation = Quaternion.Euler(0f, i, 0f);
            yield return new WaitForSeconds(waitTime);
        }

        currentPanel = panelToShow; // Update currentPanel to the newly shown panel
        coroutineAllowed = true;
        facedUp = !facedUp;
    }

}
