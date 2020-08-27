// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShipmentDestinationMaint
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
  public class ShipmentDestinationMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationMaint_ObjectChanges")]
    protected ShipmentDestinationChanges _ObjectChanges;

    public override bool Equals(object obj)
    {
      return obj is ShipmentDestinationMaint && object.Equals((object) this._ObjectToChange, (object) ((ShipmentDestinationMaint) obj)._ObjectToChange) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ShipmentDestinationMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ObjectChanges, (object) ((ShipmentDestinationMaint) obj)._ObjectChanges)) && base.Equals(obj);
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public ShipmentDestinationChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ShipmentDestinationChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
