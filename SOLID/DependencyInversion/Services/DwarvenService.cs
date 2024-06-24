using DependencyInversion.Interfaces;

namespace DependencyInversion.Services
{
    public class DwarvenService : IDwarvenService
    {
        private readonly IPickaxeService _pickaxeService;

        public DwarvenService(IPickaxeService pickaxeService)
        {
            _pickaxeService = pickaxeService;
        }

        public void DigDeeper(string dwarfName, bool hasPickaxe)
        {
            if (!hasPickaxe)
            {
                //AWFUL APPROACH
                var pickaxeService = new PickaxeService();
                pickaxeService.Dig();
            }

            if (!hasPickaxe)
            {
                //GOLDEN APPROACH
                _pickaxeService.Dig();
            }
        }
    }
}
