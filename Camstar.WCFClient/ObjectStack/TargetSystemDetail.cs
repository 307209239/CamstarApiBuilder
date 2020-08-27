// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetSystemDetail
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
  public class TargetSystemDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemDetail_TargetSystem")]
    protected TargetSystem _TargetSystem;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemDetail_IsTargetSelected")]
    protected Primitive<bool> _IsTargetSelected;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemDetail_TargetSystemName")]
    protected Primitive<string> _TargetSystemName;

    public override bool Equals(object obj)
    {
      return obj is TargetSystemDetail && object.Equals((object) this._TargetSystem, (object) ((TargetSystemDetail) obj)._TargetSystem) && (object.Equals((object) this._IsTargetSelected, (object) ((TargetSystemDetail) obj)._IsTargetSelected) && object.Equals((object) this._TargetSystemName, (object) ((TargetSystemDetail) obj)._TargetSystemName)) && base.Equals(obj);
    }

    public TargetSystem TargetSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystem), (object) value);
      }
      get
      {
        return (TargetSystem) this.PropertyGet(nameof (TargetSystem));
      }
    }

    public Primitive<bool> IsTargetSelected
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsTargetSelected), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsTargetSelected));
      }
    }

    public Primitive<string> TargetSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystemName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TargetSystemName));
      }
    }
  }
}
