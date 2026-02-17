using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] Image fillImage;
    bool fill = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Fill = 0.2f;
    }

    public float Fill { get { return fillImage.fillAmount; } set { fillImage.fillAmount = value; } }

    // Update is called once per frame
    void Update()
    {
        // if (fill)
        // {
        //     Fill += 0.01f;
        //     if (Fill >= 1f) fill = !fill;
        // }
        // else
        // {
        //     Fill -= 0.01f;
        //     if (Fill <= 0f) fill = !fill;
        // }
        
    }
}
