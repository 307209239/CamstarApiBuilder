// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.InspectionLevelChanges
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
  public class InspectionLevelChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "InspectionLevelChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "InspectionLevelChanges_LotSizeDetails")]
    protected LotSizeDetailsChanges[] _LotSizeDetails;
    [DataMember(EmitDefaultValue = false, Name = "InspectionLevelChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is InspectionLevelChanges && object.Equals((object) this._ObjectToChange, (object) ((InspectionLevelChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._LotSizeDetails, (Array) ((InspectionLevelChanges) obj)._LotSizeDetails) && object.Equals((object) this._Name, (object) ((InspectionLevelChanges) obj)._Name)) && base.Equals(obj);
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

    public LotSizeDetailsChanges[] LotSizeDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotSizeDetails), (object) value);
      }
      get
      {
        return (LotSizeDetailsChanges[]) this.PropertyGet(nameof (LotSizeDetails));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
