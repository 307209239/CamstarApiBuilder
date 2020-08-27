// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventTypeHistoryDetail_Environment
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
  public class EventTypeHistoryDetail_Environment : OtherCheckBoxFieldHistDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EventTypeHistoryDetail_Environment_SeriousInjury")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051309, false, false, false, "0")]
    protected Environment _SeriousInjury;
    [DataMember(EmitDefaultValue = false, Name = "EventTypeHistoryDetail_Environment_Unknown")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052239, false, false, false, "0")]
    protected Environment _Unknown;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051307, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EventTypeHistoryDetail_Environment_Death")]
    protected Environment _Death;
    [DataMember(EmitDefaultValue = false, Name = "EventTypeHistoryDetail_Environment_Malfunction")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051308, false, false, false, "0")]
    protected Environment _Malfunction;

    public Environment SeriousInjury
    {
      [param: In] set
      {
        this.PropertySet(nameof (SeriousInjury), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SeriousInjury));
      }
    }

    public Environment Unknown
    {
      [param: In] set
      {
        this.PropertySet(nameof (Unknown), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Unknown));
      }
    }

    public Environment Death
    {
      [param: In] set
      {
        this.PropertySet(nameof (Death), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Death));
      }
    }

    public Environment Malfunction
    {
      [param: In] set
      {
        this.PropertySet(nameof (Malfunction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Malfunction));
      }
    }
  }
}
