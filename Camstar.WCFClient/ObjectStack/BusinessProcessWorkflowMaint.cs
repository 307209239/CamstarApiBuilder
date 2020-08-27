// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessProcessWorkflowMaint
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
  public class BusinessProcessWorkflowMaint : RevisionedObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowMaint_ObjectChanges")]
    protected BusinessProcessWorkflowChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowMaint_ObjectListInquiry")]
    protected new RevisionedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;

    public override bool Equals(object obj)
    {
      return obj is BusinessProcessWorkflowMaint && object.Equals((object) this._ObjectToChange, (object) ((BusinessProcessWorkflowMaint) obj)._ObjectToChange) && (object.Equals((object) this._ObjectChanges, (object) ((BusinessProcessWorkflowMaint) obj)._ObjectChanges) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((BusinessProcessWorkflowMaint) obj)._ObjectListInquiry)) && object.Equals((object) this._BaseToChange, (object) ((BusinessProcessWorkflowMaint) obj)._BaseToChange) && base.Equals(obj);
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

    public BusinessProcessWorkflowChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (BusinessProcessWorkflowChanges) this.PropertyGet(nameof (ObjectChanges));
      }
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
  }
}
