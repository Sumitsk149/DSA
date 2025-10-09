using System;
using System.Threading;

public class Foo {

    private AutoResetEvent secondEvent = new AutoResetEvent(false);
    private AutoResetEvent thirdEvent = new AutoResetEvent(false);

    public Foo() {
        
    }

    public void First(Action printFirst) 
    {
        printFirst();
        secondEvent.Set();
    }

    public void Second(Action printSecond) 
    {
        secondEvent.WaitOne();
        printSecond();
        thirdEvent.Set();
    }

    public void Third(Action printThird) 
    {        
        thirdEvent.WaitOne();
        printThird();
    }
}