using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapController : MonoBehaviour
{
    public Vector2Int[] mapSize;
    public Vector2Int[] mapOrigin;
    public Tile[] tiles;

    //Mapas tienen que ser de 30 x 15

    private void Start()
    {
        //1. crear un objeto vacio
        GameObject grid = new GameObject();
        grid.name = "Grid";

        //2. Asignarle un componente Grid (un objeto Grid)
        grid.AddComponent<Grid>();


        //2.1. agregar un CellLayout y un CellSize especifico
        Grid isogrid = grid.GetComponent<Grid>();
        isogrid.cellLayout = GridLayout.CellLayout.Rectangle;
        isogrid.cellSize = new Vector3(1f, 1f, 1); //Aqui se define el tamaño de las celdas por pixel contando a 1 como 100

        //3.Crear un nuevo objeto tipo TileMap
        GameObject tilemap = new GameObject();
        tilemap.name = "TileMap";


        //4.Asignarle un componente TileMap y TilemapRenderer
        tilemap.AddComponent<Tilemap>();
        tilemap.AddComponent<TilemapRenderer>();

        //4.1
        TilemapRenderer TopR = tilemap.GetComponent<TilemapRenderer>();
        TopR.sortOrder = TilemapRenderer.SortOrder.TopRight;

        //5.Asignarle a tilemap el padre grid
        tilemap.transform.parent = grid.transform;

        Tilemap map = tilemap.GetComponent<Tilemap>();
        Rectangle00(map);
        Rectangle01(map);
        Rectangle02(map);
        Line00(map);
        Triangle00(map);
    }


    
    private void Rectangle00(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[0], mapSize[0], tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[0]);
    }
    private void Rectangle01(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[1], mapSize[1], tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[1]);
    }
    private void Rectangle02(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[2], mapSize[2], tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[2]);
    }
    private void Line00(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[3], mapSize[3], tilemap, Map.MapType.Line);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[3]);
    }
    private void Triangle00(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[4], mapSize[4], tilemap, Map.MapType.Triangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[4]);
    }

    /*
    private void Rectangle0(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[1], mapSize[1], tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[1]);

    }
    private void Triangle(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[3], mapSize[3], tilemap, Map.MapType.Triangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[3]);
    }
    private void Line(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[0], mapSize[0], tilemap, Map.MapType.Line);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[0]);
    }
    private void Circle(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[2], mapSize[2], tilemap, Map.MapType.Circle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[2]);
    }
    */
}
