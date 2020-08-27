// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerLevelMaint
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
  public class ContainerLevelMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelMaint_ObjectChanges")]
    protected ContainerLevelChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelMaint_WIPExpressionBaseTypeId")]
    protected Primitive<int> _WIPExpressionBaseTypeId;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is ContainerLevelMaint && object.Equals((object) this._ObjectChanges, (object) ((ContainerLevelMaint) obj)._ObjectChanges) && (object.Equals((object) this._WIPExpressionBaseTypeId, (object) ((ContainerLevelMaint) obj)._WIPExpressionBaseTypeId) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ContainerLevelMaint) obj)._ObjectListInquiry)) && object.Equals((object) this._ObjectToChange, (object) ((ContainerLevelMaint) obj)._ObjectToChange) && base.Equals(obj);
    }

    public ContainerLevelChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ContainerLevelChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Primitive<int> WIPExpressionBaseTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPExpressionBaseTypeId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (WIPExpressionBaseTypeId));
      }
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
