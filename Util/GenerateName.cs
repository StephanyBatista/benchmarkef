using System.Collections.Generic;

namespace benchmarkef.Util
{
    public static class GenerateName
    {
        private static int _productIndex = 0;
        private static List<string> _productsName = new List<string>{
            "TV",
            "Pencil",
            "Box",
            "Home",
            "Mobile",
            "Water"
        };

        private static int _categoryIndex = 0;
        private static List<string> _categoriesName = new List<string>{
            "Fictional",
            "Games",
            "Historical",
            "Labraries",
            "Cameras",
            "Places"
        };

        public static string NextProductName(){

            _productIndex++;
            if(_productIndex == 6)
                _productIndex = 0;

            return _productsName[_productIndex];
        }

        public static string NextCategoryName(){

            _categoryIndex++;
            if(_categoryIndex == 6)
                _categoryIndex = 0;

            return _categoriesName[_categoryIndex];
        }
    }
}