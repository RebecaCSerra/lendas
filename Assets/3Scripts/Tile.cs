using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private static Tile selected;
    private SpriteRenderer Renderer;

    public Vector2Int Position;

    private void Start()
    {
        Renderer = GetComponent<SpriteRenderer>();
    }

    public void Select()
    {
        Renderer.color = Color.grey;
    }

    public void Unselect()
    {
        Renderer.color = Color.white;
    }

    private void OnMouseDown()
    {
        if (selected != null)
        {
            if (selected == this)
                return;
            selected.Unselect();
            if (Vector2Int.Distance(selected.Position, Position) == 1)
            {
                GerenciaGrid.Instance.SwapTiles(Position, selected.Position);
                selected = null;
            }
            else
            {
                //GerenciaSom.Instance.PlaySound(SoundType.TypeSelect);
                selected = this;
                print("dentro de tile" + selected.name);
                Select();
            }
        }
        else
        {
            //GerenciaSom.Instance.PlaySound(SoundType.TypeSelect);
            selected = this;
            Select();
        }
    }
}
