using ERPSystem.Animals;
using ERPSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystemTests.VetClinics
{
    /// <summary>
    /// Фиктивная реализация IVetClinic, всегда возвращающая false (болен).
    /// </summary>
    public class FakeVetClinicAlwaysUnhealthy : IVetClinic
    {
        public bool IsHealthy(Animal animal) => false;
    }
}
