// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDispositionDetail_Environment
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
  public class EventDispositionDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Environment_EventFailureDetails")]
    [Metadata("Service Details to assign the Failure information to an Event.", "EventFailureDetail", false, false, false, "EventFailureDetail", 1051087, false, true, false, null)]
    protected EventFailureDetail_Environment _EventFailureDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Environment_EventDisposition")]
    [Metadata("Identifies a Disposition for an Event.", "EventDisposition", false, false, false, "SubentityRef", 1052986, false, false, false, null)]
    protected Environment _EventDisposition;
    [Metadata("Identifies the actions that can be taken on a Lot assigned to an Event.  Examples are Scrap, Rework, Return to Vendor.", "Disposition", false, true, false, "NamedObjectRef", 1051582, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Environment_Disposition")]
    protected Environment _Disposition;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052983, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Environment_ApplyEntireQty")]
    protected Environment _ApplyEntireQty;
    [Metadata("Material quantity (individual)", "", false, true, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Environment_Qty")]
    protected Environment _Qty;

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

    public EventFailureDetail_Environment EventFailureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureDetails), (object) value);
      }
      get
      {
        return (EventFailureDetail_Environment) this.PropertyGet(nameof (EventFailureDetails));
      }
    }

    public Environment EventDisposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDisposition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventDisposition));
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

    public Environment ApplyEntireQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplyEntireQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApplyEntireQty));
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
  }
}
