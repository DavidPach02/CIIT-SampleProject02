using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class TestPostProcessingController : MonoBehaviour
{
    public PostProcessVolume volume;
    public float[] bloomIntensity;
    public float[] vignetteIntensity;
    public float[] saturationIntensity;

    Bloom bloom;
    Vignette vignette;
    ColorGrading colorGrading;

    private void Start()
    {
        volume.profile.TryGetSettings<Bloom>(out bloom);
        volume.profile.TryGetSettings<Vignette>(out vignette);
        volume.profile.TryGetSettings<ColorGrading>(out colorGrading);
    }

    public void SetDangerPostProcess(bool isInDanger)
    {
        if (!isInDanger)
        {
            bloom.intensity.value = bloomIntensity[0];
            vignette.intensity.value = vignetteIntensity[0];
            colorGrading.saturation.value = saturationIntensity[0];
        }
        else
        {
            bloom.intensity.value = bloomIntensity[1];
            vignette.intensity.value = vignetteIntensity[1];
            colorGrading.saturation.value = saturationIntensity[1];
        }
    }
}
