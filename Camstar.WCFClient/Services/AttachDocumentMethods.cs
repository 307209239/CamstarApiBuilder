// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AttachDocumentMethods
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
  public enum AttachDocumentMethods
  {
    [EnumMember, Enumeration(null)] AttachDocument_CreateDoc,
    [Enumeration(null), EnumMember] AttachDocument_GetObjectInstance,
    [EnumMember, Enumeration(null)] AttachDocument_GetObjectType,
    [Enumeration(null), EnumMember] AttachDocument_ValidateNotAlreadyAttached,
    [EnumMember, Enumeration(null)] AttachDocument_Validations,
    [Enumeration(null), EnumMember] CreateParametricData,
    [EnumMember, Enumeration(null)] GetActions,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] MapLastActivityToContainer,
    [Enumeration(null), EnumMember] ProcessComputation,
    [EnumMember, Enumeration(null)] ResolveParametricData,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
