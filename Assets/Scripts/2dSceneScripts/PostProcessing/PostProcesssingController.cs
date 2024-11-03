using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcesssingController : MonoBehaviour
{
    public PostProcessVolume volume;
    public float[] bloomIntensity;
    public float[] vignetteIntensity;
    public float[] saturation;

    Bloom bloomSettings;
    Vignette vignetteSettings;
    ColorGrading colorGradingSettings;

    // Start is called before the first frame update
    void Start()
    {
        volume.profile.TryGetSettings<Bloom>(out bloomSettings);
        volume.profile.TryGetSettings<Vignette>(out vignetteSettings);
        volume.profile.TryGetSettings<ColorGrading>(out colorGradingSettings);
    }

    public void SetDangerPostProcess(bool isInDanger)
    {
        if (!isInDanger)
        {
            bloomSettings.intensity.value = bloomIntensity[0];
            vignetteSettings.intensity.value = vignetteIntensity[0];
            colorGradingSettings.saturation.value = saturation[0];
        }
        else
        {
            bloomSettings.intensity.value = bloomIntensity[1];
            vignetteSettings.intensity.value = vignetteIntensity[1];
            colorGradingSettings.saturation.value = saturation[1];
        }
    }
}
