// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SwitchingRuleMaint
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
  public class SwitchingRuleMaint : RevisionedObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleMaint_ObjectListInquiry")]
    protected new RevisionedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleMaint_ObjectChanges")]
    protected SwitchingRuleChanges _ObjectChanges;

    public override bool Equals(object obj)
    {
      return obj is SwitchingRuleMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((SwitchingRuleMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._BaseToChange, (object) ((SwitchingRuleMaint) obj)._BaseToChange) && object.Equals((object) this._ObjectToChange, (object) ((SwitchingRuleMaint) obj)._ObjectToChange)) && object.Equals((object) this._ObjectChanges, (object) ((SwitchingRuleMaint) obj)._ObjectChanges) && base.Equals(obj);
    }

    public new RevisionedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new RevisionedObjectRef BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BaseToChange));
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

    public SwitchingRuleChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SwitchingRuleChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
