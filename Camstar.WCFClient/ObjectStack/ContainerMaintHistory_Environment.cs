// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerMaintHistory_Environment
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
  public class ContainerMaintHistory_Environment : ChgContainerAttrHistory_Environment
  {
    [Metadata("Provides a service that allows changing the value of all container, container detail and current status attributes allowed to be updated.", "ContainerMaintHistDetail", false, false, false, "ContainerMaintHistDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_Environment_HistoryDetails")]
    protected ContainerMaintHistDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_Environment_ChildProcessingMode")]
    [Metadata("Child processing enum.", "ChildProcessingEnum", false, false, false, "Integer", 1050286, false, false, true, null)]
    protected new Environment _ChildProcessingMode;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050288, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_Environment_RecordDetailPostHistory")]
    protected new Environment _RecordDetailPostHistory;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050287, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_Environment_RecordDetailPreHistory")]
    protected new Environment _RecordDetailPreHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

    public ContainerMaintHistDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ContainerMaintHistDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Environment ChildProcessingMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildProcessingMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildProcessingMode));
      }
    }

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

    public new Environment RecordDetailPostHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordDetailPostHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordDetailPostHistory));
      }
    }

    public new Environment RecordDetailPreHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordDetailPreHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordDetailPreHistory));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
