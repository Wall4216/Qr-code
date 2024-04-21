using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmirhanovExam.Models
{
    public partial class Menu
    {
        public string IngredientList
        {
            get
            {
                string result = "";
                
                    foreach (var menuIngredients in IngridientMenu)
                    {
                        if (menuIngredients != null && menuIngredients.Ingridients != null)
                        {
                            result += menuIngredients.Ingridients.Name + ", ";
                        }
                    }
                return result.TrimEnd(',', ' '); 
            }
        }
    }
}