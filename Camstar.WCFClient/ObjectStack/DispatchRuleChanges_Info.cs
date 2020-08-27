// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispatchRuleChanges_Info
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
  public class DispatchRuleChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_Info_DispatchDetails")]
    protected DispatchDetailChanges_Info _DispatchDetails;
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_Info_QueryType")]
    protected Info _QueryType;
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_Info_EnforcementRange")]
    protected Info _EnforcementRange;
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_Info_Name")]
    protected new Info _Name;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public DispatchDetailChanges_Info DispatchDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchDetails), (object) value);
      }
      get
      {
        return (DispatchDetailChanges_Info) this.PropertyGet(nameof (DispatchDetails));
      }
    }

    public Info QueryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QueryType));
      }
    }

    public Info EnforcementRange
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnforcementRange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EnforcementRange));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
