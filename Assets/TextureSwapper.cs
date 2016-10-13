using UnityEngine;

public class TextureSwapper : MonoBehaviour
{
    [SerializeField] RenderTexture[] _textures;
    [SerializeField] float _interval = 0.1f;
    Camera cam;

    void Start()
    {
        Application.targetFrameRate = 90;
        //Cache
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        cam.targetTexture =
            _textures[(int)(Time.time / _interval) % _textures.Length];
    }
}
