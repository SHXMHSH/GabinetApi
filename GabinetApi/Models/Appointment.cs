using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace GabinetApi.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

    }
}
