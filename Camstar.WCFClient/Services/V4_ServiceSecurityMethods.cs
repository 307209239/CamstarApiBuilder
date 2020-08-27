// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.V4_ServiceSecurityMethods
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum V4_ServiceSecurityMethods
  {
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [Enumeration(null), EnumMember] LoadPermissionsGroup,
    [EnumMember, Enumeration(null)] LoadPermissionsUser,
    [EnumMember, Enumeration(null)] PermissionsCopy,
    [EnumMember, Enumeration(null)] Save,
    [EnumMember, Enumeration(null)] SavePermissionsGroup,
    [Enumeration(null), EnumMember] SavePermissionsUser,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
