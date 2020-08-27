// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SwitchingRuleChanges
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
  public class SwitchingRuleChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_EMailMessage")]
    protected NamedObjectRef _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_EMailDistribution")]
    protected NamedObjectRef _EMailDistribution;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_SwitchingRuleDetails")]
    protected SwitchingRuleDetailsChanges[] _SwitchingRuleDetails;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is SwitchingRuleChanges && object.Equals((object) this._Base, (object) ((SwitchingRuleChanges) obj)._Base) && (object.Equals((object) this._ObjectToChange, (object) ((SwitchingRuleChanges) obj)._ObjectToChange) && object.Equals((object) this._EMailMessage, (object) ((SwitchingRuleChanges) obj)._EMailMessage)) && (object.Equals((object) this._EMailDistribution, (object) ((SwitchingRuleChanges) obj)._EMailDistribution) && this.CompareArrays((Array) this._SwitchingRuleDetails, (Array) ((SwitchingRuleChanges) obj)._SwitchingRuleDetails) && object.Equals((object) this._Name, (object) ((SwitchingRuleChanges) obj)._Name)) && base.Equals(obj);
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EMailMessage));
      }
    }

    public NamedObjectRef EMailDistribution
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailDistribution), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EMailDistribution));
      }
    }

    public SwitchingRuleDetailsChanges[] SwitchingRuleDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SwitchingRuleDetails), (object) value);
      }
      get
      {
        return (SwitchingRuleDetailsChanges[]) this.PropertyGet(nameof (SwitchingRuleDetails));
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
