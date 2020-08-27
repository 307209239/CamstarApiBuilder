// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgContainerAttrHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ContainerMaintHistory_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChgContainerAttrHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistory_Environment_ChildProcessingMode")]
    [Metadata("Child processing enum.", "ChildProcessingEnum", false, false, false, "Integer", 1050286, false, false, true, null)]
    protected Environment _ChildProcessingMode;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistory_Environment_HistoryDetails")]
    [Metadata("This is the history detail object of the ChgContainerAttribute service.", "ChgContainerAttrHistDetail", false, false, false, "ChgContainerAttrHistDetail", 1049096, false, true, false, null)]
    protected ChgContainerAttrHistDetail_Environment _HistoryDetails;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistory_Environment_RecordDetailPostHistory")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050288, false, false, false, "1")]
    protected Environment _RecordDetailPostHistory;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistory_Environment_RecordDetailPreHistory")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050287, false, false, false, "1")]
    protected Environment _RecordDetailPreHistory;

    public Environment ChildProcessingMode
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

    public ChgContainerAttrHistDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ChgContainerAttrHistDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
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

    public Environment RecordDetailPostHistory
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

    public Environment RecordDetailPreHistory
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
  }
}
