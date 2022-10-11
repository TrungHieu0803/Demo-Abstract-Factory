using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ta : IAnimalFactory
{
    public ICat CreateCat()
    {
        return new CatTa();
    }

    public IDog CreateDog()
    {
        return new DogTa();
    }
}
