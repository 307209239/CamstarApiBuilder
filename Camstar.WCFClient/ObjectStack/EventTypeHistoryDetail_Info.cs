// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventTypeHistoryDetail_Info
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
  public class EventTypeHistoryDetail_Info : OtherCheckBoxFieldHistDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventTypeHistoryDetail_Info_SeriousInjury")]
    protected Info _SeriousInjury;
    [DataMember(EmitDefaultValue = false, Name = "EventTypeHistoryDetail_Info_Unknown")]
    protected Info _Unknown;
    [DataMember(EmitDefaultValue = false, Name = "EventTypeHistoryDetail_Info_Death")]
    protected Info _Death;
    [DataMember(EmitDefaultValue = false, Name = "EventTypeHistoryDetail_Info_Malfunction")]
    protected Info _Malfunction;

    public Info SeriousInjury
    {
      [param: In] set
      {
        this.PropertySet(nameof (SeriousInjury), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SeriousInjury));
      }
    }

    public Info Unknown
    {
      [param: In] set
      {
        this.PropertySet(nameof (Unknown), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Unknown));
      }
    }

    public Info Death
    {
      [param: In] set
      {
        this.PropertySet(nameof (Death), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Death));
      }
    }

    public Info Malfunction
    {
      [param: In] set
      {
        this.PropertySet(nameof (Malfunction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Malfunction));
      }
    }
  }
}
