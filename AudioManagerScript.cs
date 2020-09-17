using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioManagerScript : MonoBehaviour
{

    private static readonly string FirstPlay = "FirstPlay"; //[ReadOnly] 사용 -> 값을 수정할 수 없게 선정 
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectPref = "SoundEffectPref";

    private int firstPlayInt; // 설치 후 처음 실행시켰을 때의 변수 선언 
    public Slider backgroundSlider, soundEffectsSlider;
    private float backgroundFloat, soundEffectsFloat;
    public AudioSource backgroundAudio;
    public AudioSource soundEffectsAudio; //여러가지 사운드를 저장할 수 있게 배열 형태의 변수 선언 

    public Image BGMImage; // 배경음 기본 켜짐 상태 이미지
    public Image SEImage; // 효과음 기본 켜짐 상태 이미지
    public Image SPImage; // 음성음 기본 켜짐 상태 이미지
    public Sprite OnSprite; //소리가 켜졌을때 바뀔 sprite
    public Sprite OffSprite; //소리가 커졌을때 바뀔 sprite

    //public static AudioManagerScript instance = null;

    // Use this for initialization
    void Awake()
    {
        /*
         *if (instance == null)
        {
            instance = this;
        }

        else if (instance != null)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);*/

        /*public static backgroundAudio instance;
        if (instance == null) { instance = this; }
        else { Destroy(this.gameObject); */

        //DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if (firstPlayInt == 0) // 최초 실행했을 때 
        {
            backgroundFloat = .1f; //배경음 값 설정
            soundEffectsFloat = .1f; //효과음 값 설정

            backgroundSlider.value = backgroundFloat; //배경음 슬라이더 값을 볼륨 값과 같이 하기
            soundEffectsSlider.value = soundEffectsFloat; //효과음 슬라이더 값을 볼륨 값과 같이 하기

            PlayerPrefs.SetFloat(BackgroundPref, backgroundFloat); // BackgroundPref값에 아까 배경음 볼륨값을 저장
            PlayerPrefs.SetFloat(SoundEffectPref, soundEffectsFloat); // SoundEffectPref값에 아까 효과음 볼륨값을 저장//순서 : Float -> Slider -> Pref
            PlayerPrefs.SetInt(FirstPlay, -1);


            //Debug.Log(PlayerPrefs.GetFloat(BackgroundPref));
        }

        else //처음 실행이 아닐 때 
        {
            backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref); //이전 실행에 저장되있던 BackgroundPref값 불러와서 Float값에 넣기
            backgroundSlider.value = backgroundFloat; // Slider값을 float값에 맞추기 //순서 : Pref -> Float -> Slider 
            soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectPref);
            soundEffectsSlider.value = soundEffectsFloat;

            //Debug.Log(PlayerPrefs.GetFloat(BackgroundPref));
        }

    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(BackgroundPref, backgroundSlider.value);
        PlayerPrefs.SetFloat(SoundEffectPref, soundEffectsSlider.value);
        Debug.Log(PlayerPrefs.GetFloat(BackgroundPref));
    }

    void OnApplicationFocus(bool inFocus)  //앱이 포커싱되있는지 확인여부
    {
        if (!inFocus) //포커싱 되지 않았을 때 ex.앱 화면 회전, 크기 최소화 등등 
        {
            SaveSoundSettings(); //사운드 세팅 저장 함수 불러오기
        }
    }



    public void UpdateSound()
    {
        backgroundAudio.volume = backgroundSlider.value;

        if (backgroundSlider.value == 0.0f)
        {
            BGMImage.sprite = OffSprite; //BGMImage에 SourceImage를 배경음이 작동하는지에 맞는 sprite로 바꾸어줍니다
        }

        else if (backgroundSlider.value > 0.0f)
        {
            BGMImage.sprite = OnSprite;

        }//여기까지가 배경음에 대한 sprite변경내용

        //Debug.Log(PlayerPrefs.GetFloat(BackgroundPref));



        soundEffectsAudio.volume = soundEffectsSlider.value;

        if (soundEffectsSlider.value == 0.0f)
        {
            SEImage.sprite = OffSprite; //SEImage에 SourceImage를 효과음이 작동하는지에 맞는 sprite로 바꾸어줍니다
        }

         else if (soundEffectsSlider.value > 0.0f)
            {
                SEImage.sprite = OnSprite;

            }//여기까지가 효과에 대한 sprite변경내용

    }


    public void PlaySE()
    {
        soundEffectsAudio.Play();
    }


}

