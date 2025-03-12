#pragma warning disable CS8618, CS9264
namespace KTANE_Assistant.Modules;

#nullable enable
public class Maze
{
    private List<string>? directionList;

    private bool goal;
    private int goalColumn;

    private int goalRow;
    private int markerColumn;

    private int markerRow;

    private char[,] maze;

    private int playerColumn;

    private int playerRow;
    private int startingGoalColumn;
    private int startingGoalRow;
    private int startingPlayerColumn;
    private int startingPlayerRow;
    private List<Coordinate> visitedNodes;

    public Maze(int playerRow, int playerColumn, int goalRow, int goalColumn, int markerRow, int markerColumn)
    {
        visitedNodes = new List<Coordinate>();
        startingPlayerRow = playerRow;
        startingPlayerColumn = playerColumn;

        startingGoalRow = goalRow;
        startingGoalColumn = goalColumn;

        this.markerRow = markerRow;
        this.markerColumn = markerColumn;

        SetUpModule();
    }

    public void SetUpModule()
    {
        if ((markerRow == 2 && markerColumn == 1) || (markerRow == 3 && markerColumn == 6))
        {
            maze = new[,]
            {
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else if ((markerRow == 2 && markerColumn == 5) || (markerRow == 4 && markerColumn == 2))
        {
            maze = new[,]
            {
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!'
                },
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else if ((markerRow == 4 && markerColumn == 4) || (markerRow == 4 && markerColumn == 6))
        {
            maze = new[,]
            {
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else if ((markerRow == 1 && markerColumn == 1) || (markerRow == 4 && markerColumn == 1))
        {
            maze = new[,]
            {
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }
            };
        }
        else if ((markerRow == 3 && markerColumn == 5) || (markerRow == 6 && markerColumn == 4))
        {
            maze = new[,]
            {
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!'
                },
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else if ((markerRow == 1 && markerColumn == 5) || (markerRow == 5 && markerColumn == 3))
        {
            maze = new[,]
            {
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!'
                },
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?'
                },
                {
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else if ((markerRow == 1 && markerColumn == 2) || (markerRow == 6 && markerColumn == 2))
        {
            maze = new[,]
            {
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                },
                {
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!'
                },
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else if ((markerRow == 1 && markerColumn == 4) || (markerRow == 4 && markerColumn == 3))
        {
            maze = new[,]
            {
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!'
                },
                {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!'
                },
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else
        {
            maze = new[,]
            {
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                },
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                },
                {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                },
                {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!'
                },
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }
            };
        }

        playerRow = ConvertCoordinate(startingPlayerRow);
        playerColumn = ConvertCoordinate(startingPlayerColumn);

        goalRow = ConvertCoordinate(startingGoalRow);
        goalColumn = ConvertCoordinate(startingGoalColumn);

        directionList = new List<string>();
    }

    public List<Coordinate>? Solve()
    {
        visitedNodes.Add(
            new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn))
        );

        if (MoveNorth() || MoveEast() || MoveSouth() || MoveWest())
        {
            directionList = SimplifyDirections();

            return visitedNodes;
        }

        Utils.throwError("Unable to find answer");
        return null;
    }

    private List<string> SimplifyDirections()
    {
        var finalDirections = new List<string>();

        while (directionList != null && directionList.Count != 0)
        {
            var counter = 0;
            var word = directionList[0];

            while (directionList.Count != 0 && word == directionList[0])
            {
                counter++;
                directionList.RemoveAt(0);
            }

            finalDirections.Add(word + " x" + counter);
        }

        return finalDirections;
    }

    private int ConvertCoordinate(int coordinate)
    {
        return coordinate + (coordinate - 2);
    }

    private int RevertCoordinate(int coordiante)
    {
        return coordiante / 2;
    }

    private bool MoveNorth()
    {
        if (
            playerRow > 0 &&
            maze[playerRow - 1, playerColumn] != '!' &&
            maze[playerRow - 2, playerColumn] == '?' &&
            directionList != null &&
            (directionList.Count == 0 || directionList[directionList.Count - 1] != "DOWN")
        )
        {
            playerRow -= 2;
            visitedNodes.Add(
                new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn))
            );

            directionList.Add("UP");

            if (AtGoal())
            {
                goal = true;
            }
            else
            {
                goal = MoveNorth();

                if (!goal)
                {
                    goal = MoveEast();

                    if (!goal) goal = MoveSouth();

                    if (!goal)
                    {
                        goal = MoveWest();

                        if (!goal)
                        {
                            maze[playerRow, playerColumn] = 'X';
                            if (playerRow == 0 && playerColumn == 10) Console.WriteLine();

                            RemoveCoordiante(
                                new Coordinate(
                                    RevertCoordinate(playerRow),
                                    RevertCoordinate(playerColumn)
                                )
                            );
                            playerRow += 2;
                            directionList.RemoveAt(directionList.Count - 1);
                        }
                    }
                }
            }
        }
        else
        {
            goal = false;
        }

        return goal;
    }

    private bool MoveEast()
    {
        if (
            playerColumn < 10 &&
            maze[playerRow, playerColumn + 1] != '!' &&
            maze[playerRow, playerColumn + 2] == '?' &&
            directionList != null &&
            (directionList.Count == 0 || directionList[directionList.Count - 1] != "LEFT")
        )
        {
            playerColumn += 2;
            visitedNodes.Add(
                new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn))
            );
            directionList.Add("RIGHT");

            if (AtGoal())
            {
                goal = true;
            }
            else
            {
                goal = MoveEast();

                if (!goal)
                {
                    goal = MoveSouth();

                    if (!goal)
                    {
                        goal = MoveWest();

                        if (!goal)
                        {
                            goal = MoveNorth();

                            if (!goal)
                            {
                                maze[playerRow, playerColumn] = 'X';
                                RemoveCoordiante(
                                    new Coordinate(
                                        RevertCoordinate(playerRow),
                                        RevertCoordinate(playerColumn)
                                    )
                                );
                                playerColumn -= 2;
                                directionList.RemoveAt(directionList.Count - 1);
                            }
                        }
                    }
                }
            }
        }
        else
        {
            goal = false;
        }

