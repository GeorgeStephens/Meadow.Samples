﻿using Meadow.Foundation.Motors;

namespace MeadowBleRover
{
    public class CarController
    {
        float SPEED = 1.00f;

        HBridgeMotor motorLeft;
        HBridgeMotor motorRight;

        public CarController(HBridgeMotor motorLeft, HBridgeMotor motorRight)
        {
            this.motorLeft = motorLeft;
            this.motorRight = motorRight;
        }

        public void Stop()
        {
            motorLeft.Power = 0f;
            motorRight.Power = 0f;
        }

        public void TurnLeft()
        {
            motorLeft.Power = SPEED;
            motorRight.Power = -SPEED;
        }

        public void TurnRight()
        {
            motorLeft.Power = -SPEED;
            motorRight.Power = SPEED;
        }

        public void MoveForward()
        {
            motorLeft.Power = -SPEED;
            motorRight.Power = -SPEED;
        }

        public void MoveBackward()
        {
            motorLeft.Power = SPEED;
            motorRight.Power = SPEED;
        }
    }
}