package net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.quack;

public class Quack implements QuackBehavior
{
    @Override
    public String quack()
    {
        String quack = "Quack quack!";
        System.out.println(quack);
        return quack;
    }
}
