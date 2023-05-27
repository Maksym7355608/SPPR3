using System.ComponentModel;

namespace SPPR3;

public class House
{
    public string Id { get; set; }
    /// <summary>
    /// EPrice
    /// </summary>
    public int Price { get; set; }
    /// <summary>
    /// ESize
    /// </summary>
    public int Size { get; set; }
    /// <summary>
    /// ECondition
    /// </summary>
    public int Condition { get; set; }
    /// <summary>
    /// EDistance
    /// </summary>
    public int DistanceToCityCenter { get; set; }
}

public static class EnumHelper
{
    public static string GetDescription(this Enum value)
    {
        var type = value.GetType();
        var name = Enum.GetName(type, value);

        var field = type.GetField(name);
        if (name != null)
        {
            if (field != null)
            {
                if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    return attribute.Description;
                }
            }
        }

        return value.ToString();
    }
}

public enum EPrice
{
    [Description("Expensive cost")] 
    Expensive = 0,
    [Description("Cheap cost")] 
    Cheap = 1,
}
public enum ESize
{
    [Description("Small")]
    Small = 0,
    [Description("Medium")]
    Medium = 1,
    [Description("Big")]
    Big = 2,
}

public enum EDistance
{
    [Description("Out of the city")]
    OutCity = 0,
    [Description("Far into center")]
    Far = 1,
    [Description("Near center")]
    Near = 2,
    [Description("In center")]
    InCenter = 3
}

public enum ECondition
{
    [Description("Need capital repair")]
    NeedCapitalRepair = 0,
    [Description("Need minimal repair")]
    NeedMinimalRepair = 1,
    [Description("Euro repair")]
    EuroRepair = 2
}