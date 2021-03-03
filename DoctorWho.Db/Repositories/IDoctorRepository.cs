using System;
using System.Collections.Generic;

namespace DoctorWho
{
    public interface IDoctorRepository
    {
        void AddDoctor(string name, int number, DateTime birsthdate, DateTime firsteps, DateTime lasteps);
        void DeleteDoctor(int id);
        List<Doctor> GetAllDoctors();
        void UpdateDoctor(int id, string name, int number, DateTime birsthdate, DateTime firsteps, DateTime lasteps);
    }
}