// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeOwner_Info
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
  public class ChangeOwner_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_Info_TriageComplete")]
    protected Info _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_Info_CurrentRole")]
    protected Info _CurrentRole;
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_Info_CurrentOwner")]
    protected Info _CurrentOwner;

    public Info Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Role));
      }
    }

    public Info TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Info CurrentRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentRole));
      }
    }

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }

    public Info CurrentOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentOwner));
      }
    }
  }
}
