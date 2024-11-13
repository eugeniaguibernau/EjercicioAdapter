namespace Full_GRASP_And_SOLID;

public class Adaptador : TimerClient
{
    private Recipe recipe;

    public Adaptador(Recipe recipe)
    {
        this.recipe = recipe;
    }

    public void TimeOut()
    {
        recipe.SetCooked();
    }

}