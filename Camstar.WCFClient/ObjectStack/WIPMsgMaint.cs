// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgMaint
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
  public class WIPMsgMaint : Maintenance
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_LabelToFind")]
    protected Primitive<string> _LabelToFind;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_ObjectChanges")]
    protected WIPMsgDefMgrChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_OperationKeyToChange")]
    protected SubentityRef _OperationKeyToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_LabelKeyToChange")]
    protected SubentityRef _LabelKeyToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_DetailToChange")]
    protected SubentityRef _DetailToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_WIPMsgType")]
    protected Enumeration<WIPMsgTypeEnum, int> _WIPMsgType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_ObjectWithWIPMsg")]
    protected BaseObjectRef _ObjectWithWIPMsg;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_OperationToFind")]
    protected NamedObjectRef _OperationToFind;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_ObjectToChange")]
    protected SubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgMaint && object.Equals((object) this._LabelToFind, (object) ((WIPMsgMaint) obj)._LabelToFind) && (object.Equals((object) this._ObjectChanges, (object) ((WIPMsgMaint) obj)._ObjectChanges) && object.Equals((object) this._OperationKeyToChange, (object) ((WIPMsgMaint) obj)._OperationKeyToChange)) && (object.Equals((object) this._LabelKeyToChange, (object) ((WIPMsgMaint) obj)._LabelKeyToChange) && object.Equals((object) this._DetailToChange, (object) ((WIPMsgMaint) obj)._DetailToChange) && (object.Equals((object) this._WIPMsgType, (object) ((WIPMsgMaint) obj)._WIPMsgType) && object.Equals((object) this._ObjectWithWIPMsg, (object) ((WIPMsgMaint) obj)._ObjectWithWIPMsg))) && (object.Equals((object) this._OperationToFind, (object) ((WIPMsgMaint) obj)._OperationToFind) && object.Equals((object) this._ObjectToChange, (object) ((WIPMsgMaint) obj)._ObjectToChange)) && base.Equals(obj);
    }

    public Primitive<string> LabelToFind
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelToFind), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelToFind));
      }
    }

    public WIPMsgDefMgrChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public SubentityRef OperationKeyToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationKeyToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (OperationKeyToChange));
      }
    }

    public SubentityRef LabelKeyToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelKeyToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (LabelKeyToChange));
      }
    }

    public SubentityRef DetailToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (DetailToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (DetailToChange));
      }
    }

    public Enumeration<WIPMsgTypeEnum, int> WIPMsgType
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgType), (object) value);
      }
      get
      {
        return (Enumeration<WIPMsgTypeEnum, int>) this.PropertyGet(nameof (WIPMsgType));
      }
    }

    public BaseObjectRef ObjectWithWIPMsg
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectWithWIPMsg), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ObjectWithWIPMsg));
      }
    }

    public NamedObjectRef OperationToFind
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationToFind), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OperationToFind));
      }
    }

    public SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
