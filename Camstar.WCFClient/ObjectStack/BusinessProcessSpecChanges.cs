// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessProcessSpecChanges
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
  public class BusinessProcessSpecChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecChanges_BPSpecBizRuleTxnMap")]
    protected BPSpecBizRuleTxnMapChanges[] _BPSpecBizRuleTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is BusinessProcessSpecChanges && object.Equals((object) this._Base, (object) ((BusinessProcessSpecChanges) obj)._Base) && (this.CompareArrays((Array) this._BPSpecBizRuleTxnMap, (Array) ((BusinessProcessSpecChanges) obj)._BPSpecBizRuleTxnMap) && object.Equals((object) this._ObjectToChange, (object) ((BusinessProcessSpecChanges) obj)._ObjectToChange)) && object.Equals((object) this._Name, (object) ((BusinessProcessSpecChanges) obj)._Name) && base.Equals(obj);
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

    public BPSpecBizRuleTxnMapChanges[] BPSpecBizRuleTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (BPSpecBizRuleTxnMap), (object) value);
      }
      get
      {
        return (BPSpecBizRuleTxnMapChanges[]) this.PropertyGet(nameof (BPSpecBizRuleTxnMap));
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
