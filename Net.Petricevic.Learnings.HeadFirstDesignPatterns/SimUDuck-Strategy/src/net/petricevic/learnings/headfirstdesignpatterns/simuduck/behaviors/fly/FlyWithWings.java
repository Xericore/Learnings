package net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.fly;

public class FlyWithWings implements FlyBehavior
{
    @Override
    public String fly()
    {
        String fly = "Flying with my wings. Flap Flap.";
        System.out.println(fly);
        return fly;
    }
}
