using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalScaleToScreenHeight : MonoBehaviour
{
    [SerializeField]
    private float ScreenPercentToScaleToV, ScreenPercentToScaleToH;

    [SerializeField]
    private bool ConstantUpdate = false;

    [SerializeField]
    private bool ScaleHorizontal = false;

    private RectTransform rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = this.GetComponent(typeof(RectTransform)) as RectTransform;
        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, Screen.height * ScreenPercentToScaleToV);

        if (ScaleHorizontal)
        {
            rectTransform.sizeDelta = new Vector2(Screen.width * ScreenPercentToScaleToH, rectTransform.sizeDelta.y);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (ConstantUpdate)
        {
            rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, Screen.height * ScreenPercentToScaleToV);

            if (ScaleHorizontal)
            {
                rectTransform.sizeDelta = new Vector2(Screen.width * ScreenPercentToScaleToH, rectTransform.sizeDelta.y);
            }
        }
    }
}
