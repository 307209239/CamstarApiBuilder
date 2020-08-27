// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExportImportControllerMethods
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
  public enum ExportImportControllerMethods
  {
    [EnumMember, Enumeration(null)] DeleteExportFile,
    [Enumeration(null), EnumMember] DeleteImportContent,
    [Enumeration(null), EnumMember] GenerateExportFile,
    [EnumMember, Enumeration(null)] GetExportFile,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] RestartProcess,
    [Enumeration(null), EnumMember] ResumeProcess,
    [Enumeration(null), EnumMember] SetImportFile,
    [EnumMember, Enumeration(null)] StopProcess,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
