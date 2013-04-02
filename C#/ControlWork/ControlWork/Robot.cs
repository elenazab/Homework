using System;

namespace ControlWork
{
    class Robot
    {
        public Robot()
        {
            robot = new RealRobot();
        }

        public void vklMotor(int port, int mohsnost, char b)
        {
            if (b == 'B')
            {
                var str = b + port.ToString() + mohsnost.ToString();
                robot.poBlu(str);
            }

        }

        public void vyklMotor(int port, char b)
        {
            var str = b + port.ToString();
            if (b == 'B')
            {
                robot.poBlu(str);
            }
            else
                robot.poUsb(str);
        }

        public void SchitatDatchik(int port, char b)
        {
            var str = b + port.ToString();
            if (b == 'B')
            {
                robot.poBlu(str);
            }
            else
                robot.poUsb(str);
        }

        public void SchitatSchetchik(int port, char b)
        {
            var str = b + port.ToString();
            if (b == 'B')
            {
                robot.poBlu(str);
            }
            else
                robot.poUsb(str);
        }

        private RealRobot robot;
    }
}
