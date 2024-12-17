using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeInverter : MonoBehaviour
{
    public GameObject inversionPoint;
    public GameObject experimentMolecule;


    public void InvertMolecule()
    {
        foreach (Transform atom in experimentMolecule.transform)
        {
            Vector3 offset = atom.position - inversionPoint.transform.position;
            atom.position = inversionPoint.transform.position - offset;
        }
    }
}
