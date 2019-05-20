// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public partial class SteamVR_Input
    {
        
        public static SteamVR_Action_Boolean __actions_default_in_InteractUI;
        
        public static SteamVR_Action_Boolean __actions_default_in_Teleport;
        
        public static SteamVR_Action_Boolean __actions_default_in_GrabPinch;
        
        public static SteamVR_Action_Boolean __actions_default_in_GrabGrip;
        
        public static SteamVR_Action_Pose __actions_default_in_Pose;
        
        public static SteamVR_Action_Skeleton __actions_default_in_SkeletonLeftHand;
        
        public static SteamVR_Action_Skeleton __actions_default_in_SkeletonRightHand;
        
        public static SteamVR_Action_Single __actions_default_in_Squeeze;
        
        public static SteamVR_Action_Boolean __actions_default_in_VergroessernL;
        
        public static SteamVR_Action_Boolean __actions_default_in_VergroessernR;
        
        public static SteamVR_Action_Boolean __actions_default_in_BewegenL;
        
        public static SteamVR_Action_Boolean __actions_default_in_BewegenR;
        
        public static SteamVR_Action_Vector2 __actions_default_in_TrackpadPosL;
        
        public static SteamVR_Action_Boolean __actions_default_in_TrackpadTouchL;
        
        public static SteamVR_Action_Vector2 __actions_default_in_TrackpadPosR;
        
        public static SteamVR_Action_Boolean __actions_default_in_TrackpadTouchR;
        
        public static SteamVR_Action_Vector3 __actions_default_in_ScrollWheel;
        
        public static SteamVR_Action_Boolean __actions_default_in_ShowControllerUIL;
        
        public static SteamVR_Action_Boolean __actions_default_in_SelectPlanetR;
        
        public static SteamVR_Action_Boolean __actions_default_in_SelectPlanetL;
        
        public static SteamVR_Action_Boolean __actions_default_in_Back;
        
        public static SteamVR_Action_Vibration __actions_default_out_Haptic;
        
        public static void Dynamic_InitializeActions()
        {
            SteamVR_Input.__actions_default_in_InteractUI.Initialize();
            SteamVR_Input.__actions_default_in_Teleport.Initialize();
            SteamVR_Input.__actions_default_in_GrabPinch.Initialize();
            SteamVR_Input.__actions_default_in_GrabGrip.Initialize();
            SteamVR_Input.__actions_default_in_Pose.Initialize();
            SteamVR_Input.__actions_default_in_SkeletonLeftHand.Initialize();
            SteamVR_Input.__actions_default_in_SkeletonRightHand.Initialize();
            SteamVR_Input.__actions_default_in_Squeeze.Initialize();
            SteamVR_Input.__actions_default_in_VergroessernL.Initialize();
            SteamVR_Input.__actions_default_in_VergroessernR.Initialize();
            SteamVR_Input.__actions_default_in_BewegenL.Initialize();
            SteamVR_Input.__actions_default_in_BewegenR.Initialize();
            SteamVR_Input.__actions_default_in_TrackpadPosL.Initialize();
            SteamVR_Input.__actions_default_in_TrackpadTouchL.Initialize();
            SteamVR_Input.__actions_default_in_TrackpadPosR.Initialize();
            SteamVR_Input.__actions_default_in_TrackpadTouchR.Initialize();
            SteamVR_Input.__actions_default_in_ScrollWheel.Initialize();
            SteamVR_Input.__actions_default_in_ShowControllerUIL.Initialize();
            SteamVR_Input.__actions_default_in_SelectPlanetR.Initialize();
            SteamVR_Input.__actions_default_in_SelectPlanetL.Initialize();
            SteamVR_Input.__actions_default_in_Back.Initialize();
            SteamVR_Input.__actions_default_out_Haptic.Initialize();
        }
        
        public static void Dynamic_InitializeInstanceActions()
        {
            Valve.VR.SteamVR_Input.__actions_default_in_InteractUI = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_InteractUI")));
            Valve.VR.SteamVR_Input.__actions_default_in_Teleport = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_Teleport")));
            Valve.VR.SteamVR_Input.__actions_default_in_GrabPinch = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_GrabPinch")));
            Valve.VR.SteamVR_Input.__actions_default_in_GrabGrip = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_GrabGrip")));
            Valve.VR.SteamVR_Input.__actions_default_in_Pose = ((SteamVR_Action_Pose)(SteamVR_Input_References.GetAction("__actions_default_in_Pose")));
            Valve.VR.SteamVR_Input.__actions_default_in_SkeletonLeftHand = ((SteamVR_Action_Skeleton)(SteamVR_Input_References.GetAction("__actions_default_in_SkeletonLeftHand")));
            Valve.VR.SteamVR_Input.__actions_default_in_SkeletonRightHand = ((SteamVR_Action_Skeleton)(SteamVR_Input_References.GetAction("__actions_default_in_SkeletonRightHand")));
            Valve.VR.SteamVR_Input.__actions_default_in_Squeeze = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_default_in_Squeeze")));
            Valve.VR.SteamVR_Input.__actions_default_in_VergroessernL = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_VergroessernL")));
            Valve.VR.SteamVR_Input.__actions_default_in_VergroessernR = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_VergroessernR")));
            Valve.VR.SteamVR_Input.__actions_default_in_BewegenL = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_BewegenL")));
            Valve.VR.SteamVR_Input.__actions_default_in_BewegenR = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_BewegenR")));
            Valve.VR.SteamVR_Input.__actions_default_in_TrackpadPosL = ((SteamVR_Action_Vector2)(SteamVR_Input_References.GetAction("__actions_default_in_TrackpadPosL")));
            Valve.VR.SteamVR_Input.__actions_default_in_TrackpadTouchL = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_TrackpadTouchL")));
            Valve.VR.SteamVR_Input.__actions_default_in_TrackpadPosR = ((SteamVR_Action_Vector2)(SteamVR_Input_References.GetAction("__actions_default_in_TrackpadPosR")));
            Valve.VR.SteamVR_Input.__actions_default_in_TrackpadTouchR = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_TrackpadTouchR")));
            Valve.VR.SteamVR_Input.__actions_default_in_ScrollWheel = ((SteamVR_Action_Vector3)(SteamVR_Input_References.GetAction("__actions_default_in_ScrollWheel")));
            Valve.VR.SteamVR_Input.__actions_default_in_ShowControllerUIL = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_ShowControllerUIL")));
            Valve.VR.SteamVR_Input.__actions_default_in_SelectPlanetR = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_SelectPlanetR")));
            Valve.VR.SteamVR_Input.__actions_default_in_SelectPlanetL = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_SelectPlanetL")));
            Valve.VR.SteamVR_Input.__actions_default_in_Back = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_Back")));
            Valve.VR.SteamVR_Input.__actions_default_out_Haptic = ((SteamVR_Action_Vibration)(SteamVR_Input_References.GetAction("__actions_default_out_Haptic")));
            Valve.VR.SteamVR_Input.actions = new Valve.VR.SteamVR_Action[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_InteractUI,
                    Valve.VR.SteamVR_Input.__actions_default_in_Teleport,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabPinch,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabGrip,
                    Valve.VR.SteamVR_Input.__actions_default_in_Pose,
                    Valve.VR.SteamVR_Input.__actions_default_in_SkeletonLeftHand,
                    Valve.VR.SteamVR_Input.__actions_default_in_SkeletonRightHand,
                    Valve.VR.SteamVR_Input.__actions_default_in_Squeeze,
                    Valve.VR.SteamVR_Input.__actions_default_in_VergroessernL,
                    Valve.VR.SteamVR_Input.__actions_default_in_VergroessernR,
                    Valve.VR.SteamVR_Input.__actions_default_in_BewegenL,
                    Valve.VR.SteamVR_Input.__actions_default_in_BewegenR,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadPosL,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadTouchL,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadPosR,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadTouchR,
                    Valve.VR.SteamVR_Input.__actions_default_in_ScrollWheel,
                    Valve.VR.SteamVR_Input.__actions_default_in_ShowControllerUIL,
                    Valve.VR.SteamVR_Input.__actions_default_in_SelectPlanetR,
                    Valve.VR.SteamVR_Input.__actions_default_in_SelectPlanetL,
                    Valve.VR.SteamVR_Input.__actions_default_in_Back,
                    Valve.VR.SteamVR_Input.__actions_default_out_Haptic};
            Valve.VR.SteamVR_Input.actionsIn = new Valve.VR.SteamVR_Action_In[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_InteractUI,
                    Valve.VR.SteamVR_Input.__actions_default_in_Teleport,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabPinch,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabGrip,
                    Valve.VR.SteamVR_Input.__actions_default_in_Pose,
                    Valve.VR.SteamVR_Input.__actions_default_in_SkeletonLeftHand,
                    Valve.VR.SteamVR_Input.__actions_default_in_SkeletonRightHand,
                    Valve.VR.SteamVR_Input.__actions_default_in_Squeeze,
                    Valve.VR.SteamVR_Input.__actions_default_in_VergroessernL,
                    Valve.VR.SteamVR_Input.__actions_default_in_VergroessernR,
                    Valve.VR.SteamVR_Input.__actions_default_in_BewegenL,
                    Valve.VR.SteamVR_Input.__actions_default_in_BewegenR,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadPosL,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadTouchL,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadPosR,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadTouchR,
                    Valve.VR.SteamVR_Input.__actions_default_in_ScrollWheel,
                    Valve.VR.SteamVR_Input.__actions_default_in_ShowControllerUIL,
                    Valve.VR.SteamVR_Input.__actions_default_in_SelectPlanetR,
                    Valve.VR.SteamVR_Input.__actions_default_in_SelectPlanetL,
                    Valve.VR.SteamVR_Input.__actions_default_in_Back};
            Valve.VR.SteamVR_Input.actionsOut = new Valve.VR.SteamVR_Action_Out[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_out_Haptic};
            Valve.VR.SteamVR_Input.actionsVibration = new Valve.VR.SteamVR_Action_Vibration[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_out_Haptic};
            Valve.VR.SteamVR_Input.actionsPose = new Valve.VR.SteamVR_Action_Pose[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_Pose};
            Valve.VR.SteamVR_Input.actionsBoolean = new Valve.VR.SteamVR_Action_Boolean[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_InteractUI,
                    Valve.VR.SteamVR_Input.__actions_default_in_Teleport,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabPinch,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabGrip,
                    Valve.VR.SteamVR_Input.__actions_default_in_VergroessernL,
                    Valve.VR.SteamVR_Input.__actions_default_in_VergroessernR,
                    Valve.VR.SteamVR_Input.__actions_default_in_BewegenL,
                    Valve.VR.SteamVR_Input.__actions_default_in_BewegenR,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadTouchL,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadTouchR,
                    Valve.VR.SteamVR_Input.__actions_default_in_ShowControllerUIL,
                    Valve.VR.SteamVR_Input.__actions_default_in_SelectPlanetR,
                    Valve.VR.SteamVR_Input.__actions_default_in_SelectPlanetL,
                    Valve.VR.SteamVR_Input.__actions_default_in_Back};
            Valve.VR.SteamVR_Input.actionsSingle = new Valve.VR.SteamVR_Action_Single[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_Squeeze};
            Valve.VR.SteamVR_Input.actionsVector2 = new Valve.VR.SteamVR_Action_Vector2[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadPosL,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadPosR};
            Valve.VR.SteamVR_Input.actionsVector3 = new Valve.VR.SteamVR_Action_Vector3[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_ScrollWheel};
            Valve.VR.SteamVR_Input.actionsSkeleton = new Valve.VR.SteamVR_Action_Skeleton[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_SkeletonLeftHand,
                    Valve.VR.SteamVR_Input.__actions_default_in_SkeletonRightHand};
            Valve.VR.SteamVR_Input.actionsNonPoseNonSkeletonIn = new Valve.VR.SteamVR_Action_In[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_InteractUI,
                    Valve.VR.SteamVR_Input.__actions_default_in_Teleport,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabPinch,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabGrip,
                    Valve.VR.SteamVR_Input.__actions_default_in_Squeeze,
                    Valve.VR.SteamVR_Input.__actions_default_in_VergroessernL,
                    Valve.VR.SteamVR_Input.__actions_default_in_VergroessernR,
                    Valve.VR.SteamVR_Input.__actions_default_in_BewegenL,
                    Valve.VR.SteamVR_Input.__actions_default_in_BewegenR,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadPosL,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadTouchL,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadPosR,
                    Valve.VR.SteamVR_Input.__actions_default_in_TrackpadTouchR,
                    Valve.VR.SteamVR_Input.__actions_default_in_ScrollWheel,
                    Valve.VR.SteamVR_Input.__actions_default_in_ShowControllerUIL,
                    Valve.VR.SteamVR_Input.__actions_default_in_SelectPlanetR,
                    Valve.VR.SteamVR_Input.__actions_default_in_SelectPlanetL,
                    Valve.VR.SteamVR_Input.__actions_default_in_Back};
        }
    }
}