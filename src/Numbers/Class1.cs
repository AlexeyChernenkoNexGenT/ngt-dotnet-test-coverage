using System;

namespace Numbers
{
    public class Class1
    {
        public int AddOrSubtract(int a, int b, bool branch) => branch ? a + b : a - b;

        public int MultiplyOfDivide(int a, int b, bool branch) => branch ? a * b : a / b;
    }
}
