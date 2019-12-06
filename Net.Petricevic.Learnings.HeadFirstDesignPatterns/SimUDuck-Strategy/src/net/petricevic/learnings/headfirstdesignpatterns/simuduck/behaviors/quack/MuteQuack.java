package net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.quack;

public class MuteQuack implements QuackBehavior
{
    @Override
    public void quack()
    {
        System.out.println("... (silence)");
    }
}
