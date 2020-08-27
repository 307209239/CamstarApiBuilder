// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventComponentHistoryDetail_Environment
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
  public class EventComponentHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventComponentHistoryDetail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventComponentHistoryDetail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1050390, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventComponentHistoryDetail_Environment_ProductRev")]
    protected Environment _ProductRev;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049481, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventComponentHistoryDetail_Environment_Lot")]
    protected Environment _Lot;
    [DataMember(EmitDefaultValue = false, Name = "EventComponentHistoryDetail_Environment_ProductName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048625, false, false, false, null)]
    protected Environment _ProductName;

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

    public Environment ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductRev));
      }
    }

    public Environment Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Lot));
      }
    }

    public Environment ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductName));
      }
    }
  }
}
