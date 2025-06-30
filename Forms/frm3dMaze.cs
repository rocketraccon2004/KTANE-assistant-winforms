using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frm3dMaze : Form
{
    //if the user is currently facing a wall
    private bool facingWall;

    private frm3dMazeStage2 secondStage;

    public frm3dMaze()
    {
        InitializeComponent();
        UpdateForm();
    }

    public _3DMaze Module;

    public void UpdateForm()
    {
        mazeTextBox.Text = "";
        pathTextBox.Text = "";
        facingWallCheckBox.Checked = false;
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        var mazeText = mazeTextBox.Text.ToUpper();

        //maze can only have 3 letters
        if (mazeText.Length != 3)
        {
            Utils.throwError("Maze can only have 3 letters");
            return;
        }

        //make sure maze given is valid
        if (
            !(mazeText.Contains("A") && mazeText.Contains("B") && mazeText.Contains("C"))
            && !(mazeText.Contains("A") && mazeText.Contains("B") && mazeText.Contains("D"))
            && !(mazeText.Contains("A") && mazeText.Contains("B") && mazeText.Contains("H"))
            && !(mazeText.Contains("A") && mazeText.Contains("C") && mazeText.Contains("D"))
            && !(mazeText.Contains("A") && mazeText.Contains("C") && mazeText.Contains("H"))
            && !(mazeText.Contains("A") && mazeText.Contains("D") && mazeText.Contains("H"))
            && !(mazeText.Contains("B") && mazeText.Contains("C") && mazeText.Contains("D"))
            && !(mazeText.Contains("B") && mazeText.Contains("C") && mazeText.Contains("H"))
            && !(mazeText.Contains("B") && mazeText.Contains("D") && mazeText.Contains("H"))
            && !(mazeText.Contains("C") && mazeText.Contains("D") && mazeText.Contains("H"))
        )
            return;

        Module = new _3DMaze();

        Module.SetMaze(mazeText);

        //make sure user puts in valid path input

        var pathText = pathTextBox.Text.ToUpper();

        //can only put in the maze letters, *, ?, N, E, S, or W


        var mazeLetters = Module.mazeLetters;

        foreach (var c in pathText)
            if (
                c != '*'
                && c != '?'
                && c != 'N'
                && c != 'E'
                && c != 'S'
                && c != 'W'
                && c != mazeLetters[0]
                && c != mazeLetters[1]
                && c != mazeLetters[2]
            )
            {
                Utils.throwError("Path has at least one invalid character: " + c);
                return;
            }

        facingWall = facingWallCheckBox.Checked;

        var possiblePaths = ValidPathText(pathText, Module);

        if (possiblePaths.Count == 0)
        {
            Utils.throwError("Unable to find any paths");
            return;
        }

        if (possiblePaths.Count != 1)
        {
            Utils.throwError("Found multiple paths");
            return;
        }

        var playerPosition = possiblePaths[0];

        //update the player position
        Module.PlayerPosition = Module.Maze[playerPosition[0], playerPosition[1]];

        //update the player facing direction
        Module.PlayerDirection = Module.ConvertPlayerDirection(playerPosition[2]);

        //find how to get to the closest cardinal
        MessageBox.Show(Module.FindCardinal(false));

        Hide();

        secondStage = new frm3dMazeStage2(this);

        Program.switchForm(secondStage);
    }


    /// <summary>
    ///     Verifies is path is on current maze
    /// </summary>
    /// <param name="path">the path the user gave</param>
    /// <param name="module">the module</param>
    /// <returns>All of the possible paths</returns>
    private List<int[]> ValidPathText(string path, _3DMaze module)
    {
        var newPath = "";

        //convert all N, E, S, W to *
        for (var i = 0; i < path.Length; i++)
        {
            var c = path[i];

            if (c == 'N' || c == 'E' || c == 'S' || c == 'W')
                newPath += "*";
            //convert all ? to .
            else if (c == '?')
                newPath += ".";
            else
                newPath += c;
        }

        //find all possible places user ended up at

        //first digit: ending row (where the user is now)
        //second digit: ending column (where the user is now)
        //third digit: which direction the user is facing
        //0 - north
        //1 - east
        //2 - south
        //3 - west
        var possiblePaths = new List<int[]>();

        //find where user can start
        for (var row = 0; row < 8; row++)
            for (var col = 0; col < 8; col++)
                if (CharacterMatch(module.Maze[row, col], newPath[0]))
                {
                    //Pick a direction and continue to head in that direction for as many steps the user took
                    //and verify that all steps are corret
                    //North
                    if (NorthValid(newPath, row, col))
                    {
                        var newRow = row - (newPath.Length - 1);

                        while (newRow < 0) newRow += 8;

                        possiblePaths.Add(new int[] { newRow, col, 0 });
                    }

                    //East
                    if (EastValid(newPath, row, col))
                        possiblePaths.Add(
                            new int[3] { row, (col + (newPath.Length - 1)) % 8, 1 }
                        );

                    //South
                    if (SouthValid(newPath, row, col))
                        possiblePaths.Add(
                            new int[3] { (row + (newPath.Length - 1)) % 8, col, 2 }
                        );

                    //West
                    if (WestValid(newPath, row, col))
                    {
                        var newCol = col - (newPath.Length - 1);

                        while (newCol < 0) newCol += 8;

                        possiblePaths.Add(new int[3] { row, newCol, 3 });
                    }
                }

        //if one path can't be found, then path user gave was invalid
        return possiblePaths;
    }

    /// <summary>
    ///     Tells if node has the targeted caracter
    /// </summary>
    /// <param name="node"></param>
    /// <param name="target"></param>
    /// <returns>true if there is a match</returns>
    private bool CharacterMatch(_3DMaze.Node node, char target)
    {
        //if target is cardinal, return true if node is blank or has a cardinal
        if (target == '*' && node.Character == '.') return true;

        return node.Character == target;
    }

    /// <summary>
    ///     Tells if the user possibly went north
    /// </summary>
    /// <param name="path">the path the user went on</param>
    /// <param name="startingRow">the possible row the user started in</param>
    /// <param name="col">the possible column the user started in</param>
    /// <returns>true if this is a valid position of where the user is</returns>
    private bool NorthValid(string path, int startingRow, int col)
    {
        var neighbor = Module.Maze[startingRow, col];

        for (var i = 1; i < path.Length; i++)
        {
            neighbor = neighbor.North;

            //check if ther is a wall between the spaces
            if (neighbor == null) return false;

            //check to see if neighbor characters match
            if (!CharacterMatch(neighbor, path[i])) return false;
        }

        var facingWallNorth = neighbor.North == null;

        return facingWall == facingWallNorth;
    }

    private bool SouthValid(string path, int startingRow, int col)
    {
        var neighbor = Module.Maze[startingRow, col];

        for (var i = 1; i < path.Length; i++)
        {
            neighbor = neighbor.South;

            //check if ther is a wall between the spaces
            if (neighbor == null) return false;

            //check to see if next pair of characters match
            if (!CharacterMatch(neighbor, path[i])) return false;
        }

        var facingWallSouth = neighbor.South == null;

        return facingWall == facingWallSouth;
    }

    private bool EastValid(string path, int startingRow, int col)
    {
        var neighbor = Module.Maze[startingRow, col];

        for (var i = 1; i < path.Length; i++)
        {
            neighbor = neighbor.East;

            //check if ther is a wall between the spaces
            if (neighbor == null) return false;

            //check to see if next pair of characters match
            if (!CharacterMatch(neighbor, path[i])) return false;
        }

        var facingWallEast = neighbor.East == null;

        return facingWall == facingWallEast;
    }

    private bool WestValid(string path, int startingRow, int col)
    {
        var neighbor = Module.Maze[startingRow, col];

        for (var i = 1; i < path.Length; i++)
        {
            neighbor = neighbor.West;

            //check if ther is a wall between the spaces
            if (neighbor == null) return false;

            //check to see if next pair of characters match
            if (!CharacterMatch(neighbor, path[i])) return false;
        }

        var facingWallWest = neighbor.West == null;

        return facingWall == facingWallWest;
    }

    private void btnStrike_Click(object sender, EventArgs e)
    {
        Assistant.Instance.strikeButton(ModifierKeys.HasFlag(Keys.Shift));
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        Assistant.Instance.backButton();
    }
}