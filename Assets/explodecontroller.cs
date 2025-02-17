using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodecontroller : MonoBehaviour
{
    public Transform hull, pistons, grid, tubes;
    public Transform flaps, clamps, plates, turbine, flapRings, fins, containers, electronics, pipes, namePlates, bolts;

    private Vector3 hullOriginalPos, pistonsOriginalPos, gridOriginalPos, tubesOriginalPos;
    private Vector3 flapsOriginalPos, clampsOriginalPos, platesOriginalPos, turbineOriginalPos, flapRingsOriginalPos;
    private Vector3 finsOriginalPos, containersOriginalPos, electronicsOriginalPos, pipesOriginalPos, namePlatesOriginalPos, boltsOriginalPos;

    private Vector3 hullExplodedPos, pistonsExplodedPos, gridExplodedPos, tubesExplodedPos;
    private Vector3 flapsExplodedPos, clampsExplodedPos, platesExplodedPos, turbineExplodedPos, flapRingsExplodedPos;
    private Vector3 finsExplodedPos, containersExplodedPos, electronicsExplodedPos, pipesExplodedPos, namePlatesExplodedPos, boltsExplodedPos;

    private bool isExploded = false;

    void Start()
    {
        // Store original positions
        hullOriginalPos = hull.localPosition;
        pistonsOriginalPos = pistons.localPosition;
        gridOriginalPos = grid.localPosition;
        tubesOriginalPos = tubes.localPosition;

        flapsOriginalPos = flaps.localPosition;
        clampsOriginalPos = clamps.localPosition;
        platesOriginalPos = plates.localPosition;
        turbineOriginalPos = turbine.localPosition;
        flapRingsOriginalPos = flapRings.localPosition;
        finsOriginalPos = fins.localPosition;
        containersOriginalPos = containers.localPosition;
        electronicsOriginalPos = electronics.localPosition;
        pipesOriginalPos = pipes.localPosition;
        namePlatesOriginalPos = namePlates.localPosition;
        boltsOriginalPos = bolts.localPosition;

        // Define exploded positions (adjust these as needed)
        hullExplodedPos = hullOriginalPos + new Vector3(0, 0, -4);
        pistonsExplodedPos = pistonsOriginalPos + new Vector3(0, 7, 0);
        gridExplodedPos = gridOriginalPos + new Vector3(0, 0, 0);
        tubesExplodedPos = tubesOriginalPos + new Vector3(0, 0, 4);

        flapsExplodedPos = flapsOriginalPos + new Vector3(0, -7, 0);
        clampsExplodedPos = clampsOriginalPos + new Vector3(0, -2, 0);
        platesExplodedPos = platesOriginalPos + new Vector3(0, -5, 0);
        turbineExplodedPos = turbineOriginalPos + new Vector3(0, 7, 0);
        flapRingsExplodedPos = flapRingsOriginalPos + new Vector3(0, 0, 0);
        finsExplodedPos = finsOriginalPos + new Vector3(0, 6, 0);
        containersExplodedPos = containersOriginalPos + new Vector3(0, 6, 0);
        electronicsExplodedPos = electronicsOriginalPos + new Vector3(0, 0, 0);
        pipesExplodedPos = pipesOriginalPos + new Vector3(0, 6, 0);
        namePlatesExplodedPos = namePlatesOriginalPos + new Vector3(0, 0, 1);
        boltsExplodedPos = boltsOriginalPos + new Vector3(1, 1, 0);
    }

    public void ToggleExplode()
    {
        if (isExploded)
        {
            // Move parts back to their original positions
            hull.localPosition = hullOriginalPos;
            pistons.localPosition = pistonsOriginalPos;
            grid.localPosition = gridOriginalPos;
            tubes.localPosition = tubesOriginalPos;

            flaps.localPosition = flapsOriginalPos;
            clamps.localPosition = clampsOriginalPos;
            plates.localPosition = platesOriginalPos;
            turbine.localPosition = turbineOriginalPos;
            flapRings.localPosition = flapRingsOriginalPos;
            fins.localPosition = finsOriginalPos;
            containers.localPosition = containersOriginalPos;
            electronics.localPosition = electronicsOriginalPos;
            pipes.localPosition = pipesOriginalPos;
            namePlates.localPosition = namePlatesOriginalPos;
            bolts.localPosition = boltsOriginalPos;
        }
        else
        {
            // Move parts to their exploded positions
            hull.localPosition = hullExplodedPos;
            pistons.localPosition = pistonsExplodedPos;
            grid.localPosition = gridExplodedPos;
            tubes.localPosition = tubesExplodedPos;

            flaps.localPosition = flapsExplodedPos;
            clamps.localPosition = clampsExplodedPos;
            plates.localPosition = platesExplodedPos;
            turbine.localPosition = turbineExplodedPos;
            flapRings.localPosition = flapRingsExplodedPos;
            fins.localPosition = finsExplodedPos;
            containers.localPosition = containersExplodedPos;
            electronics.localPosition = electronicsExplodedPos;
            pipes.localPosition = pipesExplodedPos;
            namePlates.localPosition = namePlatesExplodedPos;
            bolts.localPosition = boltsExplodedPos;
        }

        isExploded = !isExploded; // Toggle the state
    }
}
