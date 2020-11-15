insert into [RecipesDB].[dbo].[Subcategory]
  (Name) values ('Healthy'),('Dairy Free'),('Baked Goods'),('Low Carb'),('Holiday Recipes'),('One Pan Meals'),('Ambitious Kitchen Favourites')

insert into [RecipesDB].[dbo].[Category]
(Name) values ('Breakfast'),('Lunch'),('Dinner'),('Dessert')


  insert into [RecipesDB].[dbo].[Ratings]
  (NumberOfRatings, Score, SumRatings) values (0,0.00,0)

  

   insert into [RecipesDB].[dbo].[Ingredients]
   (Name) values ('Pie Crust'),('Cherries'),('Cane Sugar'),('Flour'),('Amaretto'),('Butter'),('Almond Extract'),('Oats'),('Cornstarch'),('Brown Sugar')

  Insert into [RecipesDB].[dbo].[Recipe]
  (Name, Description, LongDescription, PictureLocation, RatingID, PrepTime, RatingID, PrepTime, CookTime)
  values ('The Best Tart Cherry Pie You’ll Ever Eat','Gorgeous dutch tart cherry pie with a wonderful, golden crumb topping. This homemade tart cherry pie recipe has a perfectly sweet filling with hints of amaretto and is absolutely delicious served with a scoop of vanilla ice cream. This will be the best tart cherry pie you’ll ever eat!','My mom absolutely LOVES cherry pie, as does Tony’s family, so 2-3 years ago I decided to make a tart cherry pie with a dutch topping crumble. Since then, I’ve spent the past few years tweaking the cherry pie recipe until I found that it was absolutely perfect.  So here it is in all its glory: from the butter pie crust, to the perfect cherry pie filling and dutch topping, this truly is the BEST cherry pie you’ll ever eat! PROMISE.  I hope you’ll give it a try and let me know how you like it. It’s well worth the effort.','/Content/Images/CherryPie.jpg',1 ,90 ,70)

    insert into [RecipesDB].[dbo].[SubcategoryRecipe]
  (SubcategoryID, RecipeID) values (3,1),(7,1)

    insert into [RecipesDB].[dbo].[CategoryRecipe] 
  (CategoryID, RecipeID) values (4,1)

  

   insert into [RecipesDB].[dbo].[IngredientsRecipe]
   (RecipeID,IngredientID,IngredientQuantity) values (1,1,'Check our recipe for'),(1,2,'6 cups frozen tart'),(1,3,'1 cup organic'),(1,4,'4 tablespoons'),(1,5,'1 tablespoon'),(1,6,'7 tablespoons'),(1,7,'1/2 teaspoon'),(1,8,'¼ cup rolled'),(1,9,'1 tablespoon'),(1,10,'½ cup packed')

   
  insert into [RecipesDB].[dbo].[Instructions]
  (RecipeID, InstructionText) values
  (1,'Make the pie dough and shape the crust in a pie pan ahead of time, then store covered in the fridge. You can follow my recipe for an all butter flaky pie crust, use your favorite recipe, or a store-bought crust.'),
  (1,'To make the tart cherry pie filling: add frozen tart cherries, sugar, cornstarch, flour and almond extract to a large pot and place over medium heat. After 5 minutes or so, the cherries will thaw, begin to break down and the sugar will melt. Stir frequently during this time. Add in butter and amaretto and continue to stir. After another 5-10 or so minutes, the mixture will begin to thicken and start to bubble along the edges. Once the filling begins to stick slightly to the back of your spoon, remove it from the heat and set aside to cool off.'),
  (1,'Preheat your oven to 350 degrees F.'),
  (1,'While your oven preheats, make the dutch crumble topping: in a medium bowl, mix together the flour, brown sugar and oats. Add in the melted butter and stir together with a fork until it begins to form into crumbles and resembles clumpy wet sand. You may need to use your hands/fingers to form into nice crumbles. Cover the bowl with plastic wrap and place in the fridge for 5 minutes or until ready to use.'),
  (1,'Remove pie pan with pie crust from the refrigerator and place pie pan onto a large baking sheet. I do this to avoid any spillage that may happen as the pie filling bubbles and bakes. Pour cooled tart cherry pie filling into the crust, then top filling with the dutch crumble topping.'), 
  (1,'Bake for 1 hour-1 hour 15 minutes or until the filling is very bubbly and the crumble is slightly golden brown. Check pie after 30 minutes to make sure the crust isn’t burning. If it is getting too golden brown, simply cover pie edges with foil or pie shield.'),
  (1,'Allow pie to cool on a wire rack until completely cooled before cutting into it (this is annoying, but if you cut into it before then the pie filling wont be set). The longer the pie rests, the easier it is to serve! Can be made a few days ahead of time. Pie is best served at room temp or just slightly warm. Serves 9. Great with vanilla bean ice cream. Enjoy!')