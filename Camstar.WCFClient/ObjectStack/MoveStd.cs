// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveStd
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
  public class MoveStd : MoveTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveStd_Path")]
    protected new NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "MoveStd_Resource")]
    protected new NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MoveStd_ToStep")]
    protected new NamedSubentityRef _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveStd_Location")]
    protected new NamedSubentityRef _Location;

    public override bool Equals(object obj)
    {
      return obj is MoveStd && object.Equals((object) this._Path, (object) ((MoveStd) obj)._Path) && (object.Equals((object) this._Resource, (object) ((MoveStd) obj)._Resource) && object.Equals((object) this._ToStep, (object) ((MoveStd) obj)._ToStep)) && object.Equals((object) this._Location, (object) ((MoveStd) obj)._Location) && base.Equals(obj);
    }

    public new NamedSubentityRef Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Path));
      }
    }

    public new NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public new NamedSubentityRef ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToStep));
      }
    }

    public new NamedSubentityRef Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Location));
      }
    }
  }
}
