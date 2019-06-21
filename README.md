# LINQ Language Integrated Query

    
```csharp
private List<PersonalInfo> listData = JSONReader.GetAll();

public List<PersonalInfo> SelectAll()
{
    var result = (from listObj in listData
                    select listObj).ToList();
    return result;
}
```
