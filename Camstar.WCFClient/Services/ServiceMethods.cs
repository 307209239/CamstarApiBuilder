// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ServiceMethods
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
  public enum ServiceMethods
  {
    [EnumMember, Enumeration(null)] AfterCommitEventFailure,
    [EnumMember, Enumeration(null)] CheckWIPMsgElapsedTime,
    [Enumeration(null), EnumMember] CheckWIPMsgRetrievalDate,
    [EnumMember, Enumeration(null)] ExportInfo_Execute,
    [EnumMember, Enumeration(null)] ExportInfo_Initialize,
    [Enumeration(null), EnumMember] ExportInfo_Initialize_User,
    [EnumMember, Enumeration(null)] ExportInfo_PreExecute,
    [Enumeration(null), EnumMember] ExportInfo_Validate,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [EnumMember, Enumeration(null)] LiveAlert_Initialize,
    [Enumeration(null), EnumMember] LiveConnect_Initialize,
    [EnumMember, Enumeration(null)] LiveRelay_Initialize,
    [EnumMember, Enumeration(null)] ProcessWIPMsgs,
    [EnumMember, Enumeration(null)] ValidateWIPMsgs,
    [Enumeration(null), EnumMember] VerifyUser,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
