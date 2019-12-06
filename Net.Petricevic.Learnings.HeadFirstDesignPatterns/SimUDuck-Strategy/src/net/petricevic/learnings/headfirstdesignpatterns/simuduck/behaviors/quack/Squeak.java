package net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.quack;

public class Squeak implements QuackBehavior
{
    @Override
    public String quack()
    {
        String quack = "Squeak";
        System.out.println(quack);
        return quack;
    }
}
