using RecipeBook.ServiceLibrary.Entities;
using RecipeBook.ServiceLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeMe.Api.BusinessLogic
{
    public class RecipeBusinessLogic
    {
        public void SaveRecipe(RecipeEntity recipeEntity)
        {
            var repository = new RecipeRepository();
            repository.SaveRecipeToDatabase(recipeEntity);
        }
    }
}
