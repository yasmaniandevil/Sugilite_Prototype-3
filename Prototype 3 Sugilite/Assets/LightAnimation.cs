using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAnimation : MonoBehaviour
{
    public Light torchlight;
    public AnimationCurve intensityCurve;

    // Start is called before the first frame update
    void Start()
    {
        torchlight = GetComponent<Light>();
        intensityCurve.postWrapMode = WrapMode.Loop;
    }

    // Update is called once per frame
    void Update()
    {
        torchlight.intensity = intensityCurve.Evaluate(Time.time) + 5;

        
    }
}
