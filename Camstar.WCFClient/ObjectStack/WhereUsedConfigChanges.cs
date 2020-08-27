// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WhereUsedConfigChanges
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
  public class WhereUsedConfigChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigChanges_WhereUsedConfigDetails")]
    protected WhereUsedConfigDetailsChanges[] _WhereUsedConfigDetails;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is WhereUsedConfigChanges && object.Equals((object) this._ObjectToChange, (object) ((WhereUsedConfigChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._WhereUsedConfigDetails, (Array) ((WhereUsedConfigChanges) obj)._WhereUsedConfigDetails) && object.Equals((object) this._Name, (object) ((WhereUsedConfigChanges) obj)._Name)) && base.Equals(obj);
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

    public WhereUsedConfigDetailsChanges[] WhereUsedConfigDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsedConfigDetails), (object) value);
      }
      get
      {
        return (WhereUsedConfigDetailsChanges[]) this.PropertyGet(nameof (WhereUsedConfigDetails));
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
