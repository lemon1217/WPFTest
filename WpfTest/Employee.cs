using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTest
{
    public class Employee
    {
        // 実装は外部から隠蔽(privateにしておく)
        private int id;
        public int Id
        {
            protected set { this.id = value; }
            get { return this.id; }
        }

        private string name;
        public string Name
        {
            protected set { this.name = value; }
            get { return this.name; }
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
