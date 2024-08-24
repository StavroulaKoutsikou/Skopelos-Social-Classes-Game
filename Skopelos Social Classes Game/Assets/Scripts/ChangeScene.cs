using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



// unused class
public class ChangeScene : MonoBehaviour
{
    public static bool Category_1 = false;
    public static bool Category_2 = false;
    public static bool Category_3 = false;

    public static void WinCategory_1()
    {
        Category_1 = true;
    }

    public static void WinCategory_2()
    {
        Category_2 = true;
    }

    public static void WinCategory_3()
    {
        Category_3 = true;
    }
    public void SceneChange(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
