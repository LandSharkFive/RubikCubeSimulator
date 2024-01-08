
using System.Text;

namespace CubeOne
{
    public class Cube
    {
        // A cube is Face * Square. 6x9
        public char[] Color = new char[54];

        // The face order is front, right, back, left, up, down.
        //string FaceStr = "FRBLUD";

        const int FT = 0;
        const int RT = 1;
        const int BK = 2;
        const int LT = 3;
        const int UP = 4;
        const int DN = 5;

        // Opposite colors are Yellow-White, Green-Blue and Red-Orange.
        // Front is Green.  Left is Red.  Right is Orange.  Up is Yellow.  Down is White. Back is Blue.
        // The squares are numbered.  Front is 0 to 8.  Right is 9 to 17. Back is 18 to 26.
        // Left is 27 to 35.  Up is 36 to 44.  Down is 45 to 53.
        // The Square Index = (Face * 6) + (Row * 3) + Column.
        // The cube and face are zero-based.

        //   U
        // L F R
        //   D
        //   B
        //
        // Positions
        //
        //          36 37 38
        //          39 40 41
        //          42 43 44
        //
        // 27 28 29 00 01 02 09 10 11
        // 30 31 32 03 04 05 12 13 14
        // 33 34 35 06 07 08 15 16 17
        //
        //          45 46 47
        //          48 49 50
        //          51 52 53
        //
        //          18 19 20
        //          21 22 23
        //          24 25 26
        //

        public Cube()
        {
            for (int i = 0; i < Color.Length; i++)
            {
                string start = "RGYBOW";
                Color[i] = start[i / 9];
            }
        }

        public void FrontMove()
        {
            // clockwise
            swap(0, 2);
            swap(1, 5);
            swap(0, 8);
            swap(0, 6);
            swap(1, 3);
            swap(3, 7);

            // rotate clockwise
            swap(42, 9);
            swap(43, 12);
            swap(44, 15);
            swap(42, 35);
            swap(43, 32);
            swap(44, 29);
            swap(45, 29);
            swap(46, 32);
            swap(47, 35);
        }

        public void AntiFrontMove()
        {
            // anticlockwise
            swap(3, 7);
            swap(1, 3);
            swap(0, 6);
            swap(0, 8);
            swap(1, 5);
            swap(0, 2);

            // rotate anticlockwise
            swap(47, 35);
            swap(46, 32);
            swap(45, 29);
            swap(44, 29);
            swap(43, 32);
            swap(42, 35);
            swap(44, 15);
            swap(43, 12);
            swap(42, 9);
        }

        public void UpMove()
        {
            // clockwise
            swap(36, 38);
            swap(37, 41);
            swap(36, 44);
            swap(36, 42);
            swap(37, 39);
            swap(39, 43);

            // rotate clockwise
            swap(9, 26);
            swap(10, 25);
            swap(11, 24);
            swap(26, 27);
            swap(25, 28);
            swap(24, 29);
            swap(0, 27);
            swap(1, 28);
            swap(2, 29);
        }

        public void AntiUpMove()
        {
            // anticlockwise
            swap(39, 43);
            swap(37, 39);
            swap(36, 42);
            swap(36, 44);
            swap(37, 41);
            swap(36, 38);

            // rotate anticlockwise
            swap(2, 29);
            swap(1, 28);
            swap(0, 27);
            swap(24, 29);
            swap(25, 28);
            swap(26, 27);
            swap(11, 24);
            swap(10, 25);
            swap(9, 26);
        }

        public void DownMove()
        {
            // clockwise
            swap(45, 47);
            swap(46, 50);
            swap(45, 53);
            swap(45, 51);
            swap(46, 48);
            swap(48, 52);

            // rotate clockwise
            swap(8, 17);
            swap(7, 16);
            swap(6, 15);
            swap(6, 33);
            swap(7, 34);
            swap(8, 35);
            swap(18, 35);
            swap(19, 34);
            swap(20, 33);
        }

        public void AntiDownMove()
        {
            // anticlockwise
            swap(48, 52);
            swap(46, 48);
            swap(45, 51);
            swap(45, 53);
            swap(46, 50);
            swap(45, 47);

            // rotate anticlockwise
            swap(20, 33);
            swap(19, 34);
            swap(18, 35);
            swap(8, 35);
            swap(7, 34);
            swap(6, 33);
            swap(6, 15);
            swap(7, 16);
            swap(8, 17);
        }

        public void LeftMove()
        {
            // clockwise
            swap(27, 29);
            swap(28, 32);
            swap(27, 35);
            swap(27, 33);
            swap(28, 30);
            swap(30, 34);

            // rotate clockwise
            swap(0, 42);
            swap(3, 39);
            swap(6, 36);
            swap(18, 42);
            swap(21, 39);
            swap(24, 36);
            swap(24, 45);
            swap(21, 48);
            swap(18, 51);
        }

