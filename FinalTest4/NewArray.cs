using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest4
{
    public class NewArray
    {
        protected IOperation op;
        protected int[] arr;
        protected int length;
        protected int numOfPos;
        protected int numOfNeg;
        protected int avg;

        public NewArray(int[] a)
        {
            this.arr = a;
            this.length = a.Length;
            posNum(a);
            negNum(a);
            Avg(a);
        }

        private int Avg(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                this.avg += arr[i];

            return this.avg / arr.Length;
        }

        private void negNum(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < 0)
                    this.numOfNeg++;
        }

        private void posNum(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > 0)
                    this.numOfPos++;
        }

        public void Operate(int num)
        {
            switch (num)
            {
                case 1:
                    op = new SortArray();
                    op.Operate(this.arr);
                    break;
                case 2:
                    op = new MultBy2();
                    op.Operate(this.arr);
                    break;
            }
        }


    }
}
