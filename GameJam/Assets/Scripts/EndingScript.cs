using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndingScript : MonoBehaviour
{
    [SerializeField] private TMP_Text EndingText;
    [SerializeField] private Button ReturnBtn;

    // Start is called before the first frame update
    void Start()
    {
        this.EndingText.text = "" + PhoneScript.timer; 
        ReturnBtn.onClick.AddListener(BackToMM);
    }

    void BackToMM() {
        SceneManager.LoadScene("MainMenu");
    }
}
