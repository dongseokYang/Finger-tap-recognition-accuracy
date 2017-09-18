using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingPractice
{
    public partial class Form1 : Form
    {

        public Form1() { InitializeComponent(); }
        private const int count = 10000;
        private int trueCount = 0;
        private DateTime timer;
        private List<Keys> KeyList;
        private List<Keys> forward;
        private List<Keys> backward;

        private Keys? pressedKey;
        private PictureBox[] pic_fingers;

        // Initialize
        private void Form1_Load(object sender, EventArgs e)
        {
            KeyList = new List<Keys>();
            for (int i = 'A'; i <= 'Z'; i++)
            {
                KeyList.Add((Keys)i);
            }
            KeyList.Add(Keys.Back);
            KeyList.Add(Keys.Return);
            KeyList.Add(Keys.Capital);
            KeyList.Add(Keys.Space);
            timer = DateTime.MaxValue;

            forward = new List<Keys>();
            backward = new List<Keys>();

            pic_fingers = new PictureBox[] { pic_finger0, pic_finger1, pic_finger2, pic_finger3, pic_finger4, pic_finger5 };
            pic_finger0.Parent = pic_hand;
            pic_finger1.Parent = pic_hand;
            pic_finger2.Parent = pic_hand;
            pic_finger3.Parent = pic_hand;
            pic_finger4.Parent = pic_hand;
            pic_finger5.Parent = pic_hand;
            pic_hand.Location = new Point(390, 180);

            Console.WriteLine("All keys: " + KeyList.Count);
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                Keys key = KeyList[r.Next(0, KeyList.Count)];
                if(i != 0)
                {
                    while(key == forward[i - 1])
                        key = KeyList[r.Next(0, KeyList.Count)];
                }
                forward.Add(key);
            }
            Console.WriteLine("Keys generated: " + count);
            UpdateUI();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if (key == Keys.Escape) btn_reset_Click(sender, e);
            if (!KeyList.Contains(key)) return;
            if (pressedKey != null) return;
            pressedKey = key;

            if (forward.Count == count) timer = DateTime.Now;

            if (key == forward[0])
            {
                trueCount++;
                pic_tf.Image = Properties.Resources.circle_true;
            }
            else
            {
                pic_tf.Image = Properties.Resources.circle_false;
            }
            backward.Add(forward[0]);
            forward.RemoveAt(0);

            UpdateUI();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e) { if (pressedKey == e.KeyCode) pressedKey = null; }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            trueCount = 0;
            timer = DateTime.MaxValue;
            forward = new List<Keys>();
            backward = new List<Keys>();
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                Keys key = KeyList[r.Next(0, KeyList.Count)];
                forward.Add(key);
            }
            UpdateUI();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update type/min
            double timeElapsed = ((double)((int)((DateTime.Now - timer).TotalSeconds * 10))) / 10;
            if (timeElapsed == 0) timeElapsed = 0.000000001;
            int typePerMin = (int)(trueCount / timeElapsed * 60);

            string s = "타속: " + typePerMin +
            " | 맞은 개수: " + trueCount +
            " | 틀린 개수: " + (backward.Count - trueCount);
            label_tpm.Text = s;
        }
        private void UpdateUI()
        {
            // Current item text
            string s = GetName(forward[0]);
            label_current.Text = s;

            // Forward items text
            s = "";
            for (int i = 1; i < forward.Count; i++)
            {
                if (i == 4) break;
                s += "▶  " + GetName(forward[i]) + "  ";
            }
            label_forward.Text = s;

            // Backward items text
            s = "";
            for (int i = backward.Count - 3; i < backward.Count; i++)
            {
                if (i < 0) continue;

                s += "  " + GetName(backward[i]) + "  ▶";
            }
            label_backward.Text = s;

            // True count text
            s = "정답: " + trueCount;
            label_true.Text = s;

            // False count text
            s = "오답: " + (backward.Count - trueCount);
            label_false.Text = s;

            // Key image
            int[] layer = keyMap[forward[0]];
            for (int i = 0; i < layer.Length; i++)
            {
                if (layer[i] == 0)
                {
                    pic_fingers[i].Image = Properties.Resources.circle_disable;
                }
                else if (layer[i] == 1)
                {
                    pic_fingers[i].Image = Properties.Resources.circle_enable;
                }
            }
        }


        private string GetName(Keys key)
        {
            if (key == Keys.Return)
                return "Enter";
            if (key == Keys.Capital)
                return "CapsLock";
            if (key == Keys.Back)
                return "Backspace";

            return Enum.GetName(typeof(Keys), key);
        }

        private readonly Dictionary<Keys, int[]> keyMap = new Dictionary<Keys, int[]>()
        {
            { Keys.A, new int[]{ 1, 0, 1, 0, 0, 0 } },
            { Keys.B, new int[]{ 1, 0, 0, 1, 0, 0 } },
            { Keys.C, new int[]{ 1, 0, 0, 0, 1, 0 } },
            { Keys.D, new int[]{ 1, 0, 0, 0, 0, 1 } },
            { Keys.E, new int[]{ 0, 1, 1, 0, 0, 0 } },
            { Keys.F, new int[]{ 0, 1, 0, 1, 0, 0 } },
            { Keys.G, new int[]{ 0, 1, 0, 0, 1, 0 } },
            { Keys.H, new int[]{ 0, 1, 0, 0, 0, 1 } },
            { Keys.I, new int[]{ 1, 0, 1, 1, 0, 0 } },
            { Keys.J, new int[]{ 1, 0, 0, 1, 1, 0 } },
            { Keys.K, new int[]{ 1, 0, 0, 0, 1, 1 } },
            { Keys.L, new int[]{ 0, 1, 1, 1, 0, 0 } },
            { Keys.M, new int[]{ 0, 1, 0, 1, 1, 0 } },
            { Keys.N, new int[]{ 0, 1, 0, 0, 1, 1 } },
            { Keys.O, new int[]{ 1, 0, 0, 0, 0, 0 } },
            { Keys.P, new int[]{ 0, 1, 0, 0, 0, 0 } },
            { Keys.Q, new int[]{ 0, 0, 1, 0, 0, 0 } },
            { Keys.R, new int[]{ 0, 0, 0, 1, 0, 0 } },
            { Keys.S, new int[]{ 0, 0, 0, 0, 1, 0 } },
            { Keys.T, new int[]{ 0, 0, 0, 0, 0, 1 } },
            { Keys.U, new int[]{ 0, 0, 1, 1, 0, 0 } },
            { Keys.V, new int[]{ 0, 0, 1, 0, 1, 0 } },
            { Keys.W, new int[]{ 0, 0, 1, 0, 0, 1 } },
            { Keys.X, new int[]{ 0, 0, 0, 1, 1, 0 } },
            { Keys.Y, new int[]{ 0, 0, 0, 1, 0, 1 } },
            { Keys.Z, new int[]{ 0, 0, 0, 0, 1, 1 } },
            { Keys.Back, new int[] { 0, 0, 1, 1, 1, 0 } },
            { Keys.Return, new int[] { 0, 0, 0, 1, 1, 1 } },
            { Keys.Capital, new int[] { 1, 0, 1, 1, 1, 0 } },
            { Keys.Space, new int[] { 0, 0, 1, 1, 1, 1 } },
        };
    }
}