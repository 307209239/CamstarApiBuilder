// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityInvestigationMaint
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
  public class ActivityInvestigationMaint : ActivityMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationMaint_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationMaint_Template")]
    protected new NamedObjectRef _Template;
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationMaint_ObjectChanges")]
    protected ActivityInvestigationChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationMaint_ObjectListInquiry")]
    protected new NamedSubentityRef[] _ObjectListInquiry;

    public override bool Equals(object obj)
    {
      return obj is ActivityInvestigationMaint && object.Equals((object) this._ObjectToChange, (object) ((ActivityInvestigationMaint) obj)._ObjectToChange) && (object.Equals((object) this._Template, (object) ((ActivityInvestigationMaint) obj)._Template) && object.Equals((object) this._ObjectChanges, (object) ((ActivityInvestigationMaint) obj)._ObjectChanges)) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ActivityInvestigationMaint) obj)._ObjectListInquiry) && base.Equals(obj);
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

    public new NamedObjectRef Template
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

    public ActivityInvestigationChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityInvestigationChanges) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
