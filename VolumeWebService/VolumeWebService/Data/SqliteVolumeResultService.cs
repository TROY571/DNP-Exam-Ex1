using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using VolumeWebService.Persistence;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Data
{
    public class SqliteVolumeResultService:IVolumeResultService
    {
        private VolumeDBContext volumeDbContext;

        public SqliteVolumeResultService()
        {
            volumeDbContext = new VolumeDBContext();
        }
        
        public async Task<IList<VolumeResult>> GetResultsAsync()
        {
            return await volumeDbContext.VolumeResults.ToListAsync();
        }

        public async Task<VolumeResult> AddResultAsync(VolumeResult result)
        {
            EntityEntry<VolumeResult> resultAdd = await volumeDbContext.VolumeResults.AddAsync(result);
            await volumeDbContext.SaveChangesAsync();
            return resultAdd.Entity;
        }

        public async Task RemoveVolumeResultAsync(int id)
        {
            VolumeResult resultremove = await volumeDbContext.VolumeResults.FirstAsync(result => result.id == id);
            if (resultremove != null)
            {
                volumeDbContext.VolumeResults.Remove(resultremove);
                await volumeDbContext.SaveChangesAsync();
            }
        }

        public async Task<double> CalculateVolumeCylinder(double height, double radius)
        {
            Calculator calculator = new Calculator();
            var res = calculator.CalculateVolumeCylinder(height, radius);
            return res;
        }

        public async Task<double> CalculateVolumeCone(double height, double radius)
        {
            Calculator calculator = new Calculator();
            var res = calculator.CalculateVolumeCylinder(height, radius);
            return res;
        }
    }
}