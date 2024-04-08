using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;

public class BasicAgents : MonoBehaviour
{
    public override void Initialize()
    {
        //Reset the agent when a episode begins
    }

    public override void OnEpisodeBegin()
    {
        //Reset environnement
        //Reset moves, agents
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        //interpret vectorAction in Unity
    }

    public override void CollectsObservations(VectorSensor sensor)
    {
        //Reset environnement
        //Reset moves, agents
    }
}
