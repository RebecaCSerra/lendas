using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciaBotoes : MonoBehaviour
{
    private bool isPaused;
    public GameObject yaraconfig;
    void Start()
    {

    }
    private void Update()
    {

        
    }
    public GameObject config;
    public void Creditos()
    { 
        SceneManager.LoadScene(1);
    }
    public void Voltar()
    {
        SceneManager.LoadScene(0);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Jogar()
    {
        SceneManager.LoadScene(13);
    }
    public void Boitata()
    {
        SceneManager.LoadScene(2);
    }
    
    public void Iara()
    {
        SceneManager.LoadScene(10);
    }
    public void Casita()
    {
        SceneManager.LoadScene(0);
    }
    public void Fase1()
    {
        SceneManager.LoadScene(19);
    }
    public void Fasebloqueada()
    {
        SceneManager.LoadScene(4);
    }
    public void Fechar()
    {
        SceneManager.LoadScene(2);
    }
    public void Fasebloqueada2()
    {
        SceneManager.LoadScene(4);
    }
    public void Fasebloqueada3()
    {
        SceneManager.LoadScene(4);
    }
    public void Fasebloqueada4()
    {
        SceneManager.LoadScene(4);
    }
    public void Fasebloqueada5()
    {
        SceneManager.LoadScene(4);
    }
    public void Fasebloqueada6()
    {
        SceneManager.LoadScene(4);
    }
    public void Fasebloqueada7()
    {
        SceneManager.LoadScene(4);
    }
    public void configurações()
    {
        SceneManager.LoadScene(5);
    }
    public void X()
    {
        config.SetActive(false);
    }
    public void back2fases()
    {
        SceneManager.LoadScene(2);
    }
    public void telainicial()
    {
        SceneManager.LoadScene(0);
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene(3);
    }
    public void Reiniciar1()
    {
        SceneManager.LoadScene(3);
    }
    public void Sair()
    {
        SceneManager.LoadScene(6);
    }
    public void nao()
    {
        SceneManager.LoadScene(5);
    }

    public void pergaminho()
    {
        SceneManager.LoadScene(7);
    }
    public void casavermelha()
    {
        SceneManager.LoadScene(0);
    }
    public void yaraatual()
    {
        SceneManager.LoadScene(24);
    }
    public void Yarablock2()
    {
        SceneManager.LoadScene(11);
    }
    public void Yarablock3()
    {
        SceneManager.LoadScene(11);
    }
    public void Yarablock4()
    {
        SceneManager.LoadScene(11);
    }
    public void Yarablock5()
    {
        SceneManager.LoadScene(11);
    }
    public void Yarablock6()
    {
        SceneManager.LoadScene(11);
    }
    public void Yarablock7()
    {
        SceneManager.LoadScene(11);
    }
    
    public void loreYara()
    {
        SceneManager.LoadScene(12);
    }
    public void redX()
    {
        SceneManager.LoadScene(10);
    }
    public void redX2()
    {
        SceneManager.LoadScene(10);
    }
    public void InicialYara()
    {
        SceneManager.LoadScene(0);
    }
    public void ReiniciarYara()
    {
        SceneManager.LoadScene(14);
    }
    public void Xconfigyara()
    {
        config.SetActive(false);
        timer.Running = true;
    }
    public void SAIRyara()
    {
        SceneManager.LoadScene(16);
    }
    public void naoSAIRyara()
    {
        SceneManager.LoadScene(15);
    }
    public void reiniciayara()
    {
        SceneManager.LoadScene(14);
    }

    public void proximaeyara()
    {
        SceneManager.LoadScene(11);
    }
    public void ShowMenuPanel()
    {
        config.SetActive(true);
    }
    public void ShowMenuPanelyara()
    {
        config.SetActive(true);
        timer.Running = false;
    }
}
   
