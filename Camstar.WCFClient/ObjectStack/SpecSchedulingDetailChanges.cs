// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecSchedulingDetailChanges
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
  public class SpecSchedulingDetailChanges : SchedulingDetailChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SpecSchedulingDetailChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "SpecSchedulingDetailChanges_FastCycleTime")]
    protected new Primitive<double> _FastCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecSchedulingDetailChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SpecSchedulingDetailChanges_NormalCycleTime")]
    protected new Primitive<double> _NormalCycleTime;

    public override bool Equals(object obj)
    {
      return obj is SpecSchedulingDetailChanges && object.Equals((object) this._ListItemToChange, (object) ((SpecSchedulingDetailChanges) obj)._ListItemToChange) && (object.Equals((object) this._FastCycleTime, (object) ((SpecSchedulingDetailChanges) obj)._FastCycleTime) && object.Equals((object) this._ObjectToChange, (object) ((SpecSchedulingDetailChanges) obj)._ObjectToChange)) && object.Equals((object) this._NormalCycleTime, (object) ((SpecSchedulingDetailChanges) obj)._NormalCycleTime) && base.Equals(obj);
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Primitive<double> FastCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (FastCycleTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (FastCycleTime));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<double> NormalCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (NormalCycleTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NormalCycleTime));
      }
    }
  }
}
