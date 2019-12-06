package net.petricevic.learnings.headfirstdesignpatterns.simuduck.ducks;

import net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.fly.FlyBehavior;
import net.petricevic.learnings.headfirstdesignpatterns.simuduck.behaviors.quack.QuackBehavior;

public abstract class Duck
{
    protected FlyBehavior flyBehavior;
    protected QuackBehavior quackBehavior;

    public String performQuack()
    {
        if (quackBehavior != null)
            return quackBehavior.quack();
        else
            System.out.println("quackBehavior is null.");

        return null;
    }

    public void swim()
    {
        System.out.println("Swimming like a duck does. All ducks float, even decoys.");
    }

    public abstract void display();

    public String performFly()
    {
        if (flyBehavior != null)
            return flyBehavior.fly();
        else
            System.out.println("flyBehavior is null.");

        return null;
    }
}
