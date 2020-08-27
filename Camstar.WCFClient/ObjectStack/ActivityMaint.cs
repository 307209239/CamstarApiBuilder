// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityMaint
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
  public class ActivityMaint : ProcessObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityMaint_RuleList")]
    protected new Primitive<string> _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ActivityMaint_Template")]
    protected NamedObjectRef _Template;
    [DataMember(EmitDefaultValue = false, Name = "ActivityMaint_ObjectChanges")]
    protected ActivityChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ActivityMaint_ObjectListInquiry")]
    protected new NamedSubentityRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ActivityMaint_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityMaint_ActivityType")]
    protected Primitive<string> _ActivityType;

    public override bool Equals(object obj)
    {
      return obj is ActivityMaint && object.Equals((object) this._RuleList, (object) ((ActivityMaint) obj)._RuleList) && (object.Equals((object) this._Template, (object) ((ActivityMaint) obj)._Template) && object.Equals((object) this._ObjectChanges, (object) ((ActivityMaint) obj)._ObjectChanges)) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ActivityMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ObjectToChange, (object) ((ActivityMaint) obj)._ObjectToChange) && object.Equals((object) this._ActivityType, (object) ((ActivityMaint) obj)._ActivityType)) && base.Equals(obj);
    }

    public new Primitive<string> RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RuleList));
      }
    }

    public NamedObjectRef Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Template));
      }
    }

    public ActivityChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new NamedSubentityRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<string> ActivityType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ActivityType));
      }
    }
  }
}
