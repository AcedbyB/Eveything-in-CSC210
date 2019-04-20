using System;

namespace FinalProject.Models {
    public class Game {
        public int numplayer = 0;
        public int winner = 0;
        public string id;
        public int pongX = 400, pongY = 400;
        public int time = 0;
        public Paddle[] paddle = new Paddle[3];

        public Game () {
            paddle[1] = new Paddle (1);
            paddle[2] = new Paddle (0);
        }

        public void calculate () {
            // Console.WriteLine(paddle[1].occupied);
            // Console.WriteLine(paddle[2].occupied);
            // Console.WriteLine(restart);
            if (paddle[1].occupied == "" || paddle[2].occupied == "" || numplayer < 2) return;
            pongX += Constants.pongVx;
            pongY += Constants.pongVy;

            if (pongY > Constants.mapHeight || pongY < 0) {
                numplayer = -1;
                if(paddle[1].occupied == "afk") paddle[1].occupied = "";
                if(paddle[2].occupied == "afk") paddle[2].occupied = "";
                if(pongY > Constants.mapHeight) {
                    winner = 2;
                }
                else winner = 1;
            }

            if (pongX <= Constants.pongSize / 2 + 1 || pongX >= Constants.mapWidth - (Constants.pongSize / 2 + 1)) {
                Constants.pongVx *= -1;
            }

            if (pongY > Constants.upperPaddle + Constants.paddleHeight && pongY < Constants.upperPaddle + Constants.paddleHeight + Constants.pongSize / 2 - 10) {
                if (paddle[2].gotThis (pongX)) {
                    Constants.pongVy *= -1;
                }
            }

            if (pongY > Constants.lowerPaddle - Constants.paddleHeight - (Constants.pongSize / 2 + 1) + 10 && pongY < Constants.lowerPaddle - Constants.paddleHeight) {
                if (paddle[1].gotThis (pongX)) {
                    Constants.pongVy *= -1;
                }
            }
        }

        public void reset () {
            pongX = 400;
            pongY = 400;
            paddle[1] = new Paddle (1);
            paddle[2] = new Paddle (0);
            Constants.pongVy = -3;
            time = 0;
        }

    }

}