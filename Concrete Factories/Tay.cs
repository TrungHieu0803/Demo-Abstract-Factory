using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tay : IAnimalFactory
{
    // Start is called before the first frame update
    public ICat CreateCat()
    {
        return new CatTay();
    }

    public IDog CreateDog()
    {
        return new DogTay();
    }
}
