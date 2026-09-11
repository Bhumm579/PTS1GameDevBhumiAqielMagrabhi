using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TMP_Text coinText;
    public GameObject winText;
    public int totalKoin;
    private int koinTerkumpul = 0;
    [SerializeField] private int skor = 0;
    void Start()
    {
        totalKoin = GameObject.FindGameObjectsWithTag("Coin").Length;
        UpdateUI();
        winText.SetActive(false);
    }

    void UpdateUI()
    {
        coinText.text = "Koin : " + koinTerkumpul + " / " + totalKoin;
    }

    public void AmbilKoin()
    {
        koinTerkumpul++;
        UpdateUI();
        if (koinTerkumpul == totalKoin)
        {
            Menang();
        }
    }

    void Menang()
    {
        winText.SetActive(true);
        coinText.gameObject.SetActive(false);
        Time.timeScale = 0f;
        Debug.Log("KAMU MENANG!");
    }

}
