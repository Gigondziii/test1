using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameObject imagePrefab;
    public Transform parentPanel;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        CreateImage();
    }

    void CreateImage()
    {
        GameObject newImage = Instantiate(imagePrefab, parentPanel);
        RectTransform rt = newImage.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(Random.Range(-200, 200), Random.Range(-100, 100));
    }
}
