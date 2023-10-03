using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yaracopy : timer 
{
    public List<Sprite> Sprites = new List<Sprite>();
    public GameObject TileYARAPrefab;
    public int GridDimension = 8;
    public float Distance = 1.0f;
    private GameObject[,] Grid;
    public TextMeshProUGUI yaraGoal1Text;
    public TextMeshProUGUI points;
    public int pontuacaoMax = 500;
    private int _numTiles;
    public int NumTiles
    {
        get
        {
            return _numTiles;
        }

        set
        {
            _numTiles = value;
        }
    }
    public static yaracopy Instance { get; private set; }

    void Awake()

    {
        Instance = this;
    }
    void Update()
    {
        if (int.Parse(points.text) >= pontuacaoMax)
            SceneManager.LoadScene(18);
       
        {
            if (TimeValue >= 0)
                points.text = TimeValue.ToString();
            //else
            //   SceneManager.LoadScene(8);

        }
    } 
    void Start()
    {
        Grid = new GameObject[GridDimension, GridDimension];
        print("chamou start");
        InitGrid2();
    }
    void InitGrid2()
    {
        Vector3 positionOffset = transform.position - new Vector3(GridDimension * Distance / 2.0f, GridDimension * Distance / 2.0f, 0);

        for (int row = 0; row < GridDimension; row++)
            for (int column = 0; column < GridDimension; column++)
            {
                GameObject newTile = Instantiate(TileYARAPrefab);

                List<Sprite> possibleSprites = new List<Sprite>(Sprites);

                //Choose what sprite to use for this cell
                Sprite left1 = GetSpriteAt2(column - 1, row);
                Sprite left2 = GetSpriteAt2(column - 2, row);
                if (left2 != null && left1 == left2)
                {
                    possibleSprites.Remove(left1);
                }

                Sprite down1 = GetSpriteAt2(column, row - 1);
                Sprite down2 = GetSpriteAt2(column, row - 2);
                if (down2 != null && down1 == down2)
                {
                    possibleSprites.Remove(down1);
                }

                SpriteRenderer renderer = newTile.GetComponent<SpriteRenderer>();
                renderer.sprite = possibleSprites[Random.Range(0, possibleSprites.Count)];

                tileYARA tile = newTile.AddComponent<tileYARA>();
                tile.Position = new Vector2Int(column, row);

                newTile.transform.parent = transform;
                newTile.transform.position = new Vector3(column * Distance, row * Distance, 0) + positionOffset;
                newTile.name = renderer.sprite.name;

                Grid[column, row] = newTile;
            }
    }

    Sprite GetSpriteAt2(int column, int row)
    {
        if (column < 0 || column >= GridDimension
         || row < 0 || row >= GridDimension)
            return null;
        GameObject ytile = Grid[column, row];
        SpriteRenderer renderer = ytile.GetComponent<SpriteRenderer>();
        return renderer.sprite;
    }

    SpriteRenderer GetSpriteRendererAt2(int column, int row)
    {
        if (column < 0 || column >= GridDimension
         || row < 0 || row >= GridDimension)
            return null;
        GameObject tile = Grid[column, row];
        SpriteRenderer renderer = tile.GetComponent<SpriteRenderer>();
        return renderer;
    }
    public void SwapTiles2(Vector2Int tile1Position, Vector2Int tile2Position)
    {
        GameObject ytile1 = Grid[tile1Position.x, tile1Position.y];
        SpriteRenderer renderer1 = ytile1.GetComponent<SpriteRenderer>();

        GameObject ytile2 = Grid[tile2Position.x, tile2Position.y];
        SpriteRenderer renderer2 = ytile2.GetComponent<SpriteRenderer>();

        Sprite temp = renderer1.sprite;
        renderer1.sprite = renderer2.sprite;
        renderer2.sprite = temp;

        bool changesOccurs = CheckandCountMatches2();
        if (!changesOccurs)
        {
            temp = renderer1.sprite;
            renderer1.sprite = renderer2.sprite;
            renderer2.sprite = temp;
            //GerenciaSom.Instance.PlaySound(SoundType.TypeMove);

        }
        else
        {
            print("Count");
            int points = int.Parse(yaraGoal1Text.text);
            if (points >= 0)
                yaraGoal1Text.text = points.ToString();
            do
            {
                FillHoles2();
            } while (CheckMatches2());
        }
    }

    bool CheckMatches2()
    {
        HashSet<SpriteRenderer> matchedTiles = new HashSet<SpriteRenderer>();
        for (int row = 0; row < GridDimension; row++)
        {
            for (int column = 0; column < GridDimension; column++)
            {
                SpriteRenderer current = GetSpriteRendererAt2(column, row);

                List<SpriteRenderer> horizontalMatches = FindColumnMatchForTile2(column, row, current.sprite);
                if (horizontalMatches.Count >= 2)
                {
                    matchedTiles.UnionWith(horizontalMatches);
                    matchedTiles.Add(current);
                }

                List<SpriteRenderer> verticalMatches = FindRowMatchForTile2(column, row, current.sprite);
                if (verticalMatches.Count >= 2)
                {
                    matchedTiles.UnionWith(verticalMatches);
                    matchedTiles.Add(current);
                }
            }
        }

        foreach (SpriteRenderer renderer in matchedTiles)
        {
            //renderer.color = Color.red;
            print(renderer.name + "em match");
            renderer.sprite = null;
            bool hasmatch = matchedTiles.Count > 0;
        }

        return matchedTiles.Count > 0;
    }
    bool CheckandCountMatches2()
    {
        HashSet<SpriteRenderer> matchedTiles = new HashSet<SpriteRenderer>();
        for (int row = 0; row < GridDimension; row++)
        {
            for (int column = 0; column < GridDimension; column++)
            {
                SpriteRenderer current = GetSpriteRendererAt2(column, row);

                List<SpriteRenderer> horizontalMatches = FindColumnMatchForTile2(column, row, current.sprite);
                if (horizontalMatches.Count >= 2)
                {
                    matchedTiles.UnionWith(horizontalMatches);
                    matchedTiles.Add(current);
                }

                List<SpriteRenderer> verticalMatches = FindRowMatchForTile2(column, row, current.sprite);
                if (verticalMatches.Count >= 2)
                {
                    matchedTiles.UnionWith(verticalMatches);
                    matchedTiles.Add(current);
                }
            }
        }
        foreach (SpriteRenderer renderer in matchedTiles)
        {
            //renderer.color = Color.red;

            renderer.sprite = null;

            bool hasmatch = matchedTiles.Count > 0;
        }

        return matchedTiles.Count > 0;
    }
    List<SpriteRenderer> FindColumnMatchForTile2(int col, int row, Sprite sprite)
    {
        List<SpriteRenderer> result = new List<SpriteRenderer>();
        for (int i = col + 1; i < GridDimension; i++)
        {
            SpriteRenderer nextColumn = GetSpriteRendererAt2(i, row);
            if (nextColumn.sprite != sprite)
            {
                break;
            }
            result.Add(nextColumn);
        }
        return result;
    }

    List<SpriteRenderer> FindRowMatchForTile2(int col, int row, Sprite sprite)
    {
        List<SpriteRenderer> result = new List<SpriteRenderer>();
        for (int i = row + 1; i < GridDimension; i++)
        {
            SpriteRenderer nextRow = GetSpriteRendererAt2(col, i);
            if (nextRow.sprite != sprite)
            {
                break;
            }
            result.Add(nextRow);
        }
        return result;
    }
    void FillHoles2()
    {
        for (int column = 0; column < GridDimension; column++)
            for (int row = 0; row < GridDimension; row++)
            {
                if (GetSpriteRendererAt2(column, row).sprite == null)
                {
                    SpriteRenderer current = GetSpriteRendererAt2(column, row);


                    current.sprite = Sprites[Random.Range(0, Sprites.Count)];
                }
            }
    }
}

