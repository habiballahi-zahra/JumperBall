using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private AudioSource MusicSource;

    [SerializeField] private Text MuteButtonText;

    private bool isMute = false;
    private static MusicController instance;
      void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // بین صحنه‌ها نابود نشه
        }
        else
        {
            Destroy(gameObject); // اگر یکی قبلاً وجود داشت، حذف کن
        }
    }

    public void ToggleMoute()
    {
        isMute = !isMute;
        MusicSource.mute = isMute;

        if (isMute)
        {
            MuteButtonText.text = "UnMute";
        }

        else
        { 
            MuteButtonText.text = "Mute";
        }

   }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
