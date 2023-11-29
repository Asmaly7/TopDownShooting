using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class TopDownShooting : MonoBehaviour
{

    private TopDownCharacterController _contoller;

    [SerializeField] private Transform projectileSpawnPosition;
    private Vector2 _aimDirection = Vector2.right;

    public GameObject testPrefabs;

    private void Awake()
    {
        _contoller = GetComponent<TopDownCharacterController>();   
    }
    // Start is called before the first frame update
    void Start()
    {
        _contoller.OnAttackEvent += Onshoot;
        _contoller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        _aimDirection = newAimDirection;
    }

    private void Onshoot()
    {
        CreateProjectile();
    }

    private void CreateProjectile()
    {
        Instantiate(testPrefabs, projectileSpawnPosition.position,quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
