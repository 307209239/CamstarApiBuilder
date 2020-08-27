// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtWorkflowMaint
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
  public class ChangeMgtWorkflowMaint : BusinessProcessWorkflowMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowMaint_ObjectListInquiry")]
    protected new RevisionedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowMaint_ObjectChanges")]
    protected ChangeMgtWorkflowChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;

    public override bool Equals(object obj)
    {
      return obj is ChangeMgtWorkflowMaint && object.Equals((object) this._ObjectToChange, (object) ((ChangeMgtWorkflowMaint) obj)._ObjectToChange) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ChangeMgtWorkflowMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ObjectChanges, (object) ((ChangeMgtWorkflowMaint) obj)._ObjectChanges)) && object.Equals((object) this._BaseToChange, (object) ((ChangeMgtWorkflowMaint) obj)._BaseToChange) && base.Equals(obj);
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

    public ChangeMgtWorkflowChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ChangeMgtWorkflowChanges) this.PropertyGet(nameof (ObjectChanges));
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
