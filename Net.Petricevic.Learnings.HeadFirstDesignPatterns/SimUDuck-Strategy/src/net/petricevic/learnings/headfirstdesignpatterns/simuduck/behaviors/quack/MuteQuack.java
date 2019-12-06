package net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.quack;

public class MuteQuack implements QuackBehavior
{
    @Override
    public String quack()
    {
        String quack = "(silence)";
        System.out.println(quack);
        return quack;
    }
}
