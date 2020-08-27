// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DisassociateHistory_Info
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
  public class DisassociateHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DisassociateHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DisassociateHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DisassociateHistory_Info_ParentContainer")]
    protected Info _ParentContainer;
    [DataMember(EmitDefaultValue = false, Name = "DisassociateHistory_Info_ChildContainers")]
    protected Info _ChildContainers;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentContainer));
      }
    }

    public Info ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildContainers));
      }
    }
  }
}
