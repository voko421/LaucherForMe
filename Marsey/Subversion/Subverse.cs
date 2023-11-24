using System.Collections.Generic;

namespace Marsey.Subversion;

public static class Subverse
{
    private static MarseyPatch? _subverter = null; 
    
    public static bool InitSubverter()
    {
        if (_subverter != null)
            return true;
        
        Subverter.LoadSubverts();
        List<MarseyPatch> patches = Subverter.GetSubverterPatches();
        foreach (MarseyPatch p in patches)
        {
            if (p.Name == "Subverter")
            {
                AssignSubverter(p);
                PatchAssemblyManager.InitLogger(patches);
                patches.RemoveAll(p => p.Name == "Subverter");
                return true;
            }
        }

        return false;
    }

    private static void AssignSubverter(MarseyPatch subverter)
    {
        _subverter = subverter;
    }

    public static void PatchSubverter()
    {
        if (_subverter != null) GameAssemblyManager.PatchProc(new List<MarseyPatch>() { _subverter });
    }
}