        return goal;
    }

    private bool MoveSouth()
    {
        if (
            playerRow < 10 &&
            maze[playerRow + 1, playerColumn] != '!' &&
            maze[playerRow + 2, playerColumn] == '?' &&
            directionList != null &&
            (directionList.Count == 0 || directionList[directionList.Count - 1] != "UP")
        )
        {
            directionList.Add("DOWN");

            playerRow += 2;
            visitedNodes.Add(
                new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn))
            );
            if (AtGoal())
            {
                goal = true;
            }
            else
            {
                goal = MoveSouth();

                if (!goal)
                {
                    goal = MoveWest();

                    if (!goal) goal = MoveNorth();

                    if (!goal)
                    {
                        goal = MoveEast();

                        if (!goal)
                        {
                            maze[playerRow, playerColumn] = 'X';
                            RemoveCoordiante(
                                new Coordinate(
                                    RevertCoordinate(playerRow),
                                    RevertCoordinate(playerColumn)
                                )
                            );
                            playerRow -= 2;
                            directionList.RemoveAt(directionList.Count - 1);
                        }
                    }
                }
            }
        }
        else
        {
            goal = false;
        }

        return goal;
    }

    private bool MoveWest()
    {
        if (
            playerColumn > 0 &&
            maze[playerRow, playerColumn - 1] != '!' &&
            maze[playerRow, playerColumn - 2] == '?' &&
            directionList != null &&
            (directionList.Count == 0 || directionList[directionList.Count - 1] != "RIGHT")
        )
        {
            playerColumn -= 2;
            visitedNodes.Add(
                new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn))
            );
            directionList.Add("LEFT");

            if (AtGoal())
            {
                goal = true;
            }
            else
            {
                goal = MoveWest();

                if (!goal)
                {
                    goal = MoveNorth();

                    if (!goal)
                    {
                        goal = MoveEast();

                        if (!goal)
                        {
                            goal = MoveSouth();

                            if (!goal)
                            {
                                maze[playerRow, playerColumn] = 'X';
                                RemoveCoordiante(
                                    new Coordinate(
                                        RevertCoordinate(playerRow),
                                        RevertCoordinate(playerColumn)
                                    )
                                );
                                playerColumn += 2;
                                directionList.RemoveAt(directionList.Count - 1);
                            }
                        }
                    }
                }
            }
        }
        else
        {
            goal = false;
        }

        return goal;
    }

    private bool AtGoal()
    {
        return playerRow == goalRow && playerColumn == goalColumn;
    }

    private void RemoveCoordiante(Coordinate coordianate)
    {
        for (var i = 0; i < visitedNodes.Count; i++)
            if (
                visitedNodes[i].Row == coordianate.Row &&
                visitedNodes[i].Column == coordianate.Column
            )
            {
                visitedNodes.RemoveAt(i);
                return;
            }
    }

    public class Coordinate(int row, int column)
    {
        public int Row { get; set; } = row;

        public int Column { get; set; } = column;
    }
}