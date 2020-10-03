using System;

namespace Application
{
    public class Class1
    {
        private int categoria = 8;

        public string GetCategory()
        {
            string category = "";
            switch (categoria)
            {
                case 5:
                case 6:
                case 7:
                case 8:
                    category = "Junior";
                    break;

            }

            return category;
        }
    }
}
