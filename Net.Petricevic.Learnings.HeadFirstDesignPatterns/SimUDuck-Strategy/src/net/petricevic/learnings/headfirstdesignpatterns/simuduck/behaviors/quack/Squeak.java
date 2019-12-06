package net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.quack;

public class Squeak implements QuackBehavior
{
    @Override
    public void quack()
    {
        System.out.println("Squeak!");
    }
}
