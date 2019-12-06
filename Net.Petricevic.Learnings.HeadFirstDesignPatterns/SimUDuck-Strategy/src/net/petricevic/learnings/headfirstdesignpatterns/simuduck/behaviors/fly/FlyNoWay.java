package net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.fly;

public class FlyNoWay implements FlyBehavior
{
    @Override
    public void fly()
    {
        System.out.println("I can't fly!");
    }
}
