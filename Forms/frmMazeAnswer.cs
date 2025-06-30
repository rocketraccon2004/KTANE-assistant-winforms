﻿using System.Linq;
using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmMazeAnswer : Form
{
    private List<Maze.Coordinate> correctSpots;
    private Image downArrowImage = Image.FromFile("Resources/Maze/down arrow.png");

    private Image leftArrowImage = Image.FromFile("Resources/Maze/left arrow.png");
    private Image rightArrowImage = Image.FromFile("Resources/Maze/right arrow.png");
    private Image upArrowImage = Image.FromFile("Resources/Maze/up arrow.png");

    public frmMazeAnswer(List<Maze.Coordinate> correctSpots)
    {
        InitializeComponent();

        this.correctSpots = correctSpots;

        row1button1.Image = GetImage(0, 0);
        row1button2.Image = GetImage(0, 1);
        row1button3.Image = GetImage(0, 2);
        row1button4.Image = GetImage(0, 3);
        row1button5.Image = GetImage(0, 4);
        row1button6.Image = GetImage(0, 5);

        row2button1.Image = GetImage(1, 0);
        row2button2.Image = GetImage(1, 1);
        row2button3.Image = GetImage(1, 2);
        row2button4.Image = GetImage(1, 3);
        row2button5.Image = GetImage(1, 4);
        row2button6.Image = GetImage(1, 5);

        row3button1.Image = GetImage(2, 0);
        row3button2.Image = GetImage(2, 1);
        row3button3.Image = GetImage(2, 2);
        row3button4.Image = GetImage(2, 3);
        row3button5.Image = GetImage(2, 4);
        row3button6.Image = GetImage(2, 5);

        row4button1.Image = GetImage(3, 0);
        row4button2.Image = GetImage(3, 1);
        row4button3.Image = GetImage(3, 2);
        row4button4.Image = GetImage(3, 3);
        row4button5.Image = GetImage(3, 4);
        row4button6.Image = GetImage(3, 5);

        row5button1.Image = GetImage(4, 0);
        row5button2.Image = GetImage(4, 1);
        row5button3.Image = GetImage(4, 2);
        row5button4.Image = GetImage(4, 3);
        row5button5.Image = GetImage(4, 4);
        row5button6.Image = GetImage(4, 5);

        row6button1.Image = GetImage(5, 0);
        row6button2.Image = GetImage(5, 1);
        row6button3.Image = GetImage(5, 2);
        row6button4.Image = GetImage(5, 3);
        row6button4.Image = GetImage(5, 3);
        row6button5.Image = GetImage(5, 4);
        row6button6.Image = GetImage(5, 5);

        row1button1.BackColor = GetColor(0, 0);
        row1button2.BackColor = GetColor(0, 1);
        row1button3.BackColor = GetColor(0, 2);
        row1button4.BackColor = GetColor(0, 3);
        row1button5.BackColor = GetColor(0, 4);
        row1button6.BackColor = GetColor(0, 5);

        row2button1.BackColor = GetColor(1, 0);
        row2button2.BackColor = GetColor(1, 1);
        row2button3.BackColor = GetColor(1, 2);
        row2button4.BackColor = GetColor(1, 3);
        row2button5.BackColor = GetColor(1, 4);
        row2button6.BackColor = GetColor(1, 5);

        row3button1.BackColor = GetColor(2, 0);
        row3button2.BackColor = GetColor(2, 1);
        row3button3.BackColor = GetColor(2, 2);
        row3button4.BackColor = GetColor(2, 3);
        row3button5.BackColor = GetColor(2, 4);
        row3button6.BackColor = GetColor(2, 5);

        row4button1.BackColor = GetColor(3, 0);
        row4button2.BackColor = GetColor(3, 1);
        row4button3.BackColor = GetColor(3, 2);
        row4button4.BackColor = GetColor(3, 3);
        row4button5.BackColor = GetColor(3, 4);
        row4button6.BackColor = GetColor(3, 5);

        row5button1.BackColor = GetColor(4, 0);
        row5button2.BackColor = GetColor(4, 1);
        row5button3.BackColor = GetColor(4, 2);
        row5button4.BackColor = GetColor(4, 3);
        row5button5.BackColor = GetColor(4, 4);
        row5button6.BackColor = GetColor(4, 5);

        row6button1.BackColor = GetColor(5, 0);
        row6button2.BackColor = GetColor(5, 1);
        row6button3.BackColor = GetColor(5, 2);
        row6button4.BackColor = GetColor(5, 3);
        row6button4.BackColor = GetColor(5, 3);
        row6button5.BackColor = GetColor(5, 4);
        row6button6.BackColor = GetColor(5, 5);

        ControlBox = false;
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        Program.switchForm(Utils.getMainForm());
    }

    private Image GetImage(int row, int column)
    {
        for (var i = correctSpots.Count() - 2; i >= 0; i--)
            if (AreEqual(correctSpots[i], new Maze.Coordinate(row, column)))
            {
                if (
                    row != 5
                    && correctSpots[i].Row + 1 == correctSpots[i + 1].Row
                    && correctSpots[i].Column == correctSpots[i + 1].Column
                )
                    return downArrowImage;

                if (
                    row != 0
                    && correctSpots[i].Row - 1 == correctSpots[i + 1].Row
                    && correctSpots[i].Column == correctSpots[i + 1].Column
                )
                    return upArrowImage;

                if (
                    column != 5
                    && correctSpots[i].Column + 1 == correctSpots[i + 1].Column
                    && correctSpots[i].Row == correctSpots[i + 1].Row
                )
                    return rightArrowImage;

                if (
                    column != 0
                    && correctSpots[i].Column - 1 == correctSpots[i + 1].Column
                    && correctSpots[i].Row == correctSpots[i + 1].Row
                )
                    return leftArrowImage;
            }

        return null;
    }

    private Color GetColor(int row, int column)
    {
        if (AreEqual(correctSpots[0], new Maze.Coordinate(row, column))) return Color.White;

        if (AreEqual(correctSpots[correctSpots.Count - 1], new Maze.Coordinate(row, column))) return Color.Red;

        foreach (var pair in correctSpots)
            if (AreEqual(pair, new Maze.Coordinate(row, column)))
                return Color.Purple;

        return Color.Blue;
    }

    private bool AreEqual(Maze.Coordinate c1, Maze.Coordinate c2)
    {
        return c1.Row == c2.Row && c1.Column == c2.Column;
    }
}