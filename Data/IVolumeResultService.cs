using System.Collections.Generic;
using System.Threading.Tasks;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Data
{
    public interface IVolumeResultService
    {
        Task<IList<VolumeResult>> GetResultsAsync();
        Task<VolumeResult> AddResultAsync(VolumeResult result);
        Task RemoveVolumeResultAsync(int id);

        Task<double> CalculateVolumeCylinder(double height, double radius);

        Task<double> CalculateVolumeCone(double height, double radius);
        
        
    }
}