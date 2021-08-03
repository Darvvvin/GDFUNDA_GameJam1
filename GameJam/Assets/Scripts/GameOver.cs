using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private TMP_Text EndingText;
    [SerializeField] private Button ReturnBtn;

    // Start is called before the first frame update
    void Start()
    {
        this.EndingText.text = "" + Phone.timer + " SECONDS"; 
        ReturnBtn.onClick.AddListener(BackToMM);
        Cursor.lockState = CursorLockMode.None;
    }

    public void BackToMM() {
        SceneManager.LoadScene("MainMenu");
    }
}
