using System;
using System.Collections.Generic;

public class ParticleTypeFactory
{
    private readonly Dictionary<string, IParticleType> _types = new Dictionary<string, IParticleType>();
    public int TotalTypesCreated { get; private set; }

    public IParticleType GetParticleType(string color, string sprite, int size)
    {
        string key = $"{color}-{sprite}-{size}";

        if (!_types.ContainsKey(key))
        {
            _types[key] = new ParticleType(color, sprite, size);
            TotalTypesCreated++;
        }

        return _types[key];
    }
}