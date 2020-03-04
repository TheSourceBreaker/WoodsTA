using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour
{
    public int playerHealth;
    public string currentRoute;
    public string nextRoute;
    public int area;

    decision normalRoute;
    decision saveRoute;
    decision deathRoute;
    
    void Update()
    {
        //loop through decision maker
        if (playerHealth == 0)
        {
            //player died
        }
    }
}


public interface decision
{
    decision makeDecision();
}

public class NormalWay
{
    int value;
    decision normalRoute;
    decision saveRoute;
    decision deathRoute;

    public NormalWay(decision normalRoute, decision saveRoute, decision deathRoute)
    {
        //if player chooses a route that is under the category "NormalWay"
        //value = 1 and normalRoute = true
        //else if player chooses a route that is under the category "SaveRoute"
        //value = 2 and saveRoute = true
        //else if player chooses a route that is under the category "DeathRoute"
        //value = 3 and deathRoute = true
    }

    decision makeDecision()
    {
        //value = 1 and normalRoute = true
        //value = 3 and saveRoute = true
        //value = 2 and deathRoute = true
        return null;
    }
}

public class SavePoint
{
    Story story;

    public SavePoint(Story _story)
    {
        story = _story;
    }

    decision makeDecision()
    {
        //override existing text file with new data
        System.IO.StreamWriter file = new System.IO.StreamWriter(@"woods");



        return null;
    }
}

public class DeathWay
{
    Story story;

    public DeathWay(Story _story)
    {
        story = _story;
    }
    decision makeDecision()
    {
        //this would check the route and area, then give out the appropriate death
        return null;
    }
}
