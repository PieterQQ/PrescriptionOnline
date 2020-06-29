using PrescriptionOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrescriptionOnline
{
    public static class TemporaryDatabase
    {
        public static List<DoctorViewModel> Doctors { get; set; } = new List<DoctorViewModel>
        {
            new DoctorViewModel
            {
                Name="Mariusz",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name="Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name="Apap"
                            },
                            new MedicineViewModel
                            {
                                Name="Ibuprom"
                            }
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name="Recepta 2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name="Magnezz"
                            },
                            new MedicineViewModel
                            {
                                Name="Żelazo"
                            }
                        }
                    }
                }

            },
             new DoctorViewModel
            {
                Name="Karol",
                 Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name="Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name="Apap"
                            },
                            new MedicineViewModel
                            {
                                Name="Ibuprom"
                            }
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name="Recepta 2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name="Magnez"
                            },
                            new MedicineViewModel
                            {
                                Name="Żelazo"
                            }
                        }
                    }
                }
            },

              new DoctorViewModel
            {
                Name="Patryk",
                 Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name="Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name="Test Lek"
                            },
                            new MedicineViewModel
                            {
                                Name="Ibuprom"
                            }
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name="Recepta 2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name="Magnez"
                            },
                            new MedicineViewModel
                            {
                                Name="Żelazo"
                            }
                        }
                    }
                }
            }
        };
    }
}
