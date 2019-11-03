using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{

    public void goBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
