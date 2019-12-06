package net.petricevic.learnings.headfirstdesignpatterns.simuduck.ducks;

import net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.fly.FlyWithWings;
import net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.quack.Quack;

public class MallardDuck extends Duck
{
    public MallardDuck()
    {
        quackBehavior = new Quack();
        flyBehavior = new FlyWithWings();
    }

    public void display()
    {
        System.out.println("I am a real Mallard duck.");
    }
}
