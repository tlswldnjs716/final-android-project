using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DBcode : MonoBehaviour
{
    public InputField CodeInputField;
   
    public string CodeUrl;
    void Start()
    {
        // 버튼을 눌렀을 때 이동할 URL 
        // (이클립스에서 jsp 파일을 실행시켰을 때의 URL을 입력)
        CodeUrl = "http://localhost/JSP_JDBC/code.jsp";

    }

    public void OkBtn()
    {
        StartCoroutine(CodeinCo());
    }

    IEnumerator CodeinCo()
    {
        WWWForm form = new WWWForm();
        form.AddField("CODE", CodeInputField.text);

        WWW webRequest = new WWW(CodeUrl, form);
        yield return webRequest;

        Debug.Log(webRequest.text);
    }
}