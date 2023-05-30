using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciaBotoes : MonoBehaviour
{
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
        SceneManager.LoadScene(2);
    }
    public void Fase1()
    {
        SceneManager.LoadScene(3);
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
    public void x()
    {
        SceneManager.LoadScene(3);
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
}
