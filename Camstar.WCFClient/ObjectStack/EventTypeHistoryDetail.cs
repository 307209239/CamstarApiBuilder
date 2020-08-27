// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventTypeHistoryDetail
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
  public class EventTypeHistoryDetail : OtherCheckBoxFieldHistDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "EventTypeHistoryDetail_SeriousInjury")]
    protected Primitive<bool> _SeriousInjury;
    [DataMember(EmitDefaultValue = false, Name = "EventTypeHistoryDetail_Unknown")]
    protected Primitive<bool> _Unknown;
    [DataMember(EmitDefaultValue = false, Name = "EventTypeHistoryDetail_Death")]
    protected Primitive<bool> _Death;
    [DataMember(EmitDefaultValue = false, Name = "EventTypeHistoryDetail_Malfunction")]
    protected Primitive<bool> _Malfunction;

    public override bool Equals(object obj)
    {
      return obj is EventTypeHistoryDetail && object.Equals((object) this._SeriousInjury, (object) ((EventTypeHistoryDetail) obj)._SeriousInjury) && (object.Equals((object) this._Unknown, (object) ((EventTypeHistoryDetail) obj)._Unknown) && object.Equals((object) this._Death, (object) ((EventTypeHistoryDetail) obj)._Death)) && object.Equals((object) this._Malfunction, (object) ((EventTypeHistoryDetail) obj)._Malfunction) && base.Equals(obj);
    }

    public Primitive<bool> SeriousInjury
    {
      [param: In] set
      {
        this.PropertySet(nameof (SeriousInjury), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SeriousInjury));
      }
    }

    public Primitive<bool> Unknown
    {
      [param: In] set
      {
        this.PropertySet(nameof (Unknown), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Unknown));
      }
    }

    public Primitive<bool> Death
    {
      [param: In] set
      {
        this.PropertySet(nameof (Death), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Death));
      }
    }

    public Primitive<bool> Malfunction
    {
      [param: In] set
      {
        this.PropertySet(nameof (Malfunction), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Malfunction));
      }
    }
  }
}
