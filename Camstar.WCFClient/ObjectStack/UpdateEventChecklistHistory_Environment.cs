// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventChecklistHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UpdateEventChecklistHistory_Environment : UpdateEventDetailsHistory_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 16779192, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventChecklistHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("ChecklistEntries, entered by the user, that are recorded.", "ExecuteChecklistHistoryDtl", false, false, false, "ExecuteChecklistHistoryDtl", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventChecklistHistory_Environment_HistoryDetails")]
    protected ExecuteChecklistHistoryDtl_Environment _HistoryDetails;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public ExecuteChecklistHistoryDtl_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ExecuteChecklistHistoryDtl_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }
  }
}
