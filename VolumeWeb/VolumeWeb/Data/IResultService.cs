using System.Collections.Generic;
using System.Threading.Tasks;
using VolumeWebService.VolumeCalculator;

namespace VolumeWeb.Data
{
    public interface IResultService
    {
        Task<IList<VolumeResult>> GetResultsAsync();
        
        Task AddResultAsync(VolumeResult result);
        
        Task RemoveVolumeResultAsync(int id);

        Task CalculateVolumeCylinder(double height, double radius);

        Task CalculateVolumeCone(double height, double radius);
    }
}