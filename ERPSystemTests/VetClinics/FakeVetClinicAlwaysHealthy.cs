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
    /// Фиктивная реализация IVetClinic, всегда возвращающая true (здоров).
    /// </summary>
    public class FakeVetClinicAlwaysHealthy : IVetClinic
    {
        public bool IsHealthy(Animal animal) => true;
    }
}
