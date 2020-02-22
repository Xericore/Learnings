package test.net.petrcevic.learnings.headfirstdesignpatterns.simuduck;

import net.petricevic.learnings.headfirstdesignpatterns.simuduck.ducks.MallardDuck;

import static org.junit.jupiter.api.Assertions.*;

class MallardDuckTest
{
    private MallardDuck mallardDuck;

    @org.junit.jupiter.api.BeforeEach
    void setUp()
    {
        mallardDuck = new MallardDuck();
    }

    @org.junit.jupiter.api.Test
    void given_MallardDuck_performFly_isFlying()
    {
        String result = mallardDuck.performFly();
        assertEquals(result, "Flying with my wings. Flap Flap.");
    }


    @org.junit.jupiter.api.Test
    void given_MallardDuck_performQuack_isQuacking()
    {
        String result = mallardDuck.performQuack();
        assertEquals(result, "Quack quack!");
    }
}