// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventComponentDetail_Environment
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
  public class EventComponentDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Identifies the Component within a Lot that is suspect for an Event.", "EventComponent", false, false, false, "SubentityRef", 1051209, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventComponentDetail_Environment_EventComponent")]
    protected Environment _EventComponent;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049481, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventComponentDetail_Environment_Lot")]
    protected Environment _Lot;
    [DataMember(EmitDefaultValue = false, Name = "EventComponentDetail_Environment_ProductName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048625, false, false, true, null)]
    protected Environment _ProductName;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1050390, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventComponentDetail_Environment_ProductRev")]
    protected Environment _ProductRev;

    public Environment EventComponent
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventComponent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventComponent));
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
  }
}
