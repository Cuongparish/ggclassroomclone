using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.Models;

namespace server.Interfaces
{
    public interface IStudentRepository
    {
        Task<HocSinh> CreateAsync(HocSinh studentModel);
        Task<HocSinh?> IsExistsAsync(int userId);
        Task<HocSinhLopHoc> CreateAsync(HocSinhLopHoc hocSinhLopHocModel);
        Task<List<HocSinhLopHoc>> GetLopIdAsync(int hocSinhId);
        Task<HocSinh?> GetHocSinhIdAsync(int userId);
        Task<List<HocSinhLopHoc>> GetAllHocSinhIdAsync(int lopId);
        Task<List<HocSinh?>> GetUserIdAsync(int[] hocsinhIds);
        Task<List<dynamic>> GetProfileIdAsync(int[] hocsinhIds);
        Task<HocSinh> UpdateStudentIdAsync(string fullName, int studentId);

    }
}