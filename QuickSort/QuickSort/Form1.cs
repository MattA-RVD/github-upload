using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSort
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Pen pen;

        int recursionLevel = 0;
        int loopCount = 0;

        public Form1()
        {
            InitializeComponent();                     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly asm = Assembly.LoadFrom(@"\\fileserver\data\Office_IT\Matt\VB6DB\NotesDB.dll");
            RegistrationServices regAsm = new RegistrationServices();
            
            bool bResult = regAsm.RegisterAssembly(asm, AssemblyRegistrationFlags.SetCodeBase);
            MessageBox.Show(bResult.ToString());
            asm = Assembly.LoadFrom(@"\\fileserver\data\Office_IT\Matt\VB6DB\NotesVM.dll");
            bResult = regAsm.RegisterAssembly(asm, AssemblyRegistrationFlags.SetCodeBase);
            MessageBox.Show(bResult.ToString());

            //btnRefresh.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string[] strArray = txtInput.Text.Split(' ');
            List<int> intList = new List<int>();
            for (int i = 0; i < strArray.Length; i++)
            {
                intList.Add(int.Parse(strArray[i]));
            }

            Draw(intList, -1, -1, -1, -1);

            loopCount = 0;
            txtLoops.Text = loopCount.ToString();
            txtLoops.Refresh();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            string[] strArray = txtInput.Text.Split(' ');
            List<int> intList = new List<int>();
            for (int i = 0; i < strArray.Length; i++)
            {
                intList.Add(int.Parse(strArray[i]));
            }

            Random rng = new Random();
            int n = intList.Count();
            int value;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                value = intList[k];
                intList[k] = intList[n];
                intList[n] = value;
            }

            txtInput.Text = string.Join(" ", intList);
            Draw(intList, -1, -1, -1, -1);

            loopCount = 0;
            txtLoops.Text = loopCount.ToString();
            txtLoops.Refresh();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string[] strArray = txtInput.Text.Split(' ');

            //QuickSorter(strArray.ToList(), false);

            List<int> intList = new List<int>();
            for (int i = 0; i < strArray.Length; i++)
            {
                intList.Add(int.Parse(strArray[i]));
            }

            Draw(intList, -1, -1, -1, -1);
            if (radQS.Checked) QS(intList);
            if (radBS.Checked) BS(intList);
            Draw(intList, -1, -1, -1, -1);
        }

        private void QS(List<int> intList)
        {
            QS(intList, 0, intList.Count() - 1);
        }

        private void QS(List<int> intList, int StartPos, int EndPos)
        {
            recursionLevel += 1;
            txtRec.Text = recursionLevel.ToString();
            txtRec.Refresh();
            //System.Threading.Thread.Sleep(int.Parse(txtSleep.Text));

            if (StartPos >= EndPos)
            {
                recursionLevel -= 1;
                txtRec.Text = recursionLevel.ToString();
                txtRec.Refresh();
                //System.Threading.Thread.Sleep(int.Parse(txtSleep.Text));
                return;
            }

            int pivotPos = EndPos;
            int pivotValue = intList[pivotPos];
            int checkValue = 0;
            bool skipNext = false;           

            for (int i = StartPos; i < pivotPos; i++)
            {
                checkValue = intList[i];
                if (checkValue >= pivotValue)
                {
                    intList.RemoveAt(i);
                    intList.Insert(EndPos, checkValue);
                    txtInput.Text = string.Join(" ", intList);
                    txtInput.Refresh();
                    pivotPos--;

                    Draw(intList, EndPos, pivotPos, i, StartPos);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(int.Parse(txtSleep.Text));

                    i--;
                    skipNext = true;
                }
                else
                {
                    if (skipNext == false)
                    {
                        Draw(intList, EndPos, pivotPos, i, StartPos);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(int.Parse(txtSleep.Text));
                    }
                    skipNext = false;
                }

                loopCount += 1;
                txtLoops.Text = loopCount.ToString();
                txtLoops.Refresh();
            }

            //if (StartPos - (pivotPos - 1) < (pivotPos + 1) - EndPos)
            //{
            QS(intList, StartPos, pivotPos - 1);
            QS(intList, pivotPos + 1, EndPos);
            //}
            //else
            //{                
            //    QS(intList, pivotPos + 1, EndPos);
            //    QS(intList, StartPos, pivotPos - 1);
            //}

            recursionLevel -= 1;
            txtRec.Text = recursionLevel.ToString();
            txtRec.Refresh();
            //System.Threading.Thread.Sleep(int.Parse(txtSleep.Text));
        }

        private void QuickSorter(List<int> SortList)
        {
            QuickSorter(SortList, 0, SortList.Count() - 1);
        }

        private void QuickSorter(List<int> SortList, int StartPos, int EndPos)
        {
            if (StartPos >= EndPos) return;

            int pivotPos = EndPos;
            int pivotValue = SortList[pivotPos];
            int checkValue = 0;
            
            for (int i = StartPos; i < pivotPos; i++)
            {
                checkValue = SortList[i];
                if (checkValue > pivotValue)
                {
                    SortList.RemoveAt(i);
                    SortList.Insert(EndPos, checkValue);
                    pivotPos--;
                    i--;
                }
            }

            QuickSorter(SortList, StartPos, pivotPos - 1);
            QuickSorter(SortList, pivotPos + 1, EndPos);
        }

        private void QuickSorter(List<string> SortList, bool IgnoreCase)
        {
            QuickSorter(SortList, IgnoreCase, 0, SortList.Count() - 1);
        }

        private void QuickSorter(List<string> SortList, bool IgnoreCase, int StartPos, int EndPos)
        {
            if (StartPos >= EndPos) return;

            int pivotPos = EndPos;
            string pivotValue = SortList[pivotPos];
            string checkValue = "";
            
            for (int i = StartPos; i < pivotPos; i++)
            {
                checkValue = SortList[i];
                if (String.Compare(checkValue, pivotValue, IgnoreCase) > 0)
                {
                    SortList.RemoveAt(i);
                    SortList.Insert(EndPos, checkValue);
                    pivotPos--;
                    i--;

                    txtInput.Text = string.Join(" ", SortList);
                    txtInput.Refresh();
                    Application.DoEvents();
                }
            }

            QuickSorter(SortList, IgnoreCase, StartPos, pivotPos - 1);
            QuickSorter(SortList, IgnoreCase, pivotPos + 1, EndPos);
        }

        private void BS(List<int> intList)
        {
            bool sorted = false;
            int checkValue1 = 0;
            int checkValue2 = 0;
            while (sorted == false)
            {
                sorted = true;
                for (int i = 0; i < intList.Count() - 1; i++)
                {
                    checkValue1 = intList[i];
                    checkValue2 = intList[i + 1];
                    if (checkValue1 > checkValue2)
                    {
                        intList[i + 1] = checkValue1;
                        intList[i] = checkValue2;
                        sorted = false;

                        txtInput.Text = string.Join(" ", intList);
                        txtInput.Refresh();
                    }
                    Draw(intList, i + 1, -1, -1, i);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(int.Parse(txtSleep.Text));
                }
            }
            
        }

        private void Draw(List<int> intList, int endPos, int pivot, int checkPos, int startPos)
        {
            int startX = 10;
            int startY = 600;            

            bitmap = new Bitmap(this.Size.Width, this.Size.Height, this.CreateGraphics());
            graphics = Graphics.FromImage(bitmap);
            

            for (int i = 0; i < intList.Count(); i++)
            {
                if (i == pivot)
                    pen = new Pen(Color.Red, 3);
                else if (i == checkPos)
                    pen = new Pen(Color.White, 3);
                else if (i == endPos || i == startPos)
                    pen = new Pen(Color.Gray, 3);
                else
                    pen = new Pen(Color.Black, 1);

                graphics.DrawLine(pen, startX + i * 8, startY, startX + i * 8, startY - intList[i] * 2 - 10);                
            }
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (bitmap != null) e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
               
    }
}
