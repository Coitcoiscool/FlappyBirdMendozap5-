

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
   public static GameControl Instance;
    public GameObject gameOverText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI Continue;

    public bool gameOver = false;
}
