


interface IPerson
{
    void Person();
}

interface IDriver : IPerson
{
    void Drive();
}


class Driver : IDriver
{
    void Person()
    {

    }

    void Drive()
    {

    }
}

