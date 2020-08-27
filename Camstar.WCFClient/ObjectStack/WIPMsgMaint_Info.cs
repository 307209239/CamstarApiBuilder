// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgMaint_Info
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
  public class WIPMsgMaint_Info : Maintenance_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Info_LabelToFind")]
    protected Info _LabelToFind;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Info_ObjectChanges")]
    protected WIPMsgDefMgrChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Info_OperationKeyToChange")]
    protected Info _OperationKeyToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Info_LabelKeyToChange")]
    protected Info _LabelKeyToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Info_DetailToChange")]
    protected Info _DetailToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Info_WIPMsgType")]
    protected Info _WIPMsgType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Info_ObjectWithWIPMsg")]
    protected Info _ObjectWithWIPMsg;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Info_OperationToFind")]
    protected Info _OperationToFind;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;

    public Info LabelToFind
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelToFind), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelToFind));
      }
    }

    public WIPMsgDefMgrChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Info OperationKeyToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationKeyToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OperationKeyToChange));
      }
    }

    public Info LabelKeyToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelKeyToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelKeyToChange));
      }
    }

    public Info DetailToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (DetailToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DetailToChange));
      }
    }

    public Info WIPMsgType
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgType));
      }
    }

    public Info ObjectWithWIPMsg
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectWithWIPMsg), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectWithWIPMsg));
      }
    }

    public Info OperationToFind
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationToFind), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OperationToFind));
      }
    }

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
  }
}
