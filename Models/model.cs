using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Models;

public class ModelsClass3
{
    private readonly List<string> _items = new();

    public string Name { get; } = "ModelsClass3";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"ModelsClass3: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Models;

public class ModelsClass4
{
    private readonly List<string> _items = new();

    public string Name { get; } = "ModelsClass4";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"ModelsClass4: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Models;

public class ModelsClass5
{
    private readonly List<string> _items = new();

    public string Name { get; } = "ModelsClass5";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"ModelsClass5: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Models;

public class ModelsClass1
{
    private readonly List<string> _items = new();

    public string Name { get; } = "ModelsClass1";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"ModelsClass1: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Models;

public class ModelsClass2
{
    private readonly List<string> _items = new();

    public string Name { get; } = "ModelsClass2";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"ModelsClass2: {Count}";
    }
}
