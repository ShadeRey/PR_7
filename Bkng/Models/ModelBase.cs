using System;
using ReactiveUI;

namespace Bkng.Models;

public class ModelBase : ReactiveObject, ICloneable
{
    public virtual object Clone()
    {
        return new ModelBase();
    }
}