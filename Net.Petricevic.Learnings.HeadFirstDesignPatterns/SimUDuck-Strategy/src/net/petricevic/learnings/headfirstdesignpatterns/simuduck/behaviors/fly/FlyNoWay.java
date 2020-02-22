package net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.fly;

public class FlyNoWay implements FlyBehavior
{
    @Override
    public String fly()
    {
        String fly = "I can't fly!";
        System.out.println(fly);
        return fly;
    }
}
