using System.ComponentModel;

namespace PracticeApi.Models
{
    public enum UnitOfMeasurement
    {

        [Description("UN")]
        Unity = 1,

        [Description("MG")]
        Miligram = 2,

        [Description("G")]
        Gram = 3,

        [Description("L")]
        Liter = 4,

        [Description("KG")]
        KiloGram = 5,
    }
}