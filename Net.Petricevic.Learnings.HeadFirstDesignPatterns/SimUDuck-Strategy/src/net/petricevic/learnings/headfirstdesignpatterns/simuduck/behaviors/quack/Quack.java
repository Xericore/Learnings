package net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.quack;

public class Quack implements QuackBehavior
{
    @Override
    public void quack()
    {
        System.out.println("Quack quack!");
    }
}
