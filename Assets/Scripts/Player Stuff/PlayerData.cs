using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "Player Data")]
public class PlayerData : ScriptableObject
{
    [Header("Stamina")]
    public float stamina;
    public float wallGrabStaminaDrain;
    public float wallJumpStaminaDrain;
    public float wallClimbStaminaDrain;
    public float waterStaminaDrain;
    public float staminaRegen;
    public float staminaMax;
    public float staminaMin;
    

    [Header("Gravity")]
    public float gravityScale;
    public float jumpGravityScale;
    public float fallGravityScale;
    public float minFallGravityScale;
    public float maxFallGravityScale;
    public float maxFallTimer;
    [Range(0f, 3)] public float maxFallTimerCap;
    public float forcedFallGravityScale;
    public float waterGravityScale;

    [Space]
    [Header("RayCast")]
    public float topRayCastLength;
    public Vector3 edgeRayCastOffset;
    public Vector3 innerRayCastOffset;

    [Header("Run")]
    public float defaultMoveSpeed;
    public float speed;
    public float runMaxSpeed;
    public float runAcceleration;
    public float groundLinearDrag;
    

    [Space]
    [Header("Jump")]
    public float defaultJumpPower;
    public float jumpPower;
    public float jumpCutPower;
    public float hangTimeCounter;
    public float jumpHangTimeThreshold;
    [Range(0f, 1)] public float jumpHangGravityMult;
    public float airLinearDrag;
    public float fallMultiplier;

    [Space]
    [Header("Wall Mechanics")]
    // wall slide
    public float wallSlidingSpeed;
    // Wall Jump
    public float wallJumpingDirection;
    public float wallJumpingTime;
    public float wallJumpingCounter;
    public float wallJumpingDuration;
    public Vector2 wallJumpingPower;
    // wall climb
    [Range(0.01f, 10f)] public float wallClimbingSpeedUp;
    [Range(0.01f, 10f)] public float wallClimbingSpeedDown;

    [Space]
    [Header("Power Ups")]
    // Move Speed
    public float moveSpeedTimer;
    public float moveSpeedTimerCap;
    public float moveSpeedIncrease;
    // Jump Boost
    public float jumpBoostTimer;
    public float jumpBoostTimerCap;
    public float jumpBoostIncrease;
    // Dash
    public float dashPower;
    public float dashTime;
    //public float dashCooldown;


    [Space]
    [Header("Assists")]
    [Range(0.01f, 0.5f)] public float coyoteTime; //Grace period after falling off a platform, where you can still jump
    public float coyoteTimeCounter;
    [Range(0.01f, 0.5f)] public float jumpBufferTime; //Grace period after pressing jump where a jump will be automatically performed once the requirements (eg. being grounded) are met.
    public float jumpBufferTimeCounter;

    private void OnValidate()
    {
        //moveSpeedIncrease = defaultMoveSpeed * 1.5f;

        //jumpBoostIncrease = defaultJumpPower * 1.3f;

        
    }

}