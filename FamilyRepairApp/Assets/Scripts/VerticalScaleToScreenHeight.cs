using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalScaleToScreenHeight : MonoBehaviour
{
    [SerializeField]
    private bool UseAnotherRectAsRef = false;

    [SerializeField]
    private RectTransform refRectTransform;

    [SerializeField]
    private int PaddingCompensationV = 0;

    [SerializeField]
    private bool ConstantUpdate = false;

    [SerializeField]
    private bool ScaleHorizontal = false;

    [SerializeField]
    private float ScreenPercentToScaleToV, ScreenPercentToScaleToH;

    private RectTransform rectTransform;
    private Vector2 refSize;

    // Start is called before the first frame update
    void Start()
    {
        if (UseAnotherRectAsRef)
        {
            refSize = new Vector2(refRectTransform.rect.width, refRectTransform.rect.height - PaddingCompensationV);
        }
        else
        {
            refSize = new Vector2(Screen.width, Screen.height - PaddingCompensationV);
        }

        rectTransform = this.GetComponent(typeof(RectTransform)) as RectTransform;
        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, (refSize.y * ScreenPercentToScaleToV) - PaddingCompensationV);

        if (ScaleHorizontal)
        {
            rectTransform.sizeDelta = new Vector2(refSize.x * ScreenPercentToScaleToH, rectTransform.sizeDelta.y);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (ConstantUpdate)
        {
            if (UseAnotherRectAsRef)
            {
                refSize = new Vector2(refRectTransform.rect.width, refRectTransform.rect.height - PaddingCompensationV);
            }
            else
            {
                refSize = new Vector2(Screen.width, Screen.height - PaddingCompensationV);
            }

            rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, (refSize.y * ScreenPercentToScaleToV) - PaddingCompensationV);

            if (ScaleHorizontal)
            {
                rectTransform.sizeDelta = new Vector2(refSize.x * ScreenPercentToScaleToH, rectTransform.sizeDelta.y);
            }
        }
    }
}
