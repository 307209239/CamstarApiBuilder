// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDispositionHistoryDetail_Environment
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
  public class EventDispositionHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("History for the EventFailureDetail.", "EventFailureHistoryDetail", false, false, true, "EventFailureHistoryDetail", 1052987, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Environment_EventFailureHistoryDetails")]
    protected EventFailureHistoryDetail_Environment _EventFailureHistoryDetails;
    [Metadata("Identifies the actions that can be taken on a Lot assigned to an Event.  Examples are Scrap, Rework, Return to Vendor.", "Disposition", false, false, true, "NamedObjectRef", 1051582, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Environment_Disposition")]
    protected Environment _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Environment_Qty")]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Environment_Lot")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049481, false, false, false, null)]
    protected Environment _Lot;

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
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

    public EventFailureHistoryDetail_Environment EventFailureHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureHistoryDetails), (object) value);
      }
      get
      {
        return (EventFailureHistoryDetail_Environment) this.PropertyGet(nameof (EventFailureHistoryDetails));
      }
    }

    public Environment Disposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Disposition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Disposition));
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

    public Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
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
  }
}
