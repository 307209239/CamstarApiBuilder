// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOInstanceInfo
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
  public class CDOInstanceInfo : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfo_Fields")]
    protected CDOField[] _Fields;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfo_InstanceRevision")]
    protected Primitive<string> _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfo_IsROR")]
    protected Primitive<bool> _IsROR;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfo_InstanceName")]
    protected Primitive<string> _InstanceName;

    public override bool Equals(object obj)
    {
      return obj is CDOInstanceInfo && this.CompareArrays((Array) this._Fields, (Array) ((CDOInstanceInfo) obj)._Fields) && (object.Equals((object) this._InstanceRevision, (object) ((CDOInstanceInfo) obj)._InstanceRevision) && object.Equals((object) this._IsROR, (object) ((CDOInstanceInfo) obj)._IsROR)) && object.Equals((object) this._InstanceName, (object) ((CDOInstanceInfo) obj)._InstanceName) && base.Equals(obj);
    }

    public CDOField[] Fields
    {
      [param: In] set
      {
        this.PropertySet(nameof (Fields), (object) value);
      }
      get
      {
        return (CDOField[]) this.PropertyGet(nameof (Fields));
      }
    }

    public Primitive<string> InstanceRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InstanceRevision));
      }
    }

    public Primitive<bool> IsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsROR), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsROR));
      }
    }

    public Primitive<string> InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InstanceName));
      }
    }
  }
}