        public void AntiLeftMove()
        {
            // anticlockwise
            swap(30, 34);
            swap(28, 30);
            swap(27, 33);
            swap(27, 35);
            swap(28, 32);
            swap(27, 29);

            // rotate anticlockwise
            swap(18, 51);
            swap(21, 48);
            swap(24, 45);
            swap(24, 36);
            swap(21, 39);
            swap(18, 42);
            swap(6, 36);
            swap(3, 39);
            swap(0, 42);
        }

        public void RightMove()
        {
            // clockwise
            swap(9, 11);
            swap(10, 14);
            swap(9, 17);
            swap(9, 15);
            swap(10, 12);
            swap(12, 16);

            // rotate clockwise
            swap(20, 44);
            swap(23, 41);
            swap(26, 38);
            swap(2, 38);
            swap(5, 41);
            swap(8, 44);
            swap(2, 53);
            swap(5, 50);
            swap(8, 47);
        }

        public void AntiRightMove()
        {
            // anticlockwise
            swap(12, 16);
            swap(10, 12);
            swap(9, 15);
            swap(9, 17);
            swap(10, 14);
            swap(9, 11);

            // rotate anticlockwise
            swap(8, 47);
            swap(5, 50);
            swap(2, 53);
            swap(8, 44);
            swap(5, 41);
            swap(2, 38);
            swap(26, 38);
            swap(23, 41);
            swap(20, 44);
        }

        public void BackMove()
        {
            // clockwise
            swap(18, 20);
            swap(19, 23);
            swap(18, 26);
            swap(18, 24);
            swap(19, 21);
            swap(21, 25);

            // rotate clockwise
            swap(51, 17);
            swap(52, 14);
            swap(53, 11);
            swap(33, 53);
            swap(30, 52);
            swap(27, 51);
            swap(27, 38);
            swap(30, 37);
            swap(33, 36);
        }

        public void AntiBackMove()
        {
            // anticlockwise
            swap(21, 25);
            swap(19, 21);
            swap(18, 24);
            swap(18, 26);
            swap(19, 23);
            swap(18, 20);

            // rotate anticlockwise
            swap(27, 38);
            swap(30, 37);
            swap(33, 36);
            swap(27, 51);
            swap(30, 52);
            swap(33, 53);
            swap(53, 11);
            swap(52, 14);
            swap(51, 17);
        }

        // Rotate Squares Clockwise.
        public void ClockWise(int face)
        {
            // 0 1 2     6 3 0
            // 3 4 5     7 4 1
            // 6 7 8     8 5 2

            int k = face * 6;
            swap(k, k + 2);
            swap(k + 1, k + 5);
            swap(k, k + 8);
            swap(k, k + 6);
            swap(k + 1, k + 3);
            swap(k + 3, k + 7);
        }

        // Rotate Squares AntiClockwise.
        public void AntiClockWise(int face)
        {
            // 0 1 2     2 5 8
            // 3 4 5     1 4 7
            // 6 7 8     0 3 6

            int k = face * 6;
            swap(k + 3, k + 7);
            swap(k + 1, k + 3);
            swap(k, k + 6);
            swap(k, k + 8);
            swap(k + 1, k + 5);
            swap(k, k + 2);
        }

        public void swap(int a, int b)
        {
            char temp = Color[a];
            Color[a] = Color[b];
            Color[b] = temp;
        }

        public void Move(char ch)
        {
            switch (ch)
            {
                case 'D':
                    DownMove();
                    break;

                case 'F':
                    FrontMove();
                    break;

                case 'B':
                    BackMove();
                    break;

                case 'L':
                    LeftMove();
                    break;

                case 'R':
                    RightMove();
                    break;

                case 'U':
                    UpMove();
                    break;

                case 'd':
                    AntiDownMove();
                    break;

                case 'f':
                    AntiFrontMove();
                    break;

                case 'b':
                    AntiBackMove();
                    break;

                case 'l':
                    AntiLeftMove();
                    break;

                case 'r':
                    AntiRightMove();
                    break;

                case 'u':
                    AntiUpMove();
                    break;
            }
        }

        public void Move(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                Move(ch);
            }
        }

        // Print Vertical
        public void PrintVert()
        {
            for (int i = 0; i < Color.Length; i += 9)
            {
                Console.WriteLine(String.Concat(Color[i], Color[i + 1], Color[i + 2]));
                Console.WriteLine(String.Concat(Color[i + 3], Color[i + 4], Color[i + 5]));
                Console.WriteLine(String.Concat(Color[i + 6], Color[i + 7], Color[i + 8]));
                Console.WriteLine();
            }
        }

