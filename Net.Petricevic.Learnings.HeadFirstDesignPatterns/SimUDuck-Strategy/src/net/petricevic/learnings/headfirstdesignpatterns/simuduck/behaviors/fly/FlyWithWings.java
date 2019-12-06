package net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.fly;

public class FlyWithWings implements FlyBehavior
{
    @Override
    public void fly()
    {
        System.out.println("Flying with my wings. Flap Flap.");
    }
}
