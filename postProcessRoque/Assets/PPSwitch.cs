using UnityEngine;

public class PPSwitch : MonoBehaviour
{
    public bool ativado;
    public KeyCode botaoTroca;
    public GameObject postProcess;
    public Material UIPostProcess;

    void Start(){
                ativado = true;
                UIPostProcess.SetFloat("_Ativado", 1f);
                postProcess.SetActive(true);
    }
        void Update()
    {
        if(Input.GetKeyDown(botaoTroca)){
            if(ativado) {
                ativado = false;
                UIPostProcess.SetFloat("_Ativado", 0f);
                postProcess.SetActive(false);
            }
            else {
                ativado = true;
                UIPostProcess.SetFloat("_Ativado", 1f);
                postProcess.SetActive(true);
            }
        }
    }
}