        public void PrintHoriz()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Concat(Color[0], Color[1], Color[2], ' '));
            sb.Append(String.Concat(Color[9], Color[10], Color[11], ' '));
            sb.Append(String.Concat(Color[18], Color[19], Color[20], ' '));
            sb.Append(String.Concat(Color[27], Color[28], Color[29], ' '));
            sb.Append(String.Concat(Color[36], Color[37], Color[38], ' '));
            sb.Append(String.Concat(Color[45], Color[46], Color[47], ' '));
            Console.WriteLine(sb.ToString());

            sb.Clear();
            sb.Append(String.Concat(Color[3], Color[4], Color[5], ' '));
            sb.Append(String.Concat(Color[12], Color[13], Color[14], ' '));
            sb.Append(String.Concat(Color[21], Color[22], Color[23], ' '));
            sb.Append(String.Concat(Color[30], Color[31], Color[32], ' '));
            sb.Append(String.Concat(Color[39], Color[40], Color[41], ' '));
            sb.Append(String.Concat(Color[48], Color[49], Color[50], ' '));
            Console.WriteLine(sb.ToString());

            sb.Clear();
            sb.Append(String.Concat(Color[6], Color[7], Color[8], ' '));
            sb.Append(String.Concat(Color[15], Color[16], Color[17], ' '));
            sb.Append(String.Concat(Color[24], Color[25], Color[26], ' '));
            sb.Append(String.Concat(Color[33], Color[34], Color[35], ' '));
            sb.Append(String.Concat(Color[42], Color[43], Color[44], ' '));
            sb.Append(String.Concat(Color[51], Color[52], Color[53], ' '));
            Console.WriteLine(sb.ToString());
            Console.WriteLine();
        }

        public void PrintCross()
        {
            //   U
            // L F R
            //   D
            //   B

            string space = "    ";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Concat(space, Color[36], Color[37], Color[38]));
            sb.AppendLine(String.Concat(space, Color[39], Color[40], Color[41]));
            sb.AppendLine(String.Concat(space, Color[42], Color[43], Color[44]));
            Console.WriteLine(sb.ToString());

            sb.Clear();
            sb.Append(String.Concat(Color[27], Color[28], Color[29], ' '));
            sb.Append(String.Concat(Color[0], Color[1], Color[2], ' '));
            sb.AppendLine(String.Concat(Color[9], Color[10], Color[11], ' '));
            sb.Append(String.Concat(Color[30], Color[31], Color[32], ' '));
            sb.Append(String.Concat(Color[3], Color[4], Color[5], ' '));
            sb.AppendLine(String.Concat(Color[12], Color[13], Color[14], ' '));
            sb.Append(String.Concat(Color[33], Color[34], Color[35], ' '));
            sb.Append(String.Concat(Color[6], Color[7], Color[8], ' '));
            sb.AppendLine(String.Concat(Color[15], Color[16], Color[17], ' '));
            Console.WriteLine(sb.ToString());

            sb.Clear();
            sb.AppendLine(String.Concat(space, Color[45], Color[46], Color[47]));
            sb.AppendLine(String.Concat(space, Color[48], Color[49], Color[50]));
            sb.AppendLine(String.Concat(space, Color[51], Color[52], Color[53]));
            Console.WriteLine(sb.ToString());

            sb.Clear();
            sb.AppendLine(String.Concat(space, Color[18], Color[19], Color[20]));
            sb.AppendLine(String.Concat(space, Color[21], Color[22], Color[23]));
            sb.AppendLine(String.Concat(space, Color[24], Color[25], Color[26]));
            Console.WriteLine(sb.ToString());
        }

        public void ShowPosition()
        {
            const string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqr";
            Color = text.ToCharArray();
        }

        public string? GetState()
        {
            return String.Concat(Color);
        }

        public void PrintState()
        {
            Console.WriteLine(String.Concat(Color));
        }

        // Print Map
        public void PrintMap()
        {
            //   U
            // L F R
            //   D
            //   B


            // UP
            string spacer = "         ";
            StringBuilder sb = new StringBuilder();
            sb.Append(spacer);
            sb.AppendLine("36 37 38");
            sb.Append(spacer);
            sb.AppendLine("39 40 41");
            sb.Append(spacer);
            sb.AppendLine("42 43 44");
            Console.WriteLine(sb.ToString());

            // LEFT FRONT RIGHT
            sb.Clear();
            sb.Append("27 28 29 ");
            sb.Append("00 01 02 ");
            sb.AppendLine("09 10 11");
            sb.Append("30 31 32 ");
            sb.Append("03 04 05 ");
            sb.AppendLine("12 13 14");
            sb.Append("33 34 35 ");
            sb.Append("06 07 08 ");
            sb.AppendLine("15 16 17");
            Console.WriteLine(sb.ToString());

            // DOWN
            sb.Clear();
            sb.Append(spacer);
            sb.AppendLine("45 46 47");
            sb.Append(spacer);
            sb.AppendLine("48 49 50");
            sb.Append(spacer);
            sb.AppendLine("51 52 53");
            Console.WriteLine(sb.ToString());

            // BOTTOM
            sb.Clear();
            sb.Append(spacer);
            sb.AppendLine("18 19 20");
            sb.Append(spacer);
            sb.AppendLine("21 22 23");
            sb.Append(spacer);
            sb.AppendLine("24 25 26");
            Console.WriteLine(sb.ToString());
        }

    }
}
