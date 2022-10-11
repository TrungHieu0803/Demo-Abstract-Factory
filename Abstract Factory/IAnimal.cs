using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnimalFactory 
{
    IDog CreateDog();

    ICat CreateCat();
}
