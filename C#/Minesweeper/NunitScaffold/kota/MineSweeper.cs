using System;

public class MineSweeper
{

   private const string MINE = "*";
   private string [,] _field;
   private int _rows;
   private int _columns;
    private readonly int _maxNumOfMines;
    private bool _gameLost;
   private bool _gameWon;
   private int _numOfMines;

   public MineSweeper(int rows, int columns, int maxNumOfMines)
   {

      _rows = rows;
      _columns = columns;
       _maxNumOfMines = maxNumOfMines;
       _field = BuildField();
   }

    public int length()
    {
        return _field.Length;
    }

    private string[,] BuildField()
    {
        return FillWithNumbers(PlaceMines());
    }

    private string[,] PlaceMines()
    {
        var field = new string[_rows, _columns];
        for (var x = 0; x < _rows; x++)
        {
            for (var y = 0; y < _columns; y++)
            {
                Random rand = new Random();

                if (rand.NextDouble() >= 0.5 && _numOfMines < _maxNumOfMines)
                {
                    AddMine(field, x, y);

                }
            }
        }
        return field;
    }

    private string[,] FillWithNumbers(string[,] field)
    {
        for (var x = 0; x < _rows; x++)
        {
            for (var y = 0; y < _columns; y++)
            {
                if (!IsMine(field[x, y]))
                    field[x, y] = HowManyMinesAround(field, x, y);
            }
        }
        return field;
    }

    public string HowManyMinesAround(string[,] field, int x, int y)
    {
        var count = 0;

        // n
        if (x - 1 >= 0)   
        {                
            if (IsMine(field[x - 1, y]))
                count++;
        }

        // ne
        if (x - 1 >= 0 && y + 1 < _columns) 
        {
            if (IsMine(field[x - 1, y+1]))
                count++;
        }

        // e
        if (y + 1 < _columns )   //0,0 0,1,
        {                 //1,0 1,1
            if (IsMine(field[x, y + 1]))
                count++;
        }

        // s

        // sw

        // w

        // nw


        return count.ToString();

    }

    private string[,] AddMine(string[,] field, int x, int y)
    {
        field[x, y] = MINE;
        _numOfMines++;
        return field;
    }

    public string Play(int x, int y){
     return _field[x,y];

   }

   public bool IsMine(string val){
       return val.Equals(MINE);
   }

}
