using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Slider = UnityEngine.UI.Slider;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _sliderText;

    [SerializeField] private Slider _slider;
    // Start is called before the first frame update
    void Start()
    {
        _slider.onValueChanged.AddListener((v) => {
            _sliderText.text = v.ToString("0");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